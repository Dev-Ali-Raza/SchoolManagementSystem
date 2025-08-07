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
    public partial class FeesFrom_Display : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public FeesFrom_Display()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fs_search_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Fees_Form where StudentName Like '" + fs_search.Text + "%'  ";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void FeesFrom_Display_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Fees_Form";
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
            Fees_Form Ali = new Fees_Form();

            Ali.fs_ID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Ali.fs_name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Ali.fs_month.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Ali.Fs_class.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            Ali.fs_amount.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            
            Ali.Show();
            this.Hide();
        }
    }
}
