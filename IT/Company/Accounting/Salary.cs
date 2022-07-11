namespace IT.Company.Accounting
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
