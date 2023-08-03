using System.Text;

namespace Entities
{
    public class Affiliate
    {
        private string name;
        private string entity;
        private long number;
        private int intern;
        private string typeDocument;
        private long dni;

        public Affiliate(string name,string entity,int intern, string typeDocument,long dni,long number)
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
            stringBuilder.AppendLine($"Nº Afiliado: {number}/{}");
        }



    }
}