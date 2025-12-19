using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices.Marshalling;
using System.Windows.Forms;

namespace Student_Management_system
{
    public partial class Form1 : Form
    {
        private int selectedId = -1;
        public Form1()
        {
            InitializeComponent();
        }
        public void Getstudents()
        {
            using (SqlConnection con = Database.DB.GetConnection())
            {
                con.Open();
                string query = "select* from StudentDataTable";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["ID"].Visible = false;


            }


        }
        private bool ValidateRequiredFields()
        {
            
            if (string.IsNullOrWhiteSpace(txtfull.Text))
            {
                MessageBox.Show("Full Name is required");
                txtfull.Focus();
                return false;
            }

            
            if (string.IsNullOrWhiteSpace(txtage.Text))
            {
                MessageBox.Show("Age is required");
                txtage.Focus();
                return false;
            }

            
            if (combogender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Gender");
                combogender.Focus();
                return false;
            }

            
            if (combocourse.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Course");
                combocourse.Focus();
                return false;
            }

            return true; 
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            if (!ValidateRequiredFields())
                return;

            try
            {
                using (SqlConnection con = Database.DB.GetConnection())
                {
                    con.Open();
                    string query = "INSERT INTO StudentDataTable(FULL_NAME, AGE, GENDER, COURSE)VALUES(@fn, @age, @gender, @course)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@fn", txtfull.Text);
                    cmd.Parameters.AddWithValue("@age", int.Parse(txtage.Text));
                    cmd.Parameters.AddWithValue("@gender", combogender.Text);
                    cmd.Parameters.AddWithValue("@course", combocourse.Text);
                    int rowaffected = cmd.ExecuteNonQuery();
                    if (rowaffected > 0)
                    {
                        MessageBox.Show("student added details successfully", "details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Getstudents();
                        clearfields();
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Getstudents();
            {
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtfull.Text = row.Cells["FULL_NAME"].Value.ToString();
                txtage.Text = row.Cells["AGE"].Value.ToString();
                combogender.Text = row.Cells["GENDER"].Value.ToString();
                combocourse.Text = row.Cells["COURSE"].Value.ToString();
                selectedId = Convert.ToInt32(row.Cells["ID"].Value);


            }
        }
        public void clearfields()
        {
            {
                txtfull.Clear();
                txtage.Clear();
                combogender.SelectedIndex = -1;
                combocourse.SelectedIndex = -1;
                selectedId = -1;
            }
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            if (!ValidateRequiredFields())
                return;

            try
            {
                using (SqlConnection con = Database.DB.GetConnection())
                {
                    con.Open();
                    string query = "UPDATE StudentDataTable SET FULL_NAME=@fn, AGE=@age, GENDER=@gender, COURSE=@course where ID=@id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@fn", txtfull.Text);
                    cmd.Parameters.AddWithValue("@age", int.Parse(txtage.Text));
                    cmd.Parameters.AddWithValue("@gender", combogender.Text);
                    cmd.Parameters.AddWithValue("@course", combocourse.Text);
                    cmd.Parameters.AddWithValue("@id", selectedId);

                    int rowaffected = cmd.ExecuteNonQuery();
                    if (rowaffected > 0)
                    {
                        MessageBox.Show("student updated details successfully", "details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Getstudents();
                        clearfields();
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            if (!ValidateRequiredFields())
                return;

            try
            {
                using (SqlConnection con = Database.DB.GetConnection())
                {
                    con.Open();
                    string query = "DELETE FROM StudentDataTable WHERE ID=@id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", selectedId);
                    int rowaffected = cmd.ExecuteNonQuery();
                    if (rowaffected > 0)
                    {
                        MessageBox.Show("student deleted succesfully");
                        Getstudents();
                        clearfields();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            
        }
    }
}
