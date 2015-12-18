using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.CookerSubscriptions
{
    public class FakeCookerSubscriptions
    {
        public List<CookerSubscription> MyCookerSubscriptions;

        public FakeCookerSubscriptions()
        {
            InitializeCookerSubscriptionList();
        }

        public void InitializeCookerSubscriptionList()
        {
            MyCookerSubscriptions = new List<CookerSubscription> {
                FirstCookerSubscription(), 
                SecondCookerSubscription(),
                ThirdCookerSubscription()
            };
        }

        public CookerSubscription FirstCookerSubscription()
        {
            var firstCookerSubscription = new CookerSubscription
            {
                CookerSubscriptionId = 1,
                CookerId = 1,
                PlanId =  (int)Util.Plans.Types.ThreeMealsPerWeek,
                ServingPriceId = (int)Util.ServingPriceModel.Values.Nine_DollarsNintyNine
            };
            return firstCookerSubscription;
        }

        public CookerSubscription SecondCookerSubscription()
        {
            var secondCookerSubscription = new CookerSubscription
            {
                CookerSubscriptionId = 2,
                CookerId = 1,
                PlanId =  (int)Util.Plans.Types.FiveMealsPerWeek,
                ServingPriceId = (int)Util.ServingPriceModel.Values.Fourteen_Dollars_NintyNine
            };
            return secondCookerSubscription;
        }

        public CookerSubscription ThirdCookerSubscription()
        {
            var thirdCookerSubscription = new CookerSubscription
            {
                CookerSubscriptionId = 3,
                CookerId = 1,
                PlanId =  (int)Util.Plans.Types.TenMealsPerWeek,
                ServingPriceId = (int)Util.ServingPriceModel.Values.Ninteen_Dollars_NintyNine
            };
            return thirdCookerSubscription;
        }

        ~FakeCookerSubscriptions()
        {
            MyCookerSubscriptions = null;
        }
    }
}
