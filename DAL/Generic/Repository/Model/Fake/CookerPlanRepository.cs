using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class CookerPlanRepository : FakeGenericRepository<CookerPlan>, ICookerPlanRepository
    {
	    public CookerPlanRepository(): base(new FakeCookerPlans().MyCookerPlans)
        {
        }

        public CookerPlanRepository(List<CookerPlan> myCookerPlans): base(myCookerPlans)
        {
        }
    }
}
       