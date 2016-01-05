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

        #region Cooker1 ServingPrice
     

        public ServingPrice FirstServingPricing()
        {
            var firstServingPricing = new ServingPrice
            {
                ServicePriceId = (int)ServingPriceModel.Values.Ninteen_Dollars_NintyNine,
                ServingMeasurementId = (int)ServingMeasurementType.Values.TwoCupContainer,
                PLanId = (int)Plans.Types.ThreeMealsPerWeek,
                Price = (decimal)(new ServingPriceModel().GetPrice(ServingPriceModel.Values.Ninteen_Dollars_NintyNine)),
                CookerId = 1,
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
                CookerId = 1,
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
                CookerId = 1,
                Quantity = 1
            };
            return thirdServingPricing;
        }
   #endregion


        ~FakeServingPrices()
        {
            MyServingPricings = null;
        }
    }
}
