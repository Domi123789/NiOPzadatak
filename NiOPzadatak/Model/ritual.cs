using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiOPzadatak.Model
{
    public class ritual: IComparable {
        private int minLvl;
        private string name;
        private string duration;
        private string product;

        public int MinLvl
        {
            get { return minLvl; }
            set { minLvl = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        public string Product
        {
            get { return product; }
            set { product = value; }
        }

        public int CompareTo(object obj)
        {
            int rez = this.minLvl.CompareTo(((ritual)obj).minLvl);
            if (rez == 0) rez = this.name.CompareTo(((ritual)obj).name);
            return rez;
        }

    }
}
