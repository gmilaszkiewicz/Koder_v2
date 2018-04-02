using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Kwadrat : KoderDekoder
    {
       
        private int dlugosc, wymiar;
        private char[,] macierz;
        public Kwadrat(string x)
        {
            wymiar = 1;
            tekst = x;
            dlugosc = tekst.Length;
            int k;
            do
            {
                wymiar++;
                k = wymiar * wymiar;
            } while (k < dlugosc);
            macierz = new char[wymiar, wymiar];
        }
        public override string koduj()
        {
            int m, n, j = 0;
            for (int i = 0; i < wymiar; i++)
            {
                for (m = 0; m < wymiar; m++)
                {
                    macierz[i, m] = Convert.ToChar(32);         //wypełnianie spacjami 
                }
            }
            m = 0; n = 0;
            for (int i = 0; i < dlugosc; i++)
            {
                {
                    macierz[n, m] = tekst[i];   //przypisywanie tekstu do zakodowania
                    m++;
                    if (m == wymiar)                    //przeskoczenie do nastepnego wiersza
                    {
                        n++;
                        m = 0;
                    }
                }
            }
            tekst = String.Empty;
            for (int i = 0; i < wymiar; i++)
            {
                for (m = 0; m < wymiar; m++)
                {
                    char znak = macierz[m, i];  //przypisanie zakodowanego tekstu
                    tekst += Convert.ToString(znak);
                }
            }

            return tekst;
        }

        public override string dekoduj()
        {
            int m, n, j = 0;
            for (int i = 0; i < wymiar; i++)
            {
                for (m = 0; m < wymiar; m++)
                {
                    macierz[i, m] = Convert.ToChar(32);         //wypełnianie spacjami 
                }
            }
            m = 0; n = 0;
            for (int i = 0; i < dlugosc; i++)
            {
                {
                    macierz[n, m] = tekst[i];   //przypisywanie tekstu do zakodowania
                    m++;
                    if (m == wymiar)                    //przeskoczenie do nastepnego wiersza
                    {
                        n++;
                        m = 0;
                    }
                }
            }
            tekst = String.Empty;
            for (int i = 0; i < wymiar; i++)
            {
                for (m = 0; m < wymiar; m++)
                {
                    char znak = macierz[m, i];  //przypisanie zakodowanego tekstu
                    tekst += Convert.ToString(znak);
                }
            }
            return tekst;
        }
    }
}
