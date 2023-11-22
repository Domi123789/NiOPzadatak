using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiOPzadatak.Model
{
    public class execution: IComparable{

        private follower follower;
        private ritual ritual;
        private DateTime start;
        private DateTime end;

        public follower Follower
        {
            get { return follower; }
            set { follower = value; }
        }

        public ritual Ritual
        {
            get { return ritual; }
            set { ritual = value; }
        }

        private DateTime Start
        { 
            get { return start; }
            set {  start = value; } 
        }

        private DateTime End
        {
            get { return End; }
            set { End = value; }
        }

        public int CompareTo(object obj)
        {
            int rez = this.start.CompareTo(((execution)obj).start);
            if (rez == 0) rez = this.end.CompareTo(((execution)obj).end);
            return rez;
        }
    }
}
