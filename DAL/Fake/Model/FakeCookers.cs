using System.Collections.Generic;
using DAL.Fake.Model.Util;
using Model;

namespace DAL.Fake.Model
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
                Cuisines = Cuisines.Types.Italian + " ," + Cuisines.Types.Mexican,
                PhoneNumber = "913-524-2544",
                Bio = "At Big Al`s their reputation has been built on providing great service ranging from small lunches to large corporate catered meetings and events.",
                Rating = 5,
                TotalRaters = 12

            };
            return firstCooker;
        }

        public Cooker SecondCooker()
        {
            var secondCooker = new Cooker
            {
                CookerId = 2,
                UserId = 2
            };
            return secondCooker;
        }

        public Cooker ThirdCooker()
        {
            var thirdCooker = new Cooker
            {
                CookerId = 3,
                UserId = 5
            };
            return thirdCooker;
        }

        ~FakeCookers()
        {
            MyCookers = null;
        }
    }
}
