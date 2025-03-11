using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDükkanıYoneticiModulu.UI.Entities
{
    public class Admin
    {
        [Key]
        public int Id { get; set; } //primary key
        [Required] //bu özellik boş bırakılamaz. hata alınır.
        public string UserName { get; set; }
        [Required] //boş olamaz 
        public string PasswordHash { get; set; } //şifre veritabanında hash olarak tutulacak
    }
}
