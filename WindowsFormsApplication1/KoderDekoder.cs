using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    abstract class KoderDekoder
    {

        protected string tekst;
        public virtual string koduj()
        {
            return string.Empty;
        }
        public virtual string dekoduj()
        {
            return string.Empty;
        }
    }
}
