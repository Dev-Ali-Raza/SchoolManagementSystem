using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IPROJECT
{
    public partial class Form1 : Form
    {
        public Form1()
        { 
            InitializeComponent();
        }
       

        private void Btn_Std_Click(object sender, EventArgs e)
        {
            Std_Reg obj = new Std_Reg();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teacher_Reg obj = new Teacher_Reg();
            obj.Show();
        }

        private void Fees_Form_Click(object sender, EventArgs e)
        {
            Fees_Form obj = new Fees_Form();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Records obj = new Records();
            obj.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Admin_Reg obj = new Admin_Reg();
            obj.Show();
           

        }

    private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Btn_logout_Click(object sender, EventArgs e)
        {
            
            Log_in obj = new Log_in();
            obj.Show();

            this.Hide();
          

        }
        
    }
}

