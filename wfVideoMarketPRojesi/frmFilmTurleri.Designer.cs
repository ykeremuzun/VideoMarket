﻿namespace wfVideoMarketPRojesi
{
    partial class frmFilmTurleri
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
            this.txtFilmTuru = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lvFilmTurleri = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTurNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Türü";
            // 
            // txtFilmTuru
            // 
            this.txtFilmTuru.Location = new System.Drawing.Point(189, 59);
            this.txtFilmTuru.Name = "txtFilmTuru";
            this.txtFilmTuru.Size = new System.Drawing.Size(157, 23);
            this.txtFilmTuru.TabIndex = 1;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(189, 106);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(157, 77);
            this.txtAciklama.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Açıklama";
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(90, 219);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(65, 29);
            this.btnYeni.TabIndex = 4;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Location = new System.Drawing.Point(161, 219);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(68, 29);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Enabled = false;
            this.btnDegistir.Location = new System.Drawing.Point(235, 219);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(68, 29);
            this.btnDegistir.TabIndex = 6;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(309, 219);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(68, 29);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lvFilmTurleri
            // 
            this.lvFilmTurleri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvFilmTurleri.FullRowSelect = true;
            this.lvFilmTurleri.GridLines = true;
            this.lvFilmTurleri.Location = new System.Drawing.Point(22, 292);
            this.lvFilmTurleri.Name = "lvFilmTurleri";
            this.lvFilmTurleri.Size = new System.Drawing.Size(420, 163);
            this.lvFilmTurleri.TabIndex = 8;
            this.lvFilmTurleri.UseCompatibleStateImageBehavior = false;
            this.lvFilmTurleri.View = System.Windows.Forms.View.Details;
            this.lvFilmTurleri.DoubleClick += new System.EventHandler(this.lvFilmTurleri_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tür No";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Film Türü";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Açıklama";
            this.columnHeader3.Width = 195;
            // 
            // txtTurNo
            // 
            this.txtTurNo.Location = new System.Drawing.Point(10, 12);
            this.txtTurNo.Name = "txtTurNo";
            this.txtTurNo.ReadOnly = true;
            this.txtTurNo.Size = new System.Drawing.Size(33, 23);
            this.txtTurNo.TabIndex = 9;
            // 
            // frmFilmTurleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(464, 501);
            this.Controls.Add(this.txtTurNo);
            this.Controls.Add(this.lvFilmTurleri);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilmTuru);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFilmTurleri";
            this.Text = "Film Türü Tanımlama";
            this.Load += new System.EventHandler(this.frmFilmTurleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilmTuru;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ListView lvFilmTurleri;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txtTurNo;
    }
}