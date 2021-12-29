
namespace ToDoListUygulaması
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxislemlistesi = new System.Windows.Forms.GroupBox();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.btn_kayit_liste = new System.Windows.Forms.Button();
            this.btn_yeni_kayit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_zaman = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupBoxislemlistesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxislemlistesi);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 537);
            this.panel1.TabIndex = 1;
            // 
            // groupBoxislemlistesi
            // 
            this.groupBoxislemlistesi.Controls.Add(this.btn_kapat);
            this.groupBoxislemlistesi.Controls.Add(this.btn_kayit_liste);
            this.groupBoxislemlistesi.Controls.Add(this.btn_yeni_kayit);
            this.groupBoxislemlistesi.Location = new System.Drawing.Point(12, 138);
            this.groupBoxislemlistesi.Name = "groupBoxislemlistesi";
            this.groupBoxislemlistesi.Size = new System.Drawing.Size(128, 353);
            this.groupBoxislemlistesi.TabIndex = 2;
            this.groupBoxislemlistesi.TabStop = false;
            this.groupBoxislemlistesi.Text = "İşlem Listesi";
            // 
            // btn_kapat
            // 
            this.btn_kapat.Location = new System.Drawing.Point(6, 77);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(116, 23);
            this.btn_kapat.TabIndex = 0;
            this.btn_kapat.Text = "Uygulama Kapat";
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // btn_kayit_liste
            // 
            this.btn_kayit_liste.Location = new System.Drawing.Point(6, 48);
            this.btn_kayit_liste.Name = "btn_kayit_liste";
            this.btn_kayit_liste.Size = new System.Drawing.Size(116, 23);
            this.btn_kayit_liste.TabIndex = 0;
            this.btn_kayit_liste.Text = "Kayıt Liste";
            this.btn_kayit_liste.UseVisualStyleBackColor = true;
            // 
            // btn_yeni_kayit
            // 
            this.btn_yeni_kayit.Location = new System.Drawing.Point(6, 19);
            this.btn_yeni_kayit.Name = "btn_yeni_kayit";
            this.btn_yeni_kayit.Size = new System.Drawing.Size(116, 23);
            this.btn_yeni_kayit.TabIndex = 0;
            this.btn_yeni_kayit.Text = "Yeni Kayıt";
            this.btn_yeni_kayit.UseVisualStyleBackColor = true;
            this.btn_yeni_kayit.Click += new System.EventHandler(this.btn_yeni_kayit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_zaman);
            this.panel2.Location = new System.Drawing.Point(680, 494);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 43);
            this.panel2.TabIndex = 2;
            // 
            // label_zaman
            // 
            this.label_zaman.AutoSize = true;
            this.label_zaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_zaman.Location = new System.Drawing.Point(17, 9);
            this.label_zaman.Name = "label_zaman";
            this.label_zaman.Size = new System.Drawing.Size(180, 25);
            this.label_zaman.TabIndex = 0;
            this.label_zaman.Text = "28/12/2021 11:37";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 537);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Todo-Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBoxislemlistesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxislemlistesi;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Button btn_kayit_liste;
        private System.Windows.Forms.Button btn_yeni_kayit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_zaman;
        private System.Windows.Forms.Timer timer1;
    }
}

