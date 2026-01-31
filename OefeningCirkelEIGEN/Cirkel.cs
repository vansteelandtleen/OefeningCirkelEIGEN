using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningCirkelEIGEN
{
    class Cirkel
    {// klasse in c sharp
        //eigenschappen
        private double straal;

        //constructor
        public Cirkel( double straal)
        {
            this.straal = straal;
        }
        //methodes
        public double getStraal()
        {

            return this.straal;
        }
        public void setStraal( double straal)
        {
            this.straal = straal;
        }

        public double berekenOmtrek()
        {
            return 2*Math.PI * getStraal();
        }
        public double berekenOpp()
        {
            return Math.PI * Math.Pow(getStraal(), 2);
        }
    }
}
