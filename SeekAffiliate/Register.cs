using Entities;
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
using Entities;

namespace SeekAffiliate
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            this.cmbTypeDu.DataSource = Enum.GetValues(typeof(TypeDu));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = this.txbNameRegister.Text;
            string surName = this.txbSurnameRegister.Text;
            string entity = this.txbEntityRegister.Text;
            string affiliateNumber = this.txbNAffiliateRegister.Text;
            string inter = this.txbIntRegister.Text;
            string dniNumber = this.txbNDniRegister.Text;

            //pongo explicito el ENUMERATE para recibir el dato
            string typeDu = this.cmbTypeDu.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(surName) && !string.IsNullOrEmpty(entity)
                && !string.IsNullOrEmpty(affiliateNumber) && !string.IsNullOrEmpty(inter) && !string.IsNullOrEmpty(dniNumber))
            {
                string completName = name + " " + surName;

                Affiliate affiliate = new Affiliate(completName.Trim(), entity.Trim(), inter.Trim(), typeDu.Trim()
                    , dniNumber.Trim(), affiliateNumber.Trim());

                bool addValidation = Functions.AddAFfiliate(affiliate);

                if (addValidation)
                {
                    DialogResult = DialogResult.OK;

                }
                else
                {
                    DialogResult = DialogResult.Abort;
                }
            }
            else
            {
                MessageBox.Show("Error debe completar todos los campos");
            }

        }

        private void btnCancelRegister_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
