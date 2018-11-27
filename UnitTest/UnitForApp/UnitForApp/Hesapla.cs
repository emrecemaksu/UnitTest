using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitForApp
{
    public class Hesapla
    {
        public decimal hesapla(decimal boy, decimal kilo)
        {
            decimal result = 10000 * (kilo / (boy * boy));
            return result;
        }
    }
}
