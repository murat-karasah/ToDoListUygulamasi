
namespace ToDoListUygulaması
{
    partial class YeniKayit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_baslik = new System.Windows.Forms.TextBox();
            this.txt_kisa_aciklama = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_onem_derecesi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_durum = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlık";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kısa Açıklama";
            // 
            // txt_baslik
            // 
            this.txt_baslik.Location = new System.Drawing.Point(147, 10);
            this.txt_baslik.Name = "txt_baslik";
            this.txt_baslik.Size = new System.Drawing.Size(185, 20);
            this.txt_baslik.TabIndex = 1;
            // 
            // txt_kisa_aciklama
            // 
            this.txt_kisa_aciklama.Location = new System.Drawing.Point(147, 48);
            this.txt_kisa_aciklama.Multiline = true;
            this.txt_kisa_aciklama.Name = "txt_kisa_aciklama";
            this.txt_kisa_aciklama.Size = new System.Drawing.Size(185, 78);
            this.txt_kisa_aciklama.TabIndex = 1;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(172, 422);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 2;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Açıklama";
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(147, 148);
            this.txt_aciklama.Multiline = true;
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(185, 78);
            this.txt_aciklama.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Önem Derecesi";
            // 
            // txt_onem_derecesi
            // 
            this.txt_onem_derecesi.Location = new System.Drawing.Point(147, 287);
            this.txt_onem_derecesi.Name = "txt_onem_derecesi";
            this.txt_onem_derecesi.Size = new System.Drawing.Size(185, 20);
            this.txt_onem_derecesi.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Durum";
            // 
            // cmb_durum
            // 
            this.cmb_durum.FormattingEnabled = true;
            this.cmb_durum.Items.AddRange(new object[] {
            "Beklemede",
            "Tamamlandı",
            "Tamamlanmadı",
            "İptal Edildi",
            "Ertelendi"});
            this.cmb_durum.Location = new System.Drawing.Point(107, 346);
            this.cmb_durum.Name = "cmb_durum";
            this.cmb_durum.Size = new System.Drawing.Size(121, 21);
            this.cmb_durum.TabIndex = 3;
            // 
            // YeniKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 487);
            this.Controls.Add(this.cmb_durum);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.txt_aciklama);
            this.Controls.Add(this.txt_kisa_aciklama);
            this.Controls.Add(this.txt_onem_derecesi);
            this.Controls.Add(this.txt_baslik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "YeniKayit";
            this.Text = "todo YeniKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_baslik;
        private System.Windows.Forms.TextBox txt_kisa_aciklama;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_onem_derecesi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_durum;
    }
}