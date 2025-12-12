using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskagitmakas
{
    internal class Oyun
    {
        Random rnd = new Random();

        List<string> oyuncuSecimleri = new List<string>();


        public string[] OyunFonksiyonu(string oyuncu)
        {
           

            string[] secenekler = { "TAŞ", "KAĞIT", "MAKAS" };
            //var bot = secenekler[rnd.Next(0, 3)];
            string bot;

            if (oyuncuSecimleri.Count < 2)
            {
                bot = secenekler[rnd.Next(0, 3)];
            }
            else
            {
                bot = KarşıHamleyiHesapla(oyuncuSecimleri);
            }
            oyuncuSecimleri.Add(oyuncu);



            if (oyuncu == bot)
            {
                //BERABERE
                return ["BERABERE", bot];
            }
            else if (
                (oyuncu == "TAŞ" && bot == "MAKAS") ||
                (oyuncu == "MAKAS" && bot == "KAĞIT") ||
                (oyuncu == "KAĞIT" && bot == "TAŞ")
                )
            {
                // OYUNCU YENDİ
                return ["YENDİ", bot];
            }
            else
            {
                //KAYBETTIK
                return ["KAYBETTİ", bot];
            }

        }


        private string KarşıHamleyiHesapla(List<string> hamleler)
        {
            // Verilen hamleler parametresi göz önüne alınara
            // karşı hamle üretilecek

            // ****1- OYUNCUNUN OYNADIĞI HAMLELERİN YÜZDESİNİ BUL
            // ****2- YÜZDE MİKTARI KADAR LİSTEYE ANTİSİNİ KOY
            // ****3- RASTGELE SAYI ÜRET VE BİRİNİ SEÇ

            Dictionary<string, int> hamleSayıları = new Dictionary<string, int>();
            hamleSayıları.Add("TAŞ", 0);
            hamleSayıları.Add("KAĞIT", 0);
            hamleSayıları.Add("MAKAS", 0);

            for (int i = 0; i < hamleler.Count; i++)
            {
                hamleSayıları[hamleler[i]]++;
            }

            

            hamleSayıları["TAŞ"] = (int)((double)hamleSayıları["TAŞ"] / hamleler.Count * 100);
            hamleSayıları["KAĞIT"] = (int)((double)hamleSayıları["KAĞIT"] / hamleler.Count * 100);
            hamleSayıları["MAKAS"] = (int)((double)hamleSayıları["MAKAS"] / hamleler.Count * 100);


            var hamleTorbası = new List<string>();

            var taşHamleleri = Enumerable.Repeat("KAĞIT", hamleSayıları["TAŞ"]).ToList();
            var kağıtHamleleri = Enumerable.Repeat("MAKAS", hamleSayıları["KAĞIT"]).ToList();
            var makasHamleleri = Enumerable.Repeat("TAŞ", hamleSayıları["MAKAS"]).ToList();

            hamleTorbası.AddRange(taşHamleleri);
            hamleTorbası.AddRange(kağıtHamleleri);
            hamleTorbası.AddRange(makasHamleleri);


            var hamlem = hamleTorbası[rnd.Next(0, 99 - (100 - hamleTorbası.Count))];

            return hamlem;
        }

    }
}
