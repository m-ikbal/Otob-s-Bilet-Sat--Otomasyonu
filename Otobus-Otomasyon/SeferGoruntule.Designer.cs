namespace Otobus_Otomasyon
{
    partial class SeferGoruntule
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
            this.dgwSeferler = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2HtmlLabel37 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSeferNumarasi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSeferTarihi = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSeferSifirla = new Guna.UI2.WinForms.Guna2Button();
            this.cmbSeferDurumu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.chkBoxSeferDurumu = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkBoxSeferSaati = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkBoxSeferNumarasi = new Guna.UI2.WinForms.Guna2CheckBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnSeferListesi = new Guna.UI2.WinForms.Guna2Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSeferler)).BeginInit();
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
            // dgwSeferler
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgwSeferler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwSeferler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwSeferler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwSeferler.ColumnHeadersHeight = 35;
            this.dgwSeferler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwSeferler.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgwSeferler.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgwSeferler.Location = new System.Drawing.Point(12, 54);
            this.dgwSeferler.Name = "dgwSeferler";
            this.dgwSeferler.RowHeadersVisible = false;
            this.dgwSeferler.RowTemplate.Height = 30;
            this.dgwSeferler.Size = new System.Drawing.Size(1070, 599);
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
            this.dgwSeferler.ThemeStyle.HeaderStyle.Height = 35;
            this.dgwSeferler.ThemeStyle.ReadOnly = false;
            this.dgwSeferler.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgwSeferler.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgwSeferler.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgwSeferler.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgwSeferler.ThemeStyle.RowsStyle.Height = 30;
            this.dgwSeferler.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgwSeferler.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2HtmlLabel37
            // 
            this.guna2HtmlLabel37.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel37.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel37.Location = new System.Drawing.Point(444, 10);
            this.guna2HtmlLabel37.Name = "guna2HtmlLabel37";
            this.guna2HtmlLabel37.Size = new System.Drawing.Size(211, 39);
            this.guna2HtmlLabel37.TabIndex = 3;
            this.guna2HtmlLabel37.Text = "Seferler Tablosu";
            // 
            // txtSeferNumarasi
            // 
            this.txtSeferNumarasi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSeferNumarasi.DefaultText = "";
            this.txtSeferNumarasi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSeferNumarasi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSeferNumarasi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSeferNumarasi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSeferNumarasi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSeferNumarasi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeferNumarasi.ForeColor = System.Drawing.Color.Black;
            this.txtSeferNumarasi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSeferNumarasi.Location = new System.Drawing.Point(193, 72);
            this.txtSeferNumarasi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSeferNumarasi.MaxLength = 11;
            this.txtSeferNumarasi.Name = "txtSeferNumarasi";
            this.txtSeferNumarasi.PasswordChar = '\0';
            this.txtSeferNumarasi.PlaceholderText = "";
            this.txtSeferNumarasi.SelectedText = "";
            this.txtSeferNumarasi.Size = new System.Drawing.Size(200, 36);
            this.txtSeferNumarasi.TabIndex = 11;
            // 
            // txtSeferTarihi
            // 
            this.txtSeferTarihi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSeferTarihi.DefaultText = "";
            this.txtSeferTarihi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSeferTarihi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSeferTarihi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSeferTarihi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSeferTarihi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSeferTarihi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeferTarihi.ForeColor = System.Drawing.Color.Black;
            this.txtSeferTarihi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSeferTarihi.Location = new System.Drawing.Point(193, 137);
            this.txtSeferTarihi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSeferTarihi.Name = "txtSeferTarihi";
            this.txtSeferTarihi.PasswordChar = '\0';
            this.txtSeferTarihi.PlaceholderText = "";
            this.txtSeferTarihi.SelectedText = "";
            this.txtSeferTarihi.Size = new System.Drawing.Size(200, 36);
            this.txtSeferTarihi.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSeferSifirla);
            this.panel1.Controls.Add(this.cmbSeferDurumu);
            this.panel1.Controls.Add(this.chkBoxSeferDurumu);
            this.panel1.Controls.Add(this.chkBoxSeferSaati);
            this.panel1.Controls.Add(this.chkBoxSeferNumarasi);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.btnSeferListesi);
            this.panel1.Controls.Add(this.txtSeferTarihi);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtSeferNumarasi);
            this.panel1.Location = new System.Drawing.Point(146, 666);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 221);
            this.panel1.TabIndex = 30;
            // 
            // btnSeferSifirla
            // 
            this.btnSeferSifirla.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSeferSifirla.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSeferSifirla.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSeferSifirla.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSeferSifirla.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnSeferSifirla.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeferSifirla.ForeColor = System.Drawing.Color.White;
            this.btnSeferSifirla.Location = new System.Drawing.Point(625, 126);
            this.btnSeferSifirla.Name = "btnSeferSifirla";
            this.btnSeferSifirla.Size = new System.Drawing.Size(167, 67);
            this.btnSeferSifirla.TabIndex = 22;
            this.btnSeferSifirla.Text = "Sıfırla";
            this.btnSeferSifirla.Click += new System.EventHandler(this.btnSeferSifirla_Click);
            // 
            // cmbSeferDurumu
            // 
            this.cmbSeferDurumu.BackColor = System.Drawing.Color.Transparent;
            this.cmbSeferDurumu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSeferDurumu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeferDurumu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSeferDurumu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSeferDurumu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSeferDurumu.ForeColor = System.Drawing.Color.Black;
            this.cmbSeferDurumu.ItemHeight = 30;
            this.cmbSeferDurumu.Items.AddRange(new object[] {
            "Aktif",
            "İptal Edildi"});
            this.cmbSeferDurumu.Location = new System.Drawing.Point(582, 69);
            this.cmbSeferDurumu.Name = "cmbSeferDurumu";
            this.cmbSeferDurumu.Size = new System.Drawing.Size(210, 36);
            this.cmbSeferDurumu.TabIndex = 21;
            // 
            // chkBoxSeferDurumu
            // 
            this.chkBoxSeferDurumu.AutoSize = true;
            this.chkBoxSeferDurumu.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkBoxSeferDurumu.CheckedState.BorderRadius = 0;
            this.chkBoxSeferDurumu.CheckedState.BorderThickness = 0;
            this.chkBoxSeferDurumu.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkBoxSeferDurumu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkBoxSeferDurumu.Location = new System.Drawing.Point(409, 76);
            this.chkBoxSeferDurumu.Name = "chkBoxSeferDurumu";
            this.chkBoxSeferDurumu.Size = new System.Drawing.Size(167, 29);
            this.chkBoxSeferDurumu.TabIndex = 20;
            this.chkBoxSeferDurumu.Text = "Sefer Durumu :";
            this.chkBoxSeferDurumu.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkBoxSeferDurumu.UncheckedState.BorderRadius = 0;
            this.chkBoxSeferDurumu.UncheckedState.BorderThickness = 0;
            this.chkBoxSeferDurumu.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // chkBoxSeferSaati
            // 
            this.chkBoxSeferSaati.AutoSize = true;
            this.chkBoxSeferSaati.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkBoxSeferSaati.CheckedState.BorderRadius = 0;
            this.chkBoxSeferSaati.CheckedState.BorderThickness = 0;
            this.chkBoxSeferSaati.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkBoxSeferSaati.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkBoxSeferSaati.Location = new System.Drawing.Point(52, 137);
            this.chkBoxSeferSaati.Name = "chkBoxSeferSaati";
            this.chkBoxSeferSaati.Size = new System.Drawing.Size(140, 29);
            this.chkBoxSeferSaati.TabIndex = 19;
            this.chkBoxSeferSaati.Text = "Sefer Tarihi :";
            this.chkBoxSeferSaati.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkBoxSeferSaati.UncheckedState.BorderRadius = 0;
            this.chkBoxSeferSaati.UncheckedState.BorderThickness = 0;
            this.chkBoxSeferSaati.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // chkBoxSeferNumarasi
            // 
            this.chkBoxSeferNumarasi.AutoSize = true;
            this.chkBoxSeferNumarasi.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkBoxSeferNumarasi.CheckedState.BorderRadius = 0;
            this.chkBoxSeferNumarasi.CheckedState.BorderThickness = 0;
            this.chkBoxSeferNumarasi.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkBoxSeferNumarasi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkBoxSeferNumarasi.Location = new System.Drawing.Point(10, 76);
            this.chkBoxSeferNumarasi.Name = "chkBoxSeferNumarasi";
            this.chkBoxSeferNumarasi.Size = new System.Drawing.Size(177, 29);
            this.chkBoxSeferNumarasi.TabIndex = 18;
            this.chkBoxSeferNumarasi.Text = "Sefer Numarası :";
            this.chkBoxSeferNumarasi.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkBoxSeferNumarasi.UncheckedState.BorderRadius = 0;
            this.chkBoxSeferNumarasi.UncheckedState.BorderThickness = 0;
            this.chkBoxSeferNumarasi.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(1, 220);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(797, 1);
            this.panel9.TabIndex = 3;
            // 
            // btnSeferListesi
            // 
            this.btnSeferListesi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSeferListesi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSeferListesi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSeferListesi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSeferListesi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnSeferListesi.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeferListesi.ForeColor = System.Drawing.Color.White;
            this.btnSeferListesi.Location = new System.Drawing.Point(452, 126);
            this.btnSeferListesi.Name = "btnSeferListesi";
            this.btnSeferListesi.Size = new System.Drawing.Size(167, 67);
            this.btnSeferListesi.TabIndex = 17;
            this.btnSeferListesi.Text = "Listele";
            this.btnSeferListesi.Click += new System.EventHandler(this.btnSeferListesi_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(798, 53);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1, 168);
            this.panel7.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 53);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 168);
            this.panel5.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel3.Controls.Add(this.guna2HtmlLabel12);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(799, 53);
            this.panel3.TabIndex = 0;
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel12.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(339, 13);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(121, 27);
            this.guna2HtmlLabel12.TabIndex = 0;
            this.guna2HtmlLabel12.Text = "Sefer Bilgileri";
            // 
            // SeferGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 914);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgwSeferler);
            this.Controls.Add(this.guna2HtmlLabel37);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeferGoruntule";
            this.Text = "SeferGoruntule";
            this.Load += new System.EventHandler(this.SeferGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSeferler)).EndInit();
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
        private Guna.UI2.WinForms.Guna2DataGridView dgwSeferler;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel37;
        private Guna.UI2.WinForms.Guna2TextBox txtSeferNumarasi;
        private Guna.UI2.WinForms.Guna2TextBox txtSeferTarihi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel9;
        private Guna.UI2.WinForms.Guna2Button btnSeferListesi;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private Guna.UI2.WinForms.Guna2CheckBox chkBoxSeferSaati;
        private Guna.UI2.WinForms.Guna2CheckBox chkBoxSeferNumarasi;
        private Guna.UI2.WinForms.Guna2CheckBox chkBoxSeferDurumu;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSeferDurumu;
        private Guna.UI2.WinForms.Guna2Button btnSeferSifirla;
    }
}