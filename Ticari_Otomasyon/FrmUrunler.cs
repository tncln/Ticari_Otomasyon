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
    public partial class FrmUrunler : XtraForm
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_URUNLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO  TBL_URUNLER(URUNAD,MARKA,MODEL,YIL,ADET,ALISFIYAT,SATISFIYAT,DETAY)" +
                " VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtMarka.Text);
            komut.Parameters.AddWithValue("@p3", txtModel.Text);
            komut.Parameters.AddWithValue("@p4", mskYil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((NudAdet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txtAlisFiyat.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txtSatisFiyat.Text));
            komut.Parameters.AddWithValue("@p8", RchDetay.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Sisteme Eklendi.","Hata");
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //SqlCommand komutsil = new SqlCommand("DELETE FROM TBL_URUNLER WHERE ID=@p1", bgl.baglanti());
            //komutsil.Parameters.AddWithValue("@p1", txtID.Text);
            //komutsil.ExecuteNonQuery();
            //bgl.baglanti().Close();
            //MessageBox.Show("Ürün Silindi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Error);
            //Listele();

            SqlCommand komutsil = new SqlCommand("DELETE FROM TBL_URUNLER WHERE ID=@p1", bgl.baglanti());
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Silme İşlemimni Gerçekleşecek Onaylıyormusunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

            if (secim == DialogResult.Yes)
            {
                komutsil.Parameters.AddWithValue("@p1", txtID.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("İstenilen Ürün Silinmiştir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            else if (secim == DialogResult.No)
            {
                MessageBox.Show("Silme İŞlemi İptal Edilmiştir...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        
    }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtID.Text = dr["ID"].ToString();
            txtAd.Text = dr["URUNAD"].ToString();
            txtMarka.Text = dr["MARKA"].ToString();
            txtModel.Text = dr["MODEL"].ToString();
            mskYil.Text = dr["YIL"].ToString();
            NudAdet.Value =decimal.Parse( dr["ADET"].ToString());
            txtAlisFiyat.Text = dr["ALISFIYAT"].ToString();
            txtSatisFiyat.Text = dr["SATISFIYAT"].ToString();
            RchDetay.Text = dr["DETAY"].ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE TBL_URUNLER SET URUNAD=@p1,MARKA=@p2,MODEL=@p3,YIL=@p4," +
                "ADET=@p5,ALISFIYAT=@p6,SATISFIYAT=@p7,DETAY=@p8 WHERE ID=@p9",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtMarka.Text);
            komut.Parameters.AddWithValue("@p3", txtModel.Text);
            komut.Parameters.AddWithValue("@p4", mskYil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((NudAdet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txtAlisFiyat.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txtSatisFiyat.Text));
            komut.Parameters.AddWithValue("@p8", RchDetay.Text);
            komut.Parameters.AddWithValue("@p9", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
        }
    }
}
