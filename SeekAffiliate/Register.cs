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
            int.TryParse(this.txbIntRegister.Text, out int inter);
            string dniNumber = this.txbNDniRegister.Text;

            //pongo explicito el ENUMERATE para recibir el dato
            TypeDu typeDu = (TypeDu)this.cmbTypeDu.SelectedItem;

            string filePath = "C:\\Users\\usuario\\Desktop\\afi\\mdaPrueba.csv";


            bool saveState = Functions.DataSaveAffiliate(name,surName,entity,inter,typeDu,dniNumber,affiliateNumber,filePath);

            if (saveState)
            {
                DialogResult = DialogResult.OK;
                
            }
            else
            {
                DialogResult = DialogResult.Abort;
            }

        }
    }
}
