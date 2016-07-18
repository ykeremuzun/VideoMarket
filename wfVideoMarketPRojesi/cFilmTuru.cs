using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfVideoMarketPRojesi
{
    class cFilmTuru
    {
        private int _filmTurNo;
        private string _turAd;
        private string _aciklama;

        #region Properties
        public int FilmTurNo
        {
            get { return _filmTurNo; }
            set { _filmTurNo = value; }
        }

        public string TurAd
        {
            get { return _turAd; }
            set { _turAd = value; }
        }

        public string Aciklama
        {
            get { return _aciklama; }
            set { _aciklama = value; }
        } 
        #endregion

        SqlConnection conn = new SqlConnection(cGenel.connStr);

        public void FilmTurleriGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select * from FilmTurleri where Silindi=0", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                int i = 0;
                while (dr.Read())
                {
                    liste.Items.Add(dr[0].ToString());
                    liste.Items[i].SubItems.Add(dr[1].ToString());
                    liste.Items[i].SubItems.Add(dr[2].ToString());
                    i++;
                }
                dr.Close();
            }
            conn.Close();
        }
        public bool FilmTuruVarmi(string FilmTuru)
        {
            bool Varmi = false;
            SqlCommand comm = new SqlCommand("Select TurAd from FilmTurleri where Silindi=0 and TurAd=@TurAd", conn);
            comm.Parameters.Add("@TurAd", SqlDbType.VarChar).Value = FilmTuru;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                Varmi = true;
            }
            dr.Close();
            conn.Close();
            return Varmi;
        }
        public bool FilmTuruVarmi(string FilmTuru, int TurNo)
        {
            bool Varmi = false;
            SqlCommand comm = new SqlCommand("Select TurAd from FilmTurleri where Silindi=0 and TurAd=@TurAd and FilmTurNo != @TurNo", conn);
            comm.Parameters.Add("@TurAd", SqlDbType.VarChar).Value = FilmTuru;
            comm.Parameters.Add("@TurNo", SqlDbType.Int).Value = TurNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                Varmi = true;
            }
            dr.Close();
            conn.Close();
            return Varmi;
        }
        public bool FilmTuruEkle(string FilmTuru, string Aciklama)
        {
            SqlCommand comm = new SqlCommand("insert into FilmTurleri (TurAd, Aciklama) values(@TurAd, @Aciklama)", conn);
            comm.Parameters.Add("@TurAd", SqlDbType.VarChar).Value = FilmTuru;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = Aciklama;
            if (conn.State == ConnectionState.Closed) conn.Open();
            bool Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            conn.Close();
            return Sonuc;
        }
        public bool FilmTuruEkle(cFilmTuru ft)
        {
            SqlCommand comm = new SqlCommand("insert into FilmTurleri (TurAd, Aciklama) values(@TurAd, @Aciklama)", conn);
            comm.Parameters.Add("@TurAd", SqlDbType.VarChar).Value = ft._turAd;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = ft._aciklama;
            if (conn.State == ConnectionState.Closed) conn.Open();
            bool Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            conn.Close();
            return Sonuc;
        }
        public bool FilmTuruGuncelle(cFilmTuru ft)
        {
            SqlCommand comm = new SqlCommand("update FilmTurleri set TurAd=@TurAd, Aciklama=@Aciklama where FilmTurNo=@TurNo", conn);
            comm.Parameters.Add("@TurAd", SqlDbType.VarChar).Value = ft._turAd;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = ft._aciklama;
            comm.Parameters.Add("@TurNo", SqlDbType.Int).Value = ft._filmTurNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            bool Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            conn.Close();
            return Sonuc;
        }
        public bool FilmTuruSil(int TurNo)
        {
            SqlCommand comm = new SqlCommand("update FilmTurleri set Silindi=1 where FilmTurNo=@TurNo", conn);
            comm.Parameters.Add("@TurNo", SqlDbType.Int).Value = TurNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            bool Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            conn.Close();
            return Sonuc;
        }
        //public void FilmTurleriGetir(ComboBox liste)
        //{
        //    liste.Items.Clear();
        //    SqlCommand comm = new SqlCommand("Select * from FilmTurleri where Silindi=0", conn);
        //    if (conn.State == ConnectionState.Closed) conn.Open();
        //    SqlDataReader dr;
        //    dr = comm.ExecuteReader();
        //    if (dr.HasRows)
        //    {
        //        while (dr.Read())
        //        {
        //            liste.Items.Add(dr["TurAd"].ToString());
        //        }
        //        dr.Close();
        //    }
        //    conn.Close();
        //}
        public void FilmTurleriGetir(ComboBox liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select * from FilmTurleri where Silindi=0", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    cFilmTuru ft = new cFilmTuru();
                    ft._filmTurNo = Convert.ToInt32(dr["FilmTurNo"]);
                    ft._turAd = dr["TurAd"].ToString();
                    liste.Items.Add(ft);
                }
                dr.Close();
            }
            conn.Close();
        }
        public int TurNoGetirByTureGore(string FilmTuru)
        {
            SqlCommand comm = new SqlCommand("select FilmTurNo from FilmTurleri where Silindi=0 and TurAd=@TurAd", conn);
            comm.Parameters.Add("@TurAd", SqlDbType.VarChar).Value = FilmTuru;
            if (conn.State == ConnectionState.Closed) conn.Open();
            int TurNo = Convert.ToInt32(comm.ExecuteScalar());
            conn.Close();
            return TurNo;
        }
        public override string ToString()
        {
            return TurAd;
        }
    }
}
