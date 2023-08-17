using Entities;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using System.Data;
using System.Data.SqlClient;

//SQL LITE
using Newtonsoft.Json;
//Function for read a json FILE
using System.Text.Json;




namespace Libraries
{
    public static class Functions
    {
        const string fileNameAffiliates = "listAffiliates";
        const string fileNameCompanies = "listCompanies";

        static List<Affiliate> listAffiliate;
        static List<Affiliate> listAffiliateLocated;
        static List<Company> listCompanies;
        static Affiliate affiliate;
        static Company company;
        static int amountAffiliateLocated;


        static Functions() 
        { 
            listAffiliate = new List<Affiliate>();
            listAffiliateLocated = new List<Affiliate>();
            listCompanies = new List<Company>();
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
                            string nameComplet = $"{data[listPos[1]]} {data[listPos[0]]}";

                            affiliate = new Affiliate(nameComplet, data[listPos[2]], data[listPos[4]], data[listPos[5]], data[listPos[6]], data[listPos[3]]);

                            listAffiliate.Add(affiliate);
                        }
                    }

                }
        }


        //This functions read the file JSON of the companies
        public static void ChargeCompaniesPos()
        {

            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileNameCompanies);
            try
            {
                if (File.Exists(jsonFilePath))
                {
                    if (listCompanies.Count > 0)
                    {
                        listCompanies.Clear();   
                    }

                    string jsonContent = File.ReadAllText(jsonFilePath);

                    JsonDocument doc = JsonDocument.Parse(jsonContent);

                    if (doc.RootElement.ValueKind == JsonValueKind.Array)
                    {
                        foreach (JsonElement element in doc.RootElement.EnumerateArray())
                        {
                            string posNameCompany = element.GetProperty("GetNameCompany").ToString();
                            
                            //I read it how a INT32
                            int posName = element.GetProperty("GetName").GetInt32();
                            int posSurName = element.GetProperty("GetSurName").GetInt32();
                            int posEntity = element.GetProperty("GetEntity").GetInt32();
                            int posNumber = element.GetProperty("GetNumber").GetInt32();
                            int posIntern = element.GetProperty("GetIntern").GetInt32();
                            int posTypeDu = element.GetProperty("GetTypeDu").GetInt32();
                            int posDu = element.GetProperty("GetDu").GetInt32();


                            company = new Company(posNameCompany, posName, posSurName, posEntity, posNumber
                                            , posIntern, posTypeDu, posDu);
                            listCompanies.Add(company);
                        }

                    }
                }
            }
            catch
            {

            }


        }
        //this method create a json
        public static string CreateJson()
        {
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileNameAffiliates);

            // Serializa la lista de afiliados a formato JSON
            string jsonData = JsonConvert.SerializeObject(listAffiliate, Formatting.Indented);

            // Escribe el JSON en el archivo
            File.WriteAllText(jsonFilePath, jsonData);

            //return $"Se han guardado {listAffiliate.Count} afiliados en {jsonFileName}";
            return $"Se han guardado {jsonFilePath}";

        }


        //overCharger the function for read dictionary
        public static string CreateJson(Company company)
        {
            listCompanies.Add(company);
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileNameCompanies);

            // Serializa la lista de afiliados a formato JSON
            string jsonData = JsonConvert.SerializeObject(listCompanies, Formatting.Indented);

            // Escribe el JSON en el archivo
             File.WriteAllText(jsonFilePath, jsonData);

            //return $"Se han guardado {listAffiliate.Count} afiliados en {jsonFileName}";
            return $"Se han guardado {jsonFilePath}";

        }

        public static string AddCompanyJson(Company companyJoin)
        {
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileNameCompanies);
            try
            {

                if (File.Exists(jsonFilePath))
                {
                   
                    listCompanies.Add(companyJoin);
                    SaveCompanyJson();

                }
                else
                {
                    CreateJson(companyJoin);
                
                }

                return "Empresa agregada";
            }
            catch (Exception ex)
            { 
                return ex.Message;
            
            }
        }



        public static void SaveCompanyJson()
        {
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileNameCompanies);

            // Serialize the updated list of companies back to JSON
            string updatedJson = JsonConvert.SerializeObject(listCompanies, Formatting.Indented);

            // Write the updated JSON content back to the file
            File.WriteAllText(jsonFilePath, updatedJson);
        }

        

        public static bool RemoveCompany(string name)
        {
            foreach (Company company in listCompanies)
            {
                if (company.GetNameCompany == name)
                {
                    listCompanies.Remove(company);
                    SaveCompanyJson();
                    return true;
                }


            }
            return false;

        }


        public static List<string> ListNameCompanies()
        {
            ChargeCompaniesPos();

            List<string> listNameCompanies = new List<string>();

            if (listCompanies.Count > 0)
            {
                foreach (Company company in listCompanies)
                {
                    listNameCompanies.Add(company.GetNameCompany);
                }
            }
            else
            {
                listNameCompanies.Add("");
            }


            return listNameCompanies;
        }

        public static List<Company> ListCompanies
        {
            get { return listCompanies; }

        }

        //this method get the JSON file created when if charged the CSV file
        public static string GetJson(string fileName) 
        {
            try
            {
                //get the directory of JSON file 
                string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

                if (File.Exists(jsonFilePath))
                {
                    string jsonContent = File.ReadAllText(jsonFilePath);

                    JsonDocument doc = JsonDocument.Parse(jsonContent);

                    if (doc.RootElement.ValueKind == JsonValueKind.Array)
                    {
                        foreach (JsonElement element in doc.RootElement.EnumerateArray())
                        {
                            string getName = element.GetProperty("GetName").GetString();
                            string getNumber = element.GetProperty("GetNumber").GetString();
                            string getDni = element.GetProperty("GetDni").GetString();
                            string getEntity = element.GetProperty("GetEntity").GetString();
                            string getIntern = element.GetProperty("GetIntern").GetString();
                            string getTypeDu = element.GetProperty("GetTypeDu").GetString();


                            affiliate = new Affiliate(getName, getEntity, getIntern, getTypeDu, getDni, getNumber);
                            listAffiliate.Add(affiliate);
                        }

                        return "";
                    }
                    
                }
                else
                {
                    return "No hay archivos cargados en el sistema";
                }
            }
            catch(Exception ex) 
            { 
            
                return "Error: " + ex.ToString();
            
            }

            return "ERROR";


        }
        
        
        //Esta funcion obtiene un afiliado segun el tipo de dato buscado
        public static List<Affiliate> GetAffiliate(string data,string dataType) 
        {
            listAffiliateLocated.Clear();

            if (dataType == "name")
            {

                foreach (Affiliate affiliate in listAffiliate)
                {
                    //Indicated for accept until 30 affiliates
                    if (amountAffiliateLocated < 20)
                    {

                        if (BuscarCoincidencia(affiliate.GetName,data))
                        {
                            listAffiliateLocated.Add(affiliate);
                            amountAffiliateLocated += 1;
                        }
                    }
                    else
                    {
                        break;
                        
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
               
                if (cadena.ToLower().Contains(fragmentos.ToLower()))
                {
                    cantTerminosEncotrados++;
                }
                else
                {
                    break;
                }

            }

            if (cantTerminosEncotrados == cantTerminos)
            {
                return true;
            }

            return false;


        }
        
        public static bool AddAFfiliate(Affiliate af)
        {
            try
            {
                listAffiliate.Add(af);
                CreateJson();
                return true;

            }
            catch (Exception ex) 
            { 
                return false;
            }
            
        }

        public static bool RemoveAffiliate(string dni)
        {
            foreach (Affiliate af in listAffiliate)
            {
                if (af.GetDni == dni)
                 {
                    listAffiliate.Remove(af);
                    //This method save the JSON file after the changed
                    CreateJson();
                    return true;
                }
            }
            return false;

        }

        //this method calculate amount of entity in total
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