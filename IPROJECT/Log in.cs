using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using System.Configuration;

namespace IPROJECT
{
    public partial class Log_in : Form
    {
        

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public Log_in()
        { 
            InitializeComponent();
          

        }
  

        private void btn_login_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cs);

            string query = "select * from LogIn where   Username=@user and Password=@pass";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", textBox2.Text);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows == true)
            {

                Form1 obj1 = new Form1();
                obj1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("INCORRECT USER OR PASS","Alert",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            con.Close();

            
        }

        private void Log_in_Load(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool check = checkBox1.Checked;

            switch (check)
            {
                case true:
                    textBox2.UseSystemPasswordChar = false;
                    break;
                default:
                    textBox2.UseSystemPasswordChar = true;
                    break;

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Log_in_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    }
    

