using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libraries;

using Entities;

namespace SeekAffiliate
{
    public partial class FileCharge : Form
    {
        private string filePath;
        private List<int> listPosition;
        string selectCompany;

        public FileCharge()
        {
            InitializeComponent();
            filePath = "";
            listPosition = new List<int>();


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
            bool inputSurname = int.TryParse(this.txbPosSurname.Text, out int posSurname);
            bool inputEntity = int.TryParse(this.txbPosEntity.Text, out int posEntity);
            bool inputNumber = int.TryParse(this.txbPosNumber.Text, out int posNumber);
            bool inputIntern = int.TryParse(this.txbPosIntern.Text, out int posIntern);
            bool inputTypeDu = int.TryParse(this.txbPosTypeDu.Text, out int posTypeDu);
            bool inputDu = int.TryParse(this.txbPosDu.Text, out int posDu);


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


                    Functions.ChargeAffiliateList(filePath, listPosition);
                    txbPath.BackColor = Color.Green;
                    string message = Functions.CreateJson();
                    MessageBox.Show(message);
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

        //Label for add company
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CompanyRegister companyRegister = new CompanyRegister();

            this.Hide();
            DialogResult dialogResult = companyRegister.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                //I get the object than contain the positions and I save whithin of json
                string message = Functions.AddCompanyJson(companyRegister.GetPositions());

                this.cmbCompany.DataSource = Functions.ListNameCompanies();
                MessageBox.Show(message);
            }

            this.Show();
        }

        private void FileCharge_Load(object sender, EventArgs e)
        {
            //I charger the Companies name List
            if (Functions.ListNameCompanies().Count > 0)
            {
                this.cmbCompany.DataSource = Functions.ListNameCompanies();

            }
        }

        private void cmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectCompany = cmbCompany.SelectedItem.ToString();

            foreach (Company company in Functions.ListCompanies)
            {
                if (selectCompany == company.GetNameCompany)
                {
                    this.txbPosName.Text = company.GetName.ToString();
                    this.txbPosSurname.Text = company.GetSurName.ToString();
                    this.txbPosEntity.Text = company.GetEntity.ToString();
                    this.txbPosNumber.Text = company.GetNumber.ToString();
                    this.txbPosIntern.Text = company.GetIntern.ToString();
                    this.txbPosTypeDu.Text = company.GetTypeDu.ToString();
                    this.txbPosDu.Text = company.GetDu.ToString();
                    break;
                }
            }

        }

        //Label for remove Company
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Functions.GetUser().AccessValidation())
            {
                bool removeCompanie = Functions.RemoveCompany(selectCompany);

                if (removeCompanie)
                {
                    this.cmbCompany.DataSource = Functions.ListNameCompanies();
                    MessageBox.Show($"Empresa elimnada. ");


                }
                else
                {
                    MessageBox.Show($"No hay empresas registradas");

                }
            }
            else
            {
                MessageBox.Show("No tienes acceso");
            }

        }

        private void txbPosName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || txbPosName.Text.Length > 1
                && e.KeyChar != '\b')
            {
                e.Handled = true; // Evita que el carácter se ingrese en el TextBox
            }
        }

        private void txbPosSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || txbPosSurname.Text.Length > 1
                && e.KeyChar != '\b')
            {
                e.Handled = true; // Evita que el carácter se ingrese en el TextBox
            }
        }

        private void txbPosEntity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || txbPosEntity.Text.Length > 1
                && e.KeyChar != '\b')
            {
                e.Handled = true; // Evita que el carácter se ingrese en el TextBox
            }
        }

        private void txbPosNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || txbPosNumber.Text.Length > 1
                && e.KeyChar != '\b')
            {
                e.Handled = true; // Evita que el carácter se ingrese en el TextBox
            }
        }

        private void txbPosIntern_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || txbPosIntern.Text.Length > 1
                && e.KeyChar != '\b')
            {
                e.Handled = true; // Evita que el carácter se ingrese en el TextBox
            }
        }

        private void txbPosTypeDu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || txbPosTypeDu.Text.Length > 1
                && e.KeyChar != '\b')
            {
                e.Handled = true; // Evita que el carácter se ingrese en el TextBox
            }
        }

        private void txbPosDu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || txbPosDu.Text.Length > 1
                && e.KeyChar != '\b')
            {
                e.Handled = true; // Evita que el carácter se ingrese en el TextBox
            }
        }
    }
}
