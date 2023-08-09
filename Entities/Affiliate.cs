using System.Text;

namespace Entities
{
    public enum TypeDu
    {
        DU,
        LC,
        LE,

    }

    public class Affiliate
    {
        private string name;
        private string entity;
        private string number;
        private int intern;
        private string typeDocument;
        private string dni;

        public Affiliate(string name,string entity,int intern, string typeDocument,string dni,string number)
        {
            this.name = name;
            this.entity = entity;
            this.intern = intern;
            this.typeDocument = typeDocument;
            this.dni = dni;
            this.number = number;
        }

        
        
        
        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();  

            stringBuilder.AppendLine($"Entidad: {entity}");
            stringBuilder.AppendLine($"Nombre: {name}");
            stringBuilder.AppendLine($"Dni: {dni}");
            stringBuilder.AppendLine($"Nº Afiliado: {number}/{intern}");

            return stringBuilder.ToString();
        }


        public string GetName
        {
            get { return name; }
        }

        public string GetNumber
        {
            get { return number; }
        }

        public string GetDni
        {
            get { return dni; }
        }

        public string GetEntity
        {
            get { return entity; }
        }

        public int GetIntern
        {
            get { return intern; }
        }

        public string GetTypeDu
        {
            get { return typeDocument; }
        }



    }
}