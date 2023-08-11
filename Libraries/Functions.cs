using Entities;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using System.Data;
using System.Data.SqlClient;

//SQL LITE
using Newtonsoft.Json;




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
        public static void ChargeAffiliateList(string pathFile,List<int>listPos)
        {
            
                using (StreamReader reader = new StreamReader(pathFile))
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
                            if (!int.TryParse(data[listPos[4]], out int intern))
                            {
                                intern = -1;
                            }
                            

                            string nameComplet = $"{data[listPos[1]]} {data[listPos[0]]}";

                            affiliate = new Affiliate(nameComplet, data[listPos[2]], intern, data[listPos[5]], data[listPos[6]], data[listPos[3]]);

                            listAffiliate.Add(affiliate);
                        }
                    }

                }
        }

        public static string CreateJson(string fileName)
        {
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            // Serializa la lista de afiliados a formato JSON
            string jsonData = JsonConvert.SerializeObject(listAffiliate, Formatting.Indented);

            // Escribe el JSON en el archivo
            File.WriteAllText(jsonFilePath, jsonData);

            //return $"Se han guardado {listAffiliate.Count} afiliados en {jsonFileName}";
            return $"Se han guardado {jsonFilePath}";



        }

        public static string GetJson(string fileName) 
        {
            
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            /*
            if (File.Exists(jsonFilePath))
            {
                string jsonContent = File.ReadAllText(jsonFilePath);

                List<Affiliate> affiliates = JsonSerializer.Deserialize<List<Affiliate>>(jsonContent);

                return "Bienvenido a Gestion de Afiliado";
            }
            else
            {
                return "Debe cargar un archivo";
            }*/

            if (File.Exists(jsonFilePath))
            {
                string jsonContent = File.ReadAllText(jsonFilePath);

                List<Affiliate> affiliates = JsonSerializer.Deserialize<List<Affiliate>>();

                foreach (Affiliate affiliate in affiliates)
                {
                    Console.WriteLine($"GetName: {affiliate.GetName}");
                    Console.WriteLine($"GetNumber: {affiliate.GetNumber}");
                    Console.WriteLine($"GetDni: {affiliate.GetDni}");
                    Console.WriteLine($"GetEntity: {affiliate.GetEntity}");
                    Console.WriteLine($"GetIntern: {affiliate.GetIntern}");
                    Console.WriteLine($"GetTypeDu: {affiliate.GetTypeDu}");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("El archivo JSON no existe.");
            }




        }
        /*
         * 
         * REVISARLA
        private static List<Affiliate> ParseJson(string jsonContent)
        {
            List<Affiliate> affiliates = new List<Affiliate>();

            JsonDocument doc = JsonDocument.Parse(jsonContent);

            if (doc.RootElement.ValueKind == JsonValueKind.Array)
            {
                foreach (JsonElement element in doc.RootElement.EnumerateArray())
                {
                    Affiliate affiliate = new Affiliate
                    {
                        GetName = element.GetProperty("GetName").GetString(),
                        GetNumber = element.GetProperty("GetNumber").GetString(),
                        GetDni = element.GetProperty("GetDni").GetString(),
                        GetEntity = element.GetProperty("GetEntity").GetString(),
                        GetIntern = element.GetProperty("GetIntern").GetInt32(),
                        GetTypeDu = element.GetProperty("GetTypeDu").GetString()
                    };

                    affiliates.Add(affiliate);
                }
            }

            return affiliates;
        }
        */

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
        
        //Guarda un afiliado en un archivo CSV
        public static bool DataSaveAffiliate(string name,string surname, string entity, int intern, TypeDu typeDocument, string dni, string number,string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath,true))
                {
                    writer.WriteLine($"99;{entity};{number};{intern};{surname};{name};'';'';'';'';'';'';{typeDocument};{dni};"); 
                }
                return true;
            } 
            catch (Exception ex) 
            { 
                return false;
            }
            
        }

        public static int CalculateAmountByEntity(string entity)
        {
            int amount = 0;

            foreach (Affiliate af in listAffiliate)
            {
                if (af.GetEntity == entity)
                {
                    amount++;
                }


            }

            return amount;
        }

        
    }
}