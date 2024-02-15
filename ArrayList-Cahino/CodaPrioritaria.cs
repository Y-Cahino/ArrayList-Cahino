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
        public CodaPrioritaria()
        {
            list= new ArrayList();
        }
        public void Add(int id)
        {
            list.Add(id);
            list.Sort();
        }
        public void Search(int id)
        {
            return list.Contains(id);
        }
    }
}
