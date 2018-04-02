using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ROT13 : KoderDekoder
    {
       
        private int dlugosc;
        public ROT13(string x)
        {
            tekst = x;
            dlugosc = tekst.Length;
        }

        public override string koduj()
        {
            char x = 'a';
            string wynik = "";
            for (int i = 0; i < dlugosc; i++)
            {
                if ((Convert.ToInt16(tekst[i]) >= 65) && (Convert.ToInt16(tekst[i]) <= 90))
                {
                    x = (char)((int)tekst[i] + 13);
                    if ((int)x > 90)
                    {
                        x = (char)((int)tekst[i] - 13);
                    }
                }
                else if ((Convert.ToInt16(tekst[i]) >= 97) && (Convert.ToInt16(tekst[i]) <= 122))
                {
                    x = (char)((int)tekst[i] + 13);
                    if ((int)x > 122)
                    {
                        x = (char)((int)tekst[i] - 13);
                    }
                }
                else
                {
                    x = tekst[i];
                }
                wynik += Convert.ToString(x);
            }
            tekst = wynik;
            return tekst;
        }

        public override string dekoduj()
        {
            char x;
            string wynik = String.Empty;
            for (int i = 0; i < dlugosc; i++)
            {
                if ((Convert.ToInt16(tekst[i]) >= 65) && (Convert.ToInt16(tekst[i]) <= 90))
                {
                    x = (char)((int)tekst[i] + 13);
                    if ((int)x > 90)
                    {
                        x = (char)((int)tekst[i] - 13);
                    }
                }
                else if ((Convert.ToInt16(tekst[i]) >= 97) && (Convert.ToInt16(tekst[i]) <= 122))
                {
                    x = (char)((int)tekst[i] + 13);
                    if ((int)x > 122)
                    {
                        x = (char)((int)tekst[i] - 13);
                    }
                }
                else
                {
                    x = tekst[i];
                }
                wynik += Convert.ToString(x);
            }
            tekst = wynik;
            return tekst;
        }
    }
}
