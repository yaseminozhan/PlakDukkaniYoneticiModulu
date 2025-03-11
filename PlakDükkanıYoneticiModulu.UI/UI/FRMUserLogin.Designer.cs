namespace PlakDükkanıYoneticiModulu.UI
{
    partial class FRMUserLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtUserName = new TextBox();
            BtnLogIn = new Button();
            label2 = new Label();
            txtUserPassword = new TextBox();
            label3 = new Label();
            lblMessage = new Label();
            btnAddNewAdmin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGray;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(21, 40);
            label1.Name = "label1";
            label1.Size = new Size(70, 17);
            label1.TabIndex = 0;
            label1.Text = "User Name:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(124, 37);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(198, 23);
            txtUserName.TabIndex = 1;
            // 
            // BtnLogIn
            // 
            BtnLogIn.BackColor = Color.Maroon;
            BtnLogIn.ForeColor = SystemColors.ButtonFace;
            BtnLogIn.Location = new Point(192, 119);
            BtnLogIn.Name = "BtnLogIn";
            BtnLogIn.Size = new Size(130, 33);
            BtnLogIn.TabIndex = 2;
            BtnLogIn.Text = "LOGİN";
            BtnLogIn.UseVisualStyleBackColor = false;
            BtnLogIn.Click += BtnLogIn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkGray;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(21, 93);
            label2.Name = "label2";
            label2.Size = new Size(88, 17);
            label2.TabIndex = 0;
            label2.Text = "User Password:";
            // 
            // txtUserPassword
            // 
            txtUserPassword.Location = new Point(124, 90);
            txtUserPassword.Name = "txtUserPassword";
            txtUserPassword.Size = new Size(198, 23);
            txtUserPassword.TabIndex = 1;
            // 
            // label3
            // 
            label3.BackColor = Color.IndianRed;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(353, 15);
            label3.TabIndex = 0;
            label3.Text = "<<<<<<<<<<<<<<<<PLAK SHOP>>>>>>>>>>>>>>>>>>>";
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 162);
            lblMessage.ForeColor = Color.DarkMagenta;
            lblMessage.Location = new Point(12, 192);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(323, 23);
            lblMessage.TabIndex = 3;
            // 
            // btnAddNewAdmin
            // 
            btnAddNewAdmin.BackColor = Color.RosyBrown;
            btnAddNewAdmin.ForeColor = Color.Sienna;
            btnAddNewAdmin.Location = new Point(21, 166);
            btnAddNewAdmin.Name = "btnAddNewAdmin";
            btnAddNewAdmin.Size = new Size(301, 23);
            btnAddNewAdmin.TabIndex = 4;
            btnAddNewAdmin.Text = "Add New Admin";
            btnAddNewAdmin.UseVisualStyleBackColor = false;
            btnAddNewAdmin.Click += btnAddNewAdmin_Click;
            // 
            // FRMUserLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(365, 231);
            Controls.Add(btnAddNewAdmin);
            Controls.Add(lblMessage);
            Controls.Add(BtnLogIn);
            Controls.Add(txtUserPassword);
            Controls.Add(label2);
            Controls.Add(txtUserName);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "FRMUserLogin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUserName;
        private Button BtnLogIn;
        private Label label2;
        private TextBox txtUserPassword;
        private Label label3;
        private Label lblMessage;
        private Button btnAddNewAdmin;
    }
}
