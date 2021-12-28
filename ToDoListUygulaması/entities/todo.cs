using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListUygulaması.entities
{
    public class todo
    {
        public Guid id { get; set; }
        public string baslik { get; set; }
        public string kisaaciklama { get; set; }
        public string aciklama { get; set; }
        public int onemderece { get; set; }
        public string durumAciklama { get; set; }
        public DateTime olusturmatarihi { get; set; }



    }
}
