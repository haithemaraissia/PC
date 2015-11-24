using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
{
    public class FakeServingPricings
    {
        public List<ServingPricing> MyServingPricings;

        public FakeServingPricings()
        {
            InitializeServingPricingList();
        }

        public void InitializeServingPricingList()
        {
            MyServingPricings = new List<ServingPricing> {
                FirstServingPricing(), 
                SecondServingPricing(),
                ThirdServingPricing()
            };
        }

        public ServingPricing FirstServingPricing()
        {
            var firstServingPricing = new ServingPricing
            {
                ServingPricingId = 1,
                ServingPricingsValue = 5,
                ServingPricingCurrencyId = 1
            };
            return firstServingPricing;
        }

        public ServingPricing SecondServingPricing()
        {
            var secondServingPricing = new ServingPricing
            {
                ServingPricingId = 2,
                ServingPricingsValue = 5,
                ServingPricingCurrencyId = 1
            };
            return secondServingPricing;
        }

        public ServingPricing ThirdServingPricing()
        {
            var thirdServingPricing = new ServingPricing
            {
                ServingPricingId = 3,
                ServingPricingsValue = 5,
                ServingPricingCurrencyId = 1
            };
            return thirdServingPricing;
        }

        ~FakeServingPricings()
        {
            MyServingPricings = null;
        }
    }
}
