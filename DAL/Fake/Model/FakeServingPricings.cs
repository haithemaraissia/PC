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
                ServingPricingsValue = "Value of Serving",
                ServingPricingCurrencyId = 1
            };
            return firstServingPricing;
        }

        public ServingPricing SecondServingPricing()
        {
            var secondServingPricing = new ServingPricing
            {
                ServingPricingId = 2,
                ServingPricingsValue = "Value of Serving",
                ServingPricingCurrencyId = 1
            };
            return secondServingPricing;
        }

        public ServingPricing ThirdServingPricing()
        {
            var thirdServingPricing = new ServingPricing
            {
                ServingPricingId = 3,
                ServingPricingsValue = "Value of Serving",
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
