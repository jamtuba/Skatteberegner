using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skatteberegner
{
    public class Beregning
    {
        // Funktionen returnerer det beløb, der skal beskattes (altså ikke selve skatten).
        public double TaxByXmasGift(double xmasGift, double secondGift)
        {
            var xmasgiftAndMore = xmasGift + secondGift;
            if (xmasGift <= 900 && xmasgiftAndMore <= 1200)
                return 0;
            else if (xmasGift > 900 && xmasgiftAndMore > 1200)
                return xmasgiftAndMore;
            else
                return secondGift;
        }
    }
}
