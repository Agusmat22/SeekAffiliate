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
    public partial class RemoveUser : Form
    {
        public RemoveUser()
        {
            InitializeComponent();
        }

        private void RemoveUser_Load(object sender, EventArgs e)
        {
            this.cmbUser.DataSource = Functions.ListNameUsers();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string selectUser = this.cmbUser.Text;

            if (!string.IsNullOrEmpty(selectUser) || selectUser != "ADMIN")
            {
                bool statusRemove = Functions.RemoveUser(selectUser);

                if (statusRemove)
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
                MessageBox.Show("Debe completar los campos");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
