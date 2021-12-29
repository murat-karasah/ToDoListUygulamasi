
namespace ToDoListUygulaması
{
    partial class Kayitliste
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
            this.groupBoxİslemListe = new System.Windows.Forms.GroupBox();
            this.groupBoxListe = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_tum_liste = new System.Windows.Forms.Button();
            this.btn_tamamlandi = new System.Windows.Forms.Button();
            this.btn_tamamlanamadi = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.groupBoxİslemListe.SuspendLayout();
            this.groupBoxListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxİslemListe
            // 
            this.groupBoxİslemListe.Controls.Add(this.btn_iptal);
            this.groupBoxİslemListe.Controls.Add(this.btn_tamamlanamadi);
            this.groupBoxİslemListe.Controls.Add(this.btn_tamamlandi);
            this.groupBoxİslemListe.Controls.Add(this.btn_tum_liste);
            this.groupBoxİslemListe.Location = new System.Drawing.Point(12, 12);
            this.groupBoxİslemListe.Name = "groupBoxİslemListe";
            this.groupBoxİslemListe.Size = new System.Drawing.Size(141, 338);
            this.groupBoxİslemListe.TabIndex = 0;
            this.groupBoxİslemListe.TabStop = false;
            this.groupBoxİslemListe.Text = "İşlem Listesi";
            // 
            // groupBoxListe
            // 
            this.groupBoxListe.Controls.Add(this.dataGridView1);
            this.groupBoxListe.Location = new System.Drawing.Point(159, 12);
            this.groupBoxListe.Name = "groupBoxListe";
            this.groupBoxListe.Size = new System.Drawing.Size(347, 338);
            this.groupBoxListe.TabIndex = 0;
            this.groupBoxListe.TabStop = false;
            this.groupBoxListe.Text = "Liste";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(341, 319);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_tum_liste
            // 
            this.btn_tum_liste.Location = new System.Drawing.Point(7, 19);
            this.btn_tum_liste.Name = "btn_tum_liste";
            this.btn_tum_liste.Size = new System.Drawing.Size(128, 23);
            this.btn_tum_liste.TabIndex = 0;
            this.btn_tum_liste.Text = "Tüm Liste";
            this.btn_tum_liste.UseVisualStyleBackColor = true;
            this.btn_tum_liste.Click += new System.EventHandler(this.btn_tum_liste_Click);
            // 
            // btn_tamamlandi
            // 
            this.btn_tamamlandi.Location = new System.Drawing.Point(7, 48);
            this.btn_tamamlandi.Name = "btn_tamamlandi";
            this.btn_tamamlandi.Size = new System.Drawing.Size(128, 23);
            this.btn_tamamlandi.TabIndex = 0;
            this.btn_tamamlandi.Text = "Tamamlandı";
            this.btn_tamamlandi.UseVisualStyleBackColor = true;
            this.btn_tamamlandi.Click += new System.EventHandler(this.btn_tamamlandi_Click);
            // 
            // btn_tamamlanamadi
            // 
            this.btn_tamamlanamadi.Location = new System.Drawing.Point(7, 77);
            this.btn_tamamlanamadi.Name = "btn_tamamlanamadi";
            this.btn_tamamlanamadi.Size = new System.Drawing.Size(128, 23);
            this.btn_tamamlanamadi.TabIndex = 0;
            this.btn_tamamlanamadi.Text = "Tamamlanamadı";
            this.btn_tamamlanamadi.UseVisualStyleBackColor = true;
            this.btn_tamamlanamadi.Click += new System.EventHandler(this.btn_tamamlanamadi_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.Location = new System.Drawing.Point(7, 106);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(128, 23);
            this.btn_iptal.TabIndex = 0;
            this.btn_iptal.Text = "İptal Edildi";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // Kayitliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 362);
            this.Controls.Add(this.groupBoxListe);
            this.Controls.Add(this.groupBoxİslemListe);
            this.Name = "Kayitliste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayitliste";
            this.Load += new System.EventHandler(this.Kayitliste_Load);
            this.groupBoxİslemListe.ResumeLayout(false);
            this.groupBoxListe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxİslemListe;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Button btn_tamamlanamadi;
        private System.Windows.Forms.Button btn_tamamlandi;
        private System.Windows.Forms.Button btn_tum_liste;
        private System.Windows.Forms.GroupBox groupBoxListe;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}