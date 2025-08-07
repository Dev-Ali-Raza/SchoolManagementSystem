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
    public partial class Tc_display : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public Tc_display()
        {
            InitializeComponent();
        }

        private void Tc_display_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Teacher_Registration";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void tc_search_TextChanged(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Teacher_Registration where FirstName Like '" + tc_search.Text + "%'  ";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            Teacher_Reg Ali = new Teacher_Reg();

            Ali.tc_id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Ali.tc_fname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Ali.tc_lname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Ali.tc_fathername.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Ali.tc_email.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            Ali.tc_dob.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            Ali.tc_MNo.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            Ali.tc_expertise.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            Ali.tc_address.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            Ali.tc_gender.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            Ali.tc_country.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            Ali.tc_province.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            Ali.tc_city.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();

            Ali.Show();

            this.Hide();
        }
    }
}
