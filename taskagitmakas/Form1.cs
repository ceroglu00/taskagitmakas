namespace taskagitmakas
{
    public partial class Form1 : Form
    {
        string oyuncu;
        string[] sonuc;
        Oyun oyunClassım = new Oyun();
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        async void OyunOynat()
        {
            sonuc = oyunClassım.OyunFonksiyonu(oyuncu);
            //ŞURADA ANİMASYONUMSU BİŞEYLER

            Bitmap[] görseller = { 
                Properties.Resources.taş, 
                Properties.Resources.kağıt, 
                Properties.Resources.makas 
            };

            Dictionary<string,Bitmap> veriTabanım = new Dictionary<string,Bitmap>();

            veriTabanım.Add("TAŞ", görseller[0]);
            veriTabanım.Add("KAĞIT", görseller[1]);
            veriTabanım.Add("MAKAS", görseller[2]);



            //RASTGELE ŞEKİLDE BOTUN GÖRSELİNİ DEĞİŞTİR
            var index = 0;

            int totalSteps = 100;
            double maxSpeed = 10;
            double minSpeed = 250;

            for (int step = 0; step < totalSteps; step++) {

                double t = (double)step / totalSteps;
                double speed = maxSpeed + (minSpeed - maxSpeed) * (t * t);

                var yeniGörsel = görseller[index++];
                if (index == 3)
                    index = 0;

                pictureBoxBot.Image = yeniGörsel;
                //Thread.Sleep(10);
                await Task.Delay((int)speed);

            }
            
            //EN SONRA DOĞRU GÖRSELİ KOY
            pictureBoxBot.Image = veriTabanım[sonuc[1]];




            lblSonuç.Text = "SONUÇ: " + sonuc[0];
            lblBotSeçim.Text = "BOT SEÇİM: " + sonuc[1];


            richTbxLog.AppendText("ROUND OYNANDI\n");

        }
        private void btnTaş_Click(object sender, EventArgs e)
        {

            oyuncu = ((PictureBox)sender).Tag.ToString();
   
            OyunOynat();
        }

    }
}
