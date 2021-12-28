using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListUygulaması.entities;

namespace ToDoListUygulaması.databas
{
   public static class sanaldatabase
    {
        public static List<Kullanici> kullaniciTablo;
        public static List<todo> todoTablo;

        static sanaldatabase()
        {
            kullaniciTablo = new List<Kullanici>();
            kullaniciTablo.Add(new Kullanici()
            {
                id = Guid.NewGuid(), kullaniciAdi = "test1", sifre = "1"
                });
            todoTablo = new List<todo>();
        }
}
}
