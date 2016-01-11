using System.Collections.Generic;
using DAL.Fake.Model.LookUp.Currency;
using Model;

namespace DAL.Fake.Model.GoodData.Currencies
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
                CurrencyId = (int)CurrencyType.Values.Usd,
                CurrencyValue = CurrencyType.Values.Usd.ToString()
            };
            return firstCurrency;
        }

        public Currency SecondCurrency()
        {
            var secondCurrency = new Currency
            {
                CurrencyId = (int)CurrencyType.Values.Cad,
                CurrencyValue = CurrencyType.Values.Cad.ToString()
            };
            return secondCurrency;
        }

        public Currency ThirdCurrency()
        {
            var thirdCurrency = new Currency
            {
                CurrencyId = (int)CurrencyType.Values.Eur,
                CurrencyValue = CurrencyType.Values.Eur.ToString()
            };
            return thirdCurrency;
        }

        ~FakeCurrencies()
        {
            MyCurrencies = null;
        }
    }
}
