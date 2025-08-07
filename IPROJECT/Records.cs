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
    public partial class Records : Form
    {
        public Records()
        {
            InitializeComponent();
        }

        private void st_record_Click(object sender, EventArgs e)
        {
            St_display obj = new St_display();
            obj.Show();

        }

        private void Tc_Records_Click(object sender, EventArgs e)
        {

            Tc_display obj = new Tc_display();
            obj.Show();
        }

        private void Fs_Record_Click(object sender, EventArgs e)
        {

            FeesFrom_Display obj = new FeesFrom_Display();
            obj.Show();
        }
    }
}
