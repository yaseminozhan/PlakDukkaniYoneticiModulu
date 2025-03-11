namespace PlakDükkanıYoneticiModulu.UI.UI
{
    partial class FRMAdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            DgvAlbums = new DataGridView();
            label2 = new Label();
            txtAlbumName = new TextBox();
            label3 = new Label();
            txtArtistBandName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtPrice = new TextBox();
            label = new Label();
            txtDiscountRate = new TextBox();
            dtpDebutDate = new DateTimePicker();
            chkIsOnSale = new CheckBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            BtnExit = new Button();
            lblMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvAlbums).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.IndianRed;
            label1.Location = new Point(78, 9);
            label1.Name = "label1";
            label1.Size = new Size(582, 23);
            label1.TabIndex = 0;
            label1.Text = "<<<<<<<<<<<<<<<<<<<<<<<<<<ADMİN PANEL AND MANAGEMENT>>>>>>>>>>>>>>>>>";
            // 
            // DgvAlbums
            // 
            DgvAlbums.BackgroundColor = Color.RosyBrown;
            DgvAlbums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvAlbums.Location = new Point(12, 276);
            DgvAlbums.Name = "DgvAlbums";
            DgvAlbums.Size = new Size(618, 243);
            DgvAlbums.TabIndex = 1;
            // 
            // label2
            // 
            label2.BackColor = Color.DarkGray;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(140, 23);
            label2.TabIndex = 2;
            label2.Text = "Album Name";
            // 
            // txtAlbumName
            // 
            txtAlbumName.Location = new Point(158, 52);
            txtAlbumName.Name = "txtAlbumName";
            txtAlbumName.Size = new Size(298, 23);
            txtAlbumName.TabIndex = 3;
            // 
            // label3
            // 
            label3.BackColor = Color.DarkGray;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(12, 90);
            label3.Name = "label3";
            label3.Size = new Size(140, 23);
            label3.TabIndex = 2;
            label3.Text = "Artist/Band Name";
            // 
            // txtArtistBandName
            // 
            txtArtistBandName.Location = new Point(158, 90);
            txtArtistBandName.Name = "txtArtistBandName";
            txtArtistBandName.Size = new Size(298, 23);
            txtArtistBandName.TabIndex = 3;
            // 
            // label4
            // 
            label4.BackColor = Color.DarkGray;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(12, 131);
            label4.Name = "label4";
            label4.Size = new Size(140, 23);
            label4.TabIndex = 2;
            label4.Text = "Debut Date";
            // 
            // label5
            // 
            label5.BackColor = Color.DarkGray;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.ForeColor = Color.DarkRed;
            label5.Location = new Point(12, 166);
            label5.Name = "label5";
            label5.Size = new Size(140, 23);
            label5.TabIndex = 2;
            label5.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(158, 166);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(298, 23);
            txtPrice.TabIndex = 3;
            // 
            // label
            // 
            label.BackColor = Color.DarkGray;
            label.BorderStyle = BorderStyle.Fixed3D;
            label.ForeColor = Color.DarkRed;
            label.Location = new Point(12, 209);
            label.Name = "label";
            label.Size = new Size(140, 23);
            label.TabIndex = 2;
            label.Text = "Discount Rate";
            // 
            // txtDiscountRate
            // 
            txtDiscountRate.Location = new Point(158, 209);
            txtDiscountRate.Name = "txtDiscountRate";
            txtDiscountRate.Size = new Size(298, 23);
            txtDiscountRate.TabIndex = 3;
            // 
            // dtpDebutDate
            // 
            dtpDebutDate.Location = new Point(158, 125);
            dtpDebutDate.Name = "dtpDebutDate";
            dtpDebutDate.Size = new Size(298, 23);
            dtpDebutDate.TabIndex = 5;
            // 
            // chkIsOnSale
            // 
            chkIsOnSale.AutoSize = true;
            chkIsOnSale.ForeColor = Color.Maroon;
            chkIsOnSale.Location = new Point(519, 241);
            chkIsOnSale.Name = "chkIsOnSale";
            chkIsOnSale.Size = new Size(77, 19);
            chkIsOnSale.TabIndex = 6;
            chkIsOnSale.Text = "Is On Sale";
            chkIsOnSale.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkRed;
            btnAdd.ForeColor = SystemColors.ButtonFace;
            btnAdd.Location = new Point(492, 52);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(138, 42);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkRed;
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(492, 112);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(138, 42);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkRed;
            btnUpdate.ForeColor = SystemColors.ButtonFace;
            btnUpdate.Location = new Point(492, 166);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(138, 42);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = Color.Red;
            BtnExit.Location = new Point(12, 525);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(618, 44);
            BtnExit.TabIndex = 7;
            BtnExit.Text = "EXİT";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 162);
            lblMessage.ForeColor = Color.DarkMagenta;
            lblMessage.Location = new Point(12, 235);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(444, 38);
            lblMessage.TabIndex = 8;
            // 
            // FRMAdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 581);
            Controls.Add(lblMessage);
            Controls.Add(BtnExit);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(chkIsOnSale);
            Controls.Add(dtpDebutDate);
            Controls.Add(txtDiscountRate);
            Controls.Add(label);
            Controls.Add(txtPrice);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtArtistBandName);
            Controls.Add(label3);
            Controls.Add(txtAlbumName);
            Controls.Add(label2);
            Controls.Add(DgvAlbums);
            Controls.Add(label1);
            Name = "FRMAdminPanel";
            Text = "FRMAdminPanel";
            ((System.ComponentModel.ISupportInitialize)DgvAlbums).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView DgvAlbums;
        private Label label2;
        private TextBox txtAlbumName;
        private Label label3;
        private TextBox txtArtistBandName;
        private Label label4;
        private Label label5;
        private TextBox txtPrice;
        private Label label;
        private TextBox txtDiscountRate;
        private DateTimePicker dtpDebutDate;
        private CheckBox chkIsOnSale;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button BtnExit;
        private Label lblMessage;
    }
}