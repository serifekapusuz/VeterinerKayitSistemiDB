namespace VeterinerKlinigiKayit
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.dgvHayvanlar = new System.Windows.Forms.DataGridView();
            this.btnHayvanSil = new System.Windows.Forms.Button();
            this.btnHayvanListele = new System.Windows.Forms.Button();
            this.btnHayvanEkle = new System.Windows.Forms.Button();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtHayvanIrk = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHayvanTur = new System.Windows.Forms.TextBox();
            this.txtHayvanAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvVeterinerler = new System.Windows.Forms.DataGridView();
            this.btnVeterinerSil = new System.Windows.Forms.Button();
            this.btnVeterinerListele = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtUzmanlik = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVetSoyad = new System.Windows.Forms.TextBox();
            this.txtVetAd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.dgRandevular = new System.Windows.Forms.DataGridView();
            this.btnRandevuSil = new System.Windows.Forms.Button();
            this.btnRandevuListele = new System.Windows.Forms.Button();
            this.btnRandevuEkle = new System.Windows.Forms.Button();
            this.txtRandevuSaat = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpRandevuTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbRandevuVeteriner = new System.Windows.Forms.ComboBox();
            this.cmbRandevuHayvan = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvAsilar = new System.Windows.Forms.DataGridView();
            this.btnAsiSil = new System.Windows.Forms.Button();
            this.btnAsiListele = new System.Windows.Forms.Button();
            this.btnAsiEkle = new System.Windows.Forms.Button();
            this.dtAsiTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtAsiAdi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbAsiHayvan = new System.Windows.Forms.ComboBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dgvMusteriler = new System.Windows.Forms.DataGridView();
            this.btnMusteriSil = new System.Windows.Forms.Button();
            this.btnMusteriListele = new System.Windows.Forms.Button();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMusteriSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dgvTedaviler = new System.Windows.Forms.DataGridView();
            this.btnTedaviSil = new System.Windows.Forms.Button();
            this.btnTedaviListele = new System.Windows.Forms.Button();
            this.btnTedaviEkle = new System.Windows.Forms.Button();
            this.dtpTedaviTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtUygulananTedavi = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTeshis = new System.Windows.Forms.TextBox();
            this.cmbTedaviHayvan = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dtSonrakiAsi = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHayvanlar)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeterinerler)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRandevular)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsilar)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTedaviler)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(27, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1138, 555);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtpDogumTarihi);
            this.tabPage1.Controls.Add(this.dgvHayvanlar);
            this.tabPage1.Controls.Add(this.btnHayvanSil);
            this.tabPage1.Controls.Add(this.btnHayvanListele);
            this.tabPage1.Controls.Add(this.btnHayvanEkle);
            this.tabPage1.Controls.Add(this.cmbMusteri);
            this.tabPage1.Controls.Add(this.cmbCinsiyet);
            this.tabPage1.Controls.Add(this.txtHayvanIrk);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtHayvanTur);
            this.tabPage1.Controls.Add(this.txtHayvanAd);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1130, 526);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tpHayvan";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(108, 245);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpDogumTarihi.TabIndex = 13;
            // 
            // dgvHayvanlar
            // 
            this.dgvHayvanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHayvanlar.Location = new System.Drawing.Point(53, 338);
            this.dgvHayvanlar.Name = "dgvHayvanlar";
            this.dgvHayvanlar.RowHeadersWidth = 51;
            this.dgvHayvanlar.RowTemplate.Height = 24;
            this.dgvHayvanlar.Size = new System.Drawing.Size(1012, 164);
            this.dgvHayvanlar.TabIndex = 12;
            // 
            // btnHayvanSil
            // 
            this.btnHayvanSil.Location = new System.Drawing.Point(757, 269);
            this.btnHayvanSil.Name = "btnHayvanSil";
            this.btnHayvanSil.Size = new System.Drawing.Size(270, 43);
            this.btnHayvanSil.TabIndex = 11;
            this.btnHayvanSil.Text = "Hayvanı Sil";
            this.btnHayvanSil.UseVisualStyleBackColor = true;
            this.btnHayvanSil.Click += new System.EventHandler(this.btnHayvanSil_Click);
            // 
            // btnHayvanListele
            // 
            this.btnHayvanListele.Location = new System.Drawing.Point(757, 148);
            this.btnHayvanListele.Name = "btnHayvanListele";
            this.btnHayvanListele.Size = new System.Drawing.Size(270, 41);
            this.btnHayvanListele.TabIndex = 10;
            this.btnHayvanListele.Text = "Hayvanları Listele";
            this.btnHayvanListele.UseVisualStyleBackColor = true;
            this.btnHayvanListele.Click += new System.EventHandler(this.btnHayvanListele_Click);
            // 
            // btnHayvanEkle
            // 
            this.btnHayvanEkle.Location = new System.Drawing.Point(757, 42);
            this.btnHayvanEkle.Name = "btnHayvanEkle";
            this.btnHayvanEkle.Size = new System.Drawing.Size(270, 42);
            this.btnHayvanEkle.TabIndex = 9;
            this.btnHayvanEkle.Text = "Hayvan Ekle";
            this.btnHayvanEkle.UseVisualStyleBackColor = true;
            this.btnHayvanEkle.Click += new System.EventHandler(this.btnHayvanEkle_Click);
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(495, 130);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(121, 24);
            this.cmbMusteri.TabIndex = 7;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Dişi"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(495, 41);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(121, 24);
            this.cmbCinsiyet.TabIndex = 6;
            // 
            // txtHayvanIrk
            // 
            this.txtHayvanIrk.Location = new System.Drawing.Point(229, 178);
            this.txtHayvanIrk.Name = "txtHayvanIrk";
            this.txtHayvanIrk.Size = new System.Drawing.Size(100, 22);
            this.txtHayvanIrk.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Hayvanın Cinsi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Hayvanın Türü:";
            // 
            // txtHayvanTur
            // 
            this.txtHayvanTur.Location = new System.Drawing.Point(229, 120);
            this.txtHayvanTur.Name = "txtHayvanTur";
            this.txtHayvanTur.Size = new System.Drawing.Size(100, 22);
            this.txtHayvanTur.TabIndex = 2;
            // 
            // txtHayvanAd
            // 
            this.txtHayvanAd.Location = new System.Drawing.Point(229, 44);
            this.txtHayvanAd.Name = "txtHayvanAd";
            this.txtHayvanAd.Size = new System.Drawing.Size(100, 22);
            this.txtHayvanAd.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hayvanın Adı:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvVeterinerler);
            this.tabPage2.Controls.Add(this.btnVeterinerSil);
            this.tabPage2.Controls.Add(this.btnVeterinerListele);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.txtUzmanlik);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtVetSoyad);
            this.tabPage2.Controls.Add(this.txtVetAd);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1130, 526);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tpVeteriner";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvVeterinerler
            // 
            this.dgvVeterinerler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeterinerler.Location = new System.Drawing.Point(42, 337);
            this.dgvVeterinerler.Name = "dgvVeterinerler";
            this.dgvVeterinerler.RowHeadersWidth = 51;
            this.dgvVeterinerler.RowTemplate.Height = 24;
            this.dgvVeterinerler.Size = new System.Drawing.Size(1065, 170);
            this.dgvVeterinerler.TabIndex = 9;
            // 
            // btnVeterinerSil
            // 
            this.btnVeterinerSil.Location = new System.Drawing.Point(722, 258);
            this.btnVeterinerSil.Name = "btnVeterinerSil";
            this.btnVeterinerSil.Size = new System.Drawing.Size(281, 45);
            this.btnVeterinerSil.TabIndex = 8;
            this.btnVeterinerSil.Text = "Veteriner Sil";
            this.btnVeterinerSil.UseVisualStyleBackColor = true;
            this.btnVeterinerSil.Click += new System.EventHandler(this.btnVeterinerSil_Click);
            // 
            // btnVeterinerListele
            // 
            this.btnVeterinerListele.Location = new System.Drawing.Point(722, 146);
            this.btnVeterinerListele.Name = "btnVeterinerListele";
            this.btnVeterinerListele.Size = new System.Drawing.Size(281, 45);
            this.btnVeterinerListele.TabIndex = 7;
            this.btnVeterinerListele.Text = "Veterinerleri Listele";
            this.btnVeterinerListele.UseVisualStyleBackColor = true;
            this.btnVeterinerListele.Click += new System.EventHandler(this.btnVeterinerListele_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(722, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "Veteriner Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUzmanlik
            // 
            this.txtUzmanlik.Location = new System.Drawing.Point(212, 175);
            this.txtUzmanlik.Name = "txtUzmanlik";
            this.txtUzmanlik.Size = new System.Drawing.Size(100, 22);
            this.txtUzmanlik.TabIndex = 5;
            this.txtUzmanlik.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Veterinerin Branşı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Veterinerin Soyadı:";
            // 
            // txtVetSoyad
            // 
            this.txtVetSoyad.Location = new System.Drawing.Point(212, 102);
            this.txtVetSoyad.Name = "txtVetSoyad";
            this.txtVetSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtVetSoyad.TabIndex = 2;
            // 
            // txtVetAd
            // 
            this.txtVetAd.Location = new System.Drawing.Point(212, 39);
            this.txtVetAd.Name = "txtVetAd";
            this.txtVetAd.Size = new System.Drawing.Size(100, 22);
            this.txtVetAd.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Veterinerin Adı:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.txtAciklama);
            this.tabPage3.Controls.Add(this.dgRandevular);
            this.tabPage3.Controls.Add(this.btnRandevuSil);
            this.tabPage3.Controls.Add(this.btnRandevuListele);
            this.tabPage3.Controls.Add(this.btnRandevuEkle);
            this.tabPage3.Controls.Add(this.txtRandevuSaat);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.dtpRandevuTarihi);
            this.tabPage3.Controls.Add(this.cmbRandevuVeteriner);
            this.tabPage3.Controls.Add(this.cmbRandevuHayvan);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1130, 526);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tpRandevu";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(440, 150);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 16);
            this.label16.TabIndex = 10;
            this.label16.Text = "Hastalığı:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(532, 147);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(100, 22);
            this.txtAciklama.TabIndex = 9;
            // 
            // dgRandevular
            // 
            this.dgRandevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRandevular.Location = new System.Drawing.Point(34, 296);
            this.dgRandevular.Name = "dgRandevular";
            this.dgRandevular.RowHeadersWidth = 51;
            this.dgRandevular.RowTemplate.Height = 24;
            this.dgRandevular.Size = new System.Drawing.Size(1053, 202);
            this.dgRandevular.TabIndex = 8;
            // 
            // btnRandevuSil
            // 
            this.btnRandevuSil.Location = new System.Drawing.Point(775, 232);
            this.btnRandevuSil.Name = "btnRandevuSil";
            this.btnRandevuSil.Size = new System.Drawing.Size(237, 40);
            this.btnRandevuSil.TabIndex = 7;
            this.btnRandevuSil.Text = "Randevu Sil";
            this.btnRandevuSil.UseVisualStyleBackColor = true;
            this.btnRandevuSil.Click += new System.EventHandler(this.btnRandevuSil_Click);
            // 
            // btnRandevuListele
            // 
            this.btnRandevuListele.Location = new System.Drawing.Point(775, 144);
            this.btnRandevuListele.Name = "btnRandevuListele";
            this.btnRandevuListele.Size = new System.Drawing.Size(237, 38);
            this.btnRandevuListele.TabIndex = 6;
            this.btnRandevuListele.Text = "Randevu Listele";
            this.btnRandevuListele.UseVisualStyleBackColor = true;
            this.btnRandevuListele.Click += new System.EventHandler(this.btnRandevuListele_Click);
            // 
            // btnRandevuEkle
            // 
            this.btnRandevuEkle.Location = new System.Drawing.Point(775, 60);
            this.btnRandevuEkle.Name = "btnRandevuEkle";
            this.btnRandevuEkle.Size = new System.Drawing.Size(237, 39);
            this.btnRandevuEkle.TabIndex = 5;
            this.btnRandevuEkle.Text = "Randevu Ekle";
            this.btnRandevuEkle.UseVisualStyleBackColor = true;
            this.btnRandevuEkle.Click += new System.EventHandler(this.btnRandevuEkle_Click);
            // 
            // txtRandevuSaat
            // 
            this.txtRandevuSaat.Location = new System.Drawing.Point(189, 197);
            this.txtRandevuSaat.Name = "txtRandevuSaat";
            this.txtRandevuSaat.Size = new System.Drawing.Size(100, 22);
            this.txtRandevuSaat.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Randevu Saati:";
            // 
            // dtpRandevuTarihi
            // 
            this.dtpRandevuTarihi.Location = new System.Drawing.Point(95, 116);
            this.dtpRandevuTarihi.Name = "dtpRandevuTarihi";
            this.dtpRandevuTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpRandevuTarihi.TabIndex = 2;
            // 
            // cmbRandevuVeteriner
            // 
            this.cmbRandevuVeteriner.FormattingEnabled = true;
            this.cmbRandevuVeteriner.Location = new System.Drawing.Point(443, 44);
            this.cmbRandevuVeteriner.Name = "cmbRandevuVeteriner";
            this.cmbRandevuVeteriner.Size = new System.Drawing.Size(121, 24);
            this.cmbRandevuVeteriner.TabIndex = 1;
            // 
            // cmbRandevuHayvan
            // 
            this.cmbRandevuHayvan.FormattingEnabled = true;
            this.cmbRandevuHayvan.Items.AddRange(new object[] {
            "Şerife Kapusuz"});
            this.cmbRandevuHayvan.Location = new System.Drawing.Point(200, 45);
            this.cmbRandevuHayvan.Name = "cmbRandevuHayvan";
            this.cmbRandevuHayvan.Size = new System.Drawing.Size(121, 24);
            this.cmbRandevuHayvan.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dtSonrakiAsi);
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.dgvAsilar);
            this.tabPage4.Controls.Add(this.btnAsiSil);
            this.tabPage4.Controls.Add(this.btnAsiListele);
            this.tabPage4.Controls.Add(this.btnAsiEkle);
            this.tabPage4.Controls.Add(this.dtAsiTarihi);
            this.tabPage4.Controls.Add(this.txtAsiAdi);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.cmbAsiHayvan);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1130, 526);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tpAsi";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvAsilar
            // 
            this.dgvAsilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsilar.Location = new System.Drawing.Point(49, 328);
            this.dgvAsilar.Name = "dgvAsilar";
            this.dgvAsilar.RowHeadersWidth = 51;
            this.dgvAsilar.RowTemplate.Height = 24;
            this.dgvAsilar.Size = new System.Drawing.Size(1049, 168);
            this.dgvAsilar.TabIndex = 9;
            // 
            // btnAsiSil
            // 
            this.btnAsiSil.Location = new System.Drawing.Point(817, 240);
            this.btnAsiSil.Name = "btnAsiSil";
            this.btnAsiSil.Size = new System.Drawing.Size(281, 43);
            this.btnAsiSil.TabIndex = 8;
            this.btnAsiSil.Text = "Aşıyı Sil";
            this.btnAsiSil.UseVisualStyleBackColor = true;
            this.btnAsiSil.Click += new System.EventHandler(this.btnAsiSil_Click);
            // 
            // btnAsiListele
            // 
            this.btnAsiListele.Location = new System.Drawing.Point(817, 146);
            this.btnAsiListele.Name = "btnAsiListele";
            this.btnAsiListele.Size = new System.Drawing.Size(281, 47);
            this.btnAsiListele.TabIndex = 7;
            this.btnAsiListele.Text = "Aşıları Listele";
            this.btnAsiListele.UseVisualStyleBackColor = true;
            this.btnAsiListele.Click += new System.EventHandler(this.btnAsiListele_Click);
            // 
            // btnAsiEkle
            // 
            this.btnAsiEkle.Location = new System.Drawing.Point(817, 61);
            this.btnAsiEkle.Name = "btnAsiEkle";
            this.btnAsiEkle.Size = new System.Drawing.Size(281, 48);
            this.btnAsiEkle.TabIndex = 6;
            this.btnAsiEkle.Text = "Aşı Ekle";
            this.btnAsiEkle.UseVisualStyleBackColor = true;
            this.btnAsiEkle.Click += new System.EventHandler(this.btnAsiEkle_Click);
            // 
            // dtAsiTarihi
            // 
            this.dtAsiTarihi.Location = new System.Drawing.Point(172, 182);
            this.dtAsiTarihi.Name = "dtAsiTarihi";
            this.dtAsiTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtAsiTarihi.TabIndex = 5;
            // 
            // txtAsiAdi
            // 
            this.txtAsiAdi.Location = new System.Drawing.Point(172, 117);
            this.txtAsiAdi.Name = "txtAsiAdi";
            this.txtAsiAdi.Size = new System.Drawing.Size(100, 22);
            this.txtAsiAdi.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(70, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Aşı Adı:";
            // 
            // cmbAsiHayvan
            // 
            this.cmbAsiHayvan.FormattingEnabled = true;
            this.cmbAsiHayvan.Location = new System.Drawing.Point(172, 38);
            this.cmbAsiHayvan.Name = "cmbAsiHayvan";
            this.cmbAsiHayvan.Size = new System.Drawing.Size(121, 24);
            this.cmbAsiHayvan.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dgvMusteriler);
            this.tabPage5.Controls.Add(this.btnMusteriSil);
            this.tabPage5.Controls.Add(this.btnMusteriListele);
            this.tabPage5.Controls.Add(this.btnMusteriEkle);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.txtAdres);
            this.tabPage5.Controls.Add(this.txtTelefon);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.txtMusteriSoyad);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.txtMusteriAd);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1130, 526);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tpMusteri";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dgvMusteriler
            // 
            this.dgvMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriler.Location = new System.Drawing.Point(39, 301);
            this.dgvMusteriler.Name = "dgvMusteriler";
            this.dgvMusteriler.RowHeadersWidth = 51;
            this.dgvMusteriler.RowTemplate.Height = 24;
            this.dgvMusteriler.Size = new System.Drawing.Size(1064, 219);
            this.dgvMusteriler.TabIndex = 11;
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.Location = new System.Drawing.Point(662, 228);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(346, 50);
            this.btnMusteriSil.TabIndex = 10;
            this.btnMusteriSil.Text = "Müşteriyi Sil";
            this.btnMusteriSil.UseVisualStyleBackColor = true;
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);
            // 
            // btnMusteriListele
            // 
            this.btnMusteriListele.Location = new System.Drawing.Point(662, 128);
            this.btnMusteriListele.Name = "btnMusteriListele";
            this.btnMusteriListele.Size = new System.Drawing.Size(346, 47);
            this.btnMusteriListele.TabIndex = 9;
            this.btnMusteriListele.Text = "Müşterileri Listele";
            this.btnMusteriListele.UseVisualStyleBackColor = true;
            this.btnMusteriListele.Click += new System.EventHandler(this.btnMusteriListele_Click);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(662, 26);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(346, 48);
            this.btnMusteriEkle.TabIndex = 8;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Müşterinin Adres Bilgisi";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(276, 230);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(100, 22);
            this.txtAdres.TabIndex = 6;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(276, 153);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 22);
            this.txtTelefon.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Müşterinin Telefon Numarası";
            // 
            // txtMusteriSoyad
            // 
            this.txtMusteriSoyad.Location = new System.Drawing.Point(174, 94);
            this.txtMusteriSoyad.Name = "txtMusteriSoyad";
            this.txtMusteriSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtMusteriSoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Müşteri Soyadı";
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Location = new System.Drawing.Point(174, 28);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(100, 22);
            this.txtMusteriAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Adı";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label19);
            this.tabPage6.Controls.Add(this.label18);
            this.tabPage6.Controls.Add(this.txtUcret);
            this.tabPage6.Controls.Add(this.label17);
            this.tabPage6.Controls.Add(this.dgvTedaviler);
            this.tabPage6.Controls.Add(this.btnTedaviSil);
            this.tabPage6.Controls.Add(this.btnTedaviListele);
            this.tabPage6.Controls.Add(this.btnTedaviEkle);
            this.tabPage6.Controls.Add(this.dtpTedaviTarihi);
            this.tabPage6.Controls.Add(this.txtUygulananTedavi);
            this.tabPage6.Controls.Add(this.label15);
            this.tabPage6.Controls.Add(this.label14);
            this.tabPage6.Controls.Add(this.txtTeshis);
            this.tabPage6.Controls.Add(this.cmbTedaviHayvan);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1130, 526);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tpTedavi";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dgvTedaviler
            // 
            this.dgvTedaviler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTedaviler.Location = new System.Drawing.Point(40, 313);
            this.dgvTedaviler.Name = "dgvTedaviler";
            this.dgvTedaviler.RowHeadersWidth = 51;
            this.dgvTedaviler.RowTemplate.Height = 24;
            this.dgvTedaviler.Size = new System.Drawing.Size(1052, 194);
            this.dgvTedaviler.TabIndex = 9;
            // 
            // btnTedaviSil
            // 
            this.btnTedaviSil.Location = new System.Drawing.Point(838, 240);
            this.btnTedaviSil.Name = "btnTedaviSil";
            this.btnTedaviSil.Size = new System.Drawing.Size(221, 44);
            this.btnTedaviSil.TabIndex = 8;
            this.btnTedaviSil.Text = "Tedaviyi Sil";
            this.btnTedaviSil.UseVisualStyleBackColor = true;
            this.btnTedaviSil.Click += new System.EventHandler(this.btnTedaviSil_Click);
            // 
            // btnTedaviListele
            // 
            this.btnTedaviListele.Location = new System.Drawing.Point(838, 148);
            this.btnTedaviListele.Name = "btnTedaviListele";
            this.btnTedaviListele.Size = new System.Drawing.Size(221, 38);
            this.btnTedaviListele.TabIndex = 7;
            this.btnTedaviListele.Text = "Tedavi Listele";
            this.btnTedaviListele.UseVisualStyleBackColor = true;
            this.btnTedaviListele.Click += new System.EventHandler(this.btnTedaviListele_Click);
            // 
            // btnTedaviEkle
            // 
            this.btnTedaviEkle.Location = new System.Drawing.Point(838, 61);
            this.btnTedaviEkle.Name = "btnTedaviEkle";
            this.btnTedaviEkle.Size = new System.Drawing.Size(221, 39);
            this.btnTedaviEkle.TabIndex = 6;
            this.btnTedaviEkle.Text = "Tedavi Ekle";
            this.btnTedaviEkle.UseVisualStyleBackColor = true;
            this.btnTedaviEkle.Click += new System.EventHandler(this.btnTedaviEkle_Click);
            // 
            // dtpTedaviTarihi
            // 
            this.dtpTedaviTarihi.Location = new System.Drawing.Point(166, 197);
            this.dtpTedaviTarihi.Name = "dtpTedaviTarihi";
            this.dtpTedaviTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpTedaviTarihi.TabIndex = 5;
            // 
            // txtUygulananTedavi
            // 
            this.txtUygulananTedavi.Location = new System.Drawing.Point(166, 105);
            this.txtUygulananTedavi.Name = "txtUygulananTedavi";
            this.txtUygulananTedavi.Size = new System.Drawing.Size(100, 22);
            this.txtUygulananTedavi.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(37, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 16);
            this.label15.TabIndex = 3;
            this.label15.Text = "Tedavi Yöntemi:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(37, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 16);
            this.label14.TabIndex = 2;
            this.label14.Text = "Hayvanın Hastalığı:";
            // 
            // txtTeshis
            // 
            this.txtTeshis.Location = new System.Drawing.Point(166, 52);
            this.txtTeshis.Name = "txtTeshis";
            this.txtTeshis.Size = new System.Drawing.Size(100, 22);
            this.txtTeshis.TabIndex = 1;
            // 
            // cmbTedaviHayvan
            // 
            this.cmbTedaviHayvan.FormattingEnabled = true;
            this.cmbTedaviHayvan.Location = new System.Drawing.Point(518, 52);
            this.cmbTedaviHayvan.Name = "cmbTedaviHayvan";
            this.cmbTedaviHayvan.Size = new System.Drawing.Size(121, 24);
            this.cmbTedaviHayvan.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(37, 159);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 16);
            this.label17.TabIndex = 10;
            this.label17.Text = "Ücret:";
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(166, 153);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(100, 22);
            this.txtUcret.TabIndex = 11;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(37, 203);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 16);
            this.label18.TabIndex = 12;
            this.label18.Text = "Tedavi Tarihi:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(354, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(116, 16);
            this.label19.TabIndex = 13;
            this.label19.Text = "Hayvanınızı Seçin:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(70, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 16);
            this.label13.TabIndex = 10;
            this.label13.Text = "Hayvanınız:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(73, 187);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 16);
            this.label20.TabIndex = 11;
            this.label20.Text = "Aşı Tarihi:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(73, 240);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(115, 16);
            this.label21.TabIndex = 12;
            this.label21.Text = "Sonraki Aşı Tarihi:";
            // 
            // dtSonrakiAsi
            // 
            this.dtSonrakiAsi.Location = new System.Drawing.Point(207, 240);
            this.dtSonrakiAsi.Name = "dtSonrakiAsi";
            this.dtSonrakiAsi.Size = new System.Drawing.Size(200, 22);
            this.dtSonrakiAsi.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 579);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHayvanlar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeterinerler)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRandevular)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsilar)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTedaviler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMusteriSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMusteriler;
        private System.Windows.Forms.Button btnMusteriSil;
        private System.Windows.Forms.Button btnMusteriListele;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.TextBox txtHayvanIrk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHayvanTur;
        private System.Windows.Forms.TextBox txtHayvanAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvHayvanlar;
        private System.Windows.Forms.Button btnHayvanSil;
        private System.Windows.Forms.Button btnHayvanListele;
        private System.Windows.Forms.Button btnHayvanEkle;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.TextBox txtUzmanlik;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVetSoyad;
        private System.Windows.Forms.TextBox txtVetAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVeterinerSil;
        private System.Windows.Forms.Button btnVeterinerListele;
        private System.Windows.Forms.DataGridView dgvVeterinerler;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.TextBox txtRandevuSaat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpRandevuTarihi;
        private System.Windows.Forms.ComboBox cmbRandevuVeteriner;
        private System.Windows.Forms.ComboBox cmbRandevuHayvan;
        private System.Windows.Forms.DataGridView dgRandevular;
        private System.Windows.Forms.Button btnRandevuSil;
        private System.Windows.Forms.Button btnRandevuListele;
        private System.Windows.Forms.Button btnRandevuEkle;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btnAsiSil;
        private System.Windows.Forms.Button btnAsiListele;
        private System.Windows.Forms.Button btnAsiEkle;
        private System.Windows.Forms.DateTimePicker dtAsiTarihi;
        private System.Windows.Forms.TextBox txtAsiAdi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbAsiHayvan;
        private System.Windows.Forms.DataGridView dgvAsilar;
        private System.Windows.Forms.Button btnTedaviSil;
        private System.Windows.Forms.Button btnTedaviListele;
        private System.Windows.Forms.Button btnTedaviEkle;
        private System.Windows.Forms.DateTimePicker dtpTedaviTarihi;
        private System.Windows.Forms.TextBox txtUygulananTedavi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTeshis;
        private System.Windows.Forms.ComboBox cmbTedaviHayvan;
        private System.Windows.Forms.DataGridView dgvTedaviler;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtSonrakiAsi;
        private System.Windows.Forms.Label label21;
    }
}

