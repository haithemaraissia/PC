using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class DishOptionRepository : FakeGenericRepository<DishOption>, IDishOptionRepository
    {
	    public DishOptionRepository(): base(new FakeDishOptions().MyDishOptions)
        {
        }

        public DishOptionRepository(List<DishOption> myDishOptions): base(myDishOptions)
        {
        }
    }
}
       