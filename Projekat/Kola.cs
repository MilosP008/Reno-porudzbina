using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
    class Kola
    {
        private string bojaKola;
        private string vrstaKola;

        public Kola()
        {
            this.bojaKola = "Neobeležena";
            this.vrstaKola = "Neobeležena";
        }
        
        public string BojaKola
        {
            get { return bojaKola; }
            set
            {
                if(value=="Crvena"||value=="Zelena"||value=="Plava"||value=="Žuta"||value=="Narandžasta"||value=="Ljubičasta"||value=="Bela")
                {
                    this.bojaKola = value;
                }
                else
                {
                    this.bojaKola = "Boja nije odabrana.";
                }
            }
        }

        public string VrstaKola
        {
            get { return vrstaKola; }
            set
            {
                if(value=="Novi Clio"||value=="Captur"||value=="Novi Megane")
                {
                    this.vrstaKola = value;
                }
                else
                {
                    this.vrstaKola = "Vrsta kola nije odabrana.";
                }
            }
        }
    }
}
