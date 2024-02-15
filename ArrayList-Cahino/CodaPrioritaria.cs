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
        public void EstraiPrimo(int id)
        {
            if(!IsEmpty())
            {
                int primo=
            }
        }
        //Verifica se è vuota
        public bool IsEmpty()
        {
            //True se è vuota
            return list.Count == 0;
        }
    }
}
