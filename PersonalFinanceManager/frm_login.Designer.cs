namespace PersonalFinanceManager
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.login_icon = new System.Windows.Forms.PictureBox();
            this.login_gbx = new System.Windows.Forms.GroupBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.cbo_username = new System.Windows.Forms.ComboBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.login_icon)).BeginInit();
            this.login_gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_icon
            // 
            this.login_icon.BackColor = System.Drawing.Color.Transparent;
            this.login_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.login_icon.Image = ((System.Drawing.Image)(resources.GetObject("login_icon.Image")));
            this.login_icon.Location = new System.Drawing.Point(119, 12);
            this.login_icon.Name = "login_icon";
            this.login_icon.Size = new System.Drawing.Size(140, 125);
            this.login_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.login_icon.TabIndex = 0;
            this.login_icon.TabStop = false;
            // 
            // login_gbx
            // 
            this.login_gbx.BackColor = System.Drawing.SystemColors.ControlLight;
            this.login_gbx.Controls.Add(this.txt_password);
            this.login_gbx.Controls.Add(this.cbo_username);
            this.login_gbx.Controls.Add(this.btn_login);
            this.login_gbx.Controls.Add(this.label3);
            this.login_gbx.Controls.Add(this.label2);
            this.login_gbx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_gbx.Location = new System.Drawing.Point(37, 194);
            this.login_gbx.Name = "login_gbx";
            this.login_gbx.Size = new System.Drawing.Size(304, 195);
            this.login_gbx.TabIndex = 0;
            this.login_gbx.TabStop = false;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(110, 95);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(171, 20);
            this.txt_password.TabIndex = 2;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyDown);
            // 
            // cbo_username
            // 
            this.cbo_username.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_username.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_username.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbo_username.FormattingEnabled = true;
            this.cbo_username.Location = new System.Drawing.Point(110, 38);
            this.cbo_username.Name = "cbo_username";
            this.cbo_username.Size = new System.Drawing.Size(171, 21);
            this.cbo_username.TabIndex = 1;
            this.cbo_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbo_username_KeyDown);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(124, 145);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 30);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "username :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(157, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PersonalFinanceManager.Properties.Resources._5096160;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(382, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_gbx);
            this.Controls.Add(this.login_icon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(398, 561);
            this.MinimizeBox = false;
            this.Name = "frm_login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HouseWife";
            this.Load += new System.EventHandler(this.frm_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.login_icon)).EndInit();
            this.login_gbx.ResumeLayout(false);
            this.login_gbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox login_icon;
        private System.Windows.Forms.GroupBox login_gbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.ComboBox cbo_username;
        private System.Windows.Forms.TextBox txt_password;
    }
}

