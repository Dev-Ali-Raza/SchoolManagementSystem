using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace IPROJECT
{
    public partial class St_display : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public St_display()
        {
            InitializeComponent();
        }

        private void St_display_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Student_Registration";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            
            
        }

        private void st_search_TextChanged(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Student_Registration where FirstName Like '"+st_search.Text+"%'  ";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Std_Reg Ali = new Std_Reg();

            Ali.st_id.Text= dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Ali.st_fname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Ali.st_lname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Ali.st_fathername.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Ali.st_email.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            Ali.st_dob.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            Ali.st_dor.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            Ali.st_class.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            Ali.st_MNo.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            Ali.St_address.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            Ali.St_Gender.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            Ali.St_country.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            Ali.St_province.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
            Ali.St_city.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();

            Ali.Show();

            this.Hide();

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        { 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
