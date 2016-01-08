using System.Collections.Generic;

namespace DAL.Fake.Model.GoodData.Plans
{
    public class FakePlans
    {
        public List<global::Model.Plan> MyPlans;

        public FakePlans()
        {
            InitializePlanList();
        }

        public void InitializePlanList()
        {
            MyPlans = new List<global::Model.Plan> {
                FirstPlan(), 
                SecondPlan(),
                ThirdPlan()
            };
        }

        public global::Model.Plan FirstPlan()
        {
            var firstPlan = new global::Model.Plan
            {
                PlanId = (int)LookUp.Plans.Plans.Types.ThreeMealsPerWeek,
                ExternalId = "1",
                Description = LookUp.Plans.Plans.Types.ThreeMealsPerWeek.ToString(),
                Title="Mike Weekly Plan"
            };
            return firstPlan;
        }

        public global::Model.Plan SecondPlan()
        {
            var secondPlan = new global::Model.Plan
            {
                PlanId = (int)LookUp.Plans.Plans.Types.FiveMealsPerWeek,
                ExternalId = "2",
                Description = LookUp.Plans.Plans.Types.FiveMealsPerWeek.ToString(),
                Title = "Mike Weekly Plan2"
            };
            return secondPlan;
        }

        public global::Model.Plan ThirdPlan()
        {
            var thirdPlan = new global::Model.Plan
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
