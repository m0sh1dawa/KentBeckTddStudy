using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddStudy.Money
{
    public class Bank
    {
        public Money Reduce(IExpression source, string to)
        {
            Sum sum = (Sum)source;
            return sum.Reduce(to);
        }
    }
}
