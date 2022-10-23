using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4
{
    internal class FouteRij<T>
    {
        Queue<T> rij_original = new Queue<T>();
        Queue<T> rij_copy = new Queue<T>();

        private T Huidig;

        public T Toevoegen(T iets)
        {
            if (rij_original.Count == 0)
            {
                rij_original.Enqueue(iets);
                Huidig = iets;
            }
            else
            {
                rij_original.Enqueue(iets);
            }
            return Huidig;
        }

        public T Verwijderen()
        {
            rij_original.Dequeue();
            Huidig = rij_original.Peek();
            return Huidig;
        }

        public T Volgende()
        {
            Huidig = rij_original.Peek();

            return Huidig;
        }    
        
        public void Leegmaken()
        {
            rij_original.Clear();
            Huidig = default(T);
        }

        public T ZetAchteraan()
        {
            T el = rij_original.Peek();
            rij_original.Dequeue();
            Huidig = rij_original.Peek();
            rij_original.Enqueue(el);

            return Huidig;
        }

        public override string ToString()
        {
            string showRij = "";

            foreach(T iets in rij_original)
            {
                showRij += iets.ToString() + "\n";
            }

            return showRij;
        }

        public Queue<T> Copy()
        {
            rij_copy = rij_original;

            return rij_copy;
        }

    }


}
