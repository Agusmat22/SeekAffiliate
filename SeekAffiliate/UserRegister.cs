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
using Libraries;

namespace SeekAffiliate
{
    public partial class UserRegister : Form
    {
        private User user;

        public UserRegister()
        {
            InitializeComponent();
        }

        private void UserRegister_Load(object sender, EventArgs e)
        {
            //I charger the ENUM of user class on comboBox 
            this.cmbTypeUser.DataSource = Enum.GetValues(typeof(TypeUser));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string userName = this.txbUser.Text;
            string typeUser = cmbTypeUser.Text;
            string password = this.txbPass.Text;
            string passwordAgain = this.txbPassAgain.Text;

            if (password == passwordAgain && !string.IsNullOrEmpty(userName))
            {
                user = new User(userName, password,typeUser);
                Functions.AddUser(user);
            }
        }
    }
}
