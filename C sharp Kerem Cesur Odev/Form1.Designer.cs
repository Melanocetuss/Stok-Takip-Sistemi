namespace C_sharp_Kerem_Cesur_Odev
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblUrunTuru = new System.Windows.Forms.Label();
            this.cbxUrununTuru = new System.Windows.Forms.ComboBox();
            this.lblMarka = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblDurumu = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.pnlUrunEkle = new System.Windows.Forms.Panel();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtKarMarji = new System.Windows.Forms.TextBox();
            this.lblKarMarjı = new System.Windows.Forms.Label();
            this.cbxDurumu = new System.Windows.Forms.ComboBox();
            this.lblUrunEkle = new System.Windows.Forms.Label();
            this.pnlAraSil = new System.Windows.Forms.Panel();
            this.lblAraSil = new System.Windows.Forms.Label();
            this.txtModelAra = new System.Windows.Forms.TextBox();
            this.btnSil1 = new System.Windows.Forms.Button();
            this.lblModelAra = new System.Windows.Forms.Label();
            this._Kerem_Cesur_C_DataSet = new C_sharp_Kerem_Cesur_Odev._Kerem_Cesur_C_DataSet();
            this.tbcUrunIslemleri = new System.Windows.Forms.TabControl();
            this.tbcUrunEkle = new System.Windows.Forms.TabPage();
            this.tbcUrunSil = new System.Windows.Forms.TabPage();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.tbcGridviews = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvToplamUrunSayisi = new System.Windows.Forms.DataGridView();
            this.pnlUrunEkle.SuspendLayout();
            this.pnlAraSil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Kerem_Cesur_C_DataSet)).BeginInit();
            this.tbcUrunIslemleri.SuspendLayout();
            this.tbcUrunEkle.SuspendLayout();
            this.tbcUrunSil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.tbcGridviews.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToplamUrunSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUrunTuru
            // 
            this.lblUrunTuru.AutoSize = true;
            this.lblUrunTuru.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrunTuru.Location = new System.Drawing.Point(27, 60);
            this.lblUrunTuru.Name = "lblUrunTuru";
            this.lblUrunTuru.Size = new System.Drawing.Size(144, 24);
            this.lblUrunTuru.TabIndex = 0;
            this.lblUrunTuru.Text = "Ürünün Türü:";
            // 
            // cbxUrununTuru
            // 
            this.cbxUrununTuru.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cbxUrununTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUrununTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUrununTuru.FormattingEnabled = true;
            this.cbxUrununTuru.Items.AddRange(new object[] {
            "Bilgisayar",
            "Monitör",
            "Kulaklık",
            "Mouse ",
            "Klavye"});
            this.cbxUrununTuru.Location = new System.Drawing.Point(208, 56);
            this.cbxUrununTuru.Name = "cbxUrununTuru";
            this.cbxUrununTuru.Size = new System.Drawing.Size(269, 28);
            this.cbxUrununTuru.TabIndex = 6;
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarka.Location = new System.Drawing.Point(28, 107);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(144, 24);
            this.lblMarka.TabIndex = 2;
            this.lblMarka.Text = "Marka Model:";
            // 
            // txtMarka
            // 
            this.txtMarka.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarka.Location = new System.Drawing.Point(208, 107);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(269, 26);
            this.txtMarka.TabIndex = 7;
            this.txtMarka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarka_KeyPress);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(28, 155);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(125, 24);
            this.lblModel.TabIndex = 4;
            this.lblModel.Text = "Ürün Kodu:";
            // 
            // txtModel
            // 
            this.txtModel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(208, 153);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(269, 26);
            this.txtModel.TabIndex = 8;
            this.txtModel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModel_KeyPress);
            // 
            // lblDurumu
            // 
            this.lblDurumu.AutoSize = true;
            this.lblDurumu.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurumu.Location = new System.Drawing.Point(27, 204);
            this.lblDurumu.Name = "lblDurumu";
            this.lblDurumu.Size = new System.Drawing.Size(98, 24);
            this.lblDurumu.TabIndex = 6;
            this.lblDurumu.Text = "Durumu:";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiyat.Location = new System.Drawing.Point(26, 252);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(145, 24);
            this.lblFiyat.TabIndex = 10;
            this.lblFiyat.Text = "Toptan Fiyatı:";
            // 
            // txtFiyat
            // 
            this.txtFiyat.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiyat.Location = new System.Drawing.Point(208, 252);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(269, 26);
            this.txtFiyat.TabIndex = 10;
            this.txtFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiyat_KeyPress);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnKaydet.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.ForeColor = System.Drawing.Color.Lime;
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnKaydet.Location = new System.Drawing.Point(383, 369);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(94, 38);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // pnlUrunEkle
            // 
            this.pnlUrunEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlUrunEkle.Controls.Add(this.btnTemizle);
            this.pnlUrunEkle.Controls.Add(this.btnGuncelle);
            this.pnlUrunEkle.Controls.Add(this.txtKarMarji);
            this.pnlUrunEkle.Controls.Add(this.lblKarMarjı);
            this.pnlUrunEkle.Controls.Add(this.cbxDurumu);
            this.pnlUrunEkle.Controls.Add(this.lblUrunEkle);
            this.pnlUrunEkle.Controls.Add(this.lblUrunTuru);
            this.pnlUrunEkle.Controls.Add(this.cbxUrununTuru);
            this.pnlUrunEkle.Controls.Add(this.btnKaydet);
            this.pnlUrunEkle.Controls.Add(this.lblMarka);
            this.pnlUrunEkle.Controls.Add(this.txtFiyat);
            this.pnlUrunEkle.Controls.Add(this.txtMarka);
            this.pnlUrunEkle.Controls.Add(this.lblFiyat);
            this.pnlUrunEkle.Controls.Add(this.lblModel);
            this.pnlUrunEkle.Controls.Add(this.txtModel);
            this.pnlUrunEkle.Controls.Add(this.lblDurumu);
            this.pnlUrunEkle.Location = new System.Drawing.Point(0, 0);
            this.pnlUrunEkle.Name = "pnlUrunEkle";
            this.pnlUrunEkle.Size = new System.Drawing.Size(495, 423);
            this.pnlUrunEkle.TabIndex = 20;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTemizle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.ForeColor = System.Drawing.Color.BlueViolet;
            this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnTemizle.Location = new System.Drawing.Point(163, 369);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(104, 38);
            this.btnTemizle.TabIndex = 17;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnGuncelle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnGuncelle.Location = new System.Drawing.Point(273, 369);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(104, 38);
            this.btnGuncelle.TabIndex = 16;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtKarMarji
            // 
            this.txtKarMarji.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtKarMarji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKarMarji.Location = new System.Drawing.Point(208, 301);
            this.txtKarMarji.Name = "txtKarMarji";
            this.txtKarMarji.Size = new System.Drawing.Size(269, 26);
            this.txtKarMarji.TabIndex = 15;
            this.txtKarMarji.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKarMarji_KeyPress);
            // 
            // lblKarMarjı
            // 
            this.lblKarMarjı.AutoSize = true;
            this.lblKarMarjı.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKarMarjı.Location = new System.Drawing.Point(27, 301);
            this.lblKarMarjı.Name = "lblKarMarjı";
            this.lblKarMarjı.Size = new System.Drawing.Size(105, 24);
            this.lblKarMarjı.TabIndex = 14;
            this.lblKarMarjı.Text = "Kar Marjı:";
            // 
            // cbxDurumu
            // 
            this.cbxDurumu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cbxDurumu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDurumu.FormattingEnabled = true;
            this.cbxDurumu.Items.AddRange(new object[] {
            "Sifir",
            "Ikinci El ",
            "Tehsir"});
            this.cbxDurumu.Location = new System.Drawing.Point(208, 200);
            this.cbxDurumu.Name = "cbxDurumu";
            this.cbxDurumu.Size = new System.Drawing.Size(269, 28);
            this.cbxDurumu.TabIndex = 9;
            // 
            // lblUrunEkle
            // 
            this.lblUrunEkle.AutoSize = true;
            this.lblUrunEkle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrunEkle.Location = new System.Drawing.Point(189, 0);
            this.lblUrunEkle.Name = "lblUrunEkle";
            this.lblUrunEkle.Size = new System.Drawing.Size(107, 24);
            this.lblUrunEkle.TabIndex = 13;
            this.lblUrunEkle.Text = "Ürün Ekle";
            // 
            // pnlAraSil
            // 
            this.pnlAraSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlAraSil.Controls.Add(this.lblAraSil);
            this.pnlAraSil.Controls.Add(this.txtModelAra);
            this.pnlAraSil.Controls.Add(this.btnSil1);
            this.pnlAraSil.Controls.Add(this.lblModelAra);
            this.pnlAraSil.Location = new System.Drawing.Point(113, 126);
            this.pnlAraSil.Name = "pnlAraSil";
            this.pnlAraSil.Size = new System.Drawing.Size(243, 142);
            this.pnlAraSil.TabIndex = 21;
            // 
            // lblAraSil
            // 
            this.lblAraSil.AutoSize = true;
            this.lblAraSil.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAraSil.Location = new System.Drawing.Point(82, 0);
            this.lblAraSil.Name = "lblAraSil";
            this.lblAraSil.Size = new System.Drawing.Size(88, 24);
            this.lblAraSil.TabIndex = 20;
            this.lblAraSil.Text = "Ara - Sil";
            // 
            // txtModelAra
            // 
            this.txtModelAra.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtModelAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelAra.Location = new System.Drawing.Point(134, 56);
            this.txtModelAra.Name = "txtModelAra";
            this.txtModelAra.Size = new System.Drawing.Size(97, 26);
            this.txtModelAra.TabIndex = 19;
            // 
            // btnSil1
            // 
            this.btnSil1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSil1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil1.ForeColor = System.Drawing.Color.Red;
            this.btnSil1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSil1.Location = new System.Drawing.Point(76, 101);
            this.btnSil1.Name = "btnSil1";
            this.btnSil1.Size = new System.Drawing.Size(94, 38);
            this.btnSil1.TabIndex = 17;
            this.btnSil1.Text = "Sil";
            this.btnSil1.UseVisualStyleBackColor = false;
            this.btnSil1.Click += new System.EventHandler(this.btnSil1_Click);
            // 
            // lblModelAra
            // 
            this.lblModelAra.AutoSize = true;
            this.lblModelAra.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelAra.Location = new System.Drawing.Point(3, 56);
            this.lblModelAra.Name = "lblModelAra";
            this.lblModelAra.Size = new System.Drawing.Size(125, 24);
            this.lblModelAra.TabIndex = 5;
            this.lblModelAra.Text = "Ürün Kodu:";
            // 
            // _Kerem_Cesur_C_DataSet
            // 
            this._Kerem_Cesur_C_DataSet.DataSetName = "_Kerem_Cesur_C_DataSet";
            this._Kerem_Cesur_C_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbcUrunIslemleri
            // 
            this.tbcUrunIslemleri.Controls.Add(this.tbcUrunEkle);
            this.tbcUrunIslemleri.Controls.Add(this.tbcUrunSil);
            this.tbcUrunIslemleri.Location = new System.Drawing.Point(12, 33);
            this.tbcUrunIslemleri.Name = "tbcUrunIslemleri";
            this.tbcUrunIslemleri.SelectedIndex = 0;
            this.tbcUrunIslemleri.Size = new System.Drawing.Size(503, 444);
            this.tbcUrunIslemleri.TabIndex = 22;
            // 
            // tbcUrunEkle
            // 
            this.tbcUrunEkle.BackColor = System.Drawing.Color.LightSlateGray;
            this.tbcUrunEkle.Controls.Add(this.pnlUrunEkle);
            this.tbcUrunEkle.Location = new System.Drawing.Point(4, 22);
            this.tbcUrunEkle.Name = "tbcUrunEkle";
            this.tbcUrunEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tbcUrunEkle.Size = new System.Drawing.Size(495, 418);
            this.tbcUrunEkle.TabIndex = 0;
            this.tbcUrunEkle.Text = "Ürün Ekle";
            // 
            // tbcUrunSil
            // 
            this.tbcUrunSil.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbcUrunSil.Controls.Add(this.pnlAraSil);
            this.tbcUrunSil.Location = new System.Drawing.Point(4, 22);
            this.tbcUrunSil.Name = "tbcUrunSil";
            this.tbcUrunSil.Padding = new System.Windows.Forms.Padding(3);
            this.tbcUrunSil.Size = new System.Drawing.Size(495, 418);
            this.tbcUrunSil.TabIndex = 1;
            this.tbcUrunSil.Text = "Ürün Sil";
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Location = new System.Drawing.Point(0, 0);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.ReadOnly = true;
            this.dgvUrunler.Size = new System.Drawing.Size(749, 423);
            this.dgvUrunler.TabIndex = 23;
            this.dgvUrunler.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunler_CellEnter);
            // 
            // tbcGridviews
            // 
            this.tbcGridviews.Controls.Add(this.tabPage1);
            this.tbcGridviews.Controls.Add(this.tabPage2);
            this.tbcGridviews.Location = new System.Drawing.Point(521, 30);
            this.tbcGridviews.Name = "tbcGridviews";
            this.tbcGridviews.SelectedIndex = 0;
            this.tbcGridviews.Size = new System.Drawing.Size(740, 447);
            this.tbcGridviews.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvUrunler);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(732, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ürünler Tablosu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.dgvToplamUrunSayisi);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(732, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Toplam Ürün ve Alış Fiyatı";
            // 
            // dgvToplamUrunSayisi
            // 
            this.dgvToplamUrunSayisi.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvToplamUrunSayisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToplamUrunSayisi.Location = new System.Drawing.Point(223, 94);
            this.dgvToplamUrunSayisi.Name = "dgvToplamUrunSayisi";
            this.dgvToplamUrunSayisi.ReadOnly = true;
            this.dgvToplamUrunSayisi.Size = new System.Drawing.Size(293, 154);
            this.dgvToplamUrunSayisi.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1266, 521);
            this.Controls.Add(this.tbcGridviews);
            this.Controls.Add(this.tbcUrunIslemleri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1282, 560);
            this.MinimumSize = new System.Drawing.Size(1282, 560);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Kontrol";
            this.pnlUrunEkle.ResumeLayout(false);
            this.pnlUrunEkle.PerformLayout();
            this.pnlAraSil.ResumeLayout(false);
            this.pnlAraSil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Kerem_Cesur_C_DataSet)).EndInit();
            this.tbcUrunIslemleri.ResumeLayout(false);
            this.tbcUrunEkle.ResumeLayout(false);
            this.tbcUrunSil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.tbcGridviews.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvToplamUrunSayisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUrunTuru;
        private System.Windows.Forms.ComboBox cbxUrununTuru;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblDurumu;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Panel pnlUrunEkle;
        private System.Windows.Forms.Label lblUrunEkle;
        private System.Windows.Forms.ComboBox cbxDurumu;
        private System.Windows.Forms.TextBox txtKarMarji;
        private System.Windows.Forms.Label lblKarMarjı;
        private System.Windows.Forms.Panel pnlAraSil;
        private System.Windows.Forms.Label lblModelAra;
        private System.Windows.Forms.Button btnSil1;
        private System.Windows.Forms.TextBox txtModelAra;
        private System.Windows.Forms.Label lblAraSil;
        private System.Windows.Forms.Button btnGuncelle;
        private _Kerem_Cesur_C_DataSet _Kerem_Cesur_C_DataSet;
        private System.Windows.Forms.TabControl tbcUrunIslemleri;
        private System.Windows.Forms.TabPage tbcUrunEkle;
        private System.Windows.Forms.TabPage tbcUrunSil;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.TabControl tbcGridviews;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvToplamUrunSayisi;
        private System.Windows.Forms.Button btnTemizle;
    }
}

