using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Servings.Measurement;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeServingMeasurementRepository : FakeGenericRepository<ServingMeasurement>, IServingMeasurementRepository
    {
	    public FakeServingMeasurementRepository(): base(new FakeServingMeasurement().MyServingMeasurement)
        {
        }

        public FakeServingMeasurementRepository(List<ServingMeasurement> myServingMeasurements)
            : base(myServingMeasurements)
        {
        }
    }
}
       