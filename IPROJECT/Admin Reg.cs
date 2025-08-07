using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace IPROJECT
{
    public partial class Admin_Reg : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public Admin_Reg()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);

            string query = "insert into LogIn values (@name,@Password)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Password", textBox2.Text);
           

            conn.Open();

            int a = cmd.ExecuteNonQuery();  // we use this method for insert update delete
            if (a > 0)
            {
                MessageBox.Show("data inserted successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindGirdView();
                resetControl();
            }
            else
            {
                MessageBox.Show("insertion failed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        public  void BindGirdView()
        {
            SqlConnection conn = new SqlConnection(cs);
            string query = "select * from LogIn";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
        }

        void resetControl()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();



        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(cs);
            string query = "delete from logIn where ID=@id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", textBox3.Text);


            conn.Open();

                int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Record Deleted Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindGirdView();
                resetControl();
            }
            else
            {
                MessageBox.Show("Delete Fialed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(cs);

          

            string query = "Update LogIn set  Username=@name,Password=@pass where Username=@name";
           
            SqlCommand cmd = new SqlCommand(query, conn);
           
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Pass", textBox2.Text);

            conn.Open();

            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Data Updated Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindGirdView();
                resetControl();
            }
            else
            {
                MessageBox.Show("Update Fialed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            resetControl();
        }

        private void Admin_Reg_Load(object sender, EventArgs e)
        {
           
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            BindGirdView();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            textBox3.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
    }
    




