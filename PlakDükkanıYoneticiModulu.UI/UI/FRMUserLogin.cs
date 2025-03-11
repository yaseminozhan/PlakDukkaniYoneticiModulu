using System.Security.Cryptography;
using System.Text;
using PlakDükkanıYoneticiModulu.UI.DAL;
using PlakDükkanıYoneticiModulu.UI.Entities;
using PlakDükkanıYoneticiModulu.UI.UI;

namespace PlakDükkanıYoneticiModulu.UI
{
    public partial class FRMUserLogin : Form
    {
        public AppDbContext _context;
        public FRMUserLogin()
        {
            _context = new AppDbContext();
            InitializeComponent();
        }

        /// <summary>
        /// SHA256 metodu
        /// </summary>
        /// <param name="sifre"></param>
        /// <returns></returns>
        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(x => x.ToString("X2")));
            }
        }
        /// <summary>
        /// şifre kriterlerini kontrol ediyoruz.
        /// </summary>
        /// <param name="sifre"></param>
        /// <returns></returns>
        private bool SifreGecerliMi(string sifre)
        {
            if (sifre.Length < 8) return false; // En az 8 karakter olmalı
            if (sifre.Count(char.IsUpper) < 2) return false; // En az 2 büyük harf içermeli
            if (sifre.Count(char.IsLower) < 3) return false; // En az 3 küçük harf içermeli

            // Belirtilen özel karakterlerden en az 2 tanesi olmalı
            string ozelKarakterler = "!:+*";
            int ozelKarakterSayisi = sifre.Count(c => ozelKarakterler.Contains(c));
            if (ozelKarakterSayisi < 2) return false;

            return true;
        }
        /// <summary>
        /// giriş işlemleri 
        /// yanlış girişlerde hata mesajı alınacak.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtUserPassword.Text;

            var admin = _context.Admins.FirstOrDefault(a => a.UserName == userName);
            if (admin == null || admin.PasswordHash != sha256_hash(password))
            {
                lblMessage.Text = "incorrect username or password !";

            }
            else //başarılı girişte admin paneli açılacak.
            {
                FRMAdminPanel userPanel = new FRMAdminPanel();
                userPanel.Show();
                this.Hide();
            }

        }
      
        private void btnAddNewAdmin_Click(object sender, EventArgs e)
        {

            //admin ekleme ekranını aç
            FRMAddUser addUserForm= new FRMAddUser();
            this.Hide(); //this hide ile giriş formunu gizliyoruz
            addUserForm.ShowDialog();
            this.Show(); //ekranı geri açıyroruz.
        }
    }
}
