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
using System.Net;
using System.Net.Mail;
namespace Ticari_Otomasyon
{
    public partial class FrmMail : DevExpress.XtraEditors.XtraForm
    {
        public FrmMail()
        {
            InitializeComponent();
        }
        public string Mail;
        private void FrmMail_Load(object sender, EventArgs e)
        {
            txtMailAdresi.Text = Mail;
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            MailMessage mesaj = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new NetworkCredential("Mail", "Şifre");
            istemci.Port = 587;
            istemci.Host = "smtp.gmail.com";
            istemci.EnableSsl = true;
            mesaj.To.Add(txtMesaj.Text);
            mesaj.From = new MailAddress("Mail");
            mesaj.Subject = txtKonu.Text;
            mesaj.Body = txtMesaj.Text;
            istemci.Send(mesaj);
        }
    }
}