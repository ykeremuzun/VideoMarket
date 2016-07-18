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
    public partial class frmFilmSorgulama : Form
    {
        public frmFilmSorgulama()
        {
            InitializeComponent();
        }

        private void frmFilmSorgulama_Load(object sender, EventArgs e)
        {
            //this.Top = 0;
            //this.Left = 0;
            cFilm f = new cFilm();
            f.FilmleriGetir(lvFilmler);

            cFilmTuru ft = new cFilmTuru();
            ft.FilmTurleriGetir(cbFilmTurleri);
            //cbFilmTurleri.Items.Add("Tüm Türler");
            cbFilmTurleri.Items.Insert(0, "Tüm Türler");
            cbFilmTurleri.SelectedIndex = 0;
        }

        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            FilmleriGetir();
            //cFilm f = new cFilm();
            //f.FilmleriGetirByAdaGore(txtAdaGore.Text, lvFilmler);
        }
        private void cbFilmTurleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilmleriGetir();
            //cFilm f = new cFilm();
            //if (cbFilmTurleri.SelectedItem.ToString() == "Tüm Türler")
            //{
            //    f.FilmleriGetirByTureGore("", lvFilmler);
            //}
            //else
            //{
            //    f.FilmleriGetirByTureGore(cbFilmTurleri.SelectedItem.ToString(), lvFilmler);
            //}
        }
        private void txtYonetmeneGore_TextChanged(object sender, EventArgs e)
        {
            FilmleriGetir();
        }
        private void txtOyuncuyaGore_TextChanged(object sender, EventArgs e)
        {
            FilmleriGetir();
        }
        private void FilmleriGetir()
        {
            string Tur = "";
            if (cbFilmTurleri.SelectedItem.ToString() != "Tüm Türler")
            {
                Tur = cbFilmTurleri.SelectedItem.ToString();
            }
            cFilm f = new cFilm();
            f.FilmleriGetirByDetaySorgulama(txtAdaGore.Text, Tur, txtYonetmeneGore.Text, txtOyuncuyaGore.Text, lvFilmler);
        }

        private void lvFilmler_DoubleClick(object sender, EventArgs e)
        {
            cGenel.filmno = Convert.ToInt32(lvFilmler.SelectedItems[0].SubItems[0].Text);
            cGenel.film = lvFilmler.SelectedItems[0].SubItems[1].Text;
            cGenel.fiyat = Convert.ToDouble(lvFilmler.SelectedItems[0].SubItems[6].Text);
            cGenel.stok = Convert.ToInt32(lvFilmler.SelectedItems[0].SubItems[7].Text);
            this.Close();
        }
    }
}
