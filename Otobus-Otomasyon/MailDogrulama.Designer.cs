namespace Otobus_Otomasyon
{
    partial class MailDogrulama
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
            this.txtKullaniciMail = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnKontrolEt = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // txtKullaniciMail
            // 
            this.txtKullaniciMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKullaniciMail.DefaultText = "";
            this.txtKullaniciMail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKullaniciMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKullaniciMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKullaniciMail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKullaniciMail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKullaniciMail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKullaniciMail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKullaniciMail.Location = new System.Drawing.Point(153, 96);
            this.txtKullaniciMail.Modified = true;
            this.txtKullaniciMail.Name = "txtKullaniciMail";
            this.txtKullaniciMail.PasswordChar = '\0';
            this.txtKullaniciMail.PlaceholderText = "";
            this.txtKullaniciMail.SelectedText = "";
            this.txtKullaniciMail.Size = new System.Drawing.Size(255, 36);
            this.txtKullaniciMail.TabIndex = 0;
            // 
            // btnKontrolEt
            // 
            this.btnKontrolEt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKontrolEt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKontrolEt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKontrolEt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKontrolEt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKontrolEt.ForeColor = System.Drawing.Color.White;
            this.btnKontrolEt.Location = new System.Drawing.Point(153, 151);
            this.btnKontrolEt.Name = "btnKontrolEt";
            this.btnKontrolEt.Size = new System.Drawing.Size(255, 45);
            this.btnKontrolEt.TabIndex = 1;
            this.btnKontrolEt.Text = "Kontrol Et";
            this.btnKontrolEt.Click += new System.EventHandler(this.btnKontrolEt_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(153, 65);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(255, 27);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Lütfen Mail Adresinizi Girin :";
            // 
            // MailDogrulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 299);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnKontrolEt);
            this.Controls.Add(this.txtKullaniciMail);
            this.Name = "MailDogrulama";
            this.Text = "MailDogrulama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnKontrolEt;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        public Guna.UI2.WinForms.Guna2TextBox txtKullaniciMail;
    }
}