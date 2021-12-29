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

namespace ToDoListUygulaması
{
    public partial class YeniKayit : Form
    {
        public YeniKayit()
        {
            InitializeComponent();
        }

        private void txt_baslik_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Yellow;

        }

        private void txt_baslik_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            Todoservices todoservices = new Todoservices();
            int sonuc = todoservices.kayitYeni(new entities.todo()
            {
                id = Guid.NewGuid(),
                baslik = txt_baslik.Text,
                kisaaciklama = txt_kisa_aciklama.Text,
                aciklama = txt_aciklama.Text,
                durumAciklama = cmb_durum.SelectedItem.ToString(),
                onemderece = int.Parse(txt_onem_derecesi.Text),
                olusturmatarihi = DateTime.Now
            });
            if (sonuc>0)
            {
                MessageBox.Show("Kayıt ekleme işlemi başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult result = MessageBox.Show("Yeni kayıt ekleme işlemine devam etmek ister misiniz?","Soru",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (result==DialogResult.Yes)
                {
                    foreach (Control item in this.Controls)
                    {
                        if (item is TextBox)
                        {
                            ((TextBox)item).Clear();
                        }

                        if (item is ComboBox)
                        {
                            ((ComboBox)item).SelectedIndex = -1;
                        }

                    }

                }
                else
                {
                    Form Kayitliste = Application.OpenForms["Kayitliste"];
                    Kayitliste = new Kayitliste();
                    Kayitliste.MdiParent= Application.OpenForms["Form1"];
                    Kayitliste.Show();


                }

            }
            else
            {
                MessageBox.Show("Kayıt ekleme işleminde hata", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
