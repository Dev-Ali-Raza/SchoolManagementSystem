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
    public partial class Std_Reg : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public Std_Reg()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void st_save_Click(object sender, EventArgs e)
        {  
          
            

            SqlConnection conn = new SqlConnection(cs);

            string query = "insert into Student_Registration values(@StudentId,@Firstname,@Lastname,@Fathername,@Email,@DOB,@DOR,@Class,@Mobile,@Address,@Gender,@Country,@Province,@City)";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@StudentId", st_id.Text);
            cmd.Parameters.AddWithValue("@Firstname", st_fname.Text);
            cmd.Parameters.AddWithValue("@Lastname", st_lname.Text);
            cmd.Parameters.AddWithValue("@Fathername", st_fathername.Text);
            cmd.Parameters.AddWithValue("@Email", st_email.Text);
            cmd.Parameters.AddWithValue("@DOB", st_dob.Text);
            cmd.Parameters.AddWithValue("@DOR", st_dor.Text);
            cmd.Parameters.AddWithValue("@Class", st_class.SelectedItem);
            cmd.Parameters.AddWithValue("@Mobile", st_MNo.Text);
            cmd.Parameters.AddWithValue("@Address", St_address.Text);
            cmd.Parameters.AddWithValue("@Gender", St_Gender.SelectedItem);
            cmd.Parameters.AddWithValue("@Country", St_country.Text);
            cmd.Parameters.AddWithValue("@Province", St_province.Text);
            cmd.Parameters.AddWithValue("@City", St_city.Text);

            conn.Open();

            if (st_id.Text == "" || st_fname.Text == "" || st_lname.Text == "" || st_fathername.Text == "" || st_email.Text == "" || st_MNo.Text == "" || St_address.Text == "" || St_country.Text == "" || St_province.Text == "" || St_city.Text == "")
            {

                MessageBox.Show("Please Fill Empty Fields", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                {

                    {
                        MessageBox.Show("Data Inserted Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetControl();

                    }
                }
                else
                {
                    MessageBox.Show("Insertion Fialed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            conn.Close();
        }

        private void st_update_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);

            string query = "update Student_Registration set  StudentId=@StudentId,Firstname=@Firstname,Lastname=@Lastname,Fathername=@Fathername,Email=@Email,DateOfBirth=@DOB,DateOfRegistration=@DOR,Class=@Class,Mobile=@Mobile,Address=@Address,Gender=@Gender,Country=@Country,Province=@Province,City=@City where StudentId=@StudentId";
            SqlCommand cmd = new SqlCommand(query, conn);


            cmd.Parameters.AddWithValue("@StudentId", st_id.Text);
            cmd.Parameters.AddWithValue("@Firstname", st_fname.Text);
            cmd.Parameters.AddWithValue("@Lastname", st_lname.Text);
            cmd.Parameters.AddWithValue("@Fathername", st_fathername.Text);
            cmd.Parameters.AddWithValue("@Email", st_email.Text);
            cmd.Parameters.AddWithValue("@DOB", st_dob.Text);
            cmd.Parameters.AddWithValue("@DOR", st_dor.Text);
            cmd.Parameters.AddWithValue("@Class", st_class.SelectedItem);
            cmd.Parameters.AddWithValue("@Mobile", st_MNo.Text);
            cmd.Parameters.AddWithValue("@Address", St_address.Text);
            cmd.Parameters.AddWithValue("@Gender", St_Gender.SelectedItem);
            cmd.Parameters.AddWithValue("@Country", St_country.Text);
            cmd.Parameters.AddWithValue("@Province", St_province.Text);
            cmd.Parameters.AddWithValue("@City", St_city.Text);



            conn.Open();
            if (st_id.Text == "" || st_fname.Text == "" || st_lname.Text == "" || st_fathername.Text == "" || st_email.Text == "" || st_MNo.Text == "" || St_address.Text == "" || St_country.Text == "" || St_province.Text == "" || St_city.Text == "")
            {

                MessageBox.Show("Please Fill Empty Fields", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                    
                {
                    MessageBox.Show("Data Updated Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetControl();
                }
            else
            {
                MessageBox.Show("Update Fialed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            conn.Close();

        }

        void resetControl()
        {
            st_id.Clear();
            st_fname.Clear();
            st_lname.Clear();
            st_fathername.Clear();
            st_email.Clear();
            st_MNo.Clear();
            St_address.Clear();           
            St_country.Clear();
            St_province.Clear();
            St_city.Clear();


        }

        private void st_new_Click(object sender, EventArgs e)
        {
            resetControl();
        }

        private void st_delete_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(cs);

            string query = "delete from Student_Registration where StudentID=@id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", st_id.Text);
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

        private void st_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void st_id_KeyPress(object sender, KeyPressEventArgs e)
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

        private void st_MNo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void st_getdata_Click(object sender, EventArgs e)
        {
            St_display obj = new St_display();
            obj.Show();

            this.Hide();
        }

        private void St_Gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
    

