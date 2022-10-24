using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4
{
    internal class TeDoen
    {
        private int Id { get; set; }
        private static int tel_id { get; set; }
        public DateTime? Tijdstip { get; set; }
        private string Titel { get; set; }
        private string[] Informatie { get; set; }
        public event EventHandler Meedelen;
        bool Dringend;


        public TeDoen(string titel, string[] informatie, DateTime tijdStip)
        {
            if (tijdStip > DateTime.Now)
            {
                this.Tijdstip = tijdStip;
            }
            else
            {
                this.Tijdstip = null;
            }

            this.Titel = titel;
            this.Informatie = informatie;
            tel_id++;
            this.Id = tel_id;
        }

        protected virtual void OnMeedelen(EventArgs e)
        {
            EventHandler handler = Meedelen;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public void MeeDelen(TextBox text, bool PopUp, bool BeepGeluid)
        {
            OnMeedelen(EventArgs.Empty);

            string Titel = this.Titel;
            string info = "";

            foreach (string el in Informatie)
            {
                info += el + "  ";
            }

            if (this.Tijdstip == null)
            {
                Dringend = true;
            }
            else if(this.Tijdstip > DateTime.Now)
            {
                Dringend = false;
            }


            if (PopUp == true)
            {
                if (BeepGeluid == true)
                {
                    System.Media.SystemSounds.Beep.Play();
                }
                System.Windows.Forms.MessageBox.Show("Titel: " + Titel + Environment.NewLine + "Informatie:" + info + Environment.NewLine + "Dringend:" + Dringend);

            }
            if (PopUp == false)
            {
                if (BeepGeluid == true)
                {
                    System.Media.SystemSounds.Beep.Play();
                }
                text.Text = "Titel: " + Titel + Environment.NewLine + "Informatie:" + info + Environment.NewLine + "Dringend:" + Dringend;
            }
        }

        public override string ToString()
        {
            return this.Titel.ToString();
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) { return false; }
            if (!(obj is TeDoen)) { return false; }
            return (this.Id == ((TeDoen)obj).Id);
        }
    }
}
