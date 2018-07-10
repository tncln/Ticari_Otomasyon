using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;

namespace Ticari_Otomasyon
{
    public partial class FrmFirmalar : XtraForm
    {
        public FrmFirmalar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            FirmaListesi();
            SehirListesi();
            Temizle();
            CariKodAciklamalar();
        }
        void FirmaListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_FIRMALAR", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr[0].ToString();
                txtAd.Text = dr[1].ToString();
                txtYGorev.Text = dr[2].ToString();
                txtYetkili.Text = dr[3].ToString();
                txtYetkiliTC.Text = dr[4].ToString();
                txtSektor.Text = dr[5].ToString();
                txtTelefon1.Text = dr[6].ToString();
                txtTelefon2.Text = dr[7].ToString();
                txtTelefon3.Text = dr[8].ToString();
                txtMail.Text = dr[9].ToString();
                txtFax.Text = dr[10].ToString();
                cmbIl.Text = dr[11].ToString();
                cmbIlce.Text = dr[12].ToString();
                txtVergiDairesi.Text = dr[13].ToString();
                txtAdres.Text = dr[14].ToString();
                txtOzelKod1.Text = dr[15].ToString();
                txtOzelKod2.Text = dr[16].ToString();
                txtOzelKod3.Text = dr[17].ToString();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO TBL_FIRMALAR " +
                "(AD,YETKILISTATU,YETKILIADSOYAD,YETKILITC,SEKTOR,TELEFON1,TELEFON2,TELEFON3,MAIL,FAX,IL,ILCE,VERGIDAIRE," +
                "ADRES,OZELKOD1,OZELKOD2,OZELKOD3) VALUES (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11,@P12,@P13,@P14,@P15,@P16,@P17)",bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtAd.Text);
            komut.Parameters.AddWithValue("@P2", txtYGorev.Text);
            komut.Parameters.AddWithValue("@P3", txtYetkili.Text);
            komut.Parameters.AddWithValue("@P4", txtYetkiliTC.Text);
            komut.Parameters.AddWithValue("@P5", txtSektor.Text);
            komut.Parameters.AddWithValue("@P6", txtTelefon1.Text);
            komut.Parameters.AddWithValue("@P7", txtTelefon2.Text);
            komut.Parameters.AddWithValue("@P8", txtTelefon3.Text);
            komut.Parameters.AddWithValue("@P9", txtMail.Text);
            komut.Parameters.AddWithValue("@P10", txtFax.Text);
            komut.Parameters.AddWithValue("@P11", cmbIl.Text);
            komut.Parameters.AddWithValue("@P12", cmbIlce.Text);
            komut.Parameters.AddWithValue("@P13", txtVergiDairesi.Text);
            komut.Parameters.AddWithValue("@P14", txtAdres.Text);
            komut.Parameters.AddWithValue("@P15", txtOzelKod1.Text);
            komut.Parameters.AddWithValue("@P16", txtOzelKod2.Text);
            komut.Parameters.AddWithValue("@P17", txtOzelKod3.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma sisteme eklendi.","Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FirmaListesi();
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
        private void Temizle()
        {
            txtAd.Text = "";
            txtAdres.Text = "";
            txtFax.Text = "";
            txtID.Text = "";
            txtMail.Text = "";
            txtOzelKod1.Text = "";
            txtOzelKod2.Text = "";
            txtOzelKod3.Text = "";
            txtSektor.Text = "";
            txtTelefon1.Text = "";
            txtTelefon2.Text = "";
            txtTelefon3.Text = "";
            txtVergiDairesi.Text = "";
            txtYetkili.Text = "";
            txtYetkiliTC.Text = "";
            txtYGorev.Text = "";
            cmbIl.Text = "";
            cmbIlce.Text = "";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE TBL_FIRMALAR SET AD=@P1,YETKILISTATU=@P2,YETKILIADSOYAD=@P3," +
                "YETKILITC=@P4,SEKTOR=@P5,TELEFON1=@P6,TELEFON2=@P7,TELEFON3=@P8,MAIL=@P9,FAX=@P10,IL=@P11,ILCE=@P12," +
                "VERGIDAIRE=@P13,ADRES=@P14,OZELKOD1=@P15,OZELKOD2=@P16,OZELKOD3=@P17 WHERE ID=@P18 ",bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtAd.Text);
            komut.Parameters.AddWithValue("@P2", txtYGorev.Text);
            komut.Parameters.AddWithValue("@P3", txtYetkili.Text);
            komut.Parameters.AddWithValue("@P4", txtYetkiliTC.Text);
            komut.Parameters.AddWithValue("@P5", txtSektor.Text);
            komut.Parameters.AddWithValue("@P6", txtTelefon1.Text);
            komut.Parameters.AddWithValue("@P7", txtTelefon2.Text);
            komut.Parameters.AddWithValue("@P8", txtTelefon3.Text);
            komut.Parameters.AddWithValue("@P9", txtMail.Text);
            komut.Parameters.AddWithValue("@P10", txtFax.Text);
            komut.Parameters.AddWithValue("@P11", cmbIl.Text);
            komut.Parameters.AddWithValue("@P12", cmbIlce.Text);
            komut.Parameters.AddWithValue("@P13", txtVergiDairesi.Text);
            komut.Parameters.AddWithValue("@P14", txtAdres.Text);
            komut.Parameters.AddWithValue("@P15", txtOzelKod1.Text);
            komut.Parameters.AddWithValue("@P16", txtOzelKod2.Text);
            komut.Parameters.AddWithValue("@P17", txtOzelKod3.Text);
            komut.Parameters.AddWithValue("@P18", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme İşlemi Başarılı.. Firma Silindi.","Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            FirmaListesi();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TBL_FIRMALAR WHERE ID=@P1",bgl.baglanti());
            komut.Parameters.AddWithValue("@P1",txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            FirmaListesi();
            MessageBox.Show("Silme İşlemi Başarılı","Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Temizle();
        }
        void CariKodAciklamalar()
        {
            SqlCommand komut = new SqlCommand("SELECT FIRMAKOD1 FROM TBL_KODLAR",bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtOzelKod1.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
