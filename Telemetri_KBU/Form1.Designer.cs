namespace Telemetri_KBU
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.baglan_b = new System.Windows.Forms.Button();
            this.haberlesme_hiz = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.portlar = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label54 = new System.Windows.Forms.Label();
            this.zaman_yazi = new System.Windows.Forms.Label();
            this.veri_kaydet = new System.Windows.Forms.Button();
            this.veri_temizle = new System.Windows.Forms.Button();
            this.anlik_veri = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.log_kayit = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.veri_gonder = new System.Windows.Forms.Button();
            this.veri_giris = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.gostergeler = new System.Windows.Forms.TabPage();
            this.sistem_durumu = new System.Windows.Forms.Label();
            this.motor_devir = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.motor_hiz = new AGaugeApp.AGauge();
            this.hiz = new AGaugeApp.AGauge();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.guc_gosterge = new CircularProgressBar.CircularProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.batarya_gosterge = new CircularProgressBar.CircularProgressBar();
            this.akim_gosterge = new CircularProgressBar.CircularProgressBar();
            this.sicaklik_gosterge = new CircularProgressBar.CircularProgressBar();
            this.pil_durumlari = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.max_hucre_deger = new System.Windows.Forms.NumericUpDown();
            this.min_hucre_deger = new System.Windows.Forms.NumericUpDown();
            this.label36 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label67 = new System.Windows.Forms.Label();
            this.pil_14_yuzde = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.pil_14_volt = new System.Windows.Forms.Label();
            this.pil_20_pro = new System.Windows.Forms.ProgressBar();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.pil_20_yuzde = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.pil_20_volt = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.pil_18_pro = new System.Windows.Forms.ProgressBar();
            this.label77 = new System.Windows.Forms.Label();
            this.pil_19_yuzde = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.pil_19_volt = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.pil_17_pro = new System.Windows.Forms.ProgressBar();
            this.label82 = new System.Windows.Forms.Label();
            this.pil_18_yuzde = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.pil_18_volt = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.pil_16_pro = new System.Windows.Forms.ProgressBar();
            this.label87 = new System.Windows.Forms.Label();
            this.pil_17_yuzde = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.pil_17_volt = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.pil_19_pro = new System.Windows.Forms.ProgressBar();
            this.label92 = new System.Windows.Forms.Label();
            this.pil_16_yuzde = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.pil_16_volt = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.pil_15_pro = new System.Windows.Forms.ProgressBar();
            this.label97 = new System.Windows.Forms.Label();
            this.pil_15_yuzde = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.pil_15_volt = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.pil_14_pro = new System.Windows.Forms.ProgressBar();
            this.label102 = new System.Windows.Forms.Label();
            this.pil_13_yuzde = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.pil_13_volt = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.pil_13_pro = new System.Windows.Forms.ProgressBar();
            this.label108 = new System.Windows.Forms.Label();
            this.pil_12_yuzde = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.pil_12_volt = new System.Windows.Forms.Label();
            this.label112 = new System.Windows.Forms.Label();
            this.pil_12_pro = new System.Windows.Forms.ProgressBar();
            this.label113 = new System.Windows.Forms.Label();
            this.pil_11_yuzde = new System.Windows.Forms.Label();
            this.label115 = new System.Windows.Forms.Label();
            this.pil_11_volt = new System.Windows.Forms.Label();
            this.label117 = new System.Windows.Forms.Label();
            this.pil_11_pro = new System.Windows.Forms.ProgressBar();
            this.label63 = new System.Windows.Forms.Label();
            this.pil_4_yuzde = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.pil_4_volt = new System.Windows.Forms.Label();
            this.pil_10_pro = new System.Windows.Forms.ProgressBar();
            this.label107 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.pil_10_yuzde = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.pil_10_volt = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.pil_8_pro = new System.Windows.Forms.ProgressBar();
            this.label53 = new System.Windows.Forms.Label();
            this.pil_9_yuzde = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.pil_9_volt = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.pil_7_pro = new System.Windows.Forms.ProgressBar();
            this.label48 = new System.Windows.Forms.Label();
            this.pil_8_yuzde = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.pil_8_volt = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.pil_6_pro = new System.Windows.Forms.ProgressBar();
            this.label43 = new System.Windows.Forms.Label();
            this.pil_7_yuzde = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.pil_7_volt = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.pil_9_pro = new System.Windows.Forms.ProgressBar();
            this.label38 = new System.Windows.Forms.Label();
            this.pil_6_yuzde = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.pil_6_volt = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.pil_5_pro = new System.Windows.Forms.ProgressBar();
            this.label33 = new System.Windows.Forms.Label();
            this.pil_5_yuzde = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.pil_5_volt = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.pil_4_pro = new System.Windows.Forms.ProgressBar();
            this.label28 = new System.Windows.Forms.Label();
            this.pil_3_yuzde = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.pil_3_volt = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.pil_3_pro = new System.Windows.Forms.ProgressBar();
            this.label23 = new System.Windows.Forms.Label();
            this.pil_2_yuzde = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.pil_2_volt = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.pil_2_pro = new System.Windows.Forms.ProgressBar();
            this.label22 = new System.Windows.Forms.Label();
            this.pil_1_yuzde = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.pil_1_volt = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pil_1_pro = new System.Windows.Forms.ProgressBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.genel_volt_yuzde = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.genel_volt_deger = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.genel_volt_pro = new System.Windows.Forms.ProgressBar();
            this.ayrinti = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.sicaklik_sensor_1 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.sicaklik_sensor_2 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.sicaklik_sensor_4 = new System.Windows.Forms.Label();
            this.sicaklik_sensor_3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.grafik = new System.Windows.Forms.TabPage();
            this.akim_grafik = new ZedGraph.ZedGraphControl();
            this.watt_grafik = new ZedGraph.ZedGraphControl();
            this.veri_tabani = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.excel_pro = new System.Windows.Forms.ProgressBar();
            this.exceleaktar = new System.Windows.Forms.Button();
            this.batarya_kapasitesi = new System.Windows.Forms.NumericUpDown();
            this.label46 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.kalan_watt_saat = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.watt_saat_text = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.akim_saat_text = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.aH = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.veri_tabani_tablo = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saniye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sicaklik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.genel_hesaplama = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.excel_islem = new System.ComponentModel.BackgroundWorker();
            this.veri_tabani_kaydi = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.gostergeler.SuspendLayout();
            this.pil_durumlari.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max_hucre_deger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_hucre_deger)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.ayrinti.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.grafik.SuspendLayout();
            this.veri_tabani.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batarya_kapasitesi)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veri_tabani_tablo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.baglan_b);
            this.groupBox1.Controls.Add(this.haberlesme_hiz);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.portlar);
            this.groupBox1.Location = new System.Drawing.Point(12, 553);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bağlantı Ayarları";
            // 
            // baglan_b
            // 
            this.baglan_b.Location = new System.Drawing.Point(9, 85);
            this.baglan_b.Name = "baglan_b";
            this.baglan_b.Size = new System.Drawing.Size(213, 23);
            this.baglan_b.TabIndex = 5;
            this.baglan_b.Text = "Bağlan";
            this.baglan_b.UseVisualStyleBackColor = true;
            this.baglan_b.Click += new System.EventHandler(this.baglan_b_Click);
            // 
            // haberlesme_hiz
            // 
            this.haberlesme_hiz.FormattingEnabled = true;
            this.haberlesme_hiz.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "74880",
            "115200",
            "230400",
            "250000"});
            this.haberlesme_hiz.Location = new System.Drawing.Point(93, 49);
            this.haberlesme_hiz.Name = "haberlesme_hiz";
            this.haberlesme_hiz.Size = new System.Drawing.Size(129, 21);
            this.haberlesme_hiz.TabIndex = 3;
            this.haberlesme_hiz.Text = "115200";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baund Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port";
            // 
            // portlar
            // 
            this.portlar.FormattingEnabled = true;
            this.portlar.Location = new System.Drawing.Point(93, 20);
            this.portlar.Name = "portlar";
            this.portlar.Size = new System.Drawing.Size(129, 21);
            this.portlar.TabIndex = 0;
            this.portlar.Text = "Port Seçin";
            this.portlar.SelectedIndexChanged += new System.EventHandler(this.portlar_SelectedIndexChanged);
            this.portlar.Click += new System.EventHandler(this.portlar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label54);
            this.groupBox2.Controls.Add(this.zaman_yazi);
            this.groupBox2.Controls.Add(this.veri_kaydet);
            this.groupBox2.Controls.Add(this.veri_temizle);
            this.groupBox2.Controls.Add(this.anlik_veri);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.log_kayit);
            this.groupBox2.Location = new System.Drawing.Point(257, 553);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(915, 196);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log Kaydı";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label54.Location = new System.Drawing.Point(677, 105);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(26, 20);
            this.label54.TabIndex = 5;
            this.label54.Text = "sn";
            // 
            // zaman_yazi
            // 
            this.zaman_yazi.AutoSize = true;
            this.zaman_yazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zaman_yazi.Location = new System.Drawing.Point(664, 85);
            this.zaman_yazi.Name = "zaman_yazi";
            this.zaman_yazi.Size = new System.Drawing.Size(18, 20);
            this.zaman_yazi.TabIndex = 2;
            this.zaman_yazi.Text = "0";
            // 
            // veri_kaydet
            // 
            this.veri_kaydet.Location = new System.Drawing.Point(667, 13);
            this.veri_kaydet.Name = "veri_kaydet";
            this.veri_kaydet.Size = new System.Drawing.Size(242, 24);
            this.veri_kaydet.TabIndex = 4;
            this.veri_kaydet.Text = "Kaydet";
            this.veri_kaydet.UseVisualStyleBackColor = true;
            this.veri_kaydet.Click += new System.EventHandler(this.veri_kaydet_Click);
            // 
            // veri_temizle
            // 
            this.veri_temizle.Location = new System.Drawing.Point(667, 43);
            this.veri_temizle.Name = "veri_temizle";
            this.veri_temizle.Size = new System.Drawing.Size(242, 27);
            this.veri_temizle.TabIndex = 3;
            this.veri_temizle.Text = "Temizle";
            this.veri_temizle.UseVisualStyleBackColor = true;
            this.veri_temizle.Click += new System.EventHandler(this.veri_temizle_Click);
            // 
            // anlik_veri
            // 
            this.anlik_veri.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.anlik_veri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.anlik_veri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anlik_veri.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.anlik_veri.Location = new System.Drawing.Point(65, 17);
            this.anlik_veri.Name = "anlik_veri";
            this.anlik_veri.ReadOnly = true;
            this.anlik_veri.Size = new System.Drawing.Size(591, 15);
            this.anlik_veri.TabIndex = 2;
            this.anlik_veri.Text = "123456789123456";
            this.anlik_veri.TextChanged += new System.EventHandler(this.anlik_veri_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Anlık Veri";
            // 
            // log_kayit
            // 
            this.log_kayit.FormattingEnabled = true;
            this.log_kayit.Location = new System.Drawing.Point(6, 47);
            this.log_kayit.Name = "log_kayit";
            this.log_kayit.Size = new System.Drawing.Size(650, 134);
            this.log_kayit.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.veri_gonder);
            this.groupBox3.Controls.Add(this.veri_giris);
            this.groupBox3.Location = new System.Drawing.Point(13, 685);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 64);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Manuel Veri Girişi";
            // 
            // veri_gonder
            // 
            this.veri_gonder.Location = new System.Drawing.Point(146, 25);
            this.veri_gonder.Name = "veri_gonder";
            this.veri_gonder.Size = new System.Drawing.Size(86, 23);
            this.veri_gonder.TabIndex = 1;
            this.veri_gonder.Text = "Gönder";
            this.veri_gonder.UseVisualStyleBackColor = true;
            this.veri_gonder.Click += new System.EventHandler(this.veri_gonder_Click);
            // 
            // veri_giris
            // 
            this.veri_giris.Location = new System.Drawing.Point(8, 27);
            this.veri_giris.Name = "veri_giris";
            this.veri_giris.Size = new System.Drawing.Size(132, 20);
            this.veri_giris.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.gostergeler);
            this.tabControl1.Controls.Add(this.pil_durumlari);
            this.tabControl1.Controls.Add(this.ayrinti);
            this.tabControl1.Controls.Add(this.grafik);
            this.tabControl1.Controls.Add(this.veri_tabani);
            this.tabControl1.Location = new System.Drawing.Point(13, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1159, 537);
            this.tabControl1.TabIndex = 3;
            // 
            // gostergeler
            // 
            this.gostergeler.BackColor = System.Drawing.Color.White;
            this.gostergeler.Controls.Add(this.sistem_durumu);
            this.gostergeler.Controls.Add(this.motor_devir);
            this.gostergeler.Controls.Add(this.label6);
            this.gostergeler.Controls.Add(this.motor_hiz);
            this.gostergeler.Controls.Add(this.hiz);
            this.gostergeler.Controls.Add(this.label7);
            this.gostergeler.Controls.Add(this.label5);
            this.gostergeler.Controls.Add(this.label11);
            this.gostergeler.Controls.Add(this.label10);
            this.gostergeler.Controls.Add(this.guc_gosterge);
            this.gostergeler.Controls.Add(this.label4);
            this.gostergeler.Controls.Add(this.batarya_gosterge);
            this.gostergeler.Controls.Add(this.akim_gosterge);
            this.gostergeler.Controls.Add(this.sicaklik_gosterge);
            this.gostergeler.Location = new System.Drawing.Point(4, 4);
            this.gostergeler.Name = "gostergeler";
            this.gostergeler.Padding = new System.Windows.Forms.Padding(3);
            this.gostergeler.Size = new System.Drawing.Size(1151, 511);
            this.gostergeler.TabIndex = 0;
            this.gostergeler.Text = "Göstergeler";
            // 
            // sistem_durumu
            // 
            this.sistem_durumu.AutoSize = true;
            this.sistem_durumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sistem_durumu.Location = new System.Drawing.Point(784, 340);
            this.sistem_durumu.Name = "sistem_durumu";
            this.sistem_durumu.Size = new System.Drawing.Size(217, 33);
            this.sistem_durumu.TabIndex = 36;
            this.sistem_durumu.Text = "Sistem Durumu";
            // 
            // motor_devir
            // 
            this.motor_devir.AutoSize = true;
            this.motor_devir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.motor_devir.Location = new System.Drawing.Point(194, 464);
            this.motor_devir.Name = "motor_devir";
            this.motor_devir.Size = new System.Drawing.Size(88, 20);
            this.motor_devir.TabIndex = 35;
            this.motor_devir.Text = "4325[RPM]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(103, 464);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Motor Devir: ";
            // 
            // motor_hiz
            // 
            this.motor_hiz.BaseArcColor = System.Drawing.Color.Gray;
            this.motor_hiz.BaseArcRadius = 150;
            this.motor_hiz.BaseArcStart = 215;
            this.motor_hiz.BaseArcSweep = 110;
            this.motor_hiz.BaseArcWidth = 2;
            this.motor_hiz.Cap_Idx = ((byte)(1));
            this.motor_hiz.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.motor_hiz.CapPosition = new System.Drawing.Point(10, 10);
            this.motor_hiz.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.motor_hiz.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.motor_hiz.CapText = "";
            this.motor_hiz.Center = new System.Drawing.Point(150, 180);
            this.motor_hiz.Location = new System.Drawing.Point(45, 340);
            this.motor_hiz.MaxValue = 6000F;
            this.motor_hiz.MinValue = 0F;
            this.motor_hiz.Name = "motor_hiz";
            this.motor_hiz.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Green;
            this.motor_hiz.NeedleColor2 = System.Drawing.Color.DimGray;
            this.motor_hiz.NeedleRadius = 150;
            this.motor_hiz.NeedleType = 0;
            this.motor_hiz.NeedleWidth = 2;
            this.motor_hiz.Range_Idx = ((byte)(2));
            this.motor_hiz.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.motor_hiz.RangeEnabled = true;
            this.motor_hiz.RangeEndValue = 4000F;
            this.motor_hiz.RangeInnerRadius = 50;
            this.motor_hiz.RangeOuterRadius = 150;
            this.motor_hiz.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.LightCoral,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.motor_hiz.RangesEnabled = new bool[] {
        false,
        true,
        true,
        true,
        false};
            this.motor_hiz.RangesEndValue = new float[] {
        300F,
        6000F,
        4000F,
        2000F,
        0F};
            this.motor_hiz.RangesInnerRadius = new int[] {
        70,
        50,
        50,
        50,
        70};
            this.motor_hiz.RangesOuterRadius = new int[] {
        80,
        150,
        150,
        150,
        80};
            this.motor_hiz.RangesStartValue = new float[] {
        -100F,
        4000F,
        2000F,
        0F,
        0F};
            this.motor_hiz.RangeStartValue = 2000F;
            this.motor_hiz.ScaleLinesInterColor = System.Drawing.Color.Red;
            this.motor_hiz.ScaleLinesInterInnerRadius = 145;
            this.motor_hiz.ScaleLinesInterOuterRadius = 150;
            this.motor_hiz.ScaleLinesInterWidth = 2;
            this.motor_hiz.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.motor_hiz.ScaleLinesMajorInnerRadius = 140;
            this.motor_hiz.ScaleLinesMajorOuterRadius = 150;
            this.motor_hiz.ScaleLinesMajorStepValue = 1000F;
            this.motor_hiz.ScaleLinesMajorWidth = 2;
            this.motor_hiz.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.motor_hiz.ScaleLinesMinorInnerRadius = 145;
            this.motor_hiz.ScaleLinesMinorNumOf = 9;
            this.motor_hiz.ScaleLinesMinorOuterRadius = 150;
            this.motor_hiz.ScaleLinesMinorWidth = 1;
            this.motor_hiz.ScaleNumbersColor = System.Drawing.Color.Black;
            this.motor_hiz.ScaleNumbersFormat = null;
            this.motor_hiz.ScaleNumbersRadius = 162;
            this.motor_hiz.ScaleNumbersRotation = 90;
            this.motor_hiz.ScaleNumbersStartScaleLine = 1;
            this.motor_hiz.ScaleNumbersStepScaleLines = 2;
            this.motor_hiz.Size = new System.Drawing.Size(297, 121);
            this.motor_hiz.TabIndex = 27;
            this.motor_hiz.Text = "motor_devir";
            this.motor_hiz.Value = 3335F;
            // 
            // hiz
            // 
            this.hiz.BaseArcColor = System.Drawing.Color.Gray;
            this.hiz.BaseArcRadius = 130;
            this.hiz.BaseArcStart = 135;
            this.hiz.BaseArcSweep = 270;
            this.hiz.BaseArcWidth = 2;
            this.hiz.Cap_Idx = ((byte)(1));
            this.hiz.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.hiz.CapPosition = new System.Drawing.Point(160, 100);
            this.hiz.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(160, 100),
        new System.Drawing.Point(125, 200),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.hiz.CapsText = new string[] {
        "",
        "Hız",
        " [km/saat]",
        "",
        ""};
            this.hiz.CapText = "Hız";
            this.hiz.Center = new System.Drawing.Point(170, 170);
            this.hiz.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiz.Location = new System.Drawing.Point(34, 22);
            this.hiz.MaxValue = 180F;
            this.hiz.MinValue = 0F;
            this.hiz.Name = "hiz";
            this.hiz.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.hiz.NeedleColor2 = System.Drawing.SystemColors.GrayText;
            this.hiz.NeedleRadius = 150;
            this.hiz.NeedleType = 0;
            this.hiz.NeedleWidth = 5;
            this.hiz.Range_Idx = ((byte)(0));
            this.hiz.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.hiz.RangeEnabled = true;
            this.hiz.RangeEndValue = 60F;
            this.hiz.RangeInnerRadius = 100;
            this.hiz.RangeOuterRadius = 130;
            this.hiz.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.hiz.RangesEnabled = new bool[] {
        true,
        true,
        true,
        false,
        false};
            this.hiz.RangesEndValue = new float[] {
        60F,
        120F,
        180F,
        0F,
        0F};
            this.hiz.RangesInnerRadius = new int[] {
        100,
        100,
        100,
        70,
        70};
            this.hiz.RangesOuterRadius = new int[] {
        130,
        130,
        130,
        80,
        80};
            this.hiz.RangesStartValue = new float[] {
        0F,
        60F,
        120F,
        0F,
        0F};
            this.hiz.RangeStartValue = 0F;
            this.hiz.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.hiz.ScaleLinesInterInnerRadius = 130;
            this.hiz.ScaleLinesInterOuterRadius = 140;
            this.hiz.ScaleLinesInterWidth = 2;
            this.hiz.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.hiz.ScaleLinesMajorInnerRadius = 130;
            this.hiz.ScaleLinesMajorOuterRadius = 142;
            this.hiz.ScaleLinesMajorStepValue = 20F;
            this.hiz.ScaleLinesMajorWidth = 3;
            this.hiz.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.hiz.ScaleLinesMinorInnerRadius = 130;
            this.hiz.ScaleLinesMinorNumOf = 9;
            this.hiz.ScaleLinesMinorOuterRadius = 140;
            this.hiz.ScaleLinesMinorWidth = 1;
            this.hiz.ScaleNumbersColor = System.Drawing.Color.Black;
            this.hiz.ScaleNumbersFormat = null;
            this.hiz.ScaleNumbersRadius = 160;
            this.hiz.ScaleNumbersRotation = 1;
            this.hiz.ScaleNumbersStartScaleLine = 1;
            this.hiz.ScaleNumbersStepScaleLines = 1;
            this.hiz.Size = new System.Drawing.Size(378, 299);
            this.hiz.TabIndex = 20;
            this.hiz.Text = "HIZ";
            this.hiz.Value = 100F;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Menu;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(496, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Batarya";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Menu;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(998, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Güç";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Menu;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(752, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Akım";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(1036, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "W";
            // 
            // guc_gosterge
            // 
            this.guc_gosterge.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.guc_gosterge.AnimationSpeed = 0;
            this.guc_gosterge.BackColor = System.Drawing.Color.Transparent;
            this.guc_gosterge.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guc_gosterge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guc_gosterge.InnerColor = System.Drawing.SystemColors.Menu;
            this.guc_gosterge.InnerMargin = 2;
            this.guc_gosterge.InnerWidth = -1;
            this.guc_gosterge.Location = new System.Drawing.Point(907, 22);
            this.guc_gosterge.MarqueeAnimationSpeed = 2000;
            this.guc_gosterge.Maximum = 999999;
            this.guc_gosterge.Name = "guc_gosterge";
            this.guc_gosterge.OuterColor = System.Drawing.SystemColors.ControlLight;
            this.guc_gosterge.OuterMargin = -25;
            this.guc_gosterge.OuterWidth = 26;
            this.guc_gosterge.ProgressColor = System.Drawing.Color.Orange;
            this.guc_gosterge.ProgressWidth = 25;
            this.guc_gosterge.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guc_gosterge.Size = new System.Drawing.Size(220, 220);
            this.guc_gosterge.StartAngle = 270;
            this.guc_gosterge.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guc_gosterge.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.guc_gosterge.SubscriptText = "";
            this.guc_gosterge.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guc_gosterge.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.guc_gosterge.SuperscriptText = "";
            this.guc_gosterge.TabIndex = 7;
            this.guc_gosterge.Text = "1";
            this.guc_gosterge.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.guc_gosterge.Value = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Menu;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(502, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sıcaklık";
            // 
            // batarya_gosterge
            // 
            this.batarya_gosterge.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.batarya_gosterge.AnimationSpeed = 500;
            this.batarya_gosterge.BackColor = System.Drawing.Color.Transparent;
            this.batarya_gosterge.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.batarya_gosterge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.batarya_gosterge.InnerColor = System.Drawing.SystemColors.Menu;
            this.batarya_gosterge.InnerMargin = 2;
            this.batarya_gosterge.InnerWidth = -1;
            this.batarya_gosterge.Location = new System.Drawing.Point(422, 264);
            this.batarya_gosterge.MarqueeAnimationSpeed = 2000;
            this.batarya_gosterge.Name = "batarya_gosterge";
            this.batarya_gosterge.OuterColor = System.Drawing.SystemColors.ControlLight;
            this.batarya_gosterge.OuterMargin = -25;
            this.batarya_gosterge.OuterWidth = 26;
            this.batarya_gosterge.ProgressColor = System.Drawing.Color.SeaGreen;
            this.batarya_gosterge.ProgressWidth = 25;
            this.batarya_gosterge.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.batarya_gosterge.Size = new System.Drawing.Size(220, 220);
            this.batarya_gosterge.StartAngle = 270;
            this.batarya_gosterge.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.batarya_gosterge.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.batarya_gosterge.SubscriptText = "";
            this.batarya_gosterge.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.batarya_gosterge.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.batarya_gosterge.SuperscriptText = "%";
            this.batarya_gosterge.TabIndex = 3;
            this.batarya_gosterge.Text = "100";
            this.batarya_gosterge.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.batarya_gosterge.Value = 100;
            // 
            // akim_gosterge
            // 
            this.akim_gosterge.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.akim_gosterge.AnimationSpeed = 0;
            this.akim_gosterge.BackColor = System.Drawing.Color.Transparent;
            this.akim_gosterge.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.akim_gosterge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.akim_gosterge.InnerColor = System.Drawing.SystemColors.Menu;
            this.akim_gosterge.InnerMargin = 2;
            this.akim_gosterge.InnerWidth = -1;
            this.akim_gosterge.Location = new System.Drawing.Point(665, 22);
            this.akim_gosterge.MarqueeAnimationSpeed = 2000;
            this.akim_gosterge.Maximum = 9000;
            this.akim_gosterge.Name = "akim_gosterge";
            this.akim_gosterge.OuterColor = System.Drawing.SystemColors.ControlLight;
            this.akim_gosterge.OuterMargin = -25;
            this.akim_gosterge.OuterWidth = 26;
            this.akim_gosterge.ProgressColor = System.Drawing.Color.Red;
            this.akim_gosterge.ProgressWidth = 25;
            this.akim_gosterge.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.akim_gosterge.Size = new System.Drawing.Size(220, 220);
            this.akim_gosterge.StartAngle = 270;
            this.akim_gosterge.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.akim_gosterge.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.akim_gosterge.SubscriptText = "";
            this.akim_gosterge.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.akim_gosterge.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.akim_gosterge.SuperscriptText = "A";
            this.akim_gosterge.TabIndex = 2;
            this.akim_gosterge.Text = "1";
            this.akim_gosterge.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.akim_gosterge.Value = 1;
            // 
            // sicaklik_gosterge
            // 
            this.sicaklik_gosterge.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.sicaklik_gosterge.AnimationSpeed = 0;
            this.sicaklik_gosterge.BackColor = System.Drawing.Color.Transparent;
            this.sicaklik_gosterge.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sicaklik_gosterge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sicaklik_gosterge.InnerColor = System.Drawing.SystemColors.Menu;
            this.sicaklik_gosterge.InnerMargin = 2;
            this.sicaklik_gosterge.InnerWidth = -1;
            this.sicaklik_gosterge.Location = new System.Drawing.Point(422, 22);
            this.sicaklik_gosterge.MarqueeAnimationSpeed = 2000;
            this.sicaklik_gosterge.Maximum = 3200;
            this.sicaklik_gosterge.Name = "sicaklik_gosterge";
            this.sicaklik_gosterge.OuterColor = System.Drawing.SystemColors.ControlLight;
            this.sicaklik_gosterge.OuterMargin = -25;
            this.sicaklik_gosterge.OuterWidth = 26;
            this.sicaklik_gosterge.ProgressColor = System.Drawing.SystemColors.MenuHighlight;
            this.sicaklik_gosterge.ProgressWidth = 25;
            this.sicaklik_gosterge.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sicaklik_gosterge.Size = new System.Drawing.Size(220, 220);
            this.sicaklik_gosterge.StartAngle = 270;
            this.sicaklik_gosterge.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sicaklik_gosterge.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.sicaklik_gosterge.SubscriptText = "";
            this.sicaklik_gosterge.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sicaklik_gosterge.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.sicaklik_gosterge.SuperscriptText = "°C";
            this.sicaklik_gosterge.TabIndex = 1;
            this.sicaklik_gosterge.Text = "1";
            this.sicaklik_gosterge.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.sicaklik_gosterge.Value = 1;
            // 
            // pil_durumlari
            // 
            this.pil_durumlari.BackColor = System.Drawing.Color.White;
            this.pil_durumlari.Controls.Add(this.groupBox9);
            this.pil_durumlari.Controls.Add(this.groupBox5);
            this.pil_durumlari.Controls.Add(this.groupBox4);
            this.pil_durumlari.Location = new System.Drawing.Point(4, 4);
            this.pil_durumlari.Name = "pil_durumlari";
            this.pil_durumlari.Padding = new System.Windows.Forms.Padding(3);
            this.pil_durumlari.Size = new System.Drawing.Size(1151, 511);
            this.pil_durumlari.TabIndex = 1;
            this.pil_durumlari.Text = "Pil Durumları";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.max_hucre_deger);
            this.groupBox9.Controls.Add(this.min_hucre_deger);
            this.groupBox9.Controls.Add(this.label36);
            this.groupBox9.Controls.Add(this.label34);
            this.groupBox9.Location = new System.Drawing.Point(279, 291);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(344, 82);
            this.groupBox9.TabIndex = 45;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Batarya Ayarları";
            // 
            // max_hucre_deger
            // 
            this.max_hucre_deger.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.max_hucre_deger.Location = new System.Drawing.Point(212, 47);
            this.max_hucre_deger.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.max_hucre_deger.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.max_hucre_deger.Name = "max_hucre_deger";
            this.max_hucre_deger.Size = new System.Drawing.Size(120, 20);
            this.max_hucre_deger.TabIndex = 10;
            this.max_hucre_deger.Value = new decimal(new int[] {
            4200,
            0,
            0,
            0});
            // 
            // min_hucre_deger
            // 
            this.min_hucre_deger.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.min_hucre_deger.Location = new System.Drawing.Point(212, 16);
            this.min_hucre_deger.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.min_hucre_deger.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.min_hucre_deger.Name = "min_hucre_deger";
            this.min_hucre_deger.Size = new System.Drawing.Size(120, 20);
            this.min_hucre_deger.TabIndex = 9;
            this.min_hucre_deger.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label36.Location = new System.Drawing.Point(6, 47);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(200, 17);
            this.label36.TabIndex = 8;
            this.label36.Text = "Maxsimum Hücre Gerilimi (mV)";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label34.Location = new System.Drawing.Point(6, 19);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(190, 17);
            this.label34.TabIndex = 6;
            this.label34.Text = "Minimum Hücre Gerilimi (mV)";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label67);
            this.groupBox5.Controls.Add(this.pil_14_yuzde);
            this.groupBox5.Controls.Add(this.label69);
            this.groupBox5.Controls.Add(this.pil_14_volt);
            this.groupBox5.Controls.Add(this.pil_20_pro);
            this.groupBox5.Controls.Add(this.label71);
            this.groupBox5.Controls.Add(this.label72);
            this.groupBox5.Controls.Add(this.pil_20_yuzde);
            this.groupBox5.Controls.Add(this.label74);
            this.groupBox5.Controls.Add(this.pil_20_volt);
            this.groupBox5.Controls.Add(this.label76);
            this.groupBox5.Controls.Add(this.pil_18_pro);
            this.groupBox5.Controls.Add(this.label77);
            this.groupBox5.Controls.Add(this.pil_19_yuzde);
            this.groupBox5.Controls.Add(this.label79);
            this.groupBox5.Controls.Add(this.pil_19_volt);
            this.groupBox5.Controls.Add(this.label81);
            this.groupBox5.Controls.Add(this.pil_17_pro);
            this.groupBox5.Controls.Add(this.label82);
            this.groupBox5.Controls.Add(this.pil_18_yuzde);
            this.groupBox5.Controls.Add(this.label84);
            this.groupBox5.Controls.Add(this.pil_18_volt);
            this.groupBox5.Controls.Add(this.label86);
            this.groupBox5.Controls.Add(this.pil_16_pro);
            this.groupBox5.Controls.Add(this.label87);
            this.groupBox5.Controls.Add(this.pil_17_yuzde);
            this.groupBox5.Controls.Add(this.label89);
            this.groupBox5.Controls.Add(this.pil_17_volt);
            this.groupBox5.Controls.Add(this.label91);
            this.groupBox5.Controls.Add(this.pil_19_pro);
            this.groupBox5.Controls.Add(this.label92);
            this.groupBox5.Controls.Add(this.pil_16_yuzde);
            this.groupBox5.Controls.Add(this.label94);
            this.groupBox5.Controls.Add(this.pil_16_volt);
            this.groupBox5.Controls.Add(this.label96);
            this.groupBox5.Controls.Add(this.pil_15_pro);
            this.groupBox5.Controls.Add(this.label97);
            this.groupBox5.Controls.Add(this.pil_15_yuzde);
            this.groupBox5.Controls.Add(this.label99);
            this.groupBox5.Controls.Add(this.pil_15_volt);
            this.groupBox5.Controls.Add(this.label101);
            this.groupBox5.Controls.Add(this.pil_14_pro);
            this.groupBox5.Controls.Add(this.label102);
            this.groupBox5.Controls.Add(this.pil_13_yuzde);
            this.groupBox5.Controls.Add(this.label104);
            this.groupBox5.Controls.Add(this.pil_13_volt);
            this.groupBox5.Controls.Add(this.label106);
            this.groupBox5.Controls.Add(this.pil_13_pro);
            this.groupBox5.Controls.Add(this.label108);
            this.groupBox5.Controls.Add(this.pil_12_yuzde);
            this.groupBox5.Controls.Add(this.label110);
            this.groupBox5.Controls.Add(this.pil_12_volt);
            this.groupBox5.Controls.Add(this.label112);
            this.groupBox5.Controls.Add(this.pil_12_pro);
            this.groupBox5.Controls.Add(this.label113);
            this.groupBox5.Controls.Add(this.pil_11_yuzde);
            this.groupBox5.Controls.Add(this.label115);
            this.groupBox5.Controls.Add(this.pil_11_volt);
            this.groupBox5.Controls.Add(this.label117);
            this.groupBox5.Controls.Add(this.pil_11_pro);
            this.groupBox5.Controls.Add(this.label63);
            this.groupBox5.Controls.Add(this.pil_4_yuzde);
            this.groupBox5.Controls.Add(this.label65);
            this.groupBox5.Controls.Add(this.pil_4_volt);
            this.groupBox5.Controls.Add(this.pil_10_pro);
            this.groupBox5.Controls.Add(this.label107);
            this.groupBox5.Controls.Add(this.label58);
            this.groupBox5.Controls.Add(this.pil_10_yuzde);
            this.groupBox5.Controls.Add(this.label60);
            this.groupBox5.Controls.Add(this.pil_10_volt);
            this.groupBox5.Controls.Add(this.label62);
            this.groupBox5.Controls.Add(this.pil_8_pro);
            this.groupBox5.Controls.Add(this.label53);
            this.groupBox5.Controls.Add(this.pil_9_yuzde);
            this.groupBox5.Controls.Add(this.label55);
            this.groupBox5.Controls.Add(this.pil_9_volt);
            this.groupBox5.Controls.Add(this.label57);
            this.groupBox5.Controls.Add(this.pil_7_pro);
            this.groupBox5.Controls.Add(this.label48);
            this.groupBox5.Controls.Add(this.pil_8_yuzde);
            this.groupBox5.Controls.Add(this.label50);
            this.groupBox5.Controls.Add(this.pil_8_volt);
            this.groupBox5.Controls.Add(this.label52);
            this.groupBox5.Controls.Add(this.pil_6_pro);
            this.groupBox5.Controls.Add(this.label43);
            this.groupBox5.Controls.Add(this.pil_7_yuzde);
            this.groupBox5.Controls.Add(this.label45);
            this.groupBox5.Controls.Add(this.pil_7_volt);
            this.groupBox5.Controls.Add(this.label47);
            this.groupBox5.Controls.Add(this.pil_9_pro);
            this.groupBox5.Controls.Add(this.label38);
            this.groupBox5.Controls.Add(this.pil_6_yuzde);
            this.groupBox5.Controls.Add(this.label40);
            this.groupBox5.Controls.Add(this.pil_6_volt);
            this.groupBox5.Controls.Add(this.label42);
            this.groupBox5.Controls.Add(this.pil_5_pro);
            this.groupBox5.Controls.Add(this.label33);
            this.groupBox5.Controls.Add(this.pil_5_yuzde);
            this.groupBox5.Controls.Add(this.label35);
            this.groupBox5.Controls.Add(this.pil_5_volt);
            this.groupBox5.Controls.Add(this.label37);
            this.groupBox5.Controls.Add(this.pil_4_pro);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.pil_3_yuzde);
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Controls.Add(this.pil_3_volt);
            this.groupBox5.Controls.Add(this.label32);
            this.groupBox5.Controls.Add(this.pil_3_pro);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.pil_2_yuzde);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.pil_2_volt);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.pil_2_pro);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.pil_1_yuzde);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.pil_1_volt);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.pil_1_pro);
            this.groupBox5.Location = new System.Drawing.Point(4, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1141, 278);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hücre Gerilimleri";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label67.Location = new System.Drawing.Point(415, 220);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(25, 24);
            this.label67.TabIndex = 177;
            this.label67.Text = "%";
            // 
            // pil_14_yuzde
            // 
            this.pil_14_yuzde.AutoSize = true;
            this.pil_14_yuzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_14_yuzde.Location = new System.Drawing.Point(363, 220);
            this.pil_14_yuzde.Name = "pil_14_yuzde";
            this.pil_14_yuzde.Size = new System.Drawing.Size(40, 24);
            this.pil_14_yuzde.TabIndex = 176;
            this.pil_14_yuzde.Text = "100";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label69.Location = new System.Drawing.Point(417, 196);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(39, 24);
            this.label69.TabIndex = 175;
            this.label69.Text = "mV";
            // 
            // pil_14_volt
            // 
            this.pil_14_volt.AutoSize = true;
            this.pil_14_volt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_14_volt.Location = new System.Drawing.Point(363, 196);
            this.pil_14_volt.Name = "pil_14_volt";
            this.pil_14_volt.Size = new System.Drawing.Size(50, 24);
            this.pil_14_volt.TabIndex = 174;
            this.pil_14_volt.Text = "4200";
            // 
            // pil_20_pro
            // 
            this.pil_20_pro.Location = new System.Drawing.Point(1040, 170);
            this.pil_20_pro.Name = "pil_20_pro";
            this.pil_20_pro.Size = new System.Drawing.Size(73, 23);
            this.pil_20_pro.TabIndex = 173;
            this.pil_20_pro.Value = 100;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label71.Location = new System.Drawing.Point(1036, 143);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(87, 24);
            this.label71.TabIndex = 172;
            this.label71.Text = "20.Hücre";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label72.Location = new System.Drawing.Point(1092, 220);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(25, 24);
            this.label72.TabIndex = 171;
            this.label72.Text = "%";
            // 
            // pil_20_yuzde
            // 
            this.pil_20_yuzde.AutoSize = true;
            this.pil_20_yuzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_20_yuzde.Location = new System.Drawing.Point(1036, 220);
            this.pil_20_yuzde.Name = "pil_20_yuzde";
            this.pil_20_yuzde.Size = new System.Drawing.Size(40, 24);
            this.pil_20_yuzde.TabIndex = 170;
            this.pil_20_yuzde.Text = "100";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label74.Location = new System.Drawing.Point(1094, 196);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(39, 24);
            this.label74.TabIndex = 169;
            this.label74.Text = "mV";
            // 
            // pil_20_volt
            // 
            this.pil_20_volt.AutoSize = true;
            this.pil_20_volt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_20_volt.Location = new System.Drawing.Point(1036, 196);
            this.pil_20_volt.Name = "pil_20_volt";
            this.pil_20_volt.Size = new System.Drawing.Size(50, 24);
            this.pil_20_volt.TabIndex = 168;
            this.pil_20_volt.Text = "4200";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label76.Location = new System.Drawing.Point(931, 143);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(87, 24);
            this.label76.TabIndex = 167;
            this.label76.Text = "19.Hücre";
            // 
            // pil_18_pro
            // 
            this.pil_18_pro.Location = new System.Drawing.Point(823, 170);
            this.pil_18_pro.Name = "pil_18_pro";
            this.pil_18_pro.Size = new System.Drawing.Size(73, 23);
            this.pil_18_pro.TabIndex = 166;
            this.pil_18_pro.Value = 100;
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label77.Location = new System.Drawing.Point(985, 220);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(25, 24);
            this.label77.TabIndex = 165;
            this.label77.Text = "%";
            // 
            // pil_19_yuzde
            // 
            this.pil_19_yuzde.AutoSize = true;
            this.pil_19_yuzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_19_yuzde.Location = new System.Drawing.Point(931, 220);
            this.pil_19_yuzde.Name = "pil_19_yuzde";
            this.pil_19_yuzde.Size = new System.Drawing.Size(40, 24);
            this.pil_19_yuzde.TabIndex = 164;
            this.pil_19_yuzde.Text = "100";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label79.Location = new System.Drawing.Point(985, 196);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(39, 24);
            this.label79.TabIndex = 163;
            this.label79.Text = "mV";
            // 
            // pil_19_volt
            // 
            this.pil_19_volt.AutoSize = true;
            this.pil_19_volt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_19_volt.Location = new System.Drawing.Point(931, 196);
            this.pil_19_volt.Name = "pil_19_volt";
            this.pil_19_volt.Size = new System.Drawing.Size(50, 24);
            this.pil_19_volt.TabIndex = 162;
            this.pil_19_volt.Text = "4200";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label81.Location = new System.Drawing.Point(819, 143);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(87, 24);
            this.label81.TabIndex = 161;
            this.label81.Text = "18.Hücre";
            // 
            // pil_17_pro
            // 
            this.pil_17_pro.Location = new System.Drawing.Point(707, 170);
            this.pil_17_pro.Name = "pil_17_pro";
            this.pil_17_pro.Size = new System.Drawing.Size(73, 23);
            this.pil_17_pro.TabIndex = 160;
            this.pil_17_pro.Value = 100;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label82.Location = new System.Drawing.Point(872, 220);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(25, 24);
            this.label82.TabIndex = 159;
            this.label82.Text = "%";
            // 
            // pil_18_yuzde
            // 
            this.pil_18_yuzde.AutoSize = true;
            this.pil_18_yuzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_18_yuzde.Location = new System.Drawing.Point(819, 220);
            this.pil_18_yuzde.Name = "pil_18_yuzde";
            this.pil_18_yuzde.Size = new System.Drawing.Size(40, 24);
            this.pil_18_yuzde.TabIndex = 158;
            this.pil_18_yuzde.Text = "100";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label84.Location = new System.Drawing.Point(879, 196);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(39, 24);
            this.label84.TabIndex = 157;
            this.label84.Text = "mV";
            // 
            // pil_18_volt
            // 
            this.pil_18_volt.AutoSize = true;
            this.pil_18_volt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_18_volt.Location = new System.Drawing.Point(819, 196);
            this.pil_18_volt.Name = "pil_18_volt";
            this.pil_18_volt.Size = new System.Drawing.Size(50, 24);
            this.pil_18_volt.TabIndex = 156;
            this.pil_18_volt.Text = "4200";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label86.Location = new System.Drawing.Point(703, 143);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(87, 24);
            this.label86.TabIndex = 155;
            this.label86.Text = "17.Hücre";
            // 
            // pil_16_pro
            // 
            this.pil_16_pro.Location = new System.Drawing.Point(591, 170);
            this.pil_16_pro.Name = "pil_16_pro";
            this.pil_16_pro.Size = new System.Drawing.Size(73, 23);
            this.pil_16_pro.TabIndex = 154;
            this.pil_16_pro.Value = 100;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label87.Location = new System.Drawing.Point(755, 220);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(25, 24);
            this.label87.TabIndex = 153;
            this.label87.Text = "%";
            // 
            // pil_17_yuzde
            // 
            this.pil_17_yuzde.AutoSize = true;
            this.pil_17_yuzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_17_yuzde.Location = new System.Drawing.Point(703, 220);
            this.pil_17_yuzde.Name = "pil_17_yuzde";
            this.pil_17_yuzde.Size = new System.Drawing.Size(40, 24);
            this.pil_17_yuzde.TabIndex = 152;
            this.pil_17_yuzde.Text = "100";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label89.Location = new System.Drawing.Point(757, 196);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(39, 24);
            this.label89.TabIndex = 151;
            this.label89.Text = "mV";
            // 
            // pil_17_volt
            // 
            this.pil_17_volt.AutoSize = true;
            this.pil_17_volt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_17_volt.Location = new System.Drawing.Point(703, 196);
            this.pil_17_volt.Name = "pil_17_volt";
            this.pil_17_volt.Size = new System.Drawing.Size(50, 24);
            this.pil_17_volt.TabIndex = 150;
            this.pil_17_volt.Text = "4200";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label91.Location = new System.Drawing.Point(591, 143);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(87, 24);
            this.label91.TabIndex = 149;
            this.label91.Text = "16.Hücre";
            // 
            // pil_19_pro
            // 
            this.pil_19_pro.Location = new System.Drawing.Point(935, 170);
            this.pil_19_pro.Name = "pil_19_pro";
            this.pil_19_pro.Size = new System.Drawing.Size(73, 23);
            this.pil_19_pro.TabIndex = 148;
            this.pil_19_pro.Value = 100;
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label92.Location = new System.Drawing.Point(643, 220);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(25, 24);
            this.label92.TabIndex = 147;
            this.label92.Text = "%";
            // 
            // pil_16_yuzde
            // 
            this.pil_16_yuzde.AutoSize = true;
            this.pil_16_yuzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_16_yuzde.Location = new System.Drawing.Point(588, 220);
            this.pil_16_yuzde.Name = "pil_16_yuzde";
            this.pil_16_yuzde.Size = new System.Drawing.Size(40, 24);
            this.pil_16_yuzde.TabIndex = 146;
            this.pil_16_yuzde.Text = "100";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label94.Location = new System.Drawing.Point(639, 196);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(39, 24);
            this.label94.TabIndex = 145;
            this.label94.Text = "mV";
            // 
            // pil_16_volt
            // 
            this.pil_16_volt.AutoSize = true;
            this.pil_16_volt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_16_volt.Location = new System.Drawing.Point(588, 196);
            this.pil_16_volt.Name = "pil_16_volt";
            this.pil_16_volt.Size = new System.Drawing.Size(50, 24);
            this.pil_16_volt.TabIndex = 144;
            this.pil_16_volt.Text = "4200";
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label96.Location = new System.Drawing.Point(476, 143);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(87, 24);
            this.label96.TabIndex = 143;
            this.label96.Text = "15.Hücre";
            // 
            // pil_15_pro
            // 
            this.pil_15_pro.Location = new System.Drawing.Point(480, 170);
            this.pil_15_pro.Name = "pil_15_pro";
            this.pil_15_pro.Size = new System.Drawing.Size(73, 23);
            this.pil_15_pro.TabIndex = 142;
            this.pil_15_pro.Value = 100;
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label97.Location = new System.Drawing.Point(528, 220);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(25, 24);
            this.label97.TabIndex = 141;
            this.label97.Text = "%";
            // 
            // pil_15_yuzde
            // 
            this.pil_15_yuzde.AutoSize = true;
            this.pil_15_yuzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_15_yuzde.Location = new System.Drawing.Point(476, 220);
            this.pil_15_yuzde.Name = "pil_15_yuzde";
            this.pil_15_yuzde.Size = new System.Drawing.Size(40, 24);
            this.pil_15_yuzde.TabIndex = 140;
            this.pil_15_yuzde.Text = "100";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label99.Location = new System.Drawing.Point(530, 196);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(39, 24);
            this.label99.TabIndex = 139;
            this.label99.Text = "mV";
            // 
            // pil_15_volt
            // 
            this.pil_15_volt.AutoSize = true;
            this.pil_15_volt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_15_volt.Location = new System.Drawing.Point(476, 196);
            this.pil_15_volt.Name = "pil_15_volt";
            this.pil_15_volt.Size = new System.Drawing.Size(50, 24);
            this.pil_15_volt.TabIndex = 138;
            this.pil_15_volt.Text = "4200";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label101.Location = new System.Drawing.Point(363, 143);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(87, 24);
            this.label101.TabIndex = 137;
            this.label101.Text = "14.Hücre";
            // 
            // pil_14_pro
            // 
            this.pil_14_pro.Location = new System.Drawing.Point(367, 170);
            this.pil_14_pro.Name = "pil_14_pro";
            this.pil_14_pro.Size = new System.Drawing.Size(73, 23);
            this.pil_14_pro.TabIndex = 136;
            this.pil_14_pro.Value = 100;
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label102.Location = new System.Drawing.Point(297, 220);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(25, 24);
            this.label102.TabIndex = 135;
            this.label102.Text = "%";
            // 
            // pil_13_yuzde
            // 
            this.pil_13_yuzde.AutoSize = true;
            this.pil_13_yuzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_13_yuzde.Location = new System.Drawing.Point(253, 220);
            this.pil_13_yuzde.Name = "pil_13_yuzde";
            this.pil_13_yuzde.Size = new System.Drawing.Size(40, 24);
            this.pil_13_yuzde.TabIndex = 134;
            this.pil_13_yuzde.Text = "100";
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label104.Location = new System.Drawing.Point(297, 196);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(39, 24);
            this.label104.TabIndex = 133;
            this.label104.Text = "mV";
            // 
            // pil_13_volt
            // 
            this.pil_13_volt.AutoSize = true;
            this.pil_13_volt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_13_volt.Location = new System.Drawing.Point(253, 196);
            this.pil_13_volt.Name = "pil_13_volt";
            this.pil_13_volt.Size = new System.Drawing.Size(50, 24);
            this.pil_13_volt.TabIndex = 132;
            this.pil_13_volt.Text = "4200";
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label106.Location = new System.Drawing.Point(253, 143);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(87, 24);
            this.label106.TabIndex = 131;
            this.label106.Text = "13.Hücre";
            // 
            // pil_13_pro
            // 
            this.pil_13_pro.Location = new System.Drawing.Point(254, 170);
            this.pil_13_pro.Name = "pil_13_pro";
            this.pil_13_pro.Size = new System.Drawing.Size(73, 23);
            this.pil_13_pro.TabIndex = 130;
            this.pil_13_pro.Value = 100;
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label108.Location = new System.Drawing.Point(183, 220);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(25, 24);
            this.label108.TabIndex = 129;
            this.label108.Text = "%";
            // 
            // pil_12_yuzde
            // 
            this.pil_12_yuzde.AutoSize = true;
            this.pil_12_yuzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_12_yuzde.Location = new System.Drawing.Point(132, 220);
            this.pil_12_yuzde.Name = "pil_12_yuzde";
            this.pil_12_yuzde.Size = new System.Drawing.Size(40, 24);
            this.pil_12_yuzde.TabIndex = 128;
            this.pil_12_yuzde.Text = "100";
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label110.Location = new System.Drawing.Point(186, 196);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(39, 24);
            this.label110.TabIndex = 127;
            this.label110.Text = "mV";
            // 
            // pil_12_volt
            // 
            this.pil_12_volt.AutoSize = true;
            this.pil_12_volt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_12_volt.Location = new System.Drawing.Point(132, 196);
            this.pil_12_volt.Name = "pil_12_volt";
            this.pil_12_volt.Size = new System.Drawing.Size(50, 24);
            this.pil_12_volt.TabIndex = 126;
            this.pil_12_volt.Text = "4200";
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label112.Location = new System.Drawing.Point(132, 143);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(87, 24);
            this.label112.TabIndex = 125;
            this.label112.Text = "12.Hücre";
            // 
            // pil_12_pro
            // 
            this.pil_12_pro.Location = new System.Drawing.Point(136, 170);
            this.pil_12_pro.Name = "pil_12_pro";
            this.pil_12_pro.Size = new System.Drawing.Size(73, 23);
            this.pil_12_pro.TabIndex = 124;
            this.pil_12_pro.Value = 100;
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label113.Location = new System.Drawing.Point(69, 220);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(25, 24);
            this.label113.TabIndex = 123;
            this.label113.Text = "%";
            // 
            // pil_11_yuzde
            // 
            this.pil_11_yuzde.AutoSize = true;
            this.pil_11_yuzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_11_yuzde.Location = new System.Drawing.Point(25, 220);
            this.pil_11_yuzde.Name = "pil_11_yuzde";
            this.pil_11_yuzde.Size = new System.Drawing.Size(40, 24);
            this.pil_11_yuzde.TabIndex = 122;
            this.pil_11_yuzde.Text = "100";
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label115.Location = new System.Drawing.Point(69, 196);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(39, 24);
            this.label115.TabIndex = 121;
            this.label115.Text = "mV";
            // 
            // pil_11_volt
            // 
            this.pil_11_volt.AutoSize = true;
            this.pil_11_volt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_11_volt.Location = new System.Drawing.Point(25, 196);
            this.pil_11_volt.Name = "pil_11_volt";
            this.pil_11_volt.Size = new System.Drawing.Size(50, 24);
            this.pil_11_volt.TabIndex = 120;
            this.pil_11_volt.Text = "4200";
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label117.Location = new System.Drawing.Point(18, 143);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(87, 24);
            this.label117.TabIndex = 119;
            this.label117.Text = "11.Hücre";
            // 
            // pil_11_pro
            // 
            this.pil_11_pro.Location = new System.Drawing.Point(22, 170);
            this.pil_11_pro.Name = "pil_11_pro";
            this.pil_11_pro.Size = new System.Drawing.Size(73, 23);
            this.pil_11_pro.TabIndex = 118;
            this.pil_11_pro.Value = 100;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label63.Location = new System.Drawing.Point(419, 101);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(25, 24);
            this.label63.TabIndex = 117;
            this.label63.Text = "%";
            // 
            // pil_4_yuzde
            // 
            this.pil_4_yuzde.AutoSize = true;
            this.pil_4_yuzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_4_yuzde.Location = new System.Drawing.Point(367, 101);
            this.pil_4_yuzde.Name = "pil_4_yuzde";
            this.pil_4_yuzde.Size = new System.Drawing.Size(40, 24);
            this.pil_4_yuzde.TabIndex = 116;
            this.pil_4_yuzde.Text = "100";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label65.Location = new System.Drawing.Point(421, 77);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(39, 24);
            this.label65.TabIndex = 115;
            this.label65.Text = "mV";
            // 
            // pil_4_volt
            // 
            this.pil_4_volt.AutoSize = true;
            this.pil_4_volt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_4_volt.Location = new System.Drawing.Point(367, 77);
            this.pil_4_volt.Name = "pil_4_volt";
            this.pil_4_volt.Size = new System.Drawing.Size(50, 24);
            this.pil_4_volt.TabIndex = 114;
            this.pil_4_volt.Text = "4200";
            // 
            // pil_10_pro
            // 
            this.pil_10_pro.Location = new System.Drawing.Point(1044, 51);
            this.pil_10_pro.Name = "pil_10_pro";
            this.pil_10_pro.Size = new System.Drawing.Size(73, 23);
            this.pil_10_pro.TabIndex = 113;
            this.pil_10_pro.Value = 100;
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label107.Location = new System.Drawing.Point(1040, 24);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(87, 24);
            this.label107.TabIndex = 60;
            this.label107.Text = "10.Hücre";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label58.Location = new System.Drawing.Point(1096, 101);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(25, 24);
            this.label58.TabIndex = 58;
            this.label58.Text = "%";
            // 
            // pil_10_yuzde
            // 
            this.pil_10_yuzde.AutoSize = true;
            this.pil_10_yuzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_10_yuzde.Location = new System.Drawing.Point(1040, 101);
            this.pil_10_yuzde.Name = "pil_10_yuzde";
            this.pil_10_yuzde.Size = new System.Drawing.Size(40, 24);
            this.pil_10_yuzde.TabIndex = 57;
            this.pil_10_yuzde.Text = "100";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label60.Location = new System.Drawing.Point(1098, 77);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(39, 24);
            this.label60.TabIndex = 56;
            this.label60.Text = "mV";
            // 
            // pil_10_volt
            // 
            this.pil_10_volt.AutoSize = true;
            this.pil_10_volt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_10_volt.Location = new System.Drawing.Point(1040, 77);
            this.pil_10_volt.Name = "pil_10_volt";
            this.pil_10_volt.Size = new System.Drawing.Size(50, 24);
            this.pil_10_volt.TabIndex = 55;
            this.pil_10_volt.Text = "4200";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label62.Location = new System.Drawing.Point(935, 24);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(77, 24);
            this.label62.TabIndex = 54;
            this.label62.Text = "9.Hücre";
            // 
            // pil_8_pro
            // 
            this.pil_8_pro.Location = new System.Drawing.Point(827, 51);
            this.pil_8_pro.Name = "pil_8_pro";
            this.pil_8_pro.Size = new System.Drawing.Size(73, 23);
            this.pil_8_pro.TabIndex = 53;
            this.pil_8_pro.Value = 100;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label53.Location = new System.Drawing.Point(989, 101);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(25, 24);
            this.label53.TabIndex = 52;
            this.label53.Text = "%";
            // 
            // pil_9_yuzde
            // 
            this.pil_9_yuzde.AutoSize = true;
            this.pil_9_yuzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_9_yuzde.Location = new System.Drawing.Point(935, 101);
            this.pil_9_yuzde.Name = "pil_9_yuzde";
            this.pil_9_yuzde.Size = new System.Drawing.Size(40, 24);
            this.pil_9_yuzde.TabIndex = 51;
            this.pil_9_yuzde.Text = "100";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label55.Location = new System.Drawing.Point(989, 77);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(39, 24);
            this.label55.TabIndex = 50;
            this.label55.Text = "mV";
            // 
            // pil_9_volt
            // 
            this.pil_9_volt.AutoSize = true;
            this.pil_9_volt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_9_volt.Location = new System.Drawing.Point(935, 77);
            this.pil_9_volt.Name = "pil_9_volt";
            this.pil_9_volt.Size = new System.Drawing.Size(50, 24);
            this.pil_9_volt.TabIndex = 49;
            this.pil_9_volt.Text = "4200";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label57.Location = new System.Drawing.Point(823, 24);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(77, 24);
            this.label57.TabIndex = 48;
            this.label57.Text = "8.Hücre";
            // 
            // pil_7_pro
            // 
            this.pil_7_pro.Location = new System.Drawing.Point(711, 51);
            this.pil_7_pro.Name = "pil_7_pro";
            this.pil_7_pro.Size = new System.Drawing.Size(73, 23);
            this.pil_7_pro.TabIndex = 47;
            this.pil_7_pro.Value = 100;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label48.Location = new System.Drawing.Point(876, 101);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(25, 24);
            this.label48.TabIndex = 46;
            this.label48.Text = "%";
            // 
            // pil_8_yuzde
            // 
            this.pil_8_yuzde.AutoSize = true;
            this.pil_8_yuzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_8_yuzde.Location = new System.Drawing.Point(823, 101);
            this.pil_8_yuzde.Name = "pil_8_yuzde";
            this.pil_8_yuzde.Size = new System.Drawing.Size(40, 24);
            this.pil_8_yuzde.TabIndex = 45;
            this.pil_8_yuzde.Text = "100";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label50.Location = new System.Drawing.Point(883, 77);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(39, 24);
            this.label50.TabIndex = 44;
            this.label50.Text = "mV";
            // 
            // pil_8_volt
            // 
            this.pil_8_volt.AutoSize = true;
            this.pil_8_volt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_8_volt.Location = new System.Drawing.Point(823, 77);
            this.pil_8_volt.Name = "pil_8_volt";
            this.pil_8_volt.Size = new System.Drawing.Size(50, 24);
            this.pil_8_volt.TabIndex = 43;
            this.pil_8_volt.Text = "4200";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label52.Location = new System.Drawing.Point(707, 24);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(77, 24);
            this.label52.TabIndex = 42;
            this.label52.Text = "7.Hücre";
            // 
            // pil_6_pro
            // 
            this.pil_6_pro.Location = new System.Drawing.Point(595, 51);
            this.pil_6_pro.Name = "pil_6_pro";
            this.pil_6_pro.Size = new System.Drawing.Size(73, 23);
            this.pil_6_pro.TabIndex = 41;
            this.pil_6_pro.Value = 100;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label43.Location = new System.Drawing.Point(759, 101);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(25, 24);
            this.label43.TabIndex = 40;
            this.label43.Text = "%";
            // 
            // pil_7_yuzde
            // 
            this.pil_7_yuzde.AutoSize = true;
            this.pil_7_yuzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_7_yuzde.Location = new System.Drawing.Point(707, 101);
            this.pil_7_yuzde.Name = "pil_7_yuzde";
            this.pil_7_yuzde.Size = new System.Drawing.Size(40, 24);
            this.pil_7_yuzde.TabIndex = 39;
            this.pil_7_yuzde.Text = "100";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label45.Location = new System.Drawing.Point(761, 77);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(39, 24);
            this.label45.TabIndex = 38;
            this.label45.Text = "mV";
            // 
            // pil_7_volt
            // 
            this.pil_7_volt.AutoSize = true;
            this.pil_7_volt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_7_volt.Location = new System.Drawing.Point(707, 77);
            this.pil_7_volt.Name = "pil_7_volt";
            this.pil_7_volt.Size = new System.Drawing.Size(50, 24);
            this.pil_7_volt.TabIndex = 37;
            this.pil_7_volt.Text = "4200";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label47.Location = new System.Drawing.Point(595, 24);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(77, 24);
            this.label47.TabIndex = 36;
            this.label47.Text = "6.Hücre";
            // 
            // pil_9_pro
            // 
            this.pil_9_pro.Location = new System.Drawing.Point(939, 51);
            this.pil_9_pro.Name = "pil_9_pro";
            this.pil_9_pro.Size = new System.Drawing.Size(73, 23);
            this.pil_9_pro.TabIndex = 35;
            this.pil_9_pro.Value = 100;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label38.Location = new System.Drawing.Point(647, 101);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(25, 24);
            this.label38.TabIndex = 34;
            this.label38.Text = "%";
            // 
            // pil_6_yuzde
            // 
            this.pil_6_yuzde.AutoSize = true;
            this.pil_6_yuzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_6_yuzde.Location = new System.Drawing.Point(592, 101);
            this.pil_6_yuzde.Name = "pil_6_yuzde";
            this.pil_6_yuzde.Size = new System.Drawing.Size(40, 24);
            this.pil_6_yuzde.TabIndex = 33;
            this.pil_6_yuzde.Text = "100";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label40.Location = new System.Drawing.Point(643, 77);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(39, 24);
            this.label40.TabIndex = 32;
            this.label40.Text = "mV";
            // 
            // pil_6_volt
            // 
            this.pil_6_volt.AutoSize = true;
            this.pil_6_volt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_6_volt.Location = new System.Drawing.Point(592, 77);
            this.pil_6_volt.Name = "pil_6_volt";
            this.pil_6_volt.Size = new System.Drawing.Size(50, 24);
            this.pil_6_volt.TabIndex = 31;
            this.pil_6_volt.Text = "4200";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label42.Location = new System.Drawing.Point(480, 24);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(77, 24);
            this.label42.TabIndex = 30;
            this.label42.Text = "5.Hücre";
            // 
            // pil_5_pro
            // 
            this.pil_5_pro.Location = new System.Drawing.Point(484, 51);
            this.pil_5_pro.Name = "pil_5_pro";
            this.pil_5_pro.Size = new System.Drawing.Size(73, 23);
            this.pil_5_pro.TabIndex = 29;
            this.pil_5_pro.Value = 100;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label33.Location = new System.Drawing.Point(532, 101);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(25, 24);
            this.label33.TabIndex = 28;
            this.label33.Text = "%";
            // 
            // pil_5_yuzde
            // 
            this.pil_5_yuzde.AutoSize = true;
            this.pil_5_yuzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_5_yuzde.Location = new System.Drawing.Point(480, 101);
            this.pil_5_yuzde.Name = "pil_5_yuzde";
            this.pil_5_yuzde.Size = new System.Drawing.Size(40, 24);
            this.pil_5_yuzde.TabIndex = 27;
            this.pil_5_yuzde.Text = "100";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label35.Location = new System.Drawing.Point(534, 77);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(39, 24);
            this.label35.TabIndex = 26;
            this.label35.Text = "mV";
            // 
            // pil_5_volt
            // 
            this.pil_5_volt.AutoSize = true;
            this.pil_5_volt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_5_volt.Location = new System.Drawing.Point(480, 77);
            this.pil_5_volt.Name = "pil_5_volt";
            this.pil_5_volt.Size = new System.Drawing.Size(50, 24);
            this.pil_5_volt.TabIndex = 25;
            this.pil_5_volt.Text = "4200";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label37.Location = new System.Drawing.Point(367, 24);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(77, 24);
            this.label37.TabIndex = 24;
            this.label37.Text = "4.Hücre";
            // 
            // pil_4_pro
            // 
            this.pil_4_pro.Location = new System.Drawing.Point(371, 51);
            this.pil_4_pro.Name = "pil_4_pro";
            this.pil_4_pro.Size = new System.Drawing.Size(73, 23);
            this.pil_4_pro.TabIndex = 23;
            this.pil_4_pro.Value = 100;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label28.Location = new System.Drawing.Point(301, 101);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(25, 24);
            this.label28.TabIndex = 22;
            this.label28.Text = "%";
            // 
            // pil_3_yuzde
            // 
            this.pil_3_yuzde.AutoSize = true;
            this.pil_3_yuzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_3_yuzde.Location = new System.Drawing.Point(257, 101);
            this.pil_3_yuzde.Name = "pil_3_yuzde";
            this.pil_3_yuzde.Size = new System.Drawing.Size(40, 24);
            this.pil_3_yuzde.TabIndex = 21;
            this.pil_3_yuzde.Text = "100";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label30.Location = new System.Drawing.Point(301, 77);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(39, 24);
            this.label30.TabIndex = 20;
            this.label30.Text = "mV";
            // 
            // pil_3_volt
            // 
            this.pil_3_volt.AutoSize = true;
            this.pil_3_volt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_3_volt.Location = new System.Drawing.Point(257, 77);
            this.pil_3_volt.Name = "pil_3_volt";
            this.pil_3_volt.Size = new System.Drawing.Size(50, 24);
            this.pil_3_volt.TabIndex = 19;
            this.pil_3_volt.Text = "4200";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label32.Location = new System.Drawing.Point(257, 24);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(77, 24);
            this.label32.TabIndex = 18;
            this.label32.Text = "3.Hücre";
            // 
            // pil_3_pro
            // 
            this.pil_3_pro.Location = new System.Drawing.Point(258, 51);
            this.pil_3_pro.Name = "pil_3_pro";
            this.pil_3_pro.Size = new System.Drawing.Size(73, 23);
            this.pil_3_pro.TabIndex = 17;
            this.pil_3_pro.Value = 100;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(187, 101);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(25, 24);
            this.label23.TabIndex = 16;
            this.label23.Text = "%";
            // 
            // pil_2_yuzde
            // 
            this.pil_2_yuzde.AutoSize = true;
            this.pil_2_yuzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_2_yuzde.Location = new System.Drawing.Point(136, 101);
            this.pil_2_yuzde.Name = "pil_2_yuzde";
            this.pil_2_yuzde.Size = new System.Drawing.Size(40, 24);
            this.pil_2_yuzde.TabIndex = 15;
            this.pil_2_yuzde.Text = "100";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.Location = new System.Drawing.Point(190, 77);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(39, 24);
            this.label25.TabIndex = 14;
            this.label25.Text = "mV";
            // 
            // pil_2_volt
            // 
            this.pil_2_volt.AutoSize = true;
            this.pil_2_volt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_2_volt.Location = new System.Drawing.Point(136, 77);
            this.pil_2_volt.Name = "pil_2_volt";
            this.pil_2_volt.Size = new System.Drawing.Size(50, 24);
            this.pil_2_volt.TabIndex = 13;
            this.pil_2_volt.Text = "4200";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label27.Location = new System.Drawing.Point(136, 24);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(77, 24);
            this.label27.TabIndex = 12;
            this.label27.Text = "2.Hücre";
            // 
            // pil_2_pro
            // 
            this.pil_2_pro.Location = new System.Drawing.Point(140, 51);
            this.pil_2_pro.Name = "pil_2_pro";
            this.pil_2_pro.Size = new System.Drawing.Size(73, 23);
            this.pil_2_pro.TabIndex = 11;
            this.pil_2_pro.Value = 100;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(73, 101);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(25, 24);
            this.label22.TabIndex = 10;
            this.label22.Text = "%";
            // 
            // pil_1_yuzde
            // 
            this.pil_1_yuzde.AutoSize = true;
            this.pil_1_yuzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_1_yuzde.Location = new System.Drawing.Point(29, 101);
            this.pil_1_yuzde.Name = "pil_1_yuzde";
            this.pil_1_yuzde.Size = new System.Drawing.Size(40, 24);
            this.pil_1_yuzde.TabIndex = 9;
            this.pil_1_yuzde.Text = "100";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(73, 77);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 24);
            this.label20.TabIndex = 8;
            this.label20.Text = "mV";
            // 
            // pil_1_volt
            // 
            this.pil_1_volt.AutoSize = true;
            this.pil_1_volt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pil_1_volt.Location = new System.Drawing.Point(29, 77);
            this.pil_1_volt.Name = "pil_1_volt";
            this.pil_1_volt.Size = new System.Drawing.Size(50, 24);
            this.pil_1_volt.TabIndex = 7;
            this.pil_1_volt.Text = "4200";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(22, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 24);
            this.label18.TabIndex = 6;
            this.label18.Text = "1.Hücre";
            // 
            // pil_1_pro
            // 
            this.pil_1_pro.Location = new System.Drawing.Point(26, 51);
            this.pil_1_pro.Name = "pil_1_pro";
            this.pil_1_pro.Size = new System.Drawing.Size(73, 23);
            this.pil_1_pro.TabIndex = 0;
            this.pil_1_pro.Value = 100;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.genel_volt_yuzde);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.genel_volt_deger);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.genel_volt_pro);
            this.groupBox4.Location = new System.Drawing.Point(6, 291);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(267, 214);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Toplam Enerji Seviyesi";
            // 
            // genel_volt_yuzde
            // 
            this.genel_volt_yuzde.AutoSize = true;
            this.genel_volt_yuzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.genel_volt_yuzde.Location = new System.Drawing.Point(145, 53);
            this.genel_volt_yuzde.Name = "genel_volt_yuzde";
            this.genel_volt_yuzde.Size = new System.Drawing.Size(77, 39);
            this.genel_volt_yuzde.TabIndex = 5;
            this.genel_volt_yuzde.Text = "100";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(212, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 39);
            this.label16.TabIndex = 4;
            this.label16.Text = "%";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(69, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 39);
            this.label15.TabIndex = 3;
            this.label15.Text = "V";
            // 
            // genel_volt_deger
            // 
            this.genel_volt_deger.AutoSize = true;
            this.genel_volt_deger.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.genel_volt_deger.Location = new System.Drawing.Point(15, 53);
            this.genel_volt_deger.Name = "genel_volt_deger";
            this.genel_volt_deger.Size = new System.Drawing.Size(57, 39);
            this.genel_volt_deger.TabIndex = 2;
            this.genel_volt_deger.Text = "84";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(34, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(208, 24);
            this.label13.TabIndex = 1;
            this.label13.Text = "Toplam Batarya Gerilimi";
            // 
            // genel_volt_pro
            // 
            this.genel_volt_pro.Location = new System.Drawing.Point(6, 95);
            this.genel_volt_pro.Name = "genel_volt_pro";
            this.genel_volt_pro.Size = new System.Drawing.Size(255, 113);
            this.genel_volt_pro.TabIndex = 0;
            this.genel_volt_pro.Value = 100;
            // 
            // ayrinti
            // 
            this.ayrinti.Controls.Add(this.groupBox7);
            this.ayrinti.Location = new System.Drawing.Point(4, 4);
            this.ayrinti.Name = "ayrinti";
            this.ayrinti.Size = new System.Drawing.Size(1151, 511);
            this.ayrinti.TabIndex = 4;
            this.ayrinti.Text = "Ayrıntılı Veriler";
            this.ayrinti.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.sicaklik_sensor_1);
            this.groupBox7.Controls.Add(this.label31);
            this.groupBox7.Controls.Add(this.label29);
            this.groupBox7.Controls.Add(this.label26);
            this.groupBox7.Controls.Add(this.label24);
            this.groupBox7.Controls.Add(this.sicaklik_sensor_2);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.sicaklik_sensor_4);
            this.groupBox7.Controls.Add(this.sicaklik_sensor_3);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Location = new System.Drawing.Point(4, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(243, 152);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Sıcaklık Verileri";
            // 
            // sicaklik_sensor_1
            // 
            this.sicaklik_sensor_1.AutoSize = true;
            this.sicaklik_sensor_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sicaklik_sensor_1.Location = new System.Drawing.Point(166, 27);
            this.sicaklik_sensor_1.Name = "sicaklik_sensor_1";
            this.sicaklik_sensor_1.Size = new System.Drawing.Size(18, 20);
            this.sicaklik_sensor_1.TabIndex = 43;
            this.sicaklik_sensor_1.Text = "0";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label31.Location = new System.Drawing.Point(199, 116);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(25, 20);
            this.label31.TabIndex = 42;
            this.label31.Text = "°C";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label29.Location = new System.Drawing.Point(201, 87);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(25, 20);
            this.label29.TabIndex = 41;
            this.label29.Text = "°C";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label26.Location = new System.Drawing.Point(199, 56);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(25, 20);
            this.label26.TabIndex = 40;
            this.label26.Text = "°C";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.Location = new System.Drawing.Point(199, 27);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(25, 20);
            this.label24.TabIndex = 39;
            this.label24.Text = "°C";
            // 
            // sicaklik_sensor_2
            // 
            this.sicaklik_sensor_2.AutoSize = true;
            this.sicaklik_sensor_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sicaklik_sensor_2.Location = new System.Drawing.Point(168, 56);
            this.sicaklik_sensor_2.Name = "sicaklik_sensor_2";
            this.sicaklik_sensor_2.Size = new System.Drawing.Size(18, 20);
            this.sicaklik_sensor_2.TabIndex = 33;
            this.sicaklik_sensor_2.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(9, 116);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(163, 20);
            this.label21.TabIndex = 38;
            this.label21.Text = "Sıcaklik Sensörü [ 4 ] :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(10, 87);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(163, 20);
            this.label19.TabIndex = 37;
            this.label19.Text = "Sıcaklik Sensörü [ 3 ] :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(9, 56);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(163, 20);
            this.label17.TabIndex = 36;
            this.label17.Text = "Sıcaklik Sensörü [ 2 ] :";
            // 
            // sicaklik_sensor_4
            // 
            this.sicaklik_sensor_4.AutoSize = true;
            this.sicaklik_sensor_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sicaklik_sensor_4.Location = new System.Drawing.Point(168, 116);
            this.sicaklik_sensor_4.Name = "sicaklik_sensor_4";
            this.sicaklik_sensor_4.Size = new System.Drawing.Size(18, 20);
            this.sicaklik_sensor_4.TabIndex = 35;
            this.sicaklik_sensor_4.Text = "0";
            // 
            // sicaklik_sensor_3
            // 
            this.sicaklik_sensor_3.AutoSize = true;
            this.sicaklik_sensor_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sicaklik_sensor_3.Location = new System.Drawing.Point(168, 87);
            this.sicaklik_sensor_3.Name = "sicaklik_sensor_3";
            this.sicaklik_sensor_3.Size = new System.Drawing.Size(18, 20);
            this.sicaklik_sensor_3.TabIndex = 34;
            this.sicaklik_sensor_3.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(9, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 20);
            this.label14.TabIndex = 31;
            this.label14.Text = "Sıcaklik Sensörü [ 1 ] :";
            // 
            // grafik
            // 
            this.grafik.BackColor = System.Drawing.Color.White;
            this.grafik.Controls.Add(this.akim_grafik);
            this.grafik.Controls.Add(this.watt_grafik);
            this.grafik.Location = new System.Drawing.Point(4, 4);
            this.grafik.Name = "grafik";
            this.grafik.Size = new System.Drawing.Size(1151, 511);
            this.grafik.TabIndex = 2;
            this.grafik.Text = "Grafikler";
            // 
            // akim_grafik
            // 
            this.akim_grafik.Location = new System.Drawing.Point(4, 3);
            this.akim_grafik.Name = "akim_grafik";
            this.akim_grafik.ScrollGrace = 0D;
            this.akim_grafik.ScrollMaxX = 0D;
            this.akim_grafik.ScrollMaxY = 0D;
            this.akim_grafik.ScrollMaxY2 = 0D;
            this.akim_grafik.ScrollMinX = 0D;
            this.akim_grafik.ScrollMinY = 0D;
            this.akim_grafik.ScrollMinY2 = 0D;
            this.akim_grafik.Size = new System.Drawing.Size(1144, 261);
            this.akim_grafik.TabIndex = 1;
            // 
            // watt_grafik
            // 
            this.watt_grafik.Location = new System.Drawing.Point(3, 270);
            this.watt_grafik.Name = "watt_grafik";
            this.watt_grafik.ScrollGrace = 0D;
            this.watt_grafik.ScrollMaxX = 0D;
            this.watt_grafik.ScrollMaxY = 0D;
            this.watt_grafik.ScrollMaxY2 = 0D;
            this.watt_grafik.ScrollMinX = 0D;
            this.watt_grafik.ScrollMinY = 0D;
            this.watt_grafik.ScrollMinY2 = 0D;
            this.watt_grafik.Size = new System.Drawing.Size(1145, 238);
            this.watt_grafik.TabIndex = 0;
            // 
            // veri_tabani
            // 
            this.veri_tabani.Controls.Add(this.groupBox8);
            this.veri_tabani.Controls.Add(this.groupBox6);
            this.veri_tabani.Controls.Add(this.veri_tabani_tablo);
            this.veri_tabani.Location = new System.Drawing.Point(4, 4);
            this.veri_tabani.Name = "veri_tabani";
            this.veri_tabani.Size = new System.Drawing.Size(1151, 511);
            this.veri_tabani.TabIndex = 5;
            this.veri_tabani.Text = "Veri Tabanı";
            this.veri_tabani.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button2);
            this.groupBox8.Controls.Add(this.excel_pro);
            this.groupBox8.Controls.Add(this.exceleaktar);
            this.groupBox8.Controls.Add(this.batarya_kapasitesi);
            this.groupBox8.Controls.Add(this.label46);
            this.groupBox8.Location = new System.Drawing.Point(829, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(319, 217);
            this.groupBox8.TabIndex = 130;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Ayarlar";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(6, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(307, 64);
            this.button2.TabIndex = 16;
            this.button2.Text = "Log kayıtları Excel\'e aktarılırken bu biraz zaman alır.  Programı kapatmadan bekl" +
    "eyiniz. Log kayıtlarını bağlantıyı kestikten sonra en son alınız.";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // excel_pro
            // 
            this.excel_pro.Location = new System.Drawing.Point(6, 97);
            this.excel_pro.Name = "excel_pro";
            this.excel_pro.Size = new System.Drawing.Size(307, 44);
            this.excel_pro.TabIndex = 12;
            // 
            // exceleaktar
            // 
            this.exceleaktar.Location = new System.Drawing.Point(6, 42);
            this.exceleaktar.Name = "exceleaktar";
            this.exceleaktar.Size = new System.Drawing.Size(307, 48);
            this.exceleaktar.TabIndex = 5;
            this.exceleaktar.Text = "Verileri Excel\'e Aktar";
            this.exceleaktar.UseVisualStyleBackColor = true;
            this.exceleaktar.Click += new System.EventHandler(this.exceleaktar_Click);
            // 
            // batarya_kapasitesi
            // 
            this.batarya_kapasitesi.Location = new System.Drawing.Point(173, 16);
            this.batarya_kapasitesi.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.batarya_kapasitesi.Name = "batarya_kapasitesi";
            this.batarya_kapasitesi.Size = new System.Drawing.Size(140, 20);
            this.batarya_kapasitesi.TabIndex = 11;
            this.batarya_kapasitesi.Value = new decimal(new int[] {
            5292,
            0,
            0,
            0});
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label46.Location = new System.Drawing.Point(6, 16);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(161, 17);
            this.label46.TabIndex = 10;
            this.label46.Text = "Batarya Kapasitesi (Wh)";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.kalan_watt_saat);
            this.groupBox6.Controls.Add(this.label49);
            this.groupBox6.Controls.Add(this.label51);
            this.groupBox6.Controls.Add(this.watt_saat_text);
            this.groupBox6.Controls.Add(this.label44);
            this.groupBox6.Controls.Add(this.akim_saat_text);
            this.groupBox6.Controls.Add(this.label41);
            this.groupBox6.Controls.Add(this.aH);
            this.groupBox6.Controls.Add(this.label39);
            this.groupBox6.Location = new System.Drawing.Point(829, 227);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(319, 281);
            this.groupBox6.TabIndex = 129;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "İstatislik";
            // 
            // kalan_watt_saat
            // 
            this.kalan_watt_saat.AutoSize = true;
            this.kalan_watt_saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kalan_watt_saat.Location = new System.Drawing.Point(12, 217);
            this.kalan_watt_saat.Name = "kalan_watt_saat";
            this.kalan_watt_saat.Size = new System.Drawing.Size(29, 31);
            this.kalan_watt_saat.TabIndex = 129;
            this.kalan_watt_saat.Text = "0";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label49.Location = new System.Drawing.Point(15, 194);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(151, 13);
            this.label49.TabIndex = 131;
            this.label49.Text = "Toplamda Kalan Enerji ( Watt )";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label51.Location = new System.Drawing.Point(36, 248);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(31, 18);
            this.label51.TabIndex = 130;
            this.label51.Text = "Wh";
            // 
            // watt_saat_text
            // 
            this.watt_saat_text.AutoSize = true;
            this.watt_saat_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.watt_saat_text.Location = new System.Drawing.Point(12, 132);
            this.watt_saat_text.Name = "watt_saat_text";
            this.watt_saat_text.Size = new System.Drawing.Size(29, 31);
            this.watt_saat_text.TabIndex = 3;
            this.watt_saat_text.Text = "0";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label44.Location = new System.Drawing.Point(15, 109);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(171, 13);
            this.label44.TabIndex = 128;
            this.label44.Text = "Toplamda Harcanan Enerji ( Watt )";
            // 
            // akim_saat_text
            // 
            this.akim_saat_text.AutoSize = true;
            this.akim_saat_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.akim_saat_text.Location = new System.Drawing.Point(12, 43);
            this.akim_saat_text.Name = "akim_saat_text";
            this.akim_saat_text.Size = new System.Drawing.Size(29, 31);
            this.akim_saat_text.TabIndex = 1;
            this.akim_saat_text.Text = "0";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label41.Location = new System.Drawing.Point(15, 26);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(133, 13);
            this.label41.TabIndex = 127;
            this.label41.Text = "Ortalama Saatteki Akım (A)";
            // 
            // aH
            // 
            this.aH.AutoSize = true;
            this.aH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aH.Location = new System.Drawing.Point(36, 78);
            this.aH.Name = "aH";
            this.aH.Size = new System.Drawing.Size(25, 18);
            this.aH.TabIndex = 2;
            this.aH.Text = "Ah";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label39.Location = new System.Drawing.Point(36, 163);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(31, 18);
            this.label39.TabIndex = 4;
            this.label39.Text = "Wh";
            // 
            // veri_tabani_tablo
            // 
            this.veri_tabani_tablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.veri_tabani_tablo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.saniye,
            this.amper,
            this.volt,
            this.waat,
            this.sicaklik,
            this.tarih});
            this.veri_tabani_tablo.Location = new System.Drawing.Point(4, 4);
            this.veri_tabani_tablo.Name = "veri_tabani_tablo";
            this.veri_tabani_tablo.Size = new System.Drawing.Size(819, 504);
            this.veri_tabani_tablo.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // saniye
            // 
            this.saniye.HeaderText = "saniye";
            this.saniye.Name = "saniye";
            // 
            // amper
            // 
            this.amper.HeaderText = "amper(mA)";
            this.amper.Name = "amper";
            // 
            // volt
            // 
            this.volt.HeaderText = "volt";
            this.volt.Name = "volt";
            // 
            // waat
            // 
            this.waat.HeaderText = "watt";
            this.waat.Name = "waat";
            // 
            // sicaklik
            // 
            this.sicaklik.HeaderText = "sicaklik";
            this.sicaklik.Name = "sicaklik";
            // 
            // tarih
            // 
            this.tarih.HeaderText = "tarih";
            this.tarih.Name = "tarih";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // genel_hesaplama
            // 
            this.genel_hesaplama.Enabled = true;
            this.genel_hesaplama.Interval = 1;
            this.genel_hesaplama.Tick += new System.EventHandler(this.genel_voltaj_hesaplama_Tick);
            // 
            // excel_islem
            // 
            this.excel_islem.WorkerReportsProgress = true;
            this.excel_islem.DoWork += new System.ComponentModel.DoWorkEventHandler(this.excel_islem_DoWork);
            this.excel_islem.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.excel_islem_ProgressChanged);
            this.excel_islem.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.excel_islem_RunWorkerCompleted);
            // 
            // veri_tabani_kaydi
            // 
            this.veri_tabani_kaydi.Interval = 1000;
            this.veri_tabani_kaydi.Tick += new System.EventHandler(this.veri_tabani_kaydi_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Telemetri KBU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.gostergeler.ResumeLayout(false);
            this.gostergeler.PerformLayout();
            this.pil_durumlari.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max_hucre_deger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_hucre_deger)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ayrinti.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.grafik.ResumeLayout(false);
            this.veri_tabani.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batarya_kapasitesi)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veri_tabani_tablo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox portlar;
        private System.Windows.Forms.Button baglan_b;
        private System.Windows.Forms.ComboBox haberlesme_hiz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button veri_gonder;
        private System.Windows.Forms.TextBox veri_giris;
        private System.Windows.Forms.TextBox anlik_veri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox log_kayit;
        private System.Windows.Forms.Button veri_kaydet;
        private System.Windows.Forms.Button veri_temizle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage gostergeler;
        private System.Windows.Forms.TabPage pil_durumlari;
        private System.Windows.Forms.TabPage grafik;
        private CircularProgressBar.CircularProgressBar sicaklik_gosterge;
        private CircularProgressBar.CircularProgressBar akim_gosterge;
        private CircularProgressBar.CircularProgressBar batarya_gosterge;
        private System.Windows.Forms.Label label4;
        private CircularProgressBar.CircularProgressBar guc_gosterge;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage ayrinti;
        private AGaugeApp.AGauge motor_hiz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label motor_devir;
        private AGaugeApp.AGauge hiz;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ProgressBar genel_volt_pro;
        private System.Windows.Forms.Label genel_volt_deger;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label genel_volt_yuzde;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label pil_1_volt;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ProgressBar pil_1_pro;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label pil_1_yuzde;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label pil_10_yuzde;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label pil_10_volt;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.ProgressBar pil_8_pro;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label pil_9_yuzde;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label pil_9_volt;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.ProgressBar pil_7_pro;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label pil_8_yuzde;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label pil_8_volt;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.ProgressBar pil_6_pro;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label pil_7_yuzde;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label pil_7_volt;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.ProgressBar pil_9_pro;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label pil_6_yuzde;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label pil_6_volt;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.ProgressBar pil_5_pro;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label pil_5_yuzde;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label pil_5_volt;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.ProgressBar pil_4_pro;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label pil_3_yuzde;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label pil_3_volt;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ProgressBar pil_3_pro;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label pil_2_yuzde;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label pil_2_volt;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ProgressBar pil_2_pro;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.ProgressBar pil_10_pro;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label pil_4_yuzde;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label pil_4_volt;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label pil_14_yuzde;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label pil_14_volt;
        private System.Windows.Forms.ProgressBar pil_20_pro;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label pil_20_yuzde;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label pil_20_volt;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.ProgressBar pil_18_pro;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label pil_19_yuzde;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label pil_19_volt;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.ProgressBar pil_17_pro;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label pil_18_yuzde;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label pil_18_volt;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.ProgressBar pil_16_pro;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label pil_17_yuzde;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label pil_17_volt;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.ProgressBar pil_19_pro;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Label pil_16_yuzde;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.Label pil_16_volt;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.ProgressBar pil_15_pro;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.Label pil_15_yuzde;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label pil_15_volt;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.ProgressBar pil_14_pro;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.Label pil_13_yuzde;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.Label pil_13_volt;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.ProgressBar pil_13_pro;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.Label pil_12_yuzde;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.Label pil_12_volt;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.ProgressBar pil_12_pro;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.Label pil_11_yuzde;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.Label pil_11_volt;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.ProgressBar pil_11_pro;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer genel_hesaplama;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label sicaklik_sensor_2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label sicaklik_sensor_3;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label sicaklik_sensor_1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.NumericUpDown max_hucre_deger;
        private System.Windows.Forms.NumericUpDown min_hucre_deger;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label34;
        private ZedGraph.ZedGraphControl akim_grafik;
        private ZedGraph.ZedGraphControl watt_grafik;
        private System.Windows.Forms.Label zaman_yazi;
        private System.Windows.Forms.TabPage veri_tabani;
        private System.Windows.Forms.DataGridView veri_tabani_tablo;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label sicaklik_sensor_4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label kalan_watt_saat;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label watt_saat_text;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label akim_saat_text;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label aH;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.NumericUpDown batarya_kapasitesi;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Button exceleaktar;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.ComponentModel.BackgroundWorker excel_islem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar excel_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn saniye;
        private System.Windows.Forms.DataGridViewTextBoxColumn amper;
        private System.Windows.Forms.DataGridViewTextBoxColumn volt;
        private System.Windows.Forms.DataGridViewTextBoxColumn waat;
        private System.Windows.Forms.DataGridViewTextBoxColumn sicaklik;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih;
        private System.Windows.Forms.Timer veri_tabani_kaydi;
        private System.Windows.Forms.Label sistem_durumu;
    }
}

