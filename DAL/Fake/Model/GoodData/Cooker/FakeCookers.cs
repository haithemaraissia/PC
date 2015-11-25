using System.Collections.Generic;
using DAL.Fake.Model.Util;

namespace DAL.Fake.Model.GoodData.Cooker
{
    public class FakeCookers
    {
        public List<global::Model.Cooker> MyCookers;

        public FakeCookers()
        {
            InitializeCookerList();
        }

        public void InitializeCookerList()
        {
            MyCookers = new List<global::Model.Cooker> {
                FirstCooker(), 
                SecondCooker(),
                ThirdCooker()
            };
        }

        public global::Model.Cooker FirstCooker()
        {
            var firstCooker = new global::Model.Cooker
            {
                CookerId = 1,
                UserId = 1,
                RestaurantName = " Fiorella's Express",
                RestaurantPhoto = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\Test\Images\Restaurant\FiorellaExpress.jpg",
                Cuisines = Cuisines.Types.Italian + " ," + Cuisines.Types.Mexican,
                PhoneNumber = "913-524-2544",
                Bio = "At Big Al`s their reputation has been built on providing great service ranging from small lunches to large corporate catered meetings and events.",
                Rating = 5,
                TotalRaters = 12,
                OfferDelivery = true,
                OfferPickUp = true,
                TaxPercent = (decimal?) 8.15,
                AmountforFreeDelivery = (decimal?) 50.00

            };
            return firstCooker;
        }

        public global::Model.Cooker SecondCooker()
        {
            var secondCooker = new global::Model.Cooker
            {
                CookerId = 1,
                UserId = 2,
                RestaurantName = " Mike's Restaurant",
                RestaurantPhoto = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\Test\Images\Restaurant\Restaurant2.jpg",
                Cuisines = Cuisines.Types.Japanese + " ," + Cuisines.Types.Filipino + " ," + Cuisines.Types.Jamaican + " ," + Cuisines.Types.Moroccan,
                PhoneNumber = "202 555 2415",
                Bio ="One of the best restaurant that offer tentative customer service and great quality.",
                Rating = 5,
                TotalRaters = 0,
                OfferDelivery = false,
                OfferPickUp = true,
                TaxPercent = (decimal?) 8.47
            };
            return secondCooker;
        }

        public global::Model.Cooker ThirdCooker()
        {
            var thirdCooker = new global::Model.Cooker
            {
                CookerId = 1,
                UserId = 5,
                RestaurantName = " Sara Home Food",
                RestaurantPhoto = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\Test\Images\Restaurant\Restaurant1.jpg",
                Cuisines = Cuisines.Types.Dominican.ToString(),
                PhoneNumber = "8164541121",
                Bio = "Sara's Home Food is the best home made food in the usa",
                Rating = 3,
                TotalRaters = 18,
                OfferDelivery = true,
                OfferPickUp = false,
                TaxPercent = (decimal?) 8.88,
                AmountforFreeDelivery = (decimal?)30.00
            };
            return thirdCooker;
        }

        ~FakeCookers()
        {
            MyCookers = null;
        }
    }
}
