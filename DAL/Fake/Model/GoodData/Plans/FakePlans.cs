using System.Collections.Generic;

namespace DAL.Fake.Model.GoodData.Plan
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
                PlanId = 1,
                ExternalId = "1",
                Description = "3 meals per week"
            };
            return firstPlan;
        }

        public global::Model.Plan SecondPlan()
        {
            var secondPlan = new global::Model.Plan
            {
                PlanId = 1,
                ExternalId = "2",
                Description = "5 meals per week"
            };
            return secondPlan;
        }

        public global::Model.Plan ThirdPlan()
        {
            var thirdPlan = new global::Model.Plan
            {
                PlanId = 3,
                ExternalId = "3",
                Description = "10 meals per week"
            };
            return thirdPlan;
        }

        ~FakePlans()
        {
            MyPlans = null;
        }
    }
}
