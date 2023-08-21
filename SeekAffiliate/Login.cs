using Entities;
using Libraries;
using BCrypt.Net;


namespace SeekAffiliate
{
    public partial class Login : Form
    {
        //maximos intentos
        private int maxAttempts = 3;
        private int attempts;
        private User user;


        public Login()
        {
            InitializeComponent();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            ValidateIncome();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            string valueMessage = Functions.GetJson("listAffiliates");
            bool chargeUsersStatus = Functions.ChargerUsers();


            if (valueMessage != "")
            {
                MessageBox.Show(valueMessage);
            }
            else if (chargeUsersStatus == false)
            {
                MessageBox.Show("ERROR al cargar los usuarios");
            }
        }

        private void txbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                ValidateIncome();  
            }
        }


        private void ValidateIncome()
        {
            string userJoined = this.txbUser.Text;
            string passJoined = this.txbPassword.Text;


            if (attempts < maxAttempts)
            {
                if (Functions.ValidateUsers(userJoined, passJoined))
                {
                    //user = User(userJoined.ToLower(),)
                    //inicializo el objeto de la interfaz menu
                    MainMenu mainMenu = new MainMenu();
                    //abro el menu
                    mainMenu.Show();
                    //escondo el login
                    this.Hide();

                }
                else
                {
                    //addition of intents
                    attempts++;
                    MessageBox.Show($"Error ingrese nuevamente la clave. Intento: {attempts}");

                }
            }
            else
            {
                MessageBox.Show("Supero los 3 intentos, se cerrara la app.");
                this.Close();
            }

        }
    }
}