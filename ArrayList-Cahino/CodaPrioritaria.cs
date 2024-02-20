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
        public void Insert(int id)
        {
           //Trova l'indice in cui inserire l'elemento mantenendo l'ordinamento
           int i=list.BinarySearch(id);
            if (i < 0) i = ~i; //inverte tutti i bit dell'intero, restituisce complemento a 1 di i- se non trova nulla
            list.Insert(i, list); //inserisce nella posizione corretta
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
        public int EstraiUltimo(int id)
        {
            int ultimo = (int)list[]
        }
    }
}
