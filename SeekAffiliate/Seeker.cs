using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using Library;

namespace SeekAffiliate
{
    public partial class Seeker : Form
    {
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
            //ManipulateFile.GetListAffiliate();

            try
            {
                using (StreamReader reader = new StreamReader("C:\\Users\\usuario\\Desktop\\afi\\pruebaPrest.csv"))
                {
                    /*
                    // Leer la línea de encabezado (columnas)
                    string headerLine = reader.ReadLine();
                    string[] headers = headerLine.Split(','); */

                    // Leer y procesar las líneas de datos
                    while (!reader.EndOfStream)
                    {
                        //Leo la primera linea
                        string dataLine = reader.ReadLine();
                        //la spliteo y entre cada ; la convierto en sub listas cada elemento
                        string[] data = dataLine.Split(';');

                        // Acceder a los valores individuales usando los encabezados
                        string entity = data[0];
                        //int edad = int.Parse(data[1]);
                        string numberAffialite = data[2];

                        string completeName = $"{data[4]} {data[5]}";

                        // Realizar manipulaciones con los datos (por ejemplo, almacenarlos en una lista, procesarlos, etc.)
                        // Para este ejemplo, simplemente imprimimos los datos
                        //MessageBox.Show($"Entidad: {entity}\nNumero de afiliado: {numberAffialite}\nNombre: {completeName}");

                        string afiliadoMostrar = $"Entidad: {entity}\nNumero de afiliado: {numberAffialite}\nNombre: {completeName}\n\n\n";
                        this.rtb_affiliate.Text += afiliadoMostrar;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo: {ex.Message}");

            }


            Console.WriteLine("holaaaa");
        }
    }
}
