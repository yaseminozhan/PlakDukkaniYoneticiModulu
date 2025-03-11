using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlakDükkanıYoneticiModulu.UI.DAL;
using PlakDükkanıYoneticiModulu.UI.Entities;

namespace PlakDükkanıYoneticiModulu.UI.UI
{
    public partial class FRMAdminPanel : Form
    {
        public AppDbContext _context;
        public FRMAdminPanel()
        {
            InitializeComponent();
            _context = new AppDbContext();
            LoadAlbums();  //form açılınca albümleri yükle.
        }
        /// <summary>
        ///Linq sorgusu ile albüm listesini veritabanından çekip dgv e yükleyeceğiz.
        ///
        /// </summary>
        private void LoadAlbums()
        {
            DgvAlbums.DataSource = _context.Albums.Select(a => new
            {
                a.Id,
                a.AlbumName,
                a.ArtistGroup,
                a.DebutDate,
                a.Price,
                a.Discount,
                a.IsActive,
            }).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAlbumName.Text) || string.IsNullOrWhiteSpace(txtArtistBandName.Text))
            {
                lblMessage.Text = "Album name or Artist/Band cannot be empty!";
                return;

            }

            var newAlbum = new Album
            {
                AlbumName = txtAlbumName.Text,
                ArtistGroup = txtArtistBandName.Text,
                DebutDate = dtpDebutDate.Value,
                Price = decimal.TryParse(txtPrice.Text, out decimal price) ? price : 0,
                Discount = decimal.TryParse(txtDiscountRate.Text, out decimal discount) ? discount : (decimal?)null,
                IsActive = chkIsOnSale.Checked,
            };

            _context.Albums.Add(newAlbum);
            _context.SaveChanges();
            LoadAlbums();
            lblMessage.Text = "album added succesfully.";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (DgvAlbums.SelectedRows.Count == 0)
            {
                lblMessage.Text = "for update,select an album!";
                return;
            }
            int albumId = Convert.ToInt32(DgvAlbums.SelectedRows[0].Cells["Id"].Value);
            var album = _context.Albums.Find(albumId);

            if (album != null)
            {
                album.AlbumName = txtAlbumName.Text;
                album.ArtistGroup = txtArtistBandName.Text;
                album.DebutDate = dtpDebutDate.Value;
                album.Price = decimal.TryParse(txtPrice.Text, out decimal price) ? price : 0;
                album.Discount = decimal.TryParse(txtDiscountRate.Text, out decimal discount) ? discount : (decimal?)null;
                album.IsActive = chkIsOnSale.Checked;
                _context.SaveChanges();
                LoadAlbums();
                lblMessage.Text = "Album updated succesfully. ";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DgvAlbums.SelectedRows.Count == 0)
            {
                lblMessage.Text = "for delete, select an album!";
                return;
            }
            int albumId = Convert.ToInt32(DgvAlbums.SelectedRows[0].Cells["Id"].Value);
            var album = _context.Albums.Find(albumId);
            if (album != null)
            {
                var confirm = MessageBox.Show("Are you sure you want to delete?", "Confirm", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    _context.Albums.Remove(album);
                    _context.SaveChanges();
                    LoadAlbums();
                    lblMessage.Text = "Album deleted succesfully";
                }
            }



        }
        /// <summary>
        /// formu kapat.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            //this.Close();  //bunu kullandığımda sadece form kapandı ben uygulamadan çıkmak istediğim için:

            Application.Exit(); //tamamen çıkış yapıldı.
        }
    }
}
