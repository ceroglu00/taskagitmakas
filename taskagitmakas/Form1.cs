using System;

namespace taskagitmakas
{
    public partial class Form1 : Form
    {
        string oyuncu;
        string[] sonuc;
        Oyun oyunClassım = new Oyun();
        Random rnd = new Random();
        int oyuncuSkor = 0;
        int botSkor = 0;
        bool oyunAktif = false;

        public Form1()
        {
            InitializeComponent();
        }

        async void OyunOynat()
        {
            oyunAktif = true;
            sonuc = oyunClassım.OyunFonksiyonu(oyuncu);
          

            //ŞURADA ANİMASYONUMSU BİŞEYLER

            Bitmap[] görseller = {
                Properties.Resources.taş,
                Properties.Resources.kağıt,
                Properties.Resources.makas
            };

            Dictionary<string, Bitmap> veriTabanım = new Dictionary<string, Bitmap>();

            veriTabanım.Add("TAŞ", görseller[0]);
            veriTabanım.Add("KAĞIT", görseller[1]);
            veriTabanım.Add("MAKAS", görseller[2]);



            //RASTGELE ŞEKİLDE BOTUN GÖRSELİNİ DEĞİŞTİR
            var index = 0;

            int totalSteps = 5; //normalde 50 idi
            double maxSpeed = 10;
            double minSpeed = 250;

            for (int step = 0; step < totalSteps; step++)
            {

                double t = (double)step / totalSteps;
                double speed = maxSpeed + (minSpeed - maxSpeed) * (t * t);

                var yeniGörsel = görseller[index++];
                if (index == 3)
                    index = 0;

                pictureBoxBot.Image = yeniGörsel;
                await Task.Delay((int)speed);

            }

            //EN SONRA DOĞRU GÖRSELİ KOY
            pictureBoxBot.Image = veriTabanım[sonuc[1]];




            if (sonuc[0] == "YENDİ")
            {
                oyuncuSkor++;
            }
            else if (sonuc[0] == "KAYBETTİ")
            {
                botSkor++;
            }

            lblOyuncuSkor.Text = oyuncuSkor.ToString();
            lblBotSkor.Text = botSkor.ToString();

            lblSonuç.Text = "SONUÇ: " + sonuc[0];
            lblBotSeçim.Text = "BOT SEÇİM: " + sonuc[1];


            richTbxLog.AppendText("ROUND OYNANDI\n");


            //await Task.Delay(3000);
            oyunAktif = false;
        }
        private void btnTaş_Click(object sender, EventArgs e)
        {
            if (oyunAktif)
                return;


            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox3.BorderStyle = BorderStyle.None;

            oyuncu = ((PictureBox)sender).Tag.ToString();

            ((PictureBox)sender).BorderStyle = BorderStyle.FixedSingle;

            OyunOynat();

        }

        void Reset()
        {
            oyuncuSkor = 0;
            botSkor = 0;

            lblOyuncuSkor.Text = oyuncuSkor.ToString();
            lblBotSkor.Text = botSkor.ToString();

            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox3.BorderStyle = BorderStyle.None;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
