using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Opdracht4
{
    internal class FouteRij<T>
    {
        internal List<T> queue { get; set; } = new List<T>();

        public T Huidig { get; set; }

        public bool IsLeeg()
        {
            return queue.Count == 0;
        }

        public int Count()
        {
            return queue.Count;
        }

        public T HuidigElement()
        {
            return Huidig;
        }

        public T Toevoegen(T iets)
        {
            queue.Add(iets);
            

            if (queue.Count() == 1)
            {
                Huidig = iets;
                return Huidig;
            }
            else
            {
                return default(T);
            }
        }

        
        public T Verwijderen()
        {
            queue.Remove(Huidig);
            if (queue.Count > 0)
            {
                Huidig = queue.First();
            }
            else
            {
                Huidig = default(T);
            }
            

            return Huidig;
        }

        public T Volgende()
        {
            if (queue.Count > 0)
            {
                int teller = queue.IndexOf(Huidig);
                if (teller == queue.Count() - 1)
                {
                    Huidig = queue[0];
                }
                else
                {
                    Huidig = queue[teller + 1];
                }
            }

            return Huidig;
        }

        public void Leegmaken()
        {
            queue.Clear();
            Huidig = default;
            
        }

        public T ZetAchteraan()
        {
            T output = Huidig;
            queue.Remove(Huidig);
            queue.Add(output);
            Huidig = queue[0];

            return Huidig;
        }


        public override string ToString()
        {
            string output = "";
            foreach (T iets in queue)
            {
                output += iets + ", ";
            }
            return output;
        }

        public Object Copy()
        {
            return (FouteRij<T>)this.MemberwiseClone();
        }

    }


}
