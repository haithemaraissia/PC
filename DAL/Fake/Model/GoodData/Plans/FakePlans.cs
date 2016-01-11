using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Plans
{
    public class FakePlans
    {
        public List<Plan> MyPlans;

        public FakePlans()
        {
            InitializePlanList();
        }

        public void InitializePlanList()
        {
            MyPlans = new List<Plan> {
                FirstPlan(), 
                SecondPlan(),
                ThirdPlan()
            };
        }

        public Plan FirstPlan()
        {
            var firstPlan = new Plan
            {
                PlanId = (int)LookUp.Plans.Plans.Types.ThreeMealsPerWeek,
                ExternalId = "1",
                Description = LookUp.Plans.Plans.Types.ThreeMealsPerWeek.ToString(),
                Title="Mike Weekly Plan"
            };
            return firstPlan;
        }

        public Plan SecondPlan()
        {
            var secondPlan = new Plan
            {
                PlanId = (int)LookUp.Plans.Plans.Types.FiveMealsPerWeek,
                ExternalId = "2",
                Description = LookUp.Plans.Plans.Types.FiveMealsPerWeek.ToString(),
                Title = "Mike Weekly Plan2"
            };
            return secondPlan;
        }

        public Plan ThirdPlan()
        {
            var thirdPlan = new Plan
            {
                PlanId = (int)LookUp.Plans.Plans.Types.TenMealsPerWeek,
                ExternalId = "3",
                Description = LookUp.Plans.Plans.Types.TenMealsPerWeek.ToString(),
                Title = "Mike Weekly Plan3"
            };
            return thirdPlan;
        }

        ~FakePlans()
        {
            MyPlans = null;
        }
    }
}
