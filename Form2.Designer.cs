namespace emlak
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.satınal = new System.Windows.Forms.Button();
            this.listele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtyemekfiyati = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtkonum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtyasi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtm2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsatılıkfiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtkıralıkfiyat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtoda = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtkati = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtanlasıalnmısteri = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtsatılıkdurum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtkiralıkdurumu = new System.Windows.Forms.TextBox();
            this.güncelle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 115;
            this.label2.Text = "konut ID";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(34, 44);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(75, 20);
            this.txtid.TabIndex = 114;
            // 
            // satınal
            // 
            this.satınal.Location = new System.Drawing.Point(16, 218);
            this.satınal.Name = "satınal";
            this.satınal.Size = new System.Drawing.Size(439, 40);
            this.satınal.TabIndex = 113;
            this.satınal.Text = "ekle";
            this.satınal.UseVisualStyleBackColor = true;
            this.satınal.Click += new System.EventHandler(this.satınal_Click);
            // 
            // listele
            // 
            this.listele.Location = new System.Drawing.Point(16, 156);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(439, 42);
            this.listele.TabIndex = 112;
            this.listele.Text = "Listele";
            this.listele.UseVisualStyleBackColor = true;
            this.listele.Click += new System.EventHandler(this.listele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(15, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(905, 195);
            this.dataGridView1.TabIndex = 111;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtyemekfiyati
            // 
            this.txtyemekfiyati.AutoSize = true;
            this.txtyemekfiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtyemekfiyati.Location = new System.Drawing.Point(23, 89);
            this.txtyemekfiyati.Name = "txtyemekfiyati";
            this.txtyemekfiyati.Size = new System.Drawing.Size(0, 20);
            this.txtyemekfiyati.TabIndex = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 117;
            this.label1.Text = "konut Konumu";
            // 
            // txtkonum
            // 
            this.txtkonum.Location = new System.Drawing.Point(137, 44);
            this.txtkonum.Name = "txtkonum";
            this.txtkonum.Size = new System.Drawing.Size(108, 20);
            this.txtkonum.TabIndex = 116;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(366, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 121;
            this.label3.Text = "konut Yasi";
            // 
            // txtyasi
            // 
            this.txtyasi.Location = new System.Drawing.Point(370, 44);
            this.txtyasi.Name = "txtyasi";
            this.txtyasi.Size = new System.Drawing.Size(75, 20);
            this.txtyasi.TabIndex = 120;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(267, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 119;
            this.label4.Text = "konut M2";
            // 
            // txtm2
            // 
            this.txtm2.Location = new System.Drawing.Point(271, 44);
            this.txtm2.Name = "txtm2";
            this.txtm2.Size = new System.Drawing.Size(75, 20);
            this.txtm2.TabIndex = 118;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(804, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 129;
            this.label5.Text = "satilik Fiyati";
            // 
            // txtsatılıkfiyat
            // 
            this.txtsatılıkfiyat.Location = new System.Drawing.Point(808, 44);
            this.txtsatılıkfiyat.Name = "txtsatılıkfiyat";
            this.txtsatılıkfiyat.Size = new System.Drawing.Size(85, 20);
            this.txtsatılıkfiyat.TabIndex = 128;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(692, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 127;
            this.label6.Text = "kiralik Fiyati";
            // 
            // txtkıralıkfiyat
            // 
            this.txtkıralıkfiyat.Location = new System.Drawing.Point(696, 44);
            this.txtkıralıkfiyat.Name = "txtkıralıkfiyat";
            this.txtkıralıkfiyat.Size = new System.Drawing.Size(85, 20);
            this.txtkıralıkfiyat.TabIndex = 126;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(590, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 125;
            this.label7.Text = "konut Oda";
            // 
            // txtoda
            // 
            this.txtoda.Location = new System.Drawing.Point(592, 44);
            this.txtoda.Name = "txtoda";
            this.txtoda.Size = new System.Drawing.Size(75, 20);
            this.txtoda.TabIndex = 124;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(478, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 123;
            this.label8.Text = "konut Katı";
            // 
            // txtkati
            // 
            this.txtkati.Location = new System.Drawing.Point(477, 44);
            this.txtkati.Name = "txtkati";
            this.txtkati.Size = new System.Drawing.Size(81, 20);
            this.txtkati.TabIndex = 122;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(540, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 20);
            this.label9.TabIndex = 135;
            this.label9.Text = "anlasilan Musteri";
            // 
            // txtanlasıalnmısteri
            // 
            this.txtanlasıalnmısteri.Location = new System.Drawing.Point(544, 111);
            this.txtanlasıalnmısteri.Name = "txtanlasıalnmısteri";
            this.txtanlasıalnmısteri.Size = new System.Drawing.Size(116, 20);
            this.txtanlasıalnmısteri.TabIndex = 134;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(409, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 20);
            this.label10.TabIndex = 133;
            this.label10.Text = "satilik Durumu";
            // 
            // txtsatılıkdurum
            // 
            this.txtsatılıkdurum.Location = new System.Drawing.Point(426, 111);
            this.txtsatılıkdurum.Name = "txtsatılıkdurum";
            this.txtsatılıkdurum.Size = new System.Drawing.Size(75, 20);
            this.txtsatılıkdurum.TabIndex = 132;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(284, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 20);
            this.label11.TabIndex = 131;
            this.label11.Text = "kiralik Durumu";
            // 
            // txtkiralıkdurumu
            // 
            this.txtkiralıkdurumu.Location = new System.Drawing.Point(300, 111);
            this.txtkiralıkdurumu.Name = "txtkiralıkdurumu";
            this.txtkiralıkdurumu.Size = new System.Drawing.Size(75, 20);
            this.txtkiralıkdurumu.TabIndex = 130;
            // 
            // güncelle
            // 
            this.güncelle.Location = new System.Drawing.Point(477, 218);
            this.güncelle.Name = "güncelle";
            this.güncelle.Size = new System.Drawing.Size(443, 40);
            this.güncelle.TabIndex = 137;
            this.güncelle.Text = "Güncelle";
            this.güncelle.UseVisualStyleBackColor = true;
            this.güncelle.Click += new System.EventHandler(this.güncelle_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(477, 156);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(443, 42);
            this.sil.TabIndex = 136;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 482);
            this.Controls.Add(this.güncelle);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtanlasıalnmısteri);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtsatılıkdurum);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtkiralıkdurumu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsatılıkfiyat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtkıralıkfiyat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtoda);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtkati);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtyasi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtm2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtkonum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.satınal);
            this.Controls.Add(this.listele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtyemekfiyati);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button satınal;
        private System.Windows.Forms.Button listele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label txtyemekfiyati;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtkonum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtyasi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtm2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsatılıkfiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtkıralıkfiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtoda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtkati;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtanlasıalnmısteri;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtsatılıkdurum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtkiralıkdurumu;
        private System.Windows.Forms.Button güncelle;
        private System.Windows.Forms.Button sil;
    }
}