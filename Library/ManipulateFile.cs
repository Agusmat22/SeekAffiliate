using Entities;
using System.Formats.Asn1;

//INSTALE EL CSVHELPER EN (ADMINISTRATION PACKAGE NUGET)
using CsvHelper;
using System.Runtime.CompilerServices;

namespace Library
{
    public class ManipulateFile
    {
        private static List<Affiliate> listAffiliate;
        private static string routeFile = "C:\\Users\\usuario\\Desktop\\afi\\pruebaPrest.csv";

        static ManipulateFile()
        {
            listAffiliate = new List<Affiliate>();
        }

        public static void GetListAffiliate()
        {
            

            try
            {
                using (StreamReader reader = new StreamReader(routeFile))
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
                        string nombre = data[0];
                        int edad = int.Parse(data[1]);
                        string ciudad = data[2];

                        // Realizar manipulaciones con los datos (por ejemplo, almacenarlos en una lista, procesarlos, etc.)
                        // Para este ejemplo, simplemente imprimimos los datos
                        Console.WriteLine($"Nombre: {nombre}, Edad: {edad}, Ciudad: {ciudad}");
                        
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el archivo: {ex.Message}");
            }


        }





    }
}