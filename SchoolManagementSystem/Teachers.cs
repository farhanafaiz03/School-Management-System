using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
            DisplayTeachers();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-ESP3VAD;Initial Catalog=schooldb;Integrated Security=True;Encrypt=False");
        private void DisplayTeachers()
        {
            Con.Open();
            string Query = "Select * from TeacherTab";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TeachDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            NameT.Text = "";
            PhoneT.Text = "";
            AddressT.Text = "";
            GenderT.SelectedIndex = 0;
            course0T.SelectedIndex = 0;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (NameT.Text == "" || PhoneT.Text == "" || AddressT.Text == "" || GenderT.SelectedIndex == -1 || course0T.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else if (PhoneT.Text.Length != 11 || !PhoneT.Text.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must be exactly 11 digits.");
            }
            else
            {
                try
                {
                    Con.Open();

                    // Find the smallest missing ID
                    SqlCommand cmdCheckGap = new SqlCommand(
                        "SELECT MIN(T1.Id + 1) AS MissingId " +
                        "FROM TeacherTab T1 " +
                        "LEFT JOIN TeacherTab T2 ON T1.Id + 1 = T2.Id " +
                        "WHERE T2.Id IS NULL", Con);

                    object missingId = cmdCheckGap.ExecuteScalar();

                    // If no gaps, use default identity value
                    string insertQuery;
                    if (missingId != null && missingId != DBNull.Value)
                    {
                        insertQuery = "SET IDENTITY_INSERT TeacherTab ON; " +
                                      "INSERT INTO TeacherTab(Id, Tname, Tgender, Tphone, Tcourse, Taddress, TDoB) " +
                                      "VALUES (@MissingId, @TName, @TGender, @TPhone, @TCourse, @TAddress, @TDob); " +
                                      "SET IDENTITY_INSERT TeacherTab OFF;";
                    }
                    else
                    {
                        insertQuery = "INSERT INTO TeacherTab(Tname, Tgender, Tphone, Tcourse, Taddress, TDoB) " +
                                      "VALUES (@TName, @TGender, @TPhone, @TCourse, @TAddress, @TDob)";
                    }

                    // Insert new record
                    SqlCommand cmdInsert = new SqlCommand(insertQuery, Con);
                    if (missingId != null && missingId != DBNull.Value)
                    {
                        cmdInsert.Parameters.AddWithValue("@MissingId", Convert.ToInt32(missingId));
                    }
                    cmdInsert.Parameters.AddWithValue("@TName", NameT.Text);
                    cmdInsert.Parameters.AddWithValue("@TGender", GenderT.SelectedItem.ToString());
                    cmdInsert.Parameters.AddWithValue("@TPhone", PhoneT.Text);
                    cmdInsert.Parameters.AddWithValue("@TCourse", course0T.SelectedItem.ToString());
                    cmdInsert.Parameters.AddWithValue("@TAddress", AddressT.Text);
                    cmdInsert.Parameters.AddWithValue("@TDob", DoBT.Value.Date);
                    cmdInsert.ExecuteNonQuery();

                    MessageBox.Show("Teacher Added");
                    Con.Close();
                    DisplayTeachers();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void CloseTeacher_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int Key = 0;
        private object courseOT;
        private void TeachDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < TeachDGV.Rows.Count)
            {
                // Access the clicked row directly
                DataGridViewRow row = TeachDGV.Rows[e.RowIndex];

                NameT.Text = row.Cells[1].Value?.ToString();
                GenderT.SelectedItem = row.Cells[2].Value?.ToString();
                PhoneT.Text = row.Cells[3].Value?.ToString();
                course0T.SelectedItem = row.Cells[4].Value?.ToString();
                AddressT.Text = row.Cells[5].Value?.ToString();
                DoBT.Text = row.Cells[6].Value?.ToString();

                // Set the key based on the ID column (if it exists)
                if (string.IsNullOrEmpty(NameT.Text))
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
            if (Key == 0)
            {
                MessageBox.Show("Select Teacher");
            }
            else
            {
                try
                {     // delete the selected row
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from TeacherTab where Id= @TKey", Con);
                    cmd.Parameters.AddWithValue("@TKey", Key);
                    cmd.ExecuteNonQuery();

                    // Reset the auto-increment value
                    SqlCommand resetCmd = new SqlCommand("DBCC CHECKIDENT ('TeacherTab', RESEED, 0)", Con);
                    resetCmd.ExecuteNonQuery();


                    MessageBox.Show("Teacher Deleted");
                    Con.Close();
                    DisplayTeachers();
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
            if (NameT.Text == "" || PhoneT.Text == "" || AddressT.Text == "" || GenderT.SelectedIndex == -1 || course0T.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update TeacherTab set Tname=@TName,Tgender=@TGender,Tphone=@TPhone,Tcourse=@TCourse,Taddress=@TAddress,TDoB=@TDob where Id=@TeachID", Con);
                    cmd.Parameters.AddWithValue("@TName", NameT.Text);
                    cmd.Parameters.AddWithValue("@TGender", GenderT.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TPhone", PhoneT.Text);
                    cmd.Parameters.AddWithValue("@TCourse", course0T.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TAddress", AddressT.Text);
                    cmd.Parameters.AddWithValue("@TDob", DoBT.Value.Date);
                    cmd.Parameters.AddWithValue("@TeachID", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher Updated");
                    Con.Close();
                    DisplayTeachers();
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
