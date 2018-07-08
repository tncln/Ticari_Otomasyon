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

namespace Ticari_Otomasyon
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_MUSTERILER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
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
        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            Listele();
            SehirListesi();
            txtAd.Focus();
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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO TBL_MUSTERILER (AD,SOYAD,TELEFON,TELEFON2,TC,MAIL,IL,ILCE," +
                "ADRES,VERGIDAIRE) VALUES (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10)", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtAd.Text);
            komut.Parameters.AddWithValue("@P2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@P3", txtTelefon1.Text);
            komut.Parameters.AddWithValue("@P4", txtTelefon2.Text);
            komut.Parameters.AddWithValue("@P5", txtTC.Text);
            komut.Parameters.AddWithValue("@P6", txtMail.Text);
            komut.Parameters.AddWithValue("@P7", cmbIl.Text);
            komut.Parameters.AddWithValue("@P8", cmbIlce.Text);
            komut.Parameters.AddWithValue("@P9", txtAdres.Text);
            komut.Parameters.AddWithValue("@P10", txtVergiDairesi.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Sisteme Eklendi.", "Başarılı", MessageBoxButtons.OK);
            Listele();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr[0].ToString();
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                txtTelefon1.Text = dr[3].ToString();
                txtTelefon2.Text = dr[4].ToString();
                txtTC.Text = dr[5].ToString();
                txtMail.Text = dr[6].ToString();
                cmbIl.Text = dr[7].ToString();
                cmbIlce.Text = dr[8].ToString();
                txtAdres.Text = dr[9].ToString();
                txtVergiDairesi.Text = dr[10].ToString();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_MUSTERILER where ID=@p1", bgl.baglanti());
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Silme İşlemimni Gerçekleşecek Onaylıyormusunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

            if (secim == DialogResult.Yes)
            {
                komut.Parameters.AddWithValue("@p1", txtID.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("İstenilen Ürün Silinmiştir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            else if (secim == DialogResult.No)
            {
                MessageBox.Show("Silme İŞlemi İptal Edilmiştir...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE TBL_MUSTERILER SET AD=@P1,SOYAD=@P2,TELEFON=@P3, TELEFON2@P4,TC=@P5," +
                "MAIL=@P6,IL=@P7,ILCE=@P8,VERGIDARE=@P9,ADRES=@P10 WHERE ID=@P11", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtAd.Text);
            komut.Parameters.AddWithValue("@P2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@P3", txtTelefon1.Text);
            komut.Parameters.AddWithValue("@P4", txtTelefon2.Text);
            komut.Parameters.AddWithValue("@P5", txtTC.Text);
            komut.Parameters.AddWithValue("@P6", txtMail.Text);
            komut.Parameters.AddWithValue("@P7", cmbIl.Text);
            komut.Parameters.AddWithValue("@P8", cmbIlce.Text);
            komut.Parameters.AddWithValue("@P9", txtVergiDairesi.Text);
            komut.Parameters.AddWithValue("@P10", txtAdres.Text);
            komut.Parameters.AddWithValue("@P11", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Bilgileri Güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

