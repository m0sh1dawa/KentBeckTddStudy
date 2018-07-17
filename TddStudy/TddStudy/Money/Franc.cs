using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddStudy.Money
{
    public class Franc : Money
    {
        public Franc(int amount)
        {
            this.Amount = amount;
        }

        public override Money Times(int multiplier)
        {
            return new Franc(this.Amount * multiplier);
        }

        public override string Currency()
        {
            return "CHF";
        }
    }
}
