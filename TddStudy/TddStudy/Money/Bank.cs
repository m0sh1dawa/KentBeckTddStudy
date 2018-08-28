using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddStudy.Money
{
    public class Bank
    {
        private IDictionary<Pair, int> rates = new Dictionary<Pair, int>();

        public Money Reduce(IExpression source, string to)
        {
            return source.Reduce(this, to);
        }

        public void AddRate(string from, string to, int rate)
        {
            rates.Add(new Pair(from, to), rate);
        }

        public int Rate(string from, string to)
        {
            return rates[new Pair(from, to)];
        }
    }
}
