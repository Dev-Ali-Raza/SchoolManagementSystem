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
    public partial class Fees_Form : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public Fees_Form()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        void resetControl()
        {
            fs_ID.Clear();
            fs_name.Clear();
            fs_amount.Clear();

        }

        private void fs_new_Click(object sender, EventArgs e)
        {
            resetControl();
        }

        private void fs_save_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(cs);

            string query = "insert into Fees_Form values(@FeesID,@Name,@Class,@Month,@DOA,@Amount)";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@FeesID", fs_ID.Text);
            cmd.Parameters.AddWithValue("@Name", fs_name.Text);
            cmd.Parameters.AddWithValue("@Class", Fs_class.SelectedItem);
            cmd.Parameters.AddWithValue("@Month", fs_month.SelectedItem);
            cmd.Parameters.AddWithValue("@DOA", Fs_doa.Text);
            cmd.Parameters.AddWithValue("@Amount", fs_amount.Text);

            conn.Open();


            if (fs_ID.Text == "" || fs_name.Text == "" || fs_amount.Text == "")
            {
                MessageBox.Show("Please Fill Empty Fields", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                {
                    MessageBox.Show("Data Inserted Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetControl();

                }

                else
                {
                    MessageBox.Show("Insertion Fialed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            conn.Close();
        }

        private void fs_update_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);

            string query = "update Fees_Form set  FeesID=@FeesID,StudentName=@Name,Class=@Class,Month=@Month,DateOfAdmission=@DOA,Amount=@Amount where FeesID=@FeesID";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@FeesID", fs_ID.Text);
            cmd.Parameters.AddWithValue("@Name", fs_name.Text);
            cmd.Parameters.AddWithValue("@Class", Fs_class.SelectedItem);
            cmd.Parameters.AddWithValue("@Month", fs_month.SelectedItem);
            cmd.Parameters.AddWithValue("@DOA", Fs_doa.Text);
            cmd.Parameters.AddWithValue("@Amount", fs_amount.Text);



            conn.Open();
            if (fs_ID.Text == "" || fs_name.Text == "" || fs_amount.Text == "")
            {

                MessageBox.Show("Please Fill Empty Fields", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                {

                    {
                        MessageBox.Show("Data Updated Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetControl();
                    }


                }
                else
                {
                    MessageBox.Show("Update Fialed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            conn.Close();
        }

        private void fs_delete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);

            string query = "delete from Fees_Form where FeesID=@id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", fs_ID.Text);
            conn.Open();

            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Record Deleted Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                resetControl();
            }
            else
            {
                MessageBox.Show("Delete Fialed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();

        }

        private void fs_getdata_Click(object sender, EventArgs e)
        {
            FeesFrom_Display obj = new FeesFrom_Display();
            obj.Show();

            this.Hide();
        }

        private void fs_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {


                e.Handled = false;

            }
            else
            {
                MessageBox.Show("Please Enter only Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;

            }
        }

        private void fs_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {


                e.Handled = false;

            }
            else
            {
                MessageBox.Show("Please Enter only Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;

            }
        }
    }
}
    
