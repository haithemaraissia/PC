using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class CookerHoursofOperationRepository : FakeGenericRepository<CookerHoursofOperation>, ICookerHoursofOperationRepository
    {
	    public CookerHoursofOperationRepository(): base(new FakeCookerHoursofOperations().MyCookerHoursofOperations)
        {
        }

        public CookerHoursofOperationRepository(List<CookerHoursofOperation> myCookerHoursofOperations): base(myCookerHoursofOperations)
        {
        }
    }
}
       