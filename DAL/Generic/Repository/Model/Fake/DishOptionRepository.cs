using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Cookers.Dishes.Cooker.DishOptions;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeDishOptionRepository : FakeGenericRepository<DishOption>, IDishOptionRepository
    {
	    public FakeDishOptionRepository(): base(new FakeDishOptions().MyDishOptions)
        {
        }

        public FakeDishOptionRepository(List<DishOption> myDishOptions)
            : base(myDishOptions)
        {
        }
    }
}
       