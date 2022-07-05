using System;
using System.Collections.Generic;
using System.Text;

namespace ITCompany
{
    public sealed class Salary
    {
        public decimal Value { get; }

        public Currency Currency { get; }

        public Salary(decimal value, Currency currency)
        {
            Value = value;
            Currency = currency;
        }

        public override string ToString()
        {
            return $"{Value} {Currency}";
        }
    }
}
