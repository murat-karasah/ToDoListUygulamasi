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
    public partial class Sistemgiris : Form
    {
        public Sistemgiris()
        {
            InitializeComponent();
        }

        private void txt_kullaniciAdi_Enter(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.Yellow;
        }

        private void txt_kullaniciAdi_Leave(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.White;
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_kullaniciAdi.Text) || !string.IsNullOrEmpty(txt_kullaniciSifre.Text) )
            {
                KullaniciServices kullaniciservice = new KullaniciServices();
                Kullanici kontrolkullanici = kullaniciservice.kullanicikontrol(txt_kullaniciAdi.Text, txt_kullaniciSifre.Text);
                if (kontrolkullanici!=null)
                {
                    Form anaform = Application.OpenForms["Form1"];
                    Panel solpanel =(Panel) anaform.Controls["panel1"];
                    GroupBox solgroup = (GroupBox)solpanel.Controls["groupBoxislemlistesi"];
                    foreach (Button item in solgroup.Controls)
                    {
                        if (item is Button)
                        {
                            ((Button)item).Enabled = true;
                        }
                    }
                    MessageBox.Show("Merhaba " +kontrolkullanici.kullaniciAdi,"Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lütfen giriş bilgilerinizi hatalı giriniz", "Hatalı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Lütfen giriş bilgilerinizi eksiksiz giriniz","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }


        }
    }
}
