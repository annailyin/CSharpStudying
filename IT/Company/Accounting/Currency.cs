namespace IT.Company.Accounting
{
    public sealed class Currency
    {
        public static readonly Currency USD = new Currency("USD", "$");

        public static readonly Currency EUR = new Currency("EUR", "€");

        public static readonly Currency BYN = new Currency("BYN");

        public string ISOCode { get; }

        public string Sign { get; }

        public Currency(string isoCode, string sign)
        {
            ISOCode = isoCode;
            Sign = sign;
        }

        public Currency(string isoCode) : this(isoCode, "")
        {
        }
    }
}
