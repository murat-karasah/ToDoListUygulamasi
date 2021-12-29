using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoListUygulaması.bussinesServices;
using ToDoListUygulaması.entities;

namespace ToDoListUygulaması
{
    public partial class Kayitliste : Form
    {
        Todoservices todoservices;
        public Kayitliste()
        {
            InitializeComponent();
            todoservices = new Todoservices();

        }

        private void Kayitliste_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TumListe();
            dataGridView1.Columns["id"].Visible = false;
        }

        private List<todo> TumListe()
        {
            return todoservices.kayitliste();
        }

        private void btn_tum_liste_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TumListe();
            dataGridView1.Columns["id"].Visible = false;
        }

        private void btn_tamamlandi_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TumListe().Where(x => x.durumAciklama == "Tamamlandı").ToList();
            dataGridView1.Columns["id"].Visible = false;

        }

        private void btn_tamamlanamadi_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TumListe().Where(x => x.durumAciklama == "Tamamlanmadı").ToList();
            dataGridView1.Columns["id"].Visible = false;
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TumListe().Where(x => x.durumAciklama == "İptal Edildi").ToList();
            dataGridView1.Columns["id"].Visible = false;
        }
    }
}
