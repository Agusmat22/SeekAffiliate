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

using CsvHelper;
using Entities;
using System.Text.RegularExpressions;
using System.Data.SQLite;
using System.Reflection.Metadata;

namespace SeekAffiliate
{
    public partial class Seeker : Form
    {
        private List<Affiliate> affiliateList;

        public Seeker()
        {
            InitializeComponent();

        }

        private void btnCancelSearch_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //REVISAR ESTE BOTON, ACA ENCUENTRO EL AFILIADO EN EL CSV
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string data = this.txbSeeked.Text;
            string dataType = "";

            if (this.rdbName.Checked == true)
            {

                dataType = "name";
            }
            else if (this.rdbNumber.Checked == true)
            {
                dataType = "number";
            }
            else if (this.rdbDni.Checked == true)
            {
                dataType = "dni";

            }



            affiliateList = Functions.GetAffiliate(data, dataType);

            if (affiliateList.Count > 0)
            {
                foreach (Affiliate af in affiliateList)
                {
                    string separado = new string('-', 53);
                    rtb_affiliate.Text += af.Mostrar() + "\n"+separado+"\n";
                }
            }
            else
            {
                MessageBox.Show("No se encontro al afiliado");
            }


        }

        private void Seeker_Load(object sender, EventArgs e)
        {

        }
    }
}
