using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskagitmakas
{
    internal class Oyun
    {
        Random random = new Random();

        public string deneme;

        private string deneme2;

        public string[] OyunFonksiyonu(string oyuncu)
        {
            string[] secenekler = { "TAŞ", "KAĞIT", "MAKAS" };
            var bot = secenekler[random.Next(0, 3)];


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

    }
}
