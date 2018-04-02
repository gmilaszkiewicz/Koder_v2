using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Base64 : KoderDekoder
    {
        public Base64(string x)
        {
            tekst = x;
        }

        public override string koduj()
        {
           
            var tekstBytes = Encoding.UTF8.GetBytes(tekst);
            return Convert.ToBase64String(tekstBytes);
        
        }

        public override string dekoduj()
        {
           
            var tekstBytes = Convert.FromBase64String(tekst);
            return Encoding.UTF8.GetString(tekstBytes);
        
        }
    
}
}
