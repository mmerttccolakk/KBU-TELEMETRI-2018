using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ZedGraph;

namespace Telemetri_KBU
{
    public partial class Form1 : Form
    {
        int id_say = 0; double akim_saat = 0; double harcanan_guc = 0; double akim = 0;
        string sonuc;

        //saniye hesabı
        Stopwatch saydir = new Stopwatch();

        public Form1()
        {
            //CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        GraphPane myPaneakim = new GraphPane();

        GraphPane myPanewatt = new GraphPane();

        PointPairList listPointsakim = new PointPairList();

        PointPairList listPointswatt = new PointPairList();

        LineItem myCurveakim;

        LineItem myCurvewatt;


        double zaman = 0;

        static int cevirint(string cevir_int_degisken)
        {
            try
            {
                return Convert.ToInt32(cevir_int_degisken);
            }
            catch
            {
                return 0;
            }


        }

        static int cevirdabint(double cevir_int_degisken)
        {
            try
            {
                return Convert.ToInt32(cevir_int_degisken);
            }
            catch
            {
                return 0;
            }


        }
        static int cevirdebint(decimal cevir_int_degisken)
        {
            try
            {
                return Convert.ToInt32(cevir_int_degisken);
            }
            catch
            {
                return 0;
            }


        }

        private void GrafikHazirla()

        {

            myPaneakim = akim_grafik.GraphPane;

            myPanewatt = watt_grafik.GraphPane;

            myPaneakim.Title.Text = "Akım – Zaman Grafiği ";

            myPanewatt.Title.Text = "Watt – Zaman Grafiği ";

            myPaneakim.XAxis.Title.Text = " t (s) ";

            myPanewatt.XAxis.Title.Text = " t (s) ";

            myPaneakim.YAxis.Title.Text = "Akim (A)";

            myPanewatt.YAxis.Title.Text = "Harcanan Güç (Kw)";

            myPaneakim.YAxis.Scale.Min = 0;

            myPanewatt.YAxis.Scale.Min = 0;

            myPaneakim.YAxis.Scale.Max = 300;

            myPanewatt.YAxis.Scale.Max = 25200;

            myCurveakim = myPaneakim.AddCurve(null, listPointsakim, Color.Red, SymbolType.None);

            myCurvewatt = myPanewatt.AddCurve(null, listPointswatt, Color.Blue, SymbolType.None);

            myCurveakim.Line.Width = 2;

            myCurvewatt.Line.Width = 2;

        }
        public void baglan()
        {//port açılıp bağlanılıyor
            if (serialPort1.IsOpen == false)
            {
                serialPort1.PortName = portlar.Text;
                serialPort1.BaudRate = cevirint(haberlesme_hiz.Text);
                try
                {
                    serialPort1.Open();
                    genel_hesaplama.Start();
                    veri_tabani_kaydi.Start();
                    saydir.Start();
                    baglan_b.Text = "Bağlantıyı Kes";

                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata:" + hata.Message);
                    genel_hesaplama.Stop();
                    veri_tabani_kaydi.Stop();
                    saydir.Stop();
                    serialPort1.Close();
                    baglan_b.Text = "Bağlan";
                    baglan_b.Enabled = false;
                    portlar.Enabled = true;
                    haberlesme_hiz.Enabled = true;
                    portlar.Text = "Port Seçin";
                    portlar.Items.Clear();
                }
            }
            else
            {
                genel_hesaplama.Stop();
                saydir.Stop();
                veri_tabani_kaydi.Stop();
                serialPort1.Close();
                baglan_b.Text = "Bağlan";
                baglan_b.Enabled = false;
                portlar.Enabled = true;
                haberlesme_hiz.Enabled = true;
                portlar.Text = "Port Seçin";
                portlar.Items.Clear();
            }
        }
        public void baglanti_ac()
        {
            //comboBox üzerinden port seçildi butonlar açılıp timer ve comboboxlar kapatılacak
            genel_hesaplama.Stop();
            saydir.Stop();
            veri_tabani_kaydi.Stop();
            baglan_b.Enabled = true;
            portlar.Enabled = false;
            portlar.Enabled = false;
        }
        public void verigonder(string deger)
        {
            if (serialPort1.IsOpen == true)
            {
                deger = deger + "\n";
                serialPort1.Write(deger);
            }
        }
        static int yuzde_hesapla(int voltaj, int min, int max)
        {
            double gec = (Double)(((Double)voltaj - (Double)min) / ((Double)max - (Double)min)) * (Double)100;
            if (cevirdabint(gec) < 0) { gec = 0; }
            if (cevirdabint(gec) > 100) { gec = 100; }
            return cevirdabint(gec);

        }
        static int genel_yuzde_hesapla(int voltaj, int min, int max)
        {
            double gec = (Double)(((Double)voltaj - ((Double)min * 20)) / (((Double)max - (Double)min) * 20)) * 100;
            if (cevirdabint(gec) < 0) { gec = 0; }
            if (cevirdabint(gec) > 100) { gec = 100; }
            return cevirdabint(gec);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < System.IO.Ports.SerialPort.GetPortNames().Length; i++)
            {
                portlar.Items.Add(System.IO.Ports.SerialPort.GetPortNames()[i]);

            }
            GrafikHazirla();
        }
        private void isle(string sonuc)
        {
            BeginInvoke(new EventHandler(delegate
            {
                anlik_veri.Text = sonuc;

            }));
        }

        private void baglan_b_Click(object sender, EventArgs e)
        {
            baglan();
        }

        private void portlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti_ac();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                sonuc = serialPort1.ReadLine();
                isle(sonuc);
            }

        }
        public void excel_aktar()
        {
            if (serialPort1.IsOpen == true)
            {
                MessageBox.Show("Log kayıtlarını almak için lütfen önce bağlantıyı kesin.");

            }
            else
            {
                MessageBox.Show("Veriler Excel'e Aktarılırken Programı Kapatmayın. Bu işlem biraz zaman alabilir.");
                Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
                uyg.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook kitap = uyg.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                for (int i = 0; i < veri_tabani_tablo.Columns.Count; i++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[1, i + 1];
                    myRange.Value2 = veri_tabani_tablo.Columns[i].HeaderText;
                }
                int ji = 0;
                for (int i = 0; i < veri_tabani_tablo.Columns.Count; i++)
                {
                    for (int j = 0; j < veri_tabani_tablo.Rows.Count; j++)
                    {
                        if (ji < j)
                        {
                            ji = j;
                        }

                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[j + 2, i + 1];
                        myRange.Value2 = veri_tabani_tablo[i, j].Value;
                        double yuzde = ((double)(i) * (double)(ji) / ((double)veri_tabani_tablo.Rows.Count * (double)veri_tabani_tablo.Columns.Count)) * (double)100;
                        excel_islem.ReportProgress(cevirdabint(yuzde));
                    }
                }
            }
        }

        private void veri_temizle_Click(object sender, EventArgs e)
        {
            log_kayit.Items.Clear();
        }

        private void genel_voltaj_hesaplama_Tick(object sender, EventArgs e)
        {
            //voltaj hesapları
            int toplam_genel_voltaj_degeri = cevirint(pil_1_volt.Text) +
            cevirint(pil_2_volt.Text) +
            cevirint(pil_3_volt.Text) +
            cevirint(pil_4_volt.Text) +
            cevirint(pil_5_volt.Text) +
            cevirint(pil_6_volt.Text) +
            cevirint(pil_7_volt.Text) +
            cevirint(pil_8_volt.Text) +
            cevirint(pil_9_volt.Text) +
            cevirint(pil_10_volt.Text) +
            cevirint(pil_11_volt.Text) +
            cevirint(pil_12_volt.Text) +
            cevirint(pil_13_volt.Text) +
            cevirint(pil_14_volt.Text) +
            cevirint(pil_15_volt.Text) +
            cevirint(pil_16_volt.Text) +
            cevirint(pil_17_volt.Text) +
            cevirint(pil_18_volt.Text) +
            cevirint(pil_19_volt.Text) +
            cevirint(pil_20_volt.Text);
            int genel_volt_yuzde_deger = genel_yuzde_hesapla(toplam_genel_voltaj_degeri, cevirdebint(min_hucre_deger.Value), cevirdebint(max_hucre_deger.Value));
            if (genel_volt_yuzde_deger < 0) { genel_volt_yuzde_deger = 0; }
            if (genel_volt_yuzde_deger > 100) { genel_volt_yuzde_deger = 100; }
            genel_volt_pro.Value = genel_volt_yuzde_deger;


            batarya_gosterge.Value = genel_volt_pro.Value;
            genel_volt_yuzde.Text = (genel_volt_pro.Value).ToString();
            batarya_gosterge.Text = genel_volt_yuzde.Text;
            genel_volt_deger.Text = (toplam_genel_voltaj_degeri / 1000).ToString();
            //en yuksek sicaklik hesabı
            if (cevirint(sicaklik_sensor_1.Text) >= cevirint(sicaklik_sensor_2.Text) && cevirint(sicaklik_sensor_1.Text) >= cevirint(sicaklik_sensor_3.Text) && cevirint(sicaklik_sensor_1.Text) >= cevirint(sicaklik_sensor_4.Text))
            {
                if ((cevirint(sicaklik_sensor_1.Text) / 10) < 0) { sicaklik_sensor_1.Text = "0"; }
                if ((cevirint(sicaklik_sensor_1.Text) / 10) > sicaklik_gosterge.Maximum) { sicaklik_sensor_1.Text = Convert.ToString(sicaklik_gosterge.Maximum); }
                sicaklik_gosterge.Value = cevirint(sicaklik_sensor_1.Text) / 10;
                sicaklik_gosterge.Text = sicaklik_gosterge.Value.ToString();
            }
            else if (cevirint(sicaklik_sensor_2.Text) >= cevirint(sicaklik_sensor_1.Text) && cevirint(sicaklik_sensor_2.Text) >= cevirint(sicaklik_sensor_3.Text) && cevirint(sicaklik_sensor_2.Text) >= cevirint(sicaklik_sensor_4.Text))
            {
                if ((cevirint(sicaklik_sensor_2.Text) / 10) < 0) { sicaklik_sensor_2.Text = "0"; }
                if ((cevirint(sicaklik_sensor_2.Text) / 10) > sicaklik_gosterge.Maximum) { sicaklik_sensor_2.Text = Convert.ToString(sicaklik_gosterge.Maximum); }
                sicaklik_gosterge.Value = cevirint(sicaklik_sensor_2.Text) / 10;
                sicaklik_gosterge.Text = sicaklik_gosterge.Value.ToString();
            }
            else if (cevirint(sicaklik_sensor_3.Text) >= cevirint(sicaklik_sensor_1.Text) && cevirint(sicaklik_sensor_3.Text) >= cevirint(sicaklik_sensor_2.Text) && cevirint(sicaklik_sensor_3.Text) >= cevirint(sicaklik_sensor_4.Text))
            {
                if ((cevirint(sicaklik_sensor_3.Text) / 10) < 0) { sicaklik_sensor_3.Text = "0"; }
                if ((cevirint(sicaklik_sensor_3.Text) / 10) > sicaklik_gosterge.Maximum) { sicaklik_sensor_3.Text = Convert.ToString(sicaklik_gosterge.Maximum); }
                sicaklik_gosterge.Value = cevirint(sicaklik_sensor_3.Text) / 10;
                sicaklik_gosterge.Text = sicaklik_gosterge.Value.ToString();
            }
            else
            {
                if ((cevirint(sicaklik_sensor_4.Text) / 10) < 0) { sicaklik_sensor_4.Text = "0"; }
                if ((cevirint(sicaklik_sensor_4.Text) / 10) > sicaklik_gosterge.Maximum) { sicaklik_sensor_4.Text = Convert.ToString(sicaklik_gosterge.Maximum); }
                sicaklik_gosterge.Value = cevirint(sicaklik_sensor_4.Text) / 10;
                sicaklik_gosterge.Text = sicaklik_gosterge.Value.ToString();
            }
            //anlik guc hesabı ve gosterge
            double guc_kw_hesap = (toplam_genel_voltaj_degeri * akim_gosterge.Value);
            guc_gosterge.Value = cevirdabint(guc_kw_hesap) / 1000;
            guc_gosterge.Text = guc_gosterge.Value.ToString();
            //grafik için zaman hesabı
            if (serialPort1.IsOpen == true)
            {
                zaman = saydir.Elapsed.TotalSeconds;
                zaman_yazi.Text = saydir.Elapsed.TotalSeconds.ToString();


                listPointsakim.Add(new PointPair(zaman, Convert.ToDouble(akim_gosterge.Value)));

                listPointswatt.Add(new PointPair(zaman, Convert.ToDouble(guc_gosterge.Value)));

                myPanewatt.XAxis.Scale.Max = zaman;
                myPaneakim.XAxis.Scale.Max = zaman;

                myPaneakim.AxisChange();
                myPanewatt.AxisChange();

                akim_grafik.Refresh();
                watt_grafik.Refresh();


                //akım-saat hesabı
                if (zaman <= 360000 && zaman > 5)
                {
                    akim_saat = 0;
                    int satir = veri_tabani_tablo.Rows.Count;
                    if (satir > 5)
                    {
                        for (int i = 1; i < id_say; i++)
                        {
                            akim_saat += Convert.ToDouble(veri_tabani_tablo.Rows[id_say - 1].Cells[2].Value) / (double)100;
                        }
                        if (id_say == 0) { id_say = 1; }
                        akim_saat = (double)akim_saat / (double)id_say;
                        akim_saat_text.Text = akim_saat.ToString();
                    }
                }
                //waat-A hesabı
                if (zaman > 1)
                {
                    harcanan_guc += ((double)guc_gosterge.Value / ((double)3600 * (1000 / (double)genel_hesaplama.Interval)));
                    watt_saat_text.Text = harcanan_guc.ToString();
                    //waat batarya kapasitesi hesabı
                    kalan_watt_saat.Text = (Convert.ToDouble(batarya_kapasitesi.Value) - harcanan_guc).ToString();
                }
            }
        }


        private void veri_gonder_Click(object sender, EventArgs e)
        {
            verigonder(veri_giris.Text);
            if (serialPort1.IsOpen == true)
            {
                string saniye = DateTime.Now.Second.ToString(); // sadece saniye
                string dakika = DateTime.Now.Minute.ToString(); // sadece dakika
                string saat = DateTime.Now.Hour.ToString(); // sadece saat
                log_kayit.Items.Add("Zaman[s:dk:sn]: " + saat + ":" + dakika + ":" + saniye + " Gönderilen Veri: " + veri_giris.Text);
                log_kayit.SelectedIndex = log_kayit.Items.Count - 1;
                log_kayit.SetSelected(log_kayit.Items.Count - 1, false);
                veri_giris.Text = "";
            }
            else
            {
                string saniye = DateTime.Now.Second.ToString(); // sadece saniye
                string dakika = DateTime.Now.Minute.ToString(); // sadece dakika
                string saat = DateTime.Now.Hour.ToString(); // sadece saat
                log_kayit.Items.Add("Zaman[s:dk:sn]: " + saat + ":" + dakika + ":" + saniye + " Hata: Veri Gönderilemedi.");
                log_kayit.SelectedIndex = log_kayit.Items.Count - 1;
                log_kayit.SetSelected(log_kayit.Items.Count - 1, false);
            }

        }

        private void anlik_veri_TextChanged(object sender, EventArgs e)
        {
            string saniye = DateTime.Now.Second.ToString(); // sadece saniye
            string dakika = DateTime.Now.Minute.ToString(); // sadece dakika
            string saat = DateTime.Now.Hour.ToString(); // sadece saat
            string zaman_ata = "Zaman[s:dk:sn]: " + saat + ":" + dakika + ":" + saniye;
            log_kayit.Items.Add(zaman_ata + " Anlık Sn " + zaman + " Gelen Veri: " + anlik_veri.Text);
            log_kayit.SelectedIndex = log_kayit.Items.Count - 1;
            log_kayit.SetSelected(log_kayit.Items.Count - 1, false);
            if (log_kayit.Items.Count >= 500000000)
            {
                //log_kayit.Items.Clear();
            }
            string bol = anlik_veri.Text;
            string[] veriler = bol.Split(',');

            switch (veriler[0])
            {
                case "200":
                    if (cevirint(veriler[1]) < 0 || cevirint(veriler[1]) > max_hucre_deger.Value) { veriler[1] = "0"; }//progress bar sıfırlamak yerine doğruluğu kontrol edilip öyle bilgi devreye konulabilir
                    pil_1_volt.Text = veriler[1];
                    pil_1_pro.Value = yuzde_hesapla(cevirint(veriler[1]), cevirdebint(min_hucre_deger.Value), cevirdebint(max_hucre_deger.Value));
                    pil_1_yuzde.Text = pil_1_pro.Value.ToString();
                    break;
                case "201":
                    if (cevirint(veriler[1]) < 0 || cevirint(veriler[1]) > max_hucre_deger.Value) { veriler[1] = "0"; }
                    pil_2_volt.Text = veriler[1];
                    pil_2_pro.Value = yuzde_hesapla(cevirint(veriler[1]), cevirdebint(min_hucre_deger.Value), cevirdebint(max_hucre_deger.Value));
                    pil_2_yuzde.Text = pil_2_pro.Value.ToString();
                    break;
                case "202":
                    if (cevirint(veriler[1]) < 0 || cevirint(veriler[1]) > max_hucre_deger.Value) { veriler[1] = "0"; }
                    pil_3_volt.Text = veriler[1];
                    pil_3_pro.Value = yuzde_hesapla(cevirint(veriler[1]), cevirdebint(min_hucre_deger.Value), cevirdebint(max_hucre_deger.Value));
                    pil_3_yuzde.Text = pil_3_pro.Value.ToString();
                    break;
                case "203":
                    if (cevirint(veriler[1]) < 0 || cevirint(veriler[1]) > max_hucre_deger.Value) { veriler[1] = "0"; }
                    pil_4_volt.Text = veriler[1];
                    pil_4_pro.Value = yuzde_hesapla(cevirint(veriler[1]), cevirdebint(min_hucre_deger.Value), cevirdebint(max_hucre_deger.Value));
                    pil_4_yuzde.Text = pil_4_pro.Value.ToString();
                    break;
                case "204":
                    if (cevirint(veriler[1]) < 0 || cevirint(veriler[1]) > max_hucre_deger.Value) { veriler[1] = "0"; }
                    pil_5_volt.Text = veriler[1];
                    pil_5_pro.Value = yuzde_hesapla(cevirint(veriler[1]), cevirdebint(min_hucre_deger.Value), cevirdebint(max_hucre_deger.Value));
                    pil_5_yuzde.Text = pil_5_pro.Value.ToString();
                    break;
                case "205":
                    if (cevirint(veriler[1]) < 0 || cevirint(veriler[1]) > max_hucre_deger.Value) { veriler[1] = "0"; }
                    pil_6_volt.Text = veriler[1];
                    pil_6_pro.Value = yuzde_hesapla(cevirint(veriler[1]), cevirdebint(min_hucre_deger.Value), cevirdebint(max_hucre_deger.Value));
                    pil_6_yuzde.Text = pil_6_pro.Value.ToString();
                    break;
                case "206":
                    if (cevirint(veriler[1]) < 0 || cevirint(veriler[1]) > max_hucre_deger.Value) { veriler[1] = "0"; }
                    pil_7_volt.Text = veriler[1];
                    pil_7_pro.Value = yuzde_hesapla(cevirint(veriler[1]), cevirdebint(min_hucre_deger.Value), cevirdebint(max_hucre_deger.Value));
                    pil_7_yuzde.Text = pil_7_pro.Value.ToString();
                    break;
                case "207":
                    if (cevirint(veriler[1]) < 0 || cevirint(veriler[1]) > max_hucre_deger.Value) { veriler[1] = "0"; }
                    pil_8_volt.Text = veriler[1];
                    pil_8_pro.Value = yuzde_hesapla(cevirint(veriler[1]), cevirdebint(min_hucre_deger.Value), cevirdebint(max_hucre_deger.Value));
                    pil_8_yuzde.Text = pil_8_pro.Value.ToString();
                    break;
                case "208":
                    if (cevirint(veriler[1]) < 0 || cevirint(veriler[1]) > max_hucre_deger.Value) { veriler[1] = "0"; }
                    pil_9_volt.Text = veriler[1];
                    pil_9_pro.Value = yuzde_hesapla(cevirint(veriler[1]), cevirdebint(min_hucre_deger.Value), cevirdebint(max_hucre_deger.Value));
                    pil_9_yuzde.Text = pil_9_pro.Value.ToString();
                    break;
                case "209":
                    if (cevirint(veriler[1]) < 0 || cevirint(veriler[1]) > max_hucre_deger.Value) { veriler[1] = "0"; }
                    pil_10_volt.Text = veriler[1];
                    pil_10_pro.Value = yuzde_hesapla(cevirint(veriler[1]), cevirdebint(min_hucre_deger.Value), cevirdebint(max_hucre_deger.Value));
                    pil_10_yuzde.Text = pil_10_pro.Value.ToString();
                    break;
                case "210":
                    if (cevirint(veriler[1]) < 0 || cevirint(veriler[1]) > max_hucre_deger.Value) { veriler[1] = "0"; }
                    pil_11_volt.Text = veriler[1];
                    pil_11_pro.Value = yuzde_hesapla(cevirint(veriler[1]), cevirdebint(min_hucre_deger.Value), cevirdebint(max_hucre_deger.Value));
                    pil_11_yuzde.Text = pil_11_pro.Value.ToString();
                    break;
                case "211":
                    if (cevirint(veriler[1]) < 0 || cevirint(veriler[1]) > max_hucre_deger.Value) { veriler[1] = "0"; }
                    pil_12_volt.Text = veriler[1];
                    pil_12_pro.Value = yuzde_hesapla(cevirint(veriler[1]), cevirdebint(min_hucre_deger.Value), cevirdebint(max_hucre_deger.Value));
                    pil_12_yuzde.Text = pil_12_pro.Value.ToString();
                    break;
                case "212":
                    if (cevirint(veriler[1]) < 0 || cevirint(veriler[1]) > max_hucre_deger.Value) { veriler[1] = "0"; }
                    pil_13_volt.Text = veriler[1];
                    pil_13_pro.Value = yuzde_hesapla(cevirint(veriler[1]), cevirdebint(min_hucre_deger.Value), cevirdebint(max_hucre_deger.Value));
                    pil_13_yuzde.Text = pil_13_pro.Value.ToString();
                    break;
                case "213":
                    if (cevirint(veriler[1]) < 0 || cevirint(veriler[1]) > max_hucre_deger.Value) { veriler[1] = "0"; }
                    pil_14_volt.Text = veriler[1];
                    pil_14_pro.Value = yuzde_hesapla(cevirint(veriler[1]), cevirdebint(min_hucre_deger.Value), cevirdebint(max_hucre_deger.Value));
                    pil_14_yuzde.Text = pil_14_pro.Value.ToString();
                    break;
                case "214":
                    if (cevirint(veriler[1]) < 0 || cevirint(veriler[1]) > max_hucre_deger.Value) { veriler[1] = "0"; }
                    pil_15_volt.Text = veriler[1];
                    pil_15_pro.Value = yuzde_hesapla(cevirint(veriler[1]), cevirdebint(min_hucre_deger.Value), cevirdebint(max_hucre_deger.Value));
                    pil_15_yuzde.Text = pil_15_pro.Value.ToString();
                    break;
                case "215":
                    if (cevirint(veriler[1]) < 0 || cevirint(veriler[1]) > max_hucre_deger.Value) { veriler[1] = "0"; }
                    pil_16_volt.Text = veriler[1];
                    pil_16_pro.Value = yuzde_hesapla(cevirint(veriler[1]), cevirdebint(min_hucre_deger.Value), cevirdebint(max_hucre_deger.Value));
                    pil_16_yuzde.Text = pil_16_pro.Value.ToString();
                    break;
                case "216":
                    if (cevirint(veriler[1]) < 0 || cevirint(veriler[1]) > max_hucre_deger.Value) { veriler[1] = "0"; }
                    pil_17_volt.Text = veriler[1];
                    pil_17_pro.Value = yuzde_hesapla(cevirint(veriler[1]), cevirdebint(min_hucre_deger.Value), cevirdebint(max_hucre_deger.Value));
                    pil_17_yuzde.Text = pil_17_pro.Value.ToString();
                    break;
                case "217":
                    if (cevirint(veriler[1]) < 0 || cevirint(veriler[1]) > max_hucre_deger.Value) { veriler[1] = "0"; }
                    pil_18_volt.Text = veriler[1];
                    pil_18_pro.Value = yuzde_hesapla(cevirint(veriler[1]), cevirdebint(min_hucre_deger.Value), cevirdebint(max_hucre_deger.Value));
                    pil_18_yuzde.Text = pil_18_pro.Value.ToString();
                    break;
                case "218":
                    if (cevirint(veriler[1]) < 0 || cevirint(veriler[1]) > max_hucre_deger.Value) { veriler[1] = "0"; }
                    pil_19_volt.Text = veriler[1];
                    pil_19_pro.Value = yuzde_hesapla(cevirint(veriler[1]), cevirdebint(min_hucre_deger.Value), cevirdebint(max_hucre_deger.Value));
                    pil_19_yuzde.Text = pil_19_pro.Value.ToString();
                    break;
                case "219":
                    if (cevirint(veriler[1]) < 0 || cevirint(veriler[1]) > max_hucre_deger.Value) { veriler[1] = "0"; }
                    pil_20_volt.Text = veriler[1];
                    pil_20_pro.Value = yuzde_hesapla(cevirint(veriler[1]), cevirdebint(min_hucre_deger.Value), cevirdebint(max_hucre_deger.Value));
                    pil_20_yuzde.Text = pil_20_pro.Value.ToString();
                    break;
                case "300":
                    sicaklik_sensor_1.Text = veriler[1];
                    break;
                case "301":
                    sicaklik_sensor_2.Text = veriler[1];
                    break;
                case "302":
                    sicaklik_sensor_3.Text = veriler[1];
                    break;
                case "303":
                    sicaklik_sensor_4.Text = veriler[1];
                    break;
                case "400":
                    if (Convert.ToDouble(veriler[1]) <= 0)
                    {
                        //veriler[1]=veriler[1].Replace(".", ",");
                        akim = Convert.ToDouble(veriler[1]);
                        akim = (double)akim / (double)100;
                        akim_gosterge.Text = akim.ToString("0.###");
                        akim_gosterge.Value = cevirdabint(akim * -1);
                        akim_gosterge.ProgressColor = System.Drawing.Color.ForestGreen;
                    }
                    else
                    {
                        //veriler[1]= veriler[1].Replace(".", ",");
                        akim = Convert.ToDouble(veriler[1]);
                        akim = (double)akim / (double)100;
                        akim_gosterge.Text = akim.ToString("0.##");
                        akim_gosterge.Value = cevirdabint(akim);
                        akim_gosterge.ProgressColor = System.Drawing.Color.Red;
                    }

                    break;
                case "401":
                    //sistem durumu
                    if (cevirint(veriler[1]) <= 0 || cevirint(veriler[1]) > 5) { veriler[1] = "0"; }
                    if (veriler[1] == "0") { sistem_durumu.Text = "Sistem İyi"; }
                    else if (veriler[1] == "1") { sistem_durumu.Text = "Sistem orta"; }
                    else if (veriler[1] == "2") { sistem_durumu.Text = "Sistem kritik"; }
                    else if (veriler[1] == "3") { sistem_durumu.Text = "kritik kötü"; }
                    else if (veriler[1] == "4") { sistem_durumu.Text = "çok kötü"; }
                    else if (veriler[1] == "5") { sistem_durumu.Text = "çooook kötü"; }
                    break;
                case "500":
                    //motor devir
                    if (cevirint(veriler[1]) < 0 || cevirint(veriler[1]) > motor_hiz.MaxValue) { veriler[1] = "0"; }
                    motor_hiz.Value = cevirint(veriler[1]);
                    motor_hiz.Text = motor_hiz.Value.ToString();
                    break;
                //arac hiz
                case "501":
                    if (cevirint(veriler[1]) < 0 || cevirint(veriler[1]) > hiz.MaxValue) { veriler[1] = "0"; }
                    hiz.Value = cevirint(veriler[1]);
                    motor_hiz.Text = hiz.Value.ToString();
                    break;
                    //default:
                    //   log_kayit.Items.Add(zaman_ata + " Anlık Sn " + zaman + " Böyle bir parametre tanımlı değil.! " + veriler[1]);
                    // break;
            }
        }


        private void veri_kaydet_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Metin Dosyaları (*.txt) |*.txt| Tüm dosyalar (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            DialogResult dk = saveFileDialog1.ShowDialog();

            if (dk == DialogResult.OK)
            {
                try
                {
                    StreamWriter s = new StreamWriter(saveFileDialog1.FileName);
                    for (int i = 0; i < log_kayit.Items.Count; i++)
                    {

                        s.WriteLine(log_kayit.Items[i].ToString());

                    }
                    s.Close();
                    MessageBox.Show("Veriler Kaydedildi.!");
                }
                catch
                {

                    MessageBox.Show("Log Kaydedilemedi.!");

                }
            }
        }

        private void exceleaktar_Click(object sender, EventArgs e)
        {
            excel_islem.RunWorkerAsync();
        }

        private void excel_islem_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            excel_aktar();
        }

        private void excel_islem_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                excel_pro.Value = 100;
                MessageBox.Show("Toplamda " + veri_tabani_tablo.Rows.Count * veri_tabani_tablo.ColumnCount + " Veri Aktarıldı.");
            }
        }

        private void excel_islem_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            excel_pro.Value = e.ProgressPercentage;
        }

        private void veri_tabani_kaydi_Tick(object sender, EventArgs e)
        {
            //veri tabanı kayıt
            string saniye = DateTime.Now.Second.ToString(); // sadece saniye
            string dakika = DateTime.Now.Minute.ToString(); // sadece dakika
            string saat = DateTime.Now.Hour.ToString(); // sadece saat
            id_say += 1;
            veri_tabani_tablo.Rows.Add(id_say, zaman, akim_gosterge.Text, genel_volt_deger.Text, guc_gosterge.Value, sicaklik_gosterge.Value, "[s:dk:sn]: " + saat + ":" + dakika + ":" + saniye);
        }

        private void portlar_Click(object sender, EventArgs e)
        {
            if (portlar.Text == "Port Seçin")
            {
                portlar.Items.Clear();
                for (int i = 0; i < System.IO.Ports.SerialPort.GetPortNames().Length; i++)
                {
                    portlar.Items.Add(System.IO.Ports.SerialPort.GetPortNames()[i]);
                }
            }
        }
    }
}
