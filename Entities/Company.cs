using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Company
    {
        private string name;
        private int posName;
        private int posSurName;
        private int posEntity;
        private int posNumber;
        private int posIntern;
        private int posTypeDu;
        private int posDu;

        public Company(string name, int posName, int posSurName, int posEntity, int posNumber, int posIntern, int posTypeDu, int posDu)
        {
            this.name = name;
            this.posName = posName;
            this.posSurName = posSurName;
            this.posEntity = posEntity;
            this.posNumber = posNumber;
            this.posIntern = posIntern;
            this.posTypeDu = posTypeDu;
            this.posDu = posDu;


        }

        public string GetNameCompany
        {
            get { return this.name; }
        }

        public int GetName
        {
            get { return this.posName; }
        }
        public int GetSurName
        {
            get { return this.posSurName; }
        }

        public int GetEntity
        {
            get { return this.posEntity; }
        }

        public int GetNumber
        {
            get { return this.posNumber; }
        }

        public int GetIntern
        {
            get { return this.posIntern; }
        }

        public int GetTypeDu
        {
            get { return this.posTypeDu; }
        }

        public int GetDu
        {
            get { return this.posDu; }
        }


    }

}
