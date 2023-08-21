using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeekAffiliate
{
    public partial class AboutSystem : Form
    {
        public AboutSystem()
        {
            InitializeComponent();
        }

        private void linklbLinkedin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://www.linkedin.com/in/agustin-matias-garcia-navas-8b980524b",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la URL: " + ex.Message);
            }
        }
    }
}

