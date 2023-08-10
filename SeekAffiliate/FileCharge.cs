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
        private List<int> listPosition;

        public FileCharge()
        {
            InitializeComponent();
            listPosition = new List<int>();
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
            bool inputName = int.TryParse(this.txbPosName.Text, out int posName);
            bool inputSurname = int.TryParse(this.txbPosName.Text, out int posSurname);
            bool inputEntity = int.TryParse(this.txbPosName.Text, out int posEntity);
            bool inputNumber = int.TryParse(this.txbPosName.Text, out int posNumber);
            bool inputIntern = int.TryParse(this.txbPosName.Text, out int posIntern);
            bool inputTypeDu = int.TryParse(this.txbPosName.Text, out int posTypeDu);
            bool inputDu = int.TryParse(this.txbPosName.Text, out int posDu);


            if (filePath != "")
            {
                if (inputName && inputSurname && inputEntity && inputNumber && inputIntern && inputTypeDu && inputDu)
                {
                    listPosition.Add(posName);
                    listPosition.Add(posSurname);
                    listPosition.Add(posEntity);
                    listPosition.Add(posNumber);
                    listPosition.Add(posIntern);
                    listPosition.Add(posTypeDu);
                    listPosition.Add(posDu);
                    
                    
                    Functions.ChargeAffiliateList(filePath,listPosition);
                    txbPath.BackColor = Color.Green;
                    MessageBox.Show("Archivo cargado");
                }


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
