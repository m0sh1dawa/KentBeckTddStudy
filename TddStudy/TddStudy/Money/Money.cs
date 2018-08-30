using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddStudy.Money
{
    public class Money : IExpression
    {
        internal int Amount;

        protected string currency;

        public Money(int amount, string currency)
        {
            Amount = amount;
            this.currency = currency;
        }

        public IExpression Times(int multiplier)
        {
            return new Money(Amount * multiplier, currency);
        }

        public IExpression Plus(IExpression added)
        {
            return new Sum(this, added);
        }

        public Money Reduce(Bank bank, string to)
        {
            int rate = bank.Rate(currency, to);
            return new Money(Amount / rate, to);
        }

        public string Currency()
        {
            return currency;
        }

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return Amount == money.Amount && currency == money.currency;
        }

        public static Money Dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money Franc(int amout)
        {
            return new Money(amout, "CHF");
        }

        public override string ToString()
        {
            return Amount + " " + currency;
        }
    }
}
