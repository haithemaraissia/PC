using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
{
    public class FakeCurrencies
    {
        public List<Currency> MyCurrencies;

        public FakeCurrencies()
        {
            InitializeCurrencyList();
        }

        public void InitializeCurrencyList()
        {
            MyCurrencies = new List<Currency> {
                FirstCurrency(), 
                SecondCurrency(),
                ThirdCurrency()
            };
        }

        public Currency FirstCurrency()
        {
            var firstCurrency = new Currency
            {
                CurrencyId = 1,
                CurrencyValue = "USD"
            };
            return firstCurrency;
        }

        public Currency SecondCurrency()
        {
            var secondCurrency = new Currency
            {
                CurrencyId = 2,
                CurrencyValue = "CAD"
            };
            return secondCurrency;
        }

        public Currency ThirdCurrency()
        {
            var thirdCurrency = new Currency
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
