using System.Collections.Generic;
using DAL.Fake.Model.LookUp.Subscription.Cookers.ServingPrice;
using Model;

namespace DAL.Fake.Model.GoodData.Subscriptions.Cookers
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
                PlanId =  (int)LookUp.Plans.Plans.Types.ThreeMealsPerWeek,
                ServingPriceId = (int)ServingPriceModel.Values.Nine_DollarsNintyNine
            };
            return firstCookerSubscription;
        }

        public CookerSubscription SecondCookerSubscription()
        {
            var secondCookerSubscription = new CookerSubscription
            {
                CookerSubscriptionId = 2,
                CookerId = 1,
                PlanId =  (int)LookUp.Plans.Plans.Types.FiveMealsPerWeek,
                ServingPriceId = (int)ServingPriceModel.Values.Fourteen_Dollars_NintyNine
            };
            return secondCookerSubscription;
        }

        public CookerSubscription ThirdCookerSubscription()
        {
            var thirdCookerSubscription = new CookerSubscription
            {
                CookerSubscriptionId = 3,
                CookerId = 1,
                PlanId =  (int)LookUp.Plans.Plans.Types.TenMealsPerWeek,
                ServingPriceId = (int)ServingPriceModel.Values.Ninteen_Dollars_NintyNine
            };
            return thirdCookerSubscription;
        }

        ~FakeCookerSubscriptions()
        {
            MyCookerSubscriptions = null;
        }
    }
}
