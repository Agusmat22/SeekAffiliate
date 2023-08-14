using System.Text;
using System.Runtime.Serialization;


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
        private string intern;
        private string typeDocument;
        private string dni;

        public Affiliate(string name,string entity,string intern, string typeDocument,string dni,string number)
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

        [DataMember(Name = "NOMBRE")]
        public string GetName
        {
            get { return name; }
        }

        [DataMember(Name = "N° AF")]
        public string GetNumber
        {
            get { return number; }
        }

        [DataMember(Name = "DNI")]
        public string GetDni
        {
            get { return dni; }
        }

        [DataMember(Name = "ENTIDAD")]

        public string GetEntity
        {
            get { return entity; }
        }

        [DataMember(Name = "INTERNO")]
        public string GetIntern
        {
            get { return intern; }
        }

        [DataMember(Name = "TIPO DU")]
        public string GetTypeDu
        {
            get { return typeDocument; }
        }



    }
}