using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiOPzadatak.Model
{
    public class follower: IComparable {
        private string fuid;
        private string name;
        private string surname;
        private int asentionlvl;
        private string donationAmount;

        public string Fuid
        { 
            get{ return fuid; }
            set { fuid = value; } 
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public int Asentionlvl
        {
            get { return asentionlvl; }
        }

        public string DonationAmount
        {
            get { return donationAmount; }
            set { donationAmount = value; }
        }

        public int CompareTo(object obj)
        {
            int rez = this.asentionlvl.CompareTo(((follower)obj).asentionlvl);
            if (rez==0) rez = this.surname.CompareTo(((follower)obj).surname);
            if (rez==0) rez = this.name.CompareTo(((follower)obj).name);
            return rez;
        }

        public override string ToString()
       
            => Surname + "," + Name + "->" + Asentionlvl.ToString();
       
       
    }

  
    
    
}
