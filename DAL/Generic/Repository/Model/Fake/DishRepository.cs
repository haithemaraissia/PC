using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Cookers.Dishes;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeDishRepository : FakeGenericRepository<Dish>, IDishRepository
    {
	    public FakeDishRepository(): base(new FakeDishes().MyDishs)
        {
        }

        public FakeDishRepository(List<Dish> myDishs)
            : base(myDishs)
        {
        }
    }
}
       