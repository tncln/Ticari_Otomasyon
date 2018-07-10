using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
namespace Ticari_Otomasyon
{
    public partial class FrmPersonel : DevExpress.XtraEditors.XtraForm
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void PersonelListe()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_PERSONELLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            PersonelListe();
            SehirListesi();
            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO TBL_PERSONELLER (AD,SOYAD,TELEFON,TC,MAIL,IL,ILCE,ADRES,GOREV) " +
                "VALUES (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtAd.Text);
            komut.Parameters.AddWithValue("@P2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@P3", txtTelefon.Text);
            komut.Parameters.AddWithValue("@P4", txtTC.Text);
            komut.Parameters.AddWithValue("@P5", txtMail.Text);
            komut.Parameters.AddWithValue("@P6", cmbIl.Text);
            komut.Parameters.AddWithValue("@P7", cmbIlce.Text);
            komut.Parameters.AddWithValue("@P8", txtAdres.Text);
            komut.Parameters.AddWithValue("@P9", txtGorev.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            PersonelListe();
            XtraMessageBox.Show("Kayıt İşlemi Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Temizle();
        }
        void SehirListesi()
        {
            SqlCommand komut = new SqlCommand("SELECT SEHIR FROM TBL_ILLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbIl.Properties.Items.Add(dr["SEHIR"]);
            }
            bgl.baglanti().Close();
        }

        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIlce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("SELECT ILCE FROM TBL_ILCELER WHERE SEHIR=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbIl.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbIlce.Properties.Items.Add(dr[0]);
                bgl.baglanti().Close();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                Temizle();
                txtID.Text = dr[0].ToString();
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                txtTelefon.Text = dr[3].ToString();
                txtTC.Text = dr[4].ToString();
                txtMail.Text = dr[5].ToString();
                cmbIl.Text = dr[6].ToString();
                cmbIlce.Text = dr[7].ToString();
                txtAdres.Text = dr[8].ToString();
                txtGorev.Text = dr[9].ToString();
            }
        }
        void Temizle()
        {
            txtID.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTelefon.Text = "";
            txtTC.Text = "";
            txtMail.Text = "";
            cmbIl.Text = "";
            cmbIlce.Text = "";
            txtAdres.Text = "";
            txtGorev.Text = "";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM TBL_PERSONELLER WHERE ID=@P1",bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            PersonelListe();
            Temizle();
            XtraMessageBox.Show("Silme İşlemi Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE TBL_PERSONELLER SET AD=@P1,SOYAD=@P2,TELEFON=@P3,TC=@P4,MAIL=@P5," +
                "IL=@P6,ILCE=@P7,ADRES=@P8,GOREV=@P9 WHERE ID=@P10", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtAd.Text);
            komut.Parameters.AddWithValue("@P2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@P3", txtTelefon.Text);
            komut.Parameters.AddWithValue("@P4", txtTC.Text);
            komut.Parameters.AddWithValue("@P5", txtMail.Text);
            komut.Parameters.AddWithValue("@P6", cmbIl.Text);
            komut.Parameters.AddWithValue("@P7", cmbIlce.Text);
            komut.Parameters.AddWithValue("@P8", txtAdres.Text);
            komut.Parameters.AddWithValue("@P9", txtGorev.Text);
            komut.Parameters.AddWithValue("@P10", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            PersonelListe();
            XtraMessageBox.Show("Güncelleme İşlemi Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Temizle();
        }
    }
}