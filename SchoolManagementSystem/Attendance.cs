using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
            DisplayAttendance();
            FillStdID();

        }
        private void FillStdID()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select StId from StudentTab", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("StId", typeof(int));
            dt.Load(rdr);
            StdID.ValueMember = "StId";
            StdID.DataSource = dt;
            Con.Close();
        }
        private void StDName()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from StudentTab where StId = @SID", Con);
            cmd.Parameters.AddWithValue("@SID", StdID.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                StdName.Text = dr["StName"].ToString();
            }
            Con.Close();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-ESP3VAD;Initial Catalog=schooldb;Integrated Security=True;Encrypt=False");

        private void DisplayAttendance()
        {
            Con.Open();
            string Query = "Select * from Attendance";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AttendDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            Status.SelectedIndex = -1;
            StdName.Text = "";
            StdID.SelectedIndex = -1;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (StdName.Text == "" || Status.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Attendance(AttStdID,AttName,AttDate,AttStatus) values (@StDID,@StDName,@Date,@AStatus)", Con);
                    cmd.Parameters.AddWithValue("@StDID", StdID.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@StDName", StdName.Text);
                    cmd.Parameters.AddWithValue("@Date", Date.Value.Date);
                    cmd.Parameters.AddWithValue("@AStatus", Status.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendance Taken");
                    Con.Close();
                    DisplayAttendance();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void CloseAttend_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void StdID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            StDName();
        }
        int Key = 0;
        private void AttendDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < AttendDGV.Rows.Count)
            {
                // Access the clicked row directly
                DataGridViewRow row = AttendDGV.Rows[e.RowIndex];

                StdID.SelectedValue = row.Cells[1].Value?.ToString();
                StdName.Text = row.Cells[2].Value?.ToString();
                Date.Text = row.Cells[3].Value?.ToString();
                Status.SelectedItem = row.Cells[4].Value?.ToString();

                if (string.IsNullOrEmpty(StdName.Text))
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
                MessageBox.Show("Select a Row!");
            }
            else
            {
                try
                {     // delete the selected row
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from Attendance where AttNum= @AKey", Con);
                    cmd.Parameters.AddWithValue("@AKey", Key);
                    cmd.ExecuteNonQuery();

                    // Reset the auto-increment value
                    SqlCommand resetCmd = new SqlCommand("DBCC CHECKIDENT ('Attendance', RESEED, 0)", Con);
                    resetCmd.ExecuteNonQuery();


                    MessageBox.Show("Attendance Deleted");
                    Con.Close();
                    DisplayAttendance();
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
            if (StdName.Text == "" || Status.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update Attendance set AttStdID=@StId,AttName=@StName,AttDate=@ADate,AttStatus=@AStatus where AttNum=@Num", Con);

                    cmd.Parameters.AddWithValue("@StId", StdID.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@StName", StdName.Text);
                    cmd.Parameters.AddWithValue("@ADate", Date.Value.Date);
                    cmd.Parameters.AddWithValue("@AStatus", Status.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Num", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendance Updated");
                    Con.Close();
                    DisplayAttendance();
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
