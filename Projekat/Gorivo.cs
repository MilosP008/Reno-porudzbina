using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
    class Gorivo : Kola
    {
        private string vrstaGoriva;

        public Gorivo()
        {
            this.vrstaGoriva = "Neobeležena";
        }

        public string VrstaGoriva
        {
            get { return vrstaGoriva; }
            set
            {
                if(value == "Benzin" || value == "Dizel" || value == "Hibrid" || value == "Električni")
                {
                    this.vrstaGoriva = value;
                }
                else
                {
                    this.vrstaGoriva = "Vrsta goriva nije odabrana.";
                }
            }
        }
    }
}
