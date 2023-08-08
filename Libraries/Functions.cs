using Entities;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

//SQL LITE
using System.Data.SQLite;

namespace Libraries
{
    public static class Functions
    {
        static List<Affiliate> listAffiliate;
        static List<Affiliate> listAffiliateLocated;
        static Affiliate affiliate;
        static int amountAffiliateLocated;

        static Functions() 
        { 
            listAffiliate = new List<Affiliate>();
            listAffiliateLocated = new List<Affiliate>();
            amountAffiliateLocated = 0;
            
        }

        //Esta funcion lee el archivo csv y lo retorna en una lista
        public static void ChargeAffiliateList()
        {
            
                using (StreamReader reader = new StreamReader("C:\\Users\\Lisandro\\Desktop\\App Buscador\\afiMaestro.csv"))
                {


                    // Leer y procesar las líneas de datos
                    while (!reader.EndOfStream)
                    {
                        //Leo la primera linea
                        string dataLine = reader.ReadLine();
                        //la spliteo y entre cada ; la convierto en sub listas cada elemento
                        string[] data = dataLine.Split(';');

                        if (data.Length >= 14)
                        {
                            if (!int.TryParse(data[3], out int intern))
                            {
                                intern = -1;
                            }

                            if (data[1] == "" || data[12] == "" || data[13] == "" || data[2] == "")
                            {
                                Console.WriteLine("INgrese aca");
                            }


                            string nameComplet = $"{data[4]} {data[5]}";

                            affiliate = new Affiliate(nameComplet, data[1], intern, data[12], data[13], data[2]);

                            listAffiliate.Add(affiliate);
                        }
                    }

                }
            
           

        }

        //ESTABA HACIENDO LA FUNCION PAR ENCONTRAR AFILIADO, CONTINUARLA Y PERFECCIONARLA

        //Esta funcion obtiene un afiliado segun el tipo de dato buscado
        public static List<Affiliate> GetAffiliate(string data,string dataType) 
        {
            listAffiliateLocated.Clear();

            if (dataType == "name")
            {

                foreach (Affiliate affiliate in listAffiliate)
                {
                    if (amountAffiliateLocated < 30)
                    {

                        if (BuscarCoincidencia(affiliate.GetName,data))
                        {
                            listAffiliateLocated.Add(affiliate);
                            amountAffiliateLocated += 1;
                        }
                    }

                    
                }
            }
            else if(dataType == "number")
            {
                foreach (Affiliate affiliate in listAffiliate)
                {

                    if (Regex.IsMatch(affiliate.GetNumber, data))
                    {
                        listAffiliateLocated.Add(affiliate);
                    }

                }

            }
            else if (dataType == "dni")
            {
                foreach (Affiliate affiliate in listAffiliate)
                {
                    if (Regex.IsMatch(affiliate.GetDni, data))
                    {
                        listAffiliateLocated.Add(affiliate);
                    }

                }
            }

            amountAffiliateLocated = 0;
            return listAffiliateLocated;
        }

        //esta funcion busca coincidencia de string para buscar un nombre
        private static bool BuscarCoincidencia(string cadena, string terminoBusqueda)
        {
            string[] termBusqueda = terminoBusqueda.Split(' ');
            int cantTerminos = termBusqueda.Length;
            int cantTerminosEncotrados = 0;

            foreach (string fragmentos in termBusqueda)
            {
                if (cadena.ToLower().IndexOf(fragmentos.ToLower()) != -1)
                {
                    cantTerminosEncotrados++;
                }

            }

            if (cantTerminosEncotrados == cantTerminos)
            {
                return true;
            }

            return false;


        }
        
        public static bool DataSaveAffiliate(string name, string entity, int intern, string typeDocument, string dni, string number,string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath,true))
                {
                    writer.WriteLine($"99;{entity};{number};{intern};{name};{name};'';'';'';'';'';'';{typeDocument};{dni};"); 
                }
                return true;
            } 
            catch (Exception ex) 
            { 
                return false;
            }
            
        }








    }
}