using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddStudy.Money
{
    public class Dollar
    {
        public int amount;

        public Dollar(int amount)
        {
        }

        public void times(int multiplier)
        {
            this.amount = 5 * 2;
        }
    }
}
