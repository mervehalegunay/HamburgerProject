using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Models
{
    public class Siparis
    {
        public Siparis()
        {

            EkstraMalzeme = new List<EkstraMalzeme>();
        }

        public Menu Menu { get; set; }
        public List<EkstraMalzeme> EkstraMalzeme { get; set; }
        public MenuBoyu MenuBoyu { get; set; }
        public int Adet { get; set; }
    }
}
