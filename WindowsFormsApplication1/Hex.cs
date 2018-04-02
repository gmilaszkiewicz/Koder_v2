using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Hex : KoderDekoder
    {
        public Hex(string x)
        {
            tekst = x;
        }

        public override string koduj()
        {
            string output = String.Empty;
            char[] values = tekst.ToCharArray();
            foreach (char znak in values)
            {
                int value = Convert.ToInt32(znak);
                output += string.Format("{0:x}", value);
            }
            tekst = output;
            return tekst;
        }

        public override string dekoduj()
        {
            if (tekst.Length % 2 == 1)
            {
                tekst = tekst.Remove(tekst.Length - 1);
            }
            bool ok = true;

            for(int i=0; i<tekst.Length; i++)
            {
                if((tekst[i]<48 || tekst[i]>57)&& (tekst[i]<65 || tekst[i]>70)&& (tekst[i] < 97 || tekst[i] > 102))
                {
                    ok = false;
                    break;
                }
            }
            if (!ok) return "";
                string output = String.Empty;
                while (tekst.Length > 0)
                {
                    output += Convert.ToChar(Convert.ToUInt32(tekst.Substring(0, 2), 16)).ToString();
                    tekst = tekst.Substring(2, tekst.Length - 2);
                }
                tekst = output;
            
            

            return tekst;
        }
    }
}
