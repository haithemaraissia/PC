using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Cookers;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeCookerPlanRepository : FakeGenericRepository<CookerPlan>, ICookerPlanRepository
    {
	    public FakeCookerPlanRepository(): base(new FakeCookerPlans().MyCookerPlans)
        {
        }

        public FakeCookerPlanRepository(List<CookerPlan> myCookerPlans)
            : base(myCookerPlans)
        {
        }
    }
}
       