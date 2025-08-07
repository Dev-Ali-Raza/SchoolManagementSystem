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
    public partial class Main : Form
    {
        public Main()
        {
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(12000);
            InitializeComponent();
            t.Abort();
        }

        public void SplashStart()
        {

            Application.Run(new Splash_Screen());
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
            Log_in obj = new Log_in();
            obj.Show();
            this.Hide();
            
        }
    }
}
