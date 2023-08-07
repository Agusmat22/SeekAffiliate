using Libraries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeekAffiliate
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void afiliadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Seeker windowsSeeker = new Seeker();

            windowsSeeker.ShowDialog();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //cierro definitivamente la APP
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            //cargo la lista de afiliados en el sistema por unica vez
            Functions.ChargeAffiliateList();
        }
    }
}
