namespace Otobus_Otomasyon
{
    partial class SeferEkle
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
            this.SidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.SeferTimer = new System.Windows.Forms.Timer(this.components);
            this.RezervasyonTimer = new System.Windows.Forms.Timer(this.components);
            this.KullaniciTimer = new System.Windows.Forms.Timer(this.components);
            this.ZamanTimer = new System.Windows.Forms.Timer(this.components);
            this.BiletTimer = new System.Windows.Forms.Timer(this.components);
            this.dgwSeferler = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel27 = new System.Windows.Forms.Panel();
            this.dtpVarisTarihi = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSeferEkle = new Guna.UI2.WinForms.Guna2Button();
            this.dtpKalkisTarihi = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel24 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel23 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel22 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel21 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel20 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel19 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel18 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbSeferDurumu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbOtobusTipi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbSeferNereye = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbSeferNereden = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel36 = new System.Windows.Forms.Panel();
            this.panel35 = new System.Windows.Forms.Panel();
            this.panel34 = new System.Windows.Forms.Panel();
            this.panel33 = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel16 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.mskKalkisSaati = new Guna.UI2.WinForms.Guna2TextBox();
            this.mskVarisSaati = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSeferler)).BeginInit();
            this.panel27.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidebarTimer
            // 
            this.SidebarTimer.Enabled = true;
            this.SidebarTimer.Interval = 10;
            // 
            // SeferTimer
            // 
            this.SeferTimer.Enabled = true;
            this.SeferTimer.Interval = 10;
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
            // BiletTimer
            // 
            this.BiletTimer.Enabled = true;
            this.BiletTimer.Interval = 10;
            // 
            // dgwSeferler
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgwSeferler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgwSeferler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwSeferler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgwSeferler.ColumnHeadersHeight = 35;
            this.dgwSeferler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwSeferler.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgwSeferler.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgwSeferler.Location = new System.Drawing.Point(559, 60);
            this.dgwSeferler.Name = "dgwSeferler";
            this.dgwSeferler.RowHeadersVisible = false;
            this.dgwSeferler.RowTemplate.Height = 30;
            this.dgwSeferler.Size = new System.Drawing.Size(515, 672);
            this.dgwSeferler.TabIndex = 5;
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
            // panel27
            // 
            this.panel27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel27.Controls.Add(this.mskVarisSaati);
            this.panel27.Controls.Add(this.mskKalkisSaati);
            this.panel27.Controls.Add(this.dtpVarisTarihi);
            this.panel27.Controls.Add(this.guna2HtmlLabel1);
            this.panel27.Controls.Add(this.btnSeferEkle);
            this.panel27.Controls.Add(this.dtpKalkisTarihi);
            this.panel27.Controls.Add(this.guna2HtmlLabel24);
            this.panel27.Controls.Add(this.guna2HtmlLabel23);
            this.panel27.Controls.Add(this.guna2HtmlLabel22);
            this.panel27.Controls.Add(this.guna2HtmlLabel21);
            this.panel27.Controls.Add(this.guna2HtmlLabel20);
            this.panel27.Controls.Add(this.guna2HtmlLabel19);
            this.panel27.Controls.Add(this.guna2HtmlLabel18);
            this.panel27.Controls.Add(this.cmbSeferDurumu);
            this.panel27.Controls.Add(this.cmbOtobusTipi);
            this.panel27.Controls.Add(this.cmbSeferNereye);
            this.panel27.Controls.Add(this.cmbSeferNereden);
            this.panel27.Controls.Add(this.panel36);
            this.panel27.Controls.Add(this.panel35);
            this.panel27.Controls.Add(this.panel34);
            this.panel27.Controls.Add(this.panel33);
            this.panel27.Location = new System.Drawing.Point(21, 60);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(509, 672);
            this.panel27.TabIndex = 4;
            // 
            // dtpVarisTarihi
            // 
            this.dtpVarisTarihi.Checked = true;
            this.dtpVarisTarihi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtpVarisTarihi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dtpVarisTarihi.ForeColor = System.Drawing.Color.Black;
            this.dtpVarisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpVarisTarihi.Location = new System.Drawing.Point(242, 485);
            this.dtpVarisTarihi.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpVarisTarihi.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpVarisTarihi.Name = "dtpVarisTarihi";
            this.dtpVarisTarihi.Size = new System.Drawing.Size(234, 36);
            this.dtpVarisTarihi.TabIndex = 32;
            this.dtpVarisTarihi.Value = new System.DateTime(2024, 12, 20, 21, 25, 36, 257);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(44, 488);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(197, 33);
            this.guna2HtmlLabel1.TabIndex = 31;
            this.guna2HtmlLabel1.Text = "Sefer Varış Tarihi :";
            // 
            // btnSeferEkle
            // 
            this.btnSeferEkle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSeferEkle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSeferEkle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSeferEkle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSeferEkle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnSeferEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeferEkle.ForeColor = System.Drawing.Color.White;
            this.btnSeferEkle.Location = new System.Drawing.Point(296, 557);
            this.btnSeferEkle.Name = "btnSeferEkle";
            this.btnSeferEkle.Size = new System.Drawing.Size(180, 45);
            this.btnSeferEkle.TabIndex = 21;
            this.btnSeferEkle.Text = "Ekle";
            this.btnSeferEkle.Click += new System.EventHandler(this.btnSeferEkle_Click);
            // 
            // dtpKalkisTarihi
            // 
            this.dtpKalkisTarihi.Checked = true;
            this.dtpKalkisTarihi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtpKalkisTarihi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dtpKalkisTarihi.ForeColor = System.Drawing.Color.Black;
            this.dtpKalkisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpKalkisTarihi.Location = new System.Drawing.Point(242, 439);
            this.dtpKalkisTarihi.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpKalkisTarihi.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpKalkisTarihi.Name = "dtpKalkisTarihi";
            this.dtpKalkisTarihi.Size = new System.Drawing.Size(234, 36);
            this.dtpKalkisTarihi.TabIndex = 20;
            this.dtpKalkisTarihi.Value = new System.DateTime(2024, 12, 20, 21, 25, 36, 257);
            // 
            // guna2HtmlLabel24
            // 
            this.guna2HtmlLabel24.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel24.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel24.Location = new System.Drawing.Point(33, 442);
            this.guna2HtmlLabel24.Name = "guna2HtmlLabel24";
            this.guna2HtmlLabel24.Size = new System.Drawing.Size(208, 33);
            this.guna2HtmlLabel24.TabIndex = 19;
            this.guna2HtmlLabel24.Text = "Sefer Kalkış Tarihi :";
            // 
            // guna2HtmlLabel23
            // 
            this.guna2HtmlLabel23.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel23.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel23.Location = new System.Drawing.Point(76, 389);
            this.guna2HtmlLabel23.Name = "guna2HtmlLabel23";
            this.guna2HtmlLabel23.Size = new System.Drawing.Size(165, 33);
            this.guna2HtmlLabel23.TabIndex = 17;
            this.guna2HtmlLabel23.Text = "Sefer Durumu : ";
            // 
            // guna2HtmlLabel22
            // 
            this.guna2HtmlLabel22.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel22.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel22.Location = new System.Drawing.Point(67, 339);
            this.guna2HtmlLabel22.Name = "guna2HtmlLabel22";
            this.guna2HtmlLabel22.Size = new System.Drawing.Size(174, 33);
            this.guna2HtmlLabel22.TabIndex = 16;
            this.guna2HtmlLabel22.Text = "Otobüs Plakası :";
            // 
            // guna2HtmlLabel21
            // 
            this.guna2HtmlLabel21.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel21.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel21.Location = new System.Drawing.Point(114, 289);
            this.guna2HtmlLabel21.Name = "guna2HtmlLabel21";
            this.guna2HtmlLabel21.Size = new System.Drawing.Size(127, 33);
            this.guna2HtmlLabel21.TabIndex = 15;
            this.guna2HtmlLabel21.Text = "Varış Saati :";
            // 
            // guna2HtmlLabel20
            // 
            this.guna2HtmlLabel20.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel20.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel20.Location = new System.Drawing.Point(103, 239);
            this.guna2HtmlLabel20.Name = "guna2HtmlLabel20";
            this.guna2HtmlLabel20.Size = new System.Drawing.Size(138, 33);
            this.guna2HtmlLabel20.TabIndex = 14;
            this.guna2HtmlLabel20.Text = "Kalkış Saati :";
            // 
            // guna2HtmlLabel19
            // 
            this.guna2HtmlLabel19.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel19.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel19.Location = new System.Drawing.Point(151, 189);
            this.guna2HtmlLabel19.Name = "guna2HtmlLabel19";
            this.guna2HtmlLabel19.Size = new System.Drawing.Size(90, 33);
            this.guna2HtmlLabel19.TabIndex = 13;
            this.guna2HtmlLabel19.Text = "Nereye :";
            // 
            // guna2HtmlLabel18
            // 
            this.guna2HtmlLabel18.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel18.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel18.Location = new System.Drawing.Point(135, 139);
            this.guna2HtmlLabel18.Name = "guna2HtmlLabel18";
            this.guna2HtmlLabel18.Size = new System.Drawing.Size(106, 33);
            this.guna2HtmlLabel18.TabIndex = 12;
            this.guna2HtmlLabel18.Text = "Nereden :";
            // 
            // cmbSeferDurumu
            // 
            this.cmbSeferDurumu.BackColor = System.Drawing.Color.Transparent;
            this.cmbSeferDurumu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSeferDurumu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeferDurumu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSeferDurumu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSeferDurumu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSeferDurumu.ForeColor = System.Drawing.Color.Black;
            this.cmbSeferDurumu.ItemHeight = 30;
            this.cmbSeferDurumu.Items.AddRange(new object[] {
            "Aktif\t",
            "Pasif"});
            this.cmbSeferDurumu.Location = new System.Drawing.Point(242, 389);
            this.cmbSeferDurumu.Name = "cmbSeferDurumu";
            this.cmbSeferDurumu.Size = new System.Drawing.Size(238, 36);
            this.cmbSeferDurumu.TabIndex = 10;
            // 
            // cmbOtobusTipi
            // 
            this.cmbOtobusTipi.BackColor = System.Drawing.Color.Transparent;
            this.cmbOtobusTipi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbOtobusTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOtobusTipi.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbOtobusTipi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbOtobusTipi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOtobusTipi.ForeColor = System.Drawing.Color.Black;
            this.cmbOtobusTipi.ItemHeight = 30;
            this.cmbOtobusTipi.Location = new System.Drawing.Point(242, 339);
            this.cmbOtobusTipi.Name = "cmbOtobusTipi";
            this.cmbOtobusTipi.Size = new System.Drawing.Size(238, 36);
            this.cmbOtobusTipi.TabIndex = 9;
            // 
            // cmbSeferNereye
            // 
            this.cmbSeferNereye.BackColor = System.Drawing.Color.Transparent;
            this.cmbSeferNereye.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSeferNereye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeferNereye.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSeferNereye.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSeferNereye.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSeferNereye.ForeColor = System.Drawing.Color.Black;
            this.cmbSeferNereye.ItemHeight = 30;
            this.cmbSeferNereye.Location = new System.Drawing.Point(242, 189);
            this.cmbSeferNereye.Name = "cmbSeferNereye";
            this.cmbSeferNereye.Size = new System.Drawing.Size(238, 36);
            this.cmbSeferNereye.TabIndex = 6;
            // 
            // cmbSeferNereden
            // 
            this.cmbSeferNereden.BackColor = System.Drawing.Color.Transparent;
            this.cmbSeferNereden.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSeferNereden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeferNereden.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSeferNereden.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSeferNereden.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSeferNereden.ForeColor = System.Drawing.Color.Black;
            this.cmbSeferNereden.ItemHeight = 30;
            this.cmbSeferNereden.Location = new System.Drawing.Point(242, 139);
            this.cmbSeferNereden.Name = "cmbSeferNereden";
            this.cmbSeferNereden.Size = new System.Drawing.Size(238, 36);
            this.cmbSeferNereden.TabIndex = 5;
            // 
            // panel36
            // 
            this.panel36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel36.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel36.Location = new System.Drawing.Point(1, 671);
            this.panel36.Name = "panel36";
            this.panel36.Size = new System.Drawing.Size(507, 1);
            this.panel36.TabIndex = 3;
            // 
            // panel35
            // 
            this.panel35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel35.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel35.Location = new System.Drawing.Point(508, 55);
            this.panel35.Name = "panel35";
            this.panel35.Size = new System.Drawing.Size(1, 617);
            this.panel35.TabIndex = 2;
            // 
            // panel34
            // 
            this.panel34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel34.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel34.Location = new System.Drawing.Point(0, 55);
            this.panel34.Name = "panel34";
            this.panel34.Size = new System.Drawing.Size(1, 617);
            this.panel34.TabIndex = 1;
            // 
            // panel33
            // 
            this.panel33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel33.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel33.Location = new System.Drawing.Point(0, 0);
            this.panel33.Name = "panel33";
            this.panel33.Size = new System.Drawing.Size(509, 55);
            this.panel33.TabIndex = 0;
            // 
            // guna2HtmlLabel16
            // 
            this.guna2HtmlLabel16.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel16.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel16.Location = new System.Drawing.Point(481, 1);
            this.guna2HtmlLabel16.Name = "guna2HtmlLabel16";
            this.guna2HtmlLabel16.Size = new System.Drawing.Size(128, 39);
            this.guna2HtmlLabel16.TabIndex = 3;
            this.guna2HtmlLabel16.Text = "Sefer Ekle";
            // 
            // mskKalkisSaati
            // 
            this.mskKalkisSaati.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mskKalkisSaati.DefaultText = "";
            this.mskKalkisSaati.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mskKalkisSaati.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mskKalkisSaati.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mskKalkisSaati.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mskKalkisSaati.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mskKalkisSaati.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskKalkisSaati.ForeColor = System.Drawing.Color.Black;
            this.mskKalkisSaati.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mskKalkisSaati.Location = new System.Drawing.Point(242, 239);
            this.mskKalkisSaati.Margin = new System.Windows.Forms.Padding(6);
            this.mskKalkisSaati.MaxLength = 11;
            this.mskKalkisSaati.Name = "mskKalkisSaati";
            this.mskKalkisSaati.PasswordChar = '\0';
            this.mskKalkisSaati.PlaceholderText = "";
            this.mskKalkisSaati.SelectedText = "";
            this.mskKalkisSaati.Size = new System.Drawing.Size(238, 36);
            this.mskKalkisSaati.TabIndex = 33;
            this.mskKalkisSaati.TextChanged += new System.EventHandler(this.txtSaat_TextChanged);
            // 
            // mskVarisSaati
            // 
            this.mskVarisSaati.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mskVarisSaati.DefaultText = "";
            this.mskVarisSaati.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mskVarisSaati.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mskVarisSaati.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mskVarisSaati.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mskVarisSaati.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mskVarisSaati.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskVarisSaati.ForeColor = System.Drawing.Color.Black;
            this.mskVarisSaati.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mskVarisSaati.Location = new System.Drawing.Point(242, 289);
            this.mskVarisSaati.Margin = new System.Windows.Forms.Padding(6);
            this.mskVarisSaati.MaxLength = 11;
            this.mskVarisSaati.Name = "mskVarisSaati";
            this.mskVarisSaati.PasswordChar = '\0';
            this.mskVarisSaati.PlaceholderText = "";
            this.mskVarisSaati.SelectedText = "";
            this.mskVarisSaati.Size = new System.Drawing.Size(238, 36);
            this.mskVarisSaati.TabIndex = 34;
            this.mskVarisSaati.TextChanged += new System.EventHandler(this.txtSaat_TextChanged_1);
            // 
            // SeferEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 875);
            this.Controls.Add(this.dgwSeferler);
            this.Controls.Add(this.panel27);
            this.Controls.Add(this.guna2HtmlLabel16);
            this.Name = "SeferEkle";
            this.Text = "SeferEkle";
            this.Load += new System.EventHandler(this.SeferEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSeferler)).EndInit();
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer SidebarTimer;
        private System.Windows.Forms.Timer SeferTimer;
        private System.Windows.Forms.Timer RezervasyonTimer;
        private System.Windows.Forms.Timer KullaniciTimer;
        private System.Windows.Forms.Timer ZamanTimer;
        private System.Windows.Forms.Timer BiletTimer;
        private Guna.UI2.WinForms.Guna2DataGridView dgwSeferler;
        private System.Windows.Forms.Panel panel27;
        private Guna.UI2.WinForms.Guna2Button btnSeferEkle;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpKalkisTarihi;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel24;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel23;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel22;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel21;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel20;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel19;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel18;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSeferDurumu;
        private Guna.UI2.WinForms.Guna2ComboBox cmbOtobusTipi;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSeferNereye;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSeferNereden;
        private System.Windows.Forms.Panel panel36;
        private System.Windows.Forms.Panel panel35;
        private System.Windows.Forms.Panel panel34;
        private System.Windows.Forms.Panel panel33;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel16;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpVarisTarihi;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox mskKalkisSaati;
        private Guna.UI2.WinForms.Guna2TextBox mskVarisSaati;
    }
}