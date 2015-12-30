using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Cooker
{
    public class FakeCookerPlans
    {
        public List<CookerPlan> MyCookerPlans;

        public FakeCookerPlans()
        {
            InitializeCookerPlanList();
        }

        public void InitializeCookerPlanList()
        {
            MyCookerPlans = new List<CookerPlan> {
                FirstCookerPlan(), 
                SecondCookerPlan(),
                ThirdCookerPlan(),
                FourthCookerPlan(),
                FifthCookerPlan(),
                SixthCookerPlan()
            };
        }

        #region Cooker1 Plans

        public CookerPlan FirstCookerPlan()
        {
            var firstCookerPlan = new CookerPlan
            {
                CookerPlanId = 1,
                CookerId = 1,
                PlanId = 1
            };
            return firstCookerPlan;
        }

        public CookerPlan SecondCookerPlan()
        {
            var secondCookerPlan = new CookerPlan
            {
                CookerPlanId = 2,
                CookerId = 1,
                PlanId = 2
            };
            return secondCookerPlan;
        }

        public CookerPlan ThirdCookerPlan()
        {
            var thirdCookerPlan = new CookerPlan
            {
                CookerPlanId = 3,
                CookerId = 1,
                PlanId = 3
            };
            return thirdCookerPlan;
        }

        #endregion

        #region Cooker2 Plans

        public CookerPlan FourthCookerPlan()
        {
            var cookerPlan = new CookerPlan
            {
                CookerPlanId = 4,
                CookerId = 2,
                PlanId = 1
            };
            return cookerPlan;
        }

        public CookerPlan FifthCookerPlan()
        {
            var cookerPlan = new CookerPlan
            {
                CookerPlanId = 5,
                CookerId = 2,
                PlanId = 2
            };
            return cookerPlan;
        }

        #endregion


        #region Cooker3 Plans

        public CookerPlan SixthCookerPlan()
        {
            var cookerPlan = new CookerPlan
            {
                CookerPlanId = 6,
                CookerId = 3,
                PlanId = 3
            };
            return cookerPlan;
        }

        #endregion
        ~FakeCookerPlans()
        {
            MyCookerPlans = null;
        }
    }
}
