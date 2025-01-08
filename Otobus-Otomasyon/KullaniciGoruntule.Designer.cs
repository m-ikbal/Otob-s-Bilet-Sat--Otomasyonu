namespace Otobus_Otomasyon
{
    partial class KullaniciGoruntule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ZamanTimer = new System.Windows.Forms.Timer(this.components);
            this.RezervasyonTimer = new System.Windows.Forms.Timer(this.components);
            this.KullaniciTimer = new System.Windows.Forms.Timer(this.components);
            this.SeferTimer = new System.Windows.Forms.Timer(this.components);
            this.SidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.BiletTimer = new System.Windows.Forms.Timer(this.components);
            this.dgwKullanicilar = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2HtmlLabel37 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtAdSoyad = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnKullaniciAra = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSifirla = new Guna.UI2.WinForms.Guna2Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKullanicilar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            // BiletTimer
            // 
            this.BiletTimer.Enabled = true;
            this.BiletTimer.Interval = 10;
            // 
            // dgwKullanicilar
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgwKullanicilar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwKullanicilar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwKullanicilar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwKullanicilar.ColumnHeadersHeight = 35;
            this.dgwKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwKullanicilar.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgwKullanicilar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgwKullanicilar.Location = new System.Drawing.Point(12, 73);
            this.dgwKullanicilar.Name = "dgwKullanicilar";
            this.dgwKullanicilar.RowHeadersVisible = false;
            this.dgwKullanicilar.RowTemplate.Height = 30;
            this.dgwKullanicilar.Size = new System.Drawing.Size(1070, 520);
            this.dgwKullanicilar.TabIndex = 7;
            this.dgwKullanicilar.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgwKullanicilar.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgwKullanicilar.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgwKullanicilar.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgwKullanicilar.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgwKullanicilar.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.dgwKullanicilar.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgwKullanicilar.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgwKullanicilar.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwKullanicilar.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgwKullanicilar.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgwKullanicilar.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgwKullanicilar.ThemeStyle.HeaderStyle.Height = 35;
            this.dgwKullanicilar.ThemeStyle.ReadOnly = false;
            this.dgwKullanicilar.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgwKullanicilar.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgwKullanicilar.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgwKullanicilar.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgwKullanicilar.ThemeStyle.RowsStyle.Height = 30;
            this.dgwKullanicilar.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgwKullanicilar.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2HtmlLabel37
            // 
            this.guna2HtmlLabel37.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel37.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel37.Location = new System.Drawing.Point(447, 30);
            this.guna2HtmlLabel37.Name = "guna2HtmlLabel37";
            this.guna2HtmlLabel37.Size = new System.Drawing.Size(200, 39);
            this.guna2HtmlLabel37.TabIndex = 6;
            this.guna2HtmlLabel37.Text = "Kullanıcı Listesi";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(25, 79);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(181, 27);
            this.guna2HtmlLabel5.TabIndex = 19;
            this.guna2HtmlLabel5.Text = "Kullanıcı Ad-Soyad :";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdSoyad.DefaultText = "";
            this.txtAdSoyad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAdSoyad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAdSoyad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdSoyad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdSoyad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdSoyad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdSoyad.ForeColor = System.Drawing.Color.Black;
            this.txtAdSoyad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdSoyad.Location = new System.Drawing.Point(212, 79);
            this.txtAdSoyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.PasswordChar = '\0';
            this.txtAdSoyad.PlaceholderText = "";
            this.txtAdSoyad.SelectedText = "";
            this.txtAdSoyad.Size = new System.Drawing.Size(200, 36);
            this.txtAdSoyad.TabIndex = 18;
            // 
            // btnKullaniciAra
            // 
            this.btnKullaniciAra.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKullaniciAra.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKullaniciAra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKullaniciAra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKullaniciAra.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnKullaniciAra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKullaniciAra.ForeColor = System.Drawing.Color.White;
            this.btnKullaniciAra.Location = new System.Drawing.Point(439, 59);
            this.btnKullaniciAra.Name = "btnKullaniciAra";
            this.btnKullaniciAra.Size = new System.Drawing.Size(106, 75);
            this.btnKullaniciAra.TabIndex = 17;
            this.btnKullaniciAra.Text = "Ara";
            this.btnKullaniciAra.Click += new System.EventHandler(this.btnKullaniciAra_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSifirla);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.btnKullaniciAra);
            this.panel1.Controls.Add(this.guna2HtmlLabel5);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.txtAdSoyad);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(244, 613);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 141);
            this.panel1.TabIndex = 29;
            // 
            // btnSifirla
            // 
            this.btnSifirla.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSifirla.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSifirla.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSifirla.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSifirla.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnSifirla.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSifirla.ForeColor = System.Drawing.Color.White;
            this.btnSifirla.Location = new System.Drawing.Point(551, 59);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(106, 75);
            this.btnSifirla.TabIndex = 20;
            this.btnSifirla.Text = "Yenile";
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(1, 140);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(663, 1);
            this.panel9.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(664, 53);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1, 88);
            this.panel7.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 53);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 88);
            this.panel5.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel3.Controls.Add(this.guna2HtmlLabel12);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(665, 53);
            this.panel3.TabIndex = 0;
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel12.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(262, 12);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(150, 27);
            this.guna2HtmlLabel12.TabIndex = 0;
            this.guna2HtmlLabel12.Text = "Kullanıcı Bilgileri";
            // 
            // KullaniciGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 875);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgwKullanicilar);
            this.Controls.Add(this.guna2HtmlLabel37);
            this.Name = "KullaniciGoruntule";
            this.Text = "KullaniciGoruntule";
            this.Load += new System.EventHandler(this.KullaniciGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKullanicilar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer ZamanTimer;
        private System.Windows.Forms.Timer RezervasyonTimer;
        private System.Windows.Forms.Timer KullaniciTimer;
        private System.Windows.Forms.Timer SeferTimer;
        private System.Windows.Forms.Timer SidebarTimer;
        private System.Windows.Forms.Timer BiletTimer;
        private Guna.UI2.WinForms.Guna2DataGridView dgwKullanicilar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel37;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox txtAdSoyad;
        private Guna.UI2.WinForms.Guna2Button btnKullaniciAra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private Guna.UI2.WinForms.Guna2Button btnSifirla;
    }
}