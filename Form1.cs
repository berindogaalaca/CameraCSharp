using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video; //video ve direct show adinda iki tane kutuphane ekledik bunlari bilgisayardaki kameralara ulasabilmek icin ekledik
using AForge.Video.DirectShow;
//using System.Speech.Recognition;
using System.Threading;
using System.Globalization;

namespace CameraOrnek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FilterInfoCollection Filc; //filc adında bir nesne ismi yazdık. filter info collection bilgisayara bağlı kameraları tutan dizim bilgisayardaki kameraları comboBox içine listeletmek için kullanacağız

        VideoCaptureDevice vcd; // görüntü yakalama aygıtı
        Image resim=null; //sonradan kullanabilmek için image resim değişkeni oluşturuyoruz.
        
        int saniye = 0; // zamanlayıcıda kullanabilmek için saniye adında bir değişken oluşturuyoruz.

        private void Form1_Load(object sender, EventArgs e)
        {
            Filc = new FilterInfoCollection(FilterCategory.VideoInputDevice);//button içinde de kullanacağımız için global olarak tanımlıyoruz. Parametre olarak gonderdiklerimiz bilgisayara bağlı olan kameralariı getirecek.
            foreach (FilterInfo filt in Filc)//filterinfo'dan ürettiğimiz filt, Filc dizimizden değer alacak.
            {
                CAMERAS.Items.Add(filt.Name); // comboBox içine filtten gelen ismi ekledik yani kameranın ismini.
                CAMERAS.SelectedIndex = 0; //Başlangıçta sıfırıncı index seçili olarak gelecek yani ilk kamera direkt orada olacak
            }
            for (int i = 1; i < 10; i++) //saniyeleri Combobox'a yerleştirmek için for döngüsü başlatıyoruz.
            {
                CHOOSESECOND.Items.Add(i + 1);
            }
            SAYAC.Visible = false; // Geri sayım labelini gizliyoruz.
        }

        private void CAMERAS_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Choose the Cam", CAMERAS);//tooltipin nerede olduğunu görebilmek için combobox1 şeklinde ekledik
        } 

        private void START_Click(object sender, EventArgs e)
        {
            vcd = new VideoCaptureDevice(Filc[CAMERAS.SelectedIndex].MonikerString); 
            /*global olarak nesne üretiyoruz. parametre olarak combobox1.selectedindex sayesinde seçmiş olduğumuz indexi monikerstring komutuyla 
             * takma bir isim olarak gondertiyoruz. Kısacası seçilen kamerayı vcd diye takma bir isim verdik
            */
            vcd.NewFrame += Vcd_NewFrame;//kameraya bir çerçeve oluşturmak için Vcd_NewFrame adında bir method tanımladık.
            vcd.Start(); //video capture device'ı başlatacak komut
        }

        private void START_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Open the Cam", START);//tooltipin nerede olduğunu görebilmek için START şeklinde ekledik
        }

        private void Vcd_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            GORUNTU.Image = (Bitmap)eventArgs.Frame.Clone(); //Bitmap sınıfından ilgili picturebox'a kameradan aldığımız çerçeveyi aktarıyoruz. Vcd_NewFrame komutu sayesinde
        }

        private void CAPTURE_Click_1(object sender, EventArgs e)
        {
                kontrol();//Tıklandığı zaman kontrol methodu çalışıyor
        }

        private void CAPTURE_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Capture the Photo", CAPTURE);//tooltipin nerede olduğunu görebilmek için CAPTURE şeklinde ekledik

        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();//savefiledialog dosya kaydetme işlemi için kullanılan bir sınıf ve buradan sfd adında bir nesne türettik
            sfd.Filter = "(*.jpg)|*.jpg"; //sfd açıldığı zaman bir filtre uygulanacak ve jpg uzantısındaki dosyları getirecek
            DialogResult dr = sfd.ShowDialog(); //dialog resultten dr isimli bir nesne ürettik ve bu nesne aracılığıyla savefiledoalog açtıracağız
            if (dr == DialogResult.OK) //dr den gelen deger yani açılan pencerede tamam tuşuna basarsak aşağıdakileri döndürecek
            {
                resim.Save(sfd.FileName); //CAPTURE'da değişkene aktarılan görseli kaydettik
            }
            vcd.Start();//Kayıttan sonra kamerayı tekrar başlattık
        }

        private void SAVE_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Save", SAVE);//tooltipin nerede olduğunu görebilmek için SAVE şeklinde ekledik
        }

        private void TIMER_Click(object sender, EventArgs e)
        {
            CHOOSESECOND.Visible = !CHOOSESECOND.Visible; //zamanlayıcıya basılınca seçeneklerin çıkması tekrar basıldığında combobox'ın gitmesi için değiline eşitledik.
        }

        private void TIMER_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Choose the Second", TIMER);//tooltipin nerede olduğunu görebilmek için TIMER şeklinde ekledik
        }

        private void CHOOSESECOND_SelectedIndexChanged(object sender, EventArgs e)
        {
            saniye = Convert.ToInt32(CHOOSESECOND.SelectedItem);//comboBox'daki seçili index değiştiğinde saniye değeri değişir.
        }

        /// <summary>
        /// Eğer zamanlayıcı çalıştırılırsa else bloğu çalışıyor eğer zamanlayıcı çalışmazsa if bloğu çalışıyor.
        /// </summary>
        private void kontrol()
        {
            if (CHOOSESECOND.SelectedIndex == -1)
            {
                resim = GORUNTU.Image;//buttona tıklandığı andaki resmi bir degişkene aktardık
                vcd.Stop();
            }
            else
            {
                timer1.Start();
                SAYAC.Visible = true;// Geri Sayım labelini gösteriyoruz.
            }
        }

        #region sesli komut satırı

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        //    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
        //    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-GB");
        //    SpeechRecognitionEngine sr = new SpeechRecognitionEngine();
        //    Choices chs = new Choices();
        //    chs.Add(new string[] { "take", "a", "photo" });
        //    Grammar g = new Grammar(new GrammarBuilder(chs));
        //    sr.RequestRecognizerUpdate();
        //    sr.LoadGrammar(g);
        //    sr.SpeechRecognized += Sr_SpeechRecognized;
        //    sr.SpeechRecognitionRejected += Sr_SpeechRecognitionRejected;
        //    try
        //    {
        //        sr.SetInputToDefaultAudioDevice();
        //        sr.RecognizeAsync(RecognizeMode.Multiple); //coklu kelime algilamasi icin yapiliyor
                
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        }
        #endregion
        #region sesli komut satırı2
        //private void Sr_SpeechRecognitionRejected(object sender, SpeechRecognitionRejectedEventArgs e)
        //{
        //    MessageBox.Show("I don`t understand");
        //}

        //private string a = "";
        //private void Sr_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        //{
        //     a += e.Result.Text.ToString();
        //    if (a.Contains("takeapicture"))
        //    {
        //        MessageBox.Show(a);
        //    }
        //}
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // her bir saniyede tekrarlar
            SAYAC.Text = saniye.ToString();//Saniye değerini ekranda gösteriyoruz.
            saniye -= 1;//saniyeyi her defasında azaltıyoruz.
            if (saniye == -1)//saniye sıfırlandığında çalışır.
            {
                timer1.Stop();// Zamanlayıcıyı durduruyoruz.
                CHOOSESECOND.SelectedIndex = saniye;//comboBox'ı sıfırlıyoruz
                kontrol();//kontrol methodunu çağrıyoruz.
                SAYAC.Visible = false;// Geri Sayım labelini gizliyoruz.
            }
        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); //CLOSE butonuna basıldığında programı kapatıyor.
        }

        private void CLOSE_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Close", CLOSE);//tooltipin nerede olduğunu görebilmek için CLOSE şeklinde ekledik
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(vcd!=null)vcd.Stop();//Uygulama kapanırken kamerayı durduruyoruz.
        }

        private void DOWNPAGE_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //Butona tıklandığı zaman simge durumuna küçültür.
        }

        private void DOWNPAGE_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Page Down", DOWNPAGE);//tooltipin nerede olduğunu görebilmek için DOWBPAGE şeklinde ekledik
        }

        private void CREDIT_Click(object sender, EventArgs e)
        {
            this.Hide(); //Formu gizliyoruz.
            new Form2(this).Show(); //Credit formunu çağrıyoruz.
        }

        private void CREDIT_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Credit", CREDIT); //tooltipin nerede olduğunu görebilmek için CREDIT şeklinde ekledik
        }
    }
}
