using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Plans;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakePlanRepository : FakeGenericRepository<Plan>, IPlanRepository
    {
	    public FakePlanRepository(): base(new FakePlans().MyPlans)
        {
        }

        public FakePlanRepository(List<Plan> myPlans)
            : base(myPlans)
        {
        }
    }
}
       