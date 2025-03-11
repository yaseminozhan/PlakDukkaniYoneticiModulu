using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlakDükkanıYoneticiModulu.UI.DAL;
using PlakDükkanıYoneticiModulu.UI.Entities;

namespace PlakDükkanıYoneticiModulu.UI.UI
{
    public partial class FRMAddUser : Form
    {
        public AppDbContext _context;
        public FRMAddUser()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }
        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(x => x.ToString("X2")));
            }
        }

        /// <summary>
        /// şifre kriterleri validate
        /// </summary>
        /// <param name="sifre"></param>
        /// <returns></returns>
        private bool SifreGecerliMi(string sifre)
        {
            if (sifre.Length < 8) return false; // En az 8 karakter olmalı
            if (sifre.Count(char.IsUpper) < 2) return false; // En az 2 büyük harf içermeli
            if (sifre.Count(char.IsLower) < 3) return false; // En az 3 küçük harf içermeli

            string ozelKarakterler = "!:+*";
            int ozelKarakterSayisi = sifre.Count(c => ozelKarakterler.Contains(c));
            if (ozelKarakterSayisi < 2) return false; // En az 2 özel karakter içermeli

            return true;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string userName=txtUserName.Text;
            string password=txtUserPassword.Text;
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                lblMessage.Text = "Username or password cannot be empty!";
                return;
            }
            if (!SifreGecerliMi(password))
            {
                lblMessage.Text = "The password does not meet the criteria. It must be at least 8 characters, 2 uppercase letters and at least 2 of the characters ( !,:,+,*). ";
                return;
            }
            var registeredAdmin = new Admin
            {
                UserName = userName,
                PasswordHash = sha256_hash(password)
            };
            _context.Admins.Add(registeredAdmin);
            _context.SaveChanges();

            MessageBox.Show("Admin added succesfully.");

            this.Close(); // admin eklendikten sonra ekranı kapat. giriş formuna dön.
        }
    }
}
