﻿namespace wfVideoMarketPRojesi
{
    partial class frmSatisSorgulama
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dtpTarih1 = new System.Windows.Forms.DateTimePicker();
            this.dtpTarih2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSatislar = new System.Windows.Forms.DataGridView();
            this.btnGetir = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.txtToplamAdet = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnYazici = new System.Windows.Forms.Button();
            this.VideoMarketDataSet = new wfVideoMarketPRojesi.VideoMarketDataSet();
            this.vw_DetayliSatisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_DetayliSatisTableAdapter = new wfVideoMarketPRojesi.VideoMarketDataSetTableAdapters.vw_DetayliSatisTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatislar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoMarketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_DetayliSatisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpTarih1
            // 
            this.dtpTarih1.Location = new System.Drawing.Point(153, 35);
            this.dtpTarih1.Name = "dtpTarih1";
            this.dtpTarih1.Size = new System.Drawing.Size(142, 20);
            this.dtpTarih1.TabIndex = 0;
            // 
            // dtpTarih2
            // 
            this.dtpTarih2.Location = new System.Drawing.Point(362, 35);
            this.dtpTarih2.Name = "dtpTarih2";
            this.dtpTarih2.Size = new System.Drawing.Size(142, 20);
            this.dtpTarih2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "İlk Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Son Tarih";
            // 
            // dgvSatislar
            // 
            this.dgvSatislar.AllowUserToAddRows = false;
            this.dgvSatislar.AllowUserToDeleteRows = false;
            this.dgvSatislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatislar.Location = new System.Drawing.Point(25, 90);
            this.dgvSatislar.Name = "dgvSatislar";
            this.dgvSatislar.ReadOnly = true;
            this.dgvSatislar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSatislar.Size = new System.Drawing.Size(647, 180);
            this.dgvSatislar.TabIndex = 4;
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(249, 61);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(165, 23);
            this.btnGetir.TabIndex = 5;
            this.btnGetir.Text = "Satışları Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 276);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 69;
            this.label8.Text = "Toplam";
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(565, 276);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.ReadOnly = true;
            this.txtToplamTutar.Size = new System.Drawing.Size(67, 20);
            this.txtToplamTutar.TabIndex = 68;
            this.txtToplamTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtToplamAdet
            // 
            this.txtToplamAdet.Location = new System.Drawing.Point(473, 276);
            this.txtToplamAdet.Name = "txtToplamAdet";
            this.txtToplamAdet.ReadOnly = true;
            this.txtToplamAdet.Size = new System.Drawing.Size(67, 20);
            this.txtToplamAdet.TabIndex = 67;
            this.txtToplamAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.vw_DetayliSatisBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "wfVideoMarketPRojesi.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(25, 336);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(647, 142);
            this.reportViewer1.TabIndex = 70;
            this.reportViewer1.Visible = false;
            // 
            // btnYazici
            // 
            this.btnYazici.Location = new System.Drawing.Point(25, 286);
            this.btnYazici.Name = "btnYazici";
            this.btnYazici.Size = new System.Drawing.Size(73, 44);
            this.btnYazici.TabIndex = 71;
            this.btnYazici.Text = "Yazıcıya Gönder";
            this.btnYazici.UseVisualStyleBackColor = true;
            this.btnYazici.Click += new System.EventHandler(this.btnYazici_Click);
            // 
            // VideoMarketDataSet
            // 
            this.VideoMarketDataSet.DataSetName = "VideoMarketDataSet";
            this.VideoMarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_DetayliSatisBindingSource
            // 
            this.vw_DetayliSatisBindingSource.DataMember = "vw_DetayliSatis";
            this.vw_DetayliSatisBindingSource.DataSource = this.VideoMarketDataSet;
            // 
            // vw_DetayliSatisTableAdapter
            // 
            this.vw_DetayliSatisTableAdapter.ClearBeforeFill = true;
            // 
            // frmSatisSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(698, 488);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.txtToplamAdet);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.dgvSatislar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpTarih2);
            this.Controls.Add(this.dtpTarih1);
            this.Controls.Add(this.btnYazici);
            this.Name = "frmSatisSorgulama";
            this.Text = "Detaylı Satış Sorgulama";
            this.Load += new System.EventHandler(this.frmSatisSorgulama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatislar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoMarketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_DetayliSatisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpTarih1;
        private System.Windows.Forms.DateTimePicker dtpTarih2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSatislar;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.TextBox txtToplamAdet;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnYazici;
        private System.Windows.Forms.BindingSource vw_DetayliSatisBindingSource;
        private VideoMarketDataSet VideoMarketDataSet;
        private VideoMarketDataSetTableAdapters.vw_DetayliSatisTableAdapter vw_DetayliSatisTableAdapter;
    }
}