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
using System.Data.SqlClient;

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
            string messageFile = Functions.GetJson("listAffiliate");

            MessageBox.Show(messageFile);
        }

        private void afiliadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register windowsRegister = new Register();

            //creo un dialog para saber el resultado de la operacion despues
            DialogResult dialogResult = windowsRegister.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                MessageBox.Show("Afiliado guardado correctamente");

            }
            else if (dialogResult == DialogResult.Abort)
            {
                MessageBox.Show("Error al guardar el afiliado");
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("Registro cancelado");
            }



        }

        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics();

            statistics.Show();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileCharge fileCharge = new FileCharge();

            DialogResult dialogResult = fileCharge.ShowDialog();
            
            if(dialogResult == DialogResult.Abort)
            {
                MessageBox.Show("Carga cancelada");

            }
            

        }
    }
}
