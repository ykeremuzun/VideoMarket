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
    public partial class frmFilmTurleri : Form
    {
        public frmFilmTurleri()
        {
            InitializeComponent();
        }

        private void frmFilmTurleri_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            cFilmTuru ft = new cFilmTuru();
            ft.FilmTurleriGetir(lvFilmTurleri);
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            Temizle();
        }
        private void Temizle()
        {
            txtFilmTuru.Clear();
            txtAciklama.Clear();
            txtTurNo.Clear();
            txtFilmTuru.Focus();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtFilmTuru.Text.Trim() != "")
            {
                cFilmTuru ft = new cFilmTuru();
                bool Sonuc = ft.FilmTuruVarmi(txtFilmTuru.Text);
                if (Sonuc)
                {
                    MessageBox.Show("Önceden Kayıtlı!");
                    txtFilmTuru.Focus();
                }
                else
                {
                    //Sonuc = ft.FilmTuruEkle(txtFilmTuru.Text, txtAciklama.Text);
                    ft.TurAd = txtFilmTuru.Text;
                    ft.Aciklama = txtAciklama.Text;
                    Sonuc = ft.FilmTuruEkle(ft);
                    if (Sonuc)
                    {
                        MessageBox.Show("Film Türü eklendi.");
                        btnKaydet.Enabled = false;
                        ft.FilmTurleriGetir(lvFilmTurleri);
                        Temizle();
                    }
                }
            }
        }
        private void lvFilmTurleri_DoubleClick(object sender, EventArgs e)
        {
            txtTurNo.Text = lvFilmTurleri.SelectedItems[0].SubItems[0].Text;
            txtFilmTuru.Text = lvFilmTurleri.SelectedItems[0].SubItems[1].Text;
            txtAciklama.Text = lvFilmTurleri.SelectedItems[0].SubItems[2].Text;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            txtFilmTuru.Focus();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtFilmTuru.Text.Trim() != "")
            {
                cFilmTuru ft = new cFilmTuru();
                bool Sonuc = ft.FilmTuruVarmi(txtFilmTuru.Text, Convert.ToInt32(txtTurNo.Text));
                if (Sonuc)
                {
                    MessageBox.Show("Önceden Kayıtlı!");
                    txtFilmTuru.Focus();
                }
                else
                {
                    ft.FilmTurNo = Convert.ToInt32(txtTurNo.Text);
                    ft.TurAd = txtFilmTuru.Text;
                    ft.Aciklama = txtAciklama.Text;
                    Sonuc = ft.FilmTuruGuncelle(ft);
                    if (Sonuc)
                    {
                        MessageBox.Show("Film Türü değiştirildi.");
                        btnDegistir.Enabled = false;
                        btnSil.Enabled = false;
                        ft.FilmTurleriGetir(lvFilmTurleri);
                        Temizle();
                    }
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cFilmTuru ft = new cFilmTuru();
                bool Sonuc = ft.FilmTuruSil(Convert.ToInt32(txtTurNo.Text));
                if (Sonuc)
                {
                    MessageBox.Show("Film Türü silindi.");
                    ft.FilmTurleriGetir(lvFilmTurleri);
                    btnDegistir.Enabled = false;
                    btnSil.Enabled = false;
                    Temizle();
                }
            }
        }
    }
}
