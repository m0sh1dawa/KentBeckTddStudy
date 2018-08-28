﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddStudy.Money
{
    public class Pair
    {
        private string from;
        private string to;

        public Pair(string from, string to)
        {
            this.from = from;
            this.to = to;
        }

        public override bool Equals(object obj)
        {
            Pair pair = (Pair)obj;
            return from.Equals(pair.from) && to.Equals(pair.to);
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }
}
