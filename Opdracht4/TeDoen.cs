using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4
{
    internal class TeDoen
    {
        private static int Id;
        private DateTime? Tijdstip;
        private string Titel;
        private string[] Informatie;
        

        public TeDoen(string titel, string[] Informatie, DateTime tijdStip)
        {
            Id++;

            if(Tijdstip >= DateTime.Now)
            {
                Tijdstip = tijdStip;
            }
            else
            {
                Tijdstip = null;
            }

            this.Titel = titel;
            this.Informatie = Informatie;


        }

        public override string ToString()
        {
            string ToonAlles = "";

            foreach (string el in Informatie)
            {
                ToonAlles += "- " +  el.ToString() + "\n";

            }

            if (Tijdstip == null)
            {
                return "Id :" + Id + "    Titel : " + Titel + "\n -----------------------" + "\n Informatie : " + ToonAlles;
            }
            else
            {
                return "Id :" + Id + "    Titel : " + Titel + " \n Tijdstip: " + Tijdstip + "\n -----------------------" +"\n Informatie : " + ToonAlles;
            }
        }
    }
}
