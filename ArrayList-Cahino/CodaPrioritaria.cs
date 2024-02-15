using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Cahino
{
    class CodaPrioritaria
    {
        private ArrayList list;
        //Costruttore
        public CodaPrioritaria()
        {
            list= new ArrayList();
        }
        public void Add(int id)
        {
            //Aggiunge l'elemento e riordina
            list.Add(id);
            list.Sort();
        }
        //Cerca elemento nella coda prioritaria
        public bool Search(int id)
        {
            return list.Contains(id);
        }
        public int EstraiPrimo(int id)
        {
            if(!IsEmpty())
            {
                //Ottiene primo elemento
                int primo = (int)list[0];
                //Lo rimuove dalla coda
                list.RemoveAt(0);
                return primo;
            }
            else
                throw new InvalidCastException("La Coda Prioritaria è vuota");
        }
        //Verifica se è vuota
        public bool IsEmpty()
        {
            //True se è vuota
            return list.Count == 0;
        }
    }
}
