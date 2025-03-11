using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDükkanıYoneticiModulu.UI.Entities
{
    /// <summary>
    /// albümün tüm bilgileri için 
    /// </summary>
    public class Album
    {
        [Key]
        public int Id { get; set; } //primary
        [Required] 
        public string AlbumName { get; set; }
        [Required]
        public string ArtistGroup { get; set; }
        public DateTime DebutDate { get; set; }
        [Required]
        public decimal Price { get; set; }
        public decimal? Discount { get; set; } //indirim varsa . ykosa null olabilir
        public bool IsActive { get; set; }
    }
}
