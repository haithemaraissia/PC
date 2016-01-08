using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class DishOptionsChoiceRepository : FakeGenericRepository<DishOptionsChoice>, IDishOptionsChoiceRepository
    {
	    public DishOptionsChoiceRepository(): base(new FakeDishOptionsChoices().MyDishOptionsChoices)
        {
        }

        public DishOptionsChoiceRepository(List<DishOptionsChoice> myDishOptionsChoices): base(myDishOptionsChoices)
        {
        }
    }
}
       