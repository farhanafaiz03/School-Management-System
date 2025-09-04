using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace SchoolManagementSystem
{
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
            DisplayFees();
            FillStdID();
            StDName();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-ESP3VAD;Initial Catalog=schooldb;Integrated Security=True;Encrypt=False");
        private void DisplayFees()
        {
            Con.Open();
            string Query = "Select * from Fees";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            FeesDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        { 
            AMOUNT.Text = "";
            STNAME.Text = "";
            STID.SelectedIndex = -1;
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
            STID.ValueMember = "StId";
            STID.DataSource = dt;
            Con.Close();
        }
        private void StDName()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from StudentTab where StId = @SID", Con);
            cmd.Parameters.AddWithValue("@SID", STID.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                STNAME.Text = dr["StName"].ToString();
            }
            Con.Close();
        }
        private void CloseFeesIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void STID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            StDName();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (STNAME.Text == "" || AMOUNT.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                string paymentperiod;
                paymentperiod = PERIOD.Value.Month.ToString() + "/" + PERIOD.Value.Year.ToString();
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Fees where StdID = '" + STID.SelectedValue.ToString() + "' and Month= '" + paymentperiod.ToString() + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Fees Already Paid for this Month");
                }
                else
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Fees(StdID,StdName,Amount,Month) values (@StID,@StName,@Amount,@Month)", Con);
                    cmd.Parameters.AddWithValue("@StID", STID.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@StName", STNAME.Text);
                    cmd.Parameters.AddWithValue("@Amount", AMOUNT.Text);
                    cmd.Parameters.AddWithValue("@Month", paymentperiod);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fees Paid");
                }
                Con.Close();
                DisplayFees();
                Reset();
            }

        }
        int Key = 0;
        private void FeesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < FeesDGV.Rows.Count)
            {
                // Access the clicked row directly
                DataGridViewRow row = FeesDGV.Rows[e.RowIndex];

                STID.SelectedValue = row.Cells[1].Value?.ToString();
                STNAME.Text = row.Cells[2].Value?.ToString();
                PERIOD.Text = row.Cells[3].Value?.ToString();
                AMOUNT.Text = row.Cells[4].Value?.ToString();

                if (string.IsNullOrEmpty(STNAME.Text))
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
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (STNAME.Text == "" || AMOUNT.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update Fees set StdID=@StId,StdName=@StName,Month=@Month,Amount=@AMOUNT where PayID=@PayDue", Con);

                    cmd.Parameters.AddWithValue("@StId", STID.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@StName", STNAME.Text);
                    cmd.Parameters.AddWithValue("@Month", PERIOD.Value.Date);
                    cmd.Parameters.AddWithValue("@AMOUNT", AMOUNT.Text.ToString());
                    cmd.Parameters.AddWithValue("@PayDue", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fees Updated");
                    Con.Close();
                    DisplayFees();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
