using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
{
    public class FakeCookerMenuPrices
    {
        public List<CookerMenuPrice> MyCookerMenuPrices;

        public FakeCookerMenuPrices()
        {
            InitializeCookerMenuPriceList();
        }

        public void InitializeCookerMenuPriceList()
        {
            MyCookerMenuPrices = new List<CookerMenuPrice> {
                FirstCookerMenuPrices(), 
                SecondCookerMenuPrices(),
                ThirdCookerMenuPrices()
            };
        }

        public CookerMenuPrice FirstCookerMenuPrices()
        {
            //One or many Menu
            //Maybe promotionId
            //think about serving Id
            var firstCookerMenuPrices = new CookerMenuPrice
            {
                PriceId = 1,
                MenuId = 1,
                ServingId = 1
            };
            return firstCookerMenuPrices;
        }

        public CookerMenuPrice SecondCookerMenuPrices()
        {
            var secondCookerMenuPrices = new CookerMenuPrice
            {
                PriceId = 2,
                MenuId = 3,
                ServingId = 2
            };
            return secondCookerMenuPrices;
        }

        public CookerMenuPrice ThirdCookerMenuPrices()
        {
            var thirdCookerMenuPrices = new CookerMenuPrice
            {
                PriceId = 3,
                MenuId = 2,
                ServingId = 3
            };
            return thirdCookerMenuPrices;
        }

        ~FakeCookerMenuPrices()
        {
            MyCookerMenuPrices = null;
        }
    }
}
