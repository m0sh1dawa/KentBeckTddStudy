using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddStudy.Money
{
    public class Sum : IExpression
    {
        public Money Augend;
        public Money Addend;

        public Sum(Money augend, Money addend)
        {
            Augend = augend;
            Addend = addend;
        }

        public Money Reduce(string to)
        {
            int amount = Augend.Amount + Addend.Amount;
            return new Money(amount, to);
        }
    }
}
