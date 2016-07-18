using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfVideoMarketPRojesi
{
    public partial class frmSatisSorgulama : Form
    {
        public frmSatisSorgulama()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        SqlConnection conn = new SqlConnection(cGenel.connStr);

        private void btnGetir_Click(object sender, EventArgs e)
        {
            cFilmSatis fs = new cFilmSatis();
            dt = fs.SatislariGetirByTarihlerArasi(dtpTarih1.Value, dtpTarih2.Value);
            dgvSatislar.DataSource = dt;
            dgvSatislar.Columns[0].Visible = false;
            dgvSatislar.Columns["BirimFiyat"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvSatislar.Columns["Tutar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvSatislar.Columns["Adet"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSatislar.Columns["Adet"].Width = 70;
            int TAdet = 0;
            double TTutar = 0;
            //foreach (DataRow dr in dt.Rows)
            //{
            //    TAdet += Convert.ToInt32(dr["Adet"]);
            //    TTutar += Convert.ToDouble(dr["Tutar"]);
            //}
            for (int i = 0; i < dgvSatislar.Rows.Count; i++)
            {
                TAdet += Convert.ToInt32(dgvSatislar.Rows[i].Cells["Adet"].Value);
                TTutar += Convert.ToInt32(dgvSatislar.Rows[i].Cells["Tutar"].Value);
            }
            txtToplamAdet.Text = TAdet.ToString();
            txtToplamTutar.Text = TTutar.ToString();

            this.reportViewer1.Visible = false;
        }

        private void frmSatisSorgulama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'VideoMarketDataSet.vw_DetayliSatis' table. You can move, or remove it, as needed.

        }

        private void btnYazici_Click(object sender, EventArgs e)
        {
            this.VideoMarketDataSet.vw_DetayliSatis.Clear();
            SqlDataAdapter da = new SqlDataAdapter("Select Convert(Varchar(20), Tarih, 104) as IslemTarihi, MusteriAd + ' ' + MusteriSoyad as Musteri, FilmAd, BirimFiyat, Adet, BirimFiyat * Adet as Tutar from FilmSatis fs inner join Musteriler m on fs.MusteriNo = m.MusteriNo inner join Filmler f on fs.FilmNo = f.FilmNo where fs.Silindi=0 and Convert(Date, Tarih, 104) Between Convert(Date, @Tarih1, 104) and Convert(Date, @Tarih2, 104) order by SatisNo desc", conn);
            da.SelectCommand.Parameters.Add("@Tarih1", SqlDbType.DateTime).Value = dtpTarih1.Value;
            da.SelectCommand.Parameters.Add("@Tarih2", SqlDbType.DateTime).Value = dtpTarih2.Value;
            try
            {
                da.Fill(this.VideoMarketDataSet.vw_DetayliSatis);
                this.reportViewer1.Visible = true;
                this.reportViewer1.Top = 90;
                this.reportViewer1.Left = 30;
                this.reportViewer1.Height = 400;
                this.reportViewer1.RefreshReport();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }

            //this.vw_DetayliSatisTableAdapter.Fill(this.VideoMarketDataSet.vw_DetayliSatis);

        }
    }
}
