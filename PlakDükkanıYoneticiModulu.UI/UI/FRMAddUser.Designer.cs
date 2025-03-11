namespace PlakDükkanıYoneticiModulu.UI.UI
{
    partial class FRMAddUser
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
            lblMessage = new Label();
            BtnAdd = new Button();
            txtUserPassword = new TextBox();
            label2 = new Label();
            txtUserName = new TextBox();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 162);
            lblMessage.ForeColor = Color.DarkMagenta;
            lblMessage.Location = new Point(12, 155);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(323, 82);
            lblMessage.TabIndex = 11;
            // 
            // BtnAdd
            // 
            BtnAdd.BackColor = Color.Maroon;
            BtnAdd.ForeColor = SystemColors.ButtonFace;
            BtnAdd.Location = new Point(192, 119);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(130, 33);
            BtnAdd.TabIndex = 10;
            BtnAdd.Text = "ADD";
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // txtUserPassword
            // 
            txtUserPassword.Location = new Point(124, 90);
            txtUserPassword.Name = "txtUserPassword";
            txtUserPassword.Size = new Size(198, 23);
            txtUserPassword.TabIndex = 8;
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
            label2.TabIndex = 5;
            label2.Text = "User Password:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(124, 37);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(198, 23);
            txtUserName.TabIndex = 9;
            // 
            // label3
            // 
            label3.BackColor = Color.IndianRed;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(353, 15);
            label3.TabIndex = 6;
            label3.Text = "<<<<<<<<<<<<<<<<Add New User>>>>>>>>>>>>>>>>";
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
            label1.TabIndex = 7;
            label1.Text = "User Name:";
            // 
            // FRMAddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 246);
            Controls.Add(lblMessage);
            Controls.Add(BtnAdd);
            Controls.Add(txtUserPassword);
            Controls.Add(label2);
            Controls.Add(txtUserName);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "FRMAddUser";
            Text = "FRMAddUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMessage;
        private Button BtnAdd;
        private TextBox txtUserPassword;
        private Label label2;
        private TextBox txtUserName;
        private Label label3;
        private Label label1;
    }
}