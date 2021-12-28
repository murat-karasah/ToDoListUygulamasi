﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoListUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 15000;
            timer1.Tick += Tm_zamanla_Tic;
            timer1.Start();
            butonAcKapa(false);
            Sistemgiris kullanicikontrol = new Sistemgiris();
            kullanicikontrol.MdiParent = this;
            kullanicikontrol.StartPosition = FormStartPosition.CenterScreen;
            kullanicikontrol.Show();
            
        }

        private void butonAcKapa(bool v)
        {
            foreach (Control item in groupBoxislemlistesi.Controls)
            {
                if (item is Button)
                {
                    ((Button)item).Enabled = v;
                }
            }
        }

        private void Tm_zamanla_Tic(object sender, EventArgs e)
        {
            label_zaman.Text = DateTime.Now.ToString("dd.MM.yyyyy HH:mm");
        }
    }
}
