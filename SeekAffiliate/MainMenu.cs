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



        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //cierro definitivamente la APP
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            

        }



        //This method seek a affiliate in particulate
        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Search windowsSearch = new Search();

            this.Hide();

            DialogResult dialResult = windowsSearch.ShowDialog();


            this.Show();
        }

        //this method charge a CSV file on system
        private void chargeFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FileCharge fileCharge = new FileCharge();

            DialogResult dialogResult = fileCharge.ShowDialog();


        }
        //This method allow register a affiliate
        private void chargeToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserRegister userRegister = new UserRegister();

            DialogResult dialogResult = userRegister.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                MessageBox.Show("Usuario registrado");
            }
            
        }
    }
}
