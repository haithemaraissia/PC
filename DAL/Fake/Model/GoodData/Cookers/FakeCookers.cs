using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Cookers
{
    public class FakeCookers
    {
        public List<Cooker> MyCookers;

        public FakeCookers()
        {
            InitializeCookerList();
        }

        public void InitializeCookerList()
        {
            MyCookers = new List<Cooker> {
                FirstCooker(), 
                SecondCooker(),
                ThirdCooker()
            };
        }

        public Cooker FirstCooker()
        {
            var firstCooker = new Cooker
            {
                CookerId = 1,
                UserId = 1,
                RestaurantName = " Fiorella's Express",
                RestaurantPhoto = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\Test\Images\Restaurant\FiorellaExpress.jpg",
                Cuisines = LookUp.Cuisine.Cuisines.Types.Italian + " ," + LookUp.Cuisine.Cuisines.Types.Mexican,
                PhoneNumber = "913-524-2544",
                Bio = "At Big Al`s their reputation has been built on providing great service ranging from small lunches to large corporate catered meetings and events.",
                Rating = 5,
                TotalRaters = 12,
                OfferDelivery = true,
                OfferPickUp = true,
                TaxPercent = (decimal?) 8.15,
                AmountforFreeDelivery = (decimal?) 50.00,
                WaitingTime =  15,
                NumberofSubscription = 1
            };
            return firstCooker;
        }

        public Cooker SecondCooker()
        {
            var secondCooker = new Cooker
            {
                CookerId = 1,
                UserId = 2,
                RestaurantName = " Mike's Restaurant",
                RestaurantPhoto = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\Test\Images\Restaurant\Restaurant2.jpg",
                Cuisines = LookUp.Cuisine.Cuisines.Types.Japanese + " ," + LookUp.Cuisine.Cuisines.Types.Filipino + " ," + LookUp.Cuisine.Cuisines.Types.Jamaican + " ," + LookUp.Cuisine.Cuisines.Types.Moroccan,
                PhoneNumber = "202 555 2415",
                Bio ="One of the best restaurant that offer tentative customer service and great quality.",
                Rating = 5,
                TotalRaters = 0,
                OfferDelivery = false,
                OfferPickUp = true,
                TaxPercent = (decimal?) 8.47,
                WaitingTime = 60,
                NumberofSubscription = 2
            };
            return secondCooker;
        }

        public Cooker ThirdCooker()
        {
            var thirdCooker = new Cooker
            {
                CookerId = 1,
                UserId = 5,
                RestaurantName = " Sara Home Food",
                RestaurantPhoto = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\Test\Images\Restaurant\Restaurant1.jpg",
                Cuisines = LookUp.Cuisine.Cuisines.Types.Dominican.ToString(),
                PhoneNumber = "8164541121",
                Bio = "Sara's Home Food is the best home made food in the usa",
                Rating = 3,
                TotalRaters = 18,
                OfferDelivery = true,
                OfferPickUp = false,
                TaxPercent = (decimal?) 8.88,
                AmountforFreeDelivery = (decimal?)30.00,
                WaitingTime = 80,
                NumberofSubscription = 0
            };
            return thirdCooker;
        }

        ~FakeCookers()
        {
            MyCookers = null;
        }
    }
}
