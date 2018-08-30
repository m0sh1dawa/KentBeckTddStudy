using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddStudy.Money
{
    public interface IExpression
    {
        IExpression Plus(IExpression addend);

        Money Reduce(Bank bank, string to);
    }
}
