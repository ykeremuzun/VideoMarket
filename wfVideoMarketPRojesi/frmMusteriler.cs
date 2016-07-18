using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfVideoMarketPRojesi
{
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }

        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            cMusteri m = new cMusteri();
            m.MusterileriGetir(lvMusteriler);
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            Temizle();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text.Trim() != "" && txtSoyadi.Text.Trim() != "" && txtTelefon.Text.Trim() != "")
            {
                cMusteri m = new cMusteri();
                if (m.MusteriVarmi(txtAdi.Text, txtSoyadi.Text, txtTelefon.Text))
                {
                    MessageBox.Show("Girdiğiniz müşteri zaten kayıtlı!");
                    txtAdi.Focus();
                }
                else
                {
                    m.MusteriAd = txtAdi.Text;
                    m.MusteriSoyad = txtSoyadi.Text;
                    m.Telefon = txtTelefon.Text;
                    m.Adres = txtAdres.Text;
                    if (m.MusteriEkle(m))
                    {
                        MessageBox.Show("Müşteri Bilgileri eklendi.");
                        m.MusterileriGetir(lvMusteriler);
                        btnKaydet.Enabled = false;
                        Temizle();
                    }
                    else { MessageBox.Show("Müşteri Bilgileri kayıt edilemedi."); }
                }
            }
        }
        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text.Trim() != "" && txtSoyadi.Text.Trim() != "" && txtTelefon.Text.Trim() != "")
            {
                cMusteri m = new cMusteri();
                m.MusteriNo = Convert.ToInt32(txtMusteriNo.Text);
                m.MusteriAd = txtAdi.Text;
                m.MusteriSoyad = txtSoyadi.Text;
                m.Telefon = txtTelefon.Text;
                m.Adres = txtAdres.Text;
                if (m.MusteriGuncelle(m))
                {
                    MessageBox.Show("Müşteri Bilgileri güncellendi.");
                    m.MusterileriGetir(lvMusteriler);
                    btnDegistir.Enabled = false;
                    btnSil.Enabled = false;
                    Temizle();
                }
                else { MessageBox.Show("Müşteri Bilgileri kayıt edilemedi."); }
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cMusteri m = new cMusteri();
                bool Sonuc = m.MusteriSil(Convert.ToInt32(txtMusteriNo.Text));
                if (Sonuc)
                {
                    MessageBox.Show("Müşteri Bilgileri silindi.");
                    m.MusterileriGetir(lvMusteriler);
                    btnDegistir.Enabled = false;
                    btnSil.Enabled = false;
                    Temizle();
                }
            }
        }
        private void Temizle()
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
            txtAdi.Focus();
        }

        private void lvMusteriler_DoubleClick(object sender, EventArgs e)
        {
            txtMusteriNo.Text = lvMusteriler.SelectedItems[0].SubItems[0].Text;
            txtAdi.Text = lvMusteriler.SelectedItems[0].SubItems[1].Text;
            txtSoyadi.Text = lvMusteriler.SelectedItems[0].SubItems[2].Text;
            txtTelefon.Text = lvMusteriler.SelectedItems[0].SubItems[3].Text;
            txtAdres.Text = lvMusteriler.SelectedItems[0].SubItems[4].Text;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            txtAdi.Focus();
        }

        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            cMusteri m = new  cMusteri();
            m.MusterileriGetirByAdaGore(txtAdaGore.Text, lvMusteriler);
        }
    }
}
