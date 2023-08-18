using Entities;
using Libraries;

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
            string userJoined = this.txbUser.Text;
            string passJoined = this.txbPassword.Text;


            if (attempts < maxAttempts)
            {
                if (userJoined.ToLower() == "agusmat" && passJoined.ToLower() == "12345")
                {
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

        private void Login_Load(object sender, EventArgs e)
        {
            string valueMessage = Functions.GetJson("listAffiliates");

            if (valueMessage != "")
            {
                MessageBox.Show(valueMessage);
            }
        }
    }
}