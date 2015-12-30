using System.Collections.Generic;
using DAL.Fake.Model.Util;
using Model;

namespace DAL.Fake.Model
{
    public class FakeServingPrices
    {
        public List<ServingPrice> MyServingPricings;

        public FakeServingPrices()
        {
            InitializeServingPricingList();
        }

        public void InitializeServingPricingList()
        {
            MyServingPricings = new List<ServingPrice> {
                FirstServingPricing(), 
                SecondServingPricing(),
                ThirdServingPricing()
            };
        }

        public ServingPrice FirstServingPricing()
        {
            var firstServingPricing = new ServingPrice
            {
                ServicePriceId = (int)ServingPriceModel.Values.Ninteen_Dollars_NintyNine,
                ServingMeasurementId = (int)ServingMeasurementType.Values.TwoCupContainer,
                PLanId = (int)Plans.Types.ThreeMealsPerWeek,
                Price = (decimal)(new ServingPriceModel().GetPrice(ServingPriceModel.Values.Ninteen_Dollars_NintyNine)),
                Quantity = 1
            };
            return firstServingPricing;
        }

        public ServingPrice SecondServingPricing()
        {
            var secondServingPricing = new ServingPrice
            {
                ServicePriceId = (int)ServingPriceModel.Values.Fourteen_Dollars_NintyNine,
                ServingMeasurementId = (int)ServingMeasurementType.Values.BreadPlate6Inches,
                PLanId = (int)Plans.Types.FiveMealsPerWeek,
                Price = (decimal)(new ServingPriceModel().GetPrice(ServingPriceModel.Values.Fourteen_Dollars_NintyNine)),
                Quantity = 2
            };
            return secondServingPricing;
        }

        public ServingPrice ThirdServingPricing()
        {
            var thirdServingPricing = new ServingPrice
            {
                ServicePriceId = (int)ServingPriceModel.Values.Ninteen_Dollars_NintyNine,
                ServingMeasurementId = (int)ServingMeasurementType.Values.LunchPlate9Inches,
                PLanId = (int)Plans.Types.TenMealsPerWeek,
                Price = (decimal)(new ServingPriceModel().GetPrice(ServingPriceModel.Values.Nine_DollarsNintyNine)),
                Quantity = 1
            };
            return thirdServingPricing;
        }

        ~FakeServingPrices()
        {
            MyServingPricings = null;
        }
    }
}
