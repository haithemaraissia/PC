using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class ServingMeasurementRepository : FakeGenericRepository<ServingMeasurement>, IServingMeasurementRepository
    {
	    public ServingMeasurementRepository(): base(new FakeServingMeasurements().MyServingMeasurements)
        {
        }

        public ServingMeasurementRepository(List<ServingMeasurement> myServingMeasurements): base(myServingMeasurements)
        {
        }
    }
}
       