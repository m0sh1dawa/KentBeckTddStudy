using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddStudy.Money
{
    public class Franc : Money
    {
        public Franc(int amount, string currency)
        {
            Amount = amount;
            this.currency = currency;
        }

        public override Money Times(int multiplier)
        {
            return Franc(Amount * multiplier);
        }
    }
}
