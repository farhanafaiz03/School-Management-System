using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolManagementSystem
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
            DisplayStudent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-ESP3VAD;Initial Catalog=schooldb;Integrated Security=True;Encrypt=False");
        private void DisplayStudent()
        {
            Con.Open();
            string Query = "Select * from StudentTab";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StdDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (stName.Text == "" || stFees.Text == "" || stGender.SelectedIndex == -1 || stClass.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();

                    // Find the smallest missing ID
                    SqlCommand cmdCheckGap = new SqlCommand(
                        "SELECT MIN(T1.StId + 1) AS MissingId " +
                        "FROM StudentTab T1 " +
                        "LEFT JOIN StudentTab T2 ON T1.StId + 1 = T2.StId " +
                        "WHERE T2.StId IS NULL", Con);

                    object missingId = cmdCheckGap.ExecuteScalar();

                    // If no gaps, use default identity value
                    string insertQuery;
                    if (missingId != null && missingId != DBNull.Value)
                    {
                        insertQuery = "SET IDENTITY_INSERT StudentTab ON; " +
                                      "INSERT INTO StudentTab(StId, StName, StGen, StDob, StClass, StFees) " +
                                      "VALUES (@MissingId, @SName, @SGender, @SDob, @SClass, @SFees); " +
                                      "SET IDENTITY_INSERT StudentTab OFF;";
                    }
                    else
                    {
                        insertQuery = "INSERT INTO StudentTab(StName, StGen, StDob, StClass, StFees) " +
                                      "VALUES (@SName, @SGender, @SDob, @SClass, @SFees)";
                    }

                    // Insert new record
                    SqlCommand cmdInsert = new SqlCommand(insertQuery, Con);
                    if (missingId != null && missingId != DBNull.Value)
                    {
                        cmdInsert.Parameters.AddWithValue("@MissingId", Convert.ToInt32(missingId));
                    }
                    cmdInsert.Parameters.AddWithValue("@SName", stName.Text);
                    cmdInsert.Parameters.AddWithValue("@SGender", stGender.SelectedItem.ToString());
                    cmdInsert.Parameters.AddWithValue("@SDob", stDob.Value.Date);
                    cmdInsert.Parameters.AddWithValue("@SClass", stClass.SelectedItem.ToString());
                    cmdInsert.Parameters.AddWithValue("@SFees", stFees.Text);
                    cmdInsert.ExecuteNonQuery();

                    MessageBox.Show("Student Added");
                    Con.Close();
                    DisplayStudent();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void CloseImage_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Reset()
        {
            Key = 0;
            stName.Text = "";
            stFees.Text = "";
            stGender.SelectedIndex = 0;
            stClass.SelectedIndex = 0;
        }
        int Key = 0;
        private void StdDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure a valid row index is clicked
            if (e.RowIndex >= 0 && e.RowIndex < StdDGV.Rows.Count)
            {
                // Access the clicked row directly
                DataGridViewRow row = StdDGV.Rows[e.RowIndex];

                stName.Text = row.Cells[1].Value?.ToString();
                stGender.SelectedItem = row.Cells[2].Value?.ToString();
                stDob.Text = row.Cells[3].Value?.ToString();
                stClass.SelectedItem = row.Cells[4].Value?.ToString();
                stFees.Text = row.Cells[5].Value?.ToString();

                // Set the key based on the ID column (if it exists)
                if (string.IsNullOrEmpty(stName.Text))
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(row.Cells[0].Value);
                }
            }
            else
            {
                MessageBox.Show("Invalid row selected.");
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(Key == 0)
            {
                MessageBox.Show("Select Student");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from StudentTab where StId= @StKey", Con);
                    cmd.Parameters.AddWithValue("@StKey", Key);
                    cmd.ExecuteNonQuery();

                    // Reset the auto-increment value
                    SqlCommand resetCmd = new SqlCommand("DBCC CHECKIDENT ('StudentTab', RESEED, 0)", Con);
                    resetCmd.ExecuteNonQuery();

                    MessageBox.Show("Student Deleted");
                    Con.Close();
                    DisplayStudent();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
               
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (stName.Text == "" || stFees.Text == "" || stGender.SelectedIndex == -1 || stClass.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update StudentTab set StName=@SName,StGen=@SGender,StDob=@SDob,StClass=@SClass,StFees=@SFees where StId=@SId", Con);
                    cmd.Parameters.AddWithValue("@SName", stName.Text);
                    cmd.Parameters.AddWithValue("@SGender", stGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SDob", stDob.Value.Date);
                    cmd.Parameters.AddWithValue("@SClass", stClass.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SFees", stFees.Text);
                    cmd.Parameters.AddWithValue("@SId", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Updated");
                    Con.Close();
                    DisplayStudent();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }
    }
}   
