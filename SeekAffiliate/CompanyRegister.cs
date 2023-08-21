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

using Entities;

namespace SeekAffiliate
{
    public partial class CompanyRegister : Form
    {
        private Company companyRegister;

        public CompanyRegister()
        {
            InitializeComponent();

        }

        public Company GetPositions()
        {
            return companyRegister;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string joinNameCompany = this.txbCompanyName.Text.ToUpper().Trim();

            bool inputName = int.TryParse(this.txbPosName.Text, out int posName);
            bool inputSurname = int.TryParse(this.txbPosSurname.Text, out int posSurname);
            bool inputEntity = int.TryParse(this.txbPosEntity.Text, out int posEntity);
            bool inputNumber = int.TryParse(this.txbPosNumber.Text, out int posNumber);
            bool inputIntern = int.TryParse(this.txbPosIntern.Text, out int posIntern);
            bool inputTypeDu = int.TryParse(this.txbPosTypeDu.Text, out int posTypeDu);
            bool inputDu = int.TryParse(this.txbPosDu.Text, out int posDu);

            if (inputName && inputSurname && inputEntity && inputNumber && inputIntern && inputTypeDu && inputDu && joinNameCompany != "")
            {

                companyRegister = new Company(joinNameCompany, posName, posSurname, posEntity, posNumber,
                                                                          posIntern, posTypeDu, posDu);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Error, debe completar todos los campos con posiciones numericas");
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

        private void txbPosDu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || txbPosDu.Text.Length > 1
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


    }
}
