using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libraries;

namespace SeekAffiliate
{
    public partial class FileCharge : Form
    {
        private string filePath;

        public FileCharge()
        {
            InitializeComponent();
            filePath = "";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //FOR SELECT THE DIRECTORY A CSV
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV Files|*.csv|All Files|*.*";
                openFileDialog.Title = "Open CSV File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    txbPath.Text = filePath;
                    // Read the CSV file and populate the DataGridView


                }


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (filePath != "")
            {
                Functions.ChargeAffiliateList(filePath);
                txbPath.BackColor = Color.Green;
                MessageBox.Show("Archivo cargado");

            }
            else
            {
                MessageBox.Show("ERROR No se encuentra seleccionado un directorio");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            //this.Hide();
        }
    }
}
