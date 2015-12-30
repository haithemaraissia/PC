using System.Collections.Generic;
using DAL.Fake.Model.Util;

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
                CurrencyId = (int)CurrencyType.Values.Usd,
                CurrencyValue = CurrencyType.Values.Usd.ToString()
            };
            return firstCurrency;
        }

        public global::Model.Currency SecondCurrency()
        {
            var secondCurrency = new global::Model.Currency
            {
                CurrencyId = (int)CurrencyType.Values.Cad,
                CurrencyValue = CurrencyType.Values.Cad.ToString()
            };
            return secondCurrency;
        }

        public global::Model.Currency ThirdCurrency()
        {
            var thirdCurrency = new global::Model.Currency
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
