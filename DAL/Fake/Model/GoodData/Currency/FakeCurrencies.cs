using System.Collections.Generic;

namespace DAL.Fake.Model.GoodData.Currency
{
    public class FakeCurrencies
    {
        public List<global::Model.Currency> MyCurrencies;

        public FakeCurrencies()
        {
            InitializeCurrencyList();
        }

        public void InitializeCurrencyList()
        {
            MyCurrencies = new List<global::Model.Currency> {
                FirstCurrency(), 
                SecondCurrency(),
                ThirdCurrency()
            };
        }

        public global::Model.Currency FirstCurrency()
        {
            var firstCurrency = new global::Model.Currency
            {
                CurrencyId = 1,
                CurrencyValue = "USD"
            };
            return firstCurrency;
        }

        public global::Model.Currency SecondCurrency()
        {
            var secondCurrency = new global::Model.Currency
            {
                CurrencyId = 2,
                CurrencyValue = "CAD"
            };
            return secondCurrency;
        }

        public global::Model.Currency ThirdCurrency()
        {
            var thirdCurrency = new global::Model.Currency
            {
                CurrencyId = 3,
                CurrencyValue = "EUR"
            };
            return thirdCurrency;
        }

        ~FakeCurrencies()
        {
            MyCurrencies = null;
        }
    }
}
