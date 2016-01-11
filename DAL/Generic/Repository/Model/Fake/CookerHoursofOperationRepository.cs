using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Cookers;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeCookerHoursofOperationRepository : FakeGenericRepository<CookerHoursofOperation>, ICookerHoursofOperationRepository
    {
	    public FakeCookerHoursofOperationRepository(): base(new FakeCookerHoursofOperation().MyCookerHoursofOperations)
        {
        }

        public FakeCookerHoursofOperationRepository(List<CookerHoursofOperation> myCookerHoursofOperations)
            : base(myCookerHoursofOperations)
        {
        }
    }
}
       