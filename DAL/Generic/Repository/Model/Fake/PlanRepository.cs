using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class PlanRepository : FakeGenericRepository<Plan>, IPlanRepository
    {
	    public PlanRepository(): base(new FakePlans().MyPlans)
        {
        }

        public PlanRepository(List<Plan> myPlans): base(myPlans)
        {
        }
    }
}
       