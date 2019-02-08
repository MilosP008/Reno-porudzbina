using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
    class Motor : Gorivo
    {
        protected string tipMotora;
        protected double kubikaza;
        protected string tipMenjaca;
        protected double aerodinamika;
        protected double maxBrzina;
        protected int emisijeCO2;
        protected double gradskaVoznja;
        protected double vangradskaVoznja;
        protected double mesovitaVoznja;

        public Motor()
        {
            this.tipMotora = "Neobeležen";
            this.kubikaza = 0.0;
            this.tipMenjaca = "Neobeležen";
            this.aerodinamika = 0.0;
            this.maxBrzina = 0.0;
            this.emisijeCO2 = 0;
            this.gradskaVoznja = 0.0;
            this.vangradskaVoznja = 0.0;
            this.mesovitaVoznja = 0.0;
        }

        public string TipMotora
        {
            get { return tipMotora; }
            set
            {
                if (value == "Atmosferski" || value == "Turbo/višetačkovno ubrizgavanje" || value == "Turbo/direktno ubrizgavanje" || value == "4-Cilindrični/direktno ubrizgavanje" || value == "4-Cilindrični/sa varijabilnom geom." || value == "4-Cilindrični/dvostruki turbopunjač")
                {
                    this.tipMotora = value;
                }
                else
                {
                    this.tipMotora = "Tip motora nije odabran.";
                }
            }
        }
        //
        // Specifikacije za Novi Clio.
        //
        public double NCKubikaza()
        {
            if (VrstaGoriva == "Benzin")
            {
                if (TipMotora == "Atmosferski")
                {
                    kubikaza = 1149;
                }
                else if (TipMotora == "Turbo/višetačkovno ubrizgavanje")
                {
                    kubikaza = 898;
                }
                else if (TipMotora == "Turbo/direktno ubrizgavanje")
                {
                    kubikaza = 1618;
                }
            }
            else if (VrstaGoriva == "Dizel")
            {
                if (TipMotora == "Turbo/direktno ubrizgavanje")
                {
                    kubikaza = 1461;
                }
            }
            return kubikaza;
        }

        public string NCMenjac()
        {
            if (VrstaGoriva == "Benzin")
            {
                if (TipMotora == "Atmosferski" || TipMotora == "Turbo/višetačkovno ubrizgavanje")
                {
                    tipMenjaca = "5-stepeni ručni menjač";
                }
                else if (TipMotora == "Turbo/direktno ubrizgavanje")
                {
                    tipMenjaca = "6-stepeni ručni menjač";
                }
            }
            else if (VrstaGoriva == "Dizel")
            {
                if (TipMotora == "Turbo/direktno ubrizgavanje")
                {
                    tipMenjaca = "6-stepeni menjač EDC";
                }
            }
            return tipMenjaca;
        }

        public double NCPerformanse(int a)
        {
            if (VrstaGoriva == "Benzin")
            {
                if (TipMotora == "Atmosferski")
                {
                    aerodinamika = 0.744;
                    maxBrzina = 167;
                }
                else if (TipMotora == "Turbo/višetačkovno ubrizgavanje")
                {
                    aerodinamika = 0.670;
                    maxBrzina = 180;
                }
                else if (TipMotora == "Turbo/direktno ubrizgavanje")
                {
                    aerodinamika = 0.710;
                    maxBrzina = 230;
                }
            }
            else if (VrstaGoriva == "Dizel")
            {
                if (TipMotora == "Turbo/direktno ubrizgavanje")
                {
                    aerodinamika = 0.670;
                    maxBrzina = 180;
                }
            }

            if (a == 1)
            {
                return aerodinamika;
            }
            else if (a == 2)
            {
                return maxBrzina;
            }
            return 0.0;
        }

        public double NCPotrosnjaGorivaIEmisije(int a)
        {
            if (VrstaGoriva == "Benzin")
            {
                if (TipMotora == "Atmosferski")
                {
                    emisijeCO2 = 127;
                    gradskaVoznja = 7.2;
                    vangradskaVoznja = 4.7;
                    mesovitaVoznja = 5.5;
                }
                else if (TipMotora == "Turbo/višetačkovno ubrizgavanje")
                {
                    emisijeCO2 = 105;
                    gradskaVoznja = 5.7;
                    vangradskaVoznja = 4.1;
                    mesovitaVoznja = 4.7;
                }
                else if (TipMotora == "Turbo/direktno ubrizgavanje")
                {
                    emisijeCO2 = 118;
                    gradskaVoznja = 6.8;
                    vangradskaVoznja = 4.5;
                    mesovitaVoznja = 5.3;
                }
            }
            else if (VrstaGoriva == "Dizel")
            {
                if (TipMotora == "Turbo/direktno ubrizgavanje")
                {
                    emisijeCO2 = 90;
                    gradskaVoznja = 3.8;
                    vangradskaVoznja = 3.3;
                    mesovitaVoznja = 3.5;
                }
            }

            if (a == 1)
            {
                return emisijeCO2;
            }
            else if (a == 2)
            {
                return gradskaVoznja;
            }
            else if (a == 3)
            {
                return vangradskaVoznja;
            }
            else if (a == 4)
            {
                return mesovitaVoznja;
            }
            return 0.0;
        }
        //
        // Specifikacije za Captur.
        //
        public double CKubikaza()
        {
            if (VrstaGoriva == "Benzin")
            {
                if (TipMotora == "Turbo/višetačkovno ubrizgavanje")
                {
                    kubikaza = 898;
                }
                else if (TipMotora == "Turbo/direktno ubrizgavanje")
                {
                    kubikaza = 1197;
                }
            }
            else if (VrstaGoriva == "Dizel")
            {
                if (TipMotora == "Turbo/direktno ubrizgavanje")
                {
                    kubikaza = 1461;
                }
            }
            return kubikaza;
        }

        public string CMenjac()
        {
            if (VrstaGoriva == "Benzin")
            {
                if (TipMotora == "Turbo/višetačkovno ubrizgavanje")
                {
                    tipMenjaca = "5-stepeni ručni menjač";
                }
                else if (TipMotora == "Turbo/direktno ubrizgavanje")
                {
                    tipMenjaca = "6-stepeni automatski menjač sa dvostrukim kvačilom";
                }
            }
            else if (VrstaGoriva == "Dizel")
            {
                if (TipMotora == "Turbo/direktno ubrizgavanje")
                {
                    tipMenjaca = "5-stepeni ručni menjač";
                }
            }
            return tipMenjaca;
        }

        public double CPerformanse()
        {
            if (VrstaGoriva == "Benzin")
            {
                if (TipMotora == "Turbo/višetačkovno ubrizgavanje")
                {
                    maxBrzina = 171;
                }
                else if (TipMotora == "Turbo/direktno ubrizgavanje")
                {
                    maxBrzina = 192;
                }
            }
            else if (VrstaGoriva == "Dizel")
            {
                if (TipMotora == "Turbo/direktno ubrizgavanje")
                {
                    maxBrzina = 171;
                }
            }
            return maxBrzina;
        }

        public double CPotrosnjaGorivaIEmisije(int a)
        {
            if (VrstaGoriva == "Benzin")
            {
                if (TipMotora == "Turbo/višetačkovno ubrizgavanje")
                {
                    emisijeCO2 = 113;
                    gradskaVoznja = 6;
                    vangradskaVoznja = 4.5;
                    mesovitaVoznja = 5.1;
                }
                else if (TipMotora == "Turbo/direktno ubrizgavanje")
                {
                    emisijeCO2 = 125;
                    gradskaVoznja = 7.3;
                    vangradskaVoznja = 4.9;
                    mesovitaVoznja = 5.5;
                }
            }
            else if (VrstaGoriva == "Dizel")
            {
                if (TipMotora == "Turbo/direktno ubrizgavanje")
                {
                    emisijeCO2 = 95;
                    gradskaVoznja = 3.9;
                    vangradskaVoznja = 3.5;
                    mesovitaVoznja = 3.7;
                }
            }

            if (a == 1)
            {
                return emisijeCO2;
            }
            else if (a == 2)
            {
                return gradskaVoznja;
            }
            else if (a == 3)
            {
                return vangradskaVoznja;
            }
            else if (a == 4)
            {
                return mesovitaVoznja;
            }
            return 0.0;
        }
        //
        // Specifikacije za Novi Megane.
        //
        public double NMKubikaza()
        {
            if (VrstaGoriva == "Benzin")
            {
                if (TipMotora == "4-Cilindrični/direktno ubrizgavanje")
                {
                    kubikaza = 1198;
                }
            }
            else if (VrstaGoriva == "Dizel")
            {
                if (TipMotora == "4-Cilindrični/sa varijabilnom geom.")
                {
                    kubikaza = 1461;
                }
                else if (TipMotora == "4-Cilindrični/dvostruki turbopunjač")
                {
                    kubikaza = 1598;
                }
            }
            return kubikaza;
        }

        public string NMMenjac()
        {
            if (VrstaGoriva == "Benzin")
            {
                if (TipMotora == "4-Cilindrični/direktno ubrizgavanje")
                {
                    tipMenjaca = "5-stepeni ručni menjač";
                }
            }
            else if (VrstaGoriva == "Dizel")
            {
                if (TipMotora == "4-Cilindrični/sa varijabilnom geom.")
                {
                    tipMenjaca = "5-stepeni ručni menjač";
                }
                else if (TipMotora == "4-Cilindrični/dvostruki turbopunjač")
                {
                    tipMenjaca = "Automatski menjač EDC sa dvostrukim kvačilom";
                }
            }
            return tipMenjaca;
        }

        public double NMPerformanse(int a)
        {
            if (VrstaGoriva == "Benzin")
            {
                if (TipMotora == "4-Cilindrični/direktno ubrizgavanje")
                {
                    aerodinamika = 0.71;
                    maxBrzina = 179;
                }
            }
            else if (VrstaGoriva == "Dizel")
            {
                if (TipMotora == "4-Cilindrični/sa varijabilnom geom.")
                {
                    aerodinamika = 0.69;
                    maxBrzina = 174;
                }
                else if (TipMotora == "4-Cilindrični/dvostruki turbopunjač")
                {
                    aerodinamika = 0.69;
                    maxBrzina = 0.0;
                }
            }

            if (a == 1)
            {
                return aerodinamika;
            }
            else if (a == 2)
            {
                return maxBrzina;
            }
            return 0.0;
        }

        public double NMPotrosnjaGorivaIEmisije(int a)
        {
            if (VrstaGoriva == "Benzin")
            {
                if (TipMotora == "4-Cilindrični/direktno ubrizgavanje")
                {
                    emisijeCO2 = 119;
                    gradskaVoznja = 6.7;
                    vangradskaVoznja = 4.6;
                    mesovitaVoznja = 5.4;
                }
            }
            else if (VrstaGoriva == "Dizel")
            {
                if (TipMotora == "4-Cilindrični/sa varijabilnom geom.")
                {
                    emisijeCO2 = 95;
                    gradskaVoznja = 4.2;
                    vangradskaVoznja = 3.4;
                    mesovitaVoznja = 3.7;
                }
                else if (TipMotora == "4-Cilindrični/dvostruki turbopunjač")
                {
                    emisijeCO2 = 0;
                    gradskaVoznja = 0.0;
                    vangradskaVoznja = 0.0;
                    mesovitaVoznja = 0.0;
                }
            }

            if (a == 1)
            {
                return emisijeCO2;
            }
            else if (a == 2)
            {
                return gradskaVoznja;
            }
            else if (a == 3)
            {
                return vangradskaVoznja;
            }
            else if (a == 4)
            {
                return mesovitaVoznja;
            }
            return 0.0;
        }
    }
}
