namespace Otobus_Otomasyon
{
    partial class SeferIptalEt
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BiletTimer = new System.Windows.Forms.Timer(this.components);
            this.RezervasyonTimer = new System.Windows.Forms.Timer(this.components);
            this.KullaniciTimer = new System.Windows.Forms.Timer(this.components);
            this.ZamanTimer = new System.Windows.Forms.Timer(this.components);
            this.SeferTimer = new System.Windows.Forms.Timer(this.components);
            this.SidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel43 = new System.Windows.Forms.Panel();
            this.btnSeferIptalEt = new Guna.UI2.WinForms.Guna2Button();
            this.txtSeferId = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel36 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel44 = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel35 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgwSeferler = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2HtmlLabel34 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel43.SuspendLayout();
            this.panel44.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSeferler)).BeginInit();
            this.SuspendLayout();
            // 
            // BiletTimer
            // 
            this.BiletTimer.Enabled = true;
            this.BiletTimer.Interval = 10;
            // 
            // RezervasyonTimer
            // 
            this.RezervasyonTimer.Enabled = true;
            this.RezervasyonTimer.Interval = 10;
            // 
            // KullaniciTimer
            // 
            this.KullaniciTimer.Enabled = true;
            this.KullaniciTimer.Interval = 10;
            // 
            // SeferTimer
            // 
            this.SeferTimer.Enabled = true;
            this.SeferTimer.Interval = 10;
            // 
            // SidebarTimer
            // 
            this.SidebarTimer.Enabled = true;
            this.SidebarTimer.Interval = 10;
            // 
            // panel43
            // 
            this.panel43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel43.Controls.Add(this.btnSeferIptalEt);
            this.panel43.Controls.Add(this.txtSeferId);
            this.panel43.Controls.Add(this.guna2HtmlLabel36);
            this.panel43.Controls.Add(this.panel44);
            this.panel43.Location = new System.Drawing.Point(241, 584);
            this.panel43.Name = "panel43";
            this.panel43.Size = new System.Drawing.Size(615, 250);
            this.panel43.TabIndex = 5;
            // 
            // btnSeferIptalEt
            // 
            this.btnSeferIptalEt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSeferIptalEt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSeferIptalEt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSeferIptalEt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSeferIptalEt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnSeferIptalEt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeferIptalEt.ForeColor = System.Drawing.Color.White;
            this.btnSeferIptalEt.Location = new System.Drawing.Point(364, 157);
            this.btnSeferIptalEt.Name = "btnSeferIptalEt";
            this.btnSeferIptalEt.Size = new System.Drawing.Size(230, 68);
            this.btnSeferIptalEt.TabIndex = 3;
            this.btnSeferIptalEt.Text = "Sefer İptal Et";
            this.btnSeferIptalEt.Click += new System.EventHandler(this.btnSeferIptalEt_Click);
            // 
            // txtSeferId
            // 
            this.txtSeferId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSeferId.DefaultText = "";
            this.txtSeferId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSeferId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSeferId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSeferId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSeferId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSeferId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSeferId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSeferId.Location = new System.Drawing.Point(364, 96);
            this.txtSeferId.Name = "txtSeferId";
            this.txtSeferId.PasswordChar = '\0';
            this.txtSeferId.PlaceholderText = "";
            this.txtSeferId.SelectedText = "";
            this.txtSeferId.Size = new System.Drawing.Size(230, 36);
            this.txtSeferId.TabIndex = 2;
            // 
            // guna2HtmlLabel36
            // 
            this.guna2HtmlLabel36.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel36.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel36.Location = new System.Drawing.Point(3, 96);
            this.guna2HtmlLabel36.Name = "guna2HtmlLabel36";
            this.guna2HtmlLabel36.Size = new System.Drawing.Size(302, 32);
            this.guna2HtmlLabel36.TabIndex = 1;
            this.guna2HtmlLabel36.Text = "İptal Edilecek Sefer Numarası :";
            // 
            // panel44
            // 
            this.panel44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel44.Controls.Add(this.guna2HtmlLabel35);
            this.panel44.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel44.Location = new System.Drawing.Point(0, 0);
            this.panel44.Name = "panel44";
            this.panel44.Size = new System.Drawing.Size(615, 64);
            this.panel44.TabIndex = 0;
            // 
            // guna2HtmlLabel35
            // 
            this.guna2HtmlLabel35.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel35.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel35.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel35.Location = new System.Drawing.Point(250, 11);
            this.guna2HtmlLabel35.Name = "guna2HtmlLabel35";
            this.guna2HtmlLabel35.Size = new System.Drawing.Size(178, 42);
            this.guna2HtmlLabel35.TabIndex = 0;
            this.guna2HtmlLabel35.Text = "Sefer İptal Et";
            // 
            // dgwSeferler
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgwSeferler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgwSeferler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwSeferler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgwSeferler.ColumnHeadersHeight = 25;
            this.dgwSeferler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwSeferler.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgwSeferler.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgwSeferler.Location = new System.Drawing.Point(7, 100);
            this.dgwSeferler.Name = "dgwSeferler";
            this.dgwSeferler.RowHeadersVisible = false;
            this.dgwSeferler.Size = new System.Drawing.Size(1080, 468);
            this.dgwSeferler.TabIndex = 4;
            this.dgwSeferler.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgwSeferler.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgwSeferler.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgwSeferler.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgwSeferler.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgwSeferler.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.dgwSeferler.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgwSeferler.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgwSeferler.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwSeferler.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgwSeferler.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgwSeferler.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgwSeferler.ThemeStyle.HeaderStyle.Height = 25;
            this.dgwSeferler.ThemeStyle.ReadOnly = false;
            this.dgwSeferler.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgwSeferler.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgwSeferler.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgwSeferler.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgwSeferler.ThemeStyle.RowsStyle.Height = 22;
            this.dgwSeferler.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgwSeferler.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2HtmlLabel34
            // 
            this.guna2HtmlLabel34.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel34.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel34.Location = new System.Drawing.Point(313, 49);
            this.guna2HtmlLabel34.Name = "guna2HtmlLabel34";
            this.guna2HtmlLabel34.Size = new System.Drawing.Size(440, 39);
            this.guna2HtmlLabel34.TabIndex = 3;
            this.guna2HtmlLabel34.Text = "Lütfen İptal Edilecek Seferi Seçiniz";
            // 
            // SeferIptalEt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 875);
            this.Controls.Add(this.panel43);
            this.Controls.Add(this.dgwSeferler);
            this.Controls.Add(this.guna2HtmlLabel34);
            this.Name = "SeferIptalEt";
            this.Text = "SeferSil";
            this.Load += new System.EventHandler(this.SeferIptalEt_Load);
            this.panel43.ResumeLayout(false);
            this.panel43.PerformLayout();
            this.panel44.ResumeLayout(false);
            this.panel44.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSeferler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer BiletTimer;
        private System.Windows.Forms.Timer RezervasyonTimer;
        private System.Windows.Forms.Timer KullaniciTimer;
        private System.Windows.Forms.Timer ZamanTimer;
        private System.Windows.Forms.Timer SeferTimer;
        private System.Windows.Forms.Timer SidebarTimer;
        private System.Windows.Forms.Panel panel43;
        private Guna.UI2.WinForms.Guna2Button btnSeferIptalEt;
        private Guna.UI2.WinForms.Guna2TextBox txtSeferId;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel36;
        private System.Windows.Forms.Panel panel44;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel35;
        private Guna.UI2.WinForms.Guna2DataGridView dgwSeferler;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel34;
    }
}