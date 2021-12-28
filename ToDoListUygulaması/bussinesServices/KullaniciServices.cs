using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListUygulaması.databas;
using ToDoListUygulaması.entities;

namespace ToDoListUygulaması.bussinesServices
{
   public class KullaniciServices
    {
        public Kullanici kullanicikontrol(string kullaniciAdi,string sifre)
        {
            return sanaldatabase.kullaniciTablo.Where(x => x.kullaniciAdi == kullaniciAdi && x.sifre == sifre).FirstOrDefault();

        }
    }
}
