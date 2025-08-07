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
    public partial class Teacher_Reg : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public Teacher_Reg()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        void resetControl()
        {
            tc_id.Clear();
            tc_fname.Clear();
            tc_lname.Clear();
            tc_fathername.Clear();
            tc_email.Clear();
            tc_MNo.Clear();
            tc_address.Clear();
            tc_country.Clear();
            tc_province.Clear();
            tc_city.Clear();
        }

        private void tc_new_Click(object sender, EventArgs e)
        {
            resetControl();
        }

        private void tc_save_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(cs);

            string query = "insert into Teacher_Registration values(@TeacherID,@Firstname,@Lastname,@Fathername,@Email,@DOB,@Mobile,@Expertise,@Address,@Gender,@Country,@Province,@City)";


            SqlCommand cmd = new SqlCommand(query, conn);


            cmd.Parameters.AddWithValue("@TeacherID", tc_id.Text);
            cmd.Parameters.AddWithValue("@Firstname", tc_fname.Text);
            cmd.Parameters.AddWithValue("@Lastname", tc_lname.Text);
            cmd.Parameters.AddWithValue("@Fathername", tc_fathername.Text);
            cmd.Parameters.AddWithValue("@Email", tc_email.Text);
            cmd.Parameters.AddWithValue("@DOB", tc_dob.Text);
            cmd.Parameters.AddWithValue("@Mobile", tc_MNo.Text);
            cmd.Parameters.AddWithValue("@Expertise", tc_expertise.SelectedItem);
            cmd.Parameters.AddWithValue("@Address", tc_address.Text);
            cmd.Parameters.AddWithValue("@Gender", tc_gender.SelectedItem);
            cmd.Parameters.AddWithValue("@Country", tc_country.Text);
            cmd.Parameters.AddWithValue("@Province", tc_province.Text);
            cmd.Parameters.AddWithValue("@City", tc_city.Text);

            conn.Open();
            if (tc_id.Text == "" || tc_fname.Text == "" || tc_lname.Text == "" || tc_fathername.Text == "" || tc_email.Text == "" || tc_MNo.Text == "" || tc_address.Text == "" || tc_country.Text == "" || tc_province.Text == "" || tc_city.Text == "")
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

        private void tc_update_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);

            string query = "update Teacher_Registration set  TeacherID=@TeacherID,Firstname=@Firstname,Lastname=@Lastname,Fathername=@Fathername,Email=@Email,DateOfBirth=@DOB,Mobile=@Mobile,Expertise=@Expertise,Address=@Address,Gender=@Gender,Country=@Country,Province=@Province,City=@City where TeacherID=@TeacherID";
            SqlCommand cmd = new SqlCommand(query, conn);


            cmd.Parameters.AddWithValue("@TeacherID", tc_id.Text);
            cmd.Parameters.AddWithValue("@Firstname", tc_fname.Text);
            cmd.Parameters.AddWithValue("@Lastname", tc_lname.Text);
            cmd.Parameters.AddWithValue("@Fathername", tc_fathername.Text);
            cmd.Parameters.AddWithValue("@Email", tc_email.Text);
            cmd.Parameters.AddWithValue("@DOB", tc_dob.Text);
            cmd.Parameters.AddWithValue("@Mobile", tc_MNo.Text);
            cmd.Parameters.AddWithValue("@Expertise", tc_expertise.SelectedItem);
            cmd.Parameters.AddWithValue("@Address", tc_address.Text);
            cmd.Parameters.AddWithValue("@Gender", tc_gender.SelectedItem);
            cmd.Parameters.AddWithValue("@Country", tc_country.Text);
            cmd.Parameters.AddWithValue("@Province", tc_province.Text);
            cmd.Parameters.AddWithValue("@City", tc_city.Text);



            conn.Open();

            if (tc_id.Text == "" || tc_fname.Text == "" || tc_lname.Text == "" || tc_fathername.Text == "" || tc_email.Text == "" || tc_MNo.Text == "" || tc_address.Text == "" || tc_country.Text == "" || tc_province.Text == "" || tc_city.Text == "")
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

        private void tc_delete_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(cs);

            string query = "delete from Teacher_Registration where TeacherID=@id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", tc_id.Text);
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

        private void tc_getdata_Click(object sender, EventArgs e)
        {
            Tc_display obj = new Tc_display();
            obj.Show();

            this.Hide();
        }

        private void tc_id_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tc_MNo_KeyPress(object sender, KeyPressEventArgs e)
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
