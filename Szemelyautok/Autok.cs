using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szemelyautok
{
    class Autok
    {

        string nev;
        string tipus;
        double eve;
        double ara;

        public string Nev
        {
            get => nev;
            set
            {
                if (String.IsNullOrEmpty(value))
                {

                    throw new ArgumentException($"{value} nem lehet az autó neve!");

                }
                else
                {

                    nev = value;

                }
            }
        }
        public string Tipus
        {
            get => tipus;
            set
            {
                if (String.IsNullOrEmpty(value))
                {

                    throw new ArgumentException($"{value} nem lehet az autó típusa!");

                }
                else
                {

                    tipus = value;

                }
            }
        }
        public double Eve
        {
            get => eve;
            set
            {
                if (value < 0)
                {

                    throw new ArgumentException($"{value} nem lehet az autó éve!");

                }
                else
                {

                    eve = value;

                }
            }
        }
        public double Ara
        {
            get => ara;
            set
            {
                if (value < 0)
                {

                    throw new ArgumentException($"{value} nem lehet az autó ára!");

                }
                else
                {

                    ara = value;

                }
            }
        }




        public Autok(string nev, string tipus, double eve, double ara)
        {
            this.Nev = nev;
            this.Tipus = tipus;
            this.Eve = eve;
            this.Ara = ara;
        }
    }
}
