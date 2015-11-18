using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
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
                PlanId = 1,
                ExternalId = "1",
                Description = "3 meals per week"
            };
            return firstPlan;
        }

        public Plan SecondPlan()
        {
            var secondPlan = new Plan
            {
                PlanId = 1,
                ExternalId = "2",
                Description = "5 meals per week"
            };
            return secondPlan;
        }

        public Plan ThirdPlan()
        {
            var thirdPlan = new Plan
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
