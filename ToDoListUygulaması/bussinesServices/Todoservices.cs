using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListUygulaması.databas;
using ToDoListUygulaması.entities;

namespace ToDoListUygulaması.bussinesServices
{
   public class Todoservices
    {
        public int kayitKontrol()
        {
            return sanaldatabase.todoTablo.Count;
        }

        public List<todo> kayitliste()
        {
            return sanaldatabase.todoTablo;
        }


        public int kayitYeni(todo data)
        {
            try {
                sanaldatabase.todoTablo.Add(data);
                return 1;
            }
            catch(Exception)
            {
                return 0;
            }
        }

    }
}
