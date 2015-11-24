using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Serving.Subscription
{
    public class FakeMenuServings
    {
        public List<MenuServing> MyMenuServings;

        public FakeMenuServings()
        {
            InitializeMenuServingList();
        }

        public void InitializeMenuServingList()
        {
            MyMenuServings = new List<MenuServing> {
                FirstMenuServing(), 
                SecondMenuServing(),
                ThirdMenuServing()
            };
        }

        public MenuServing FirstMenuServing()
        {
            var firstMenuServing = new MenuServing
            {
                MenuServingId = 1,
                MenuServingValue ="2 per week"
            };
            return firstMenuServing;
        }

        public MenuServing SecondMenuServing()
        {
            var secondMenuServing = new MenuServing
            {
                MenuServingId = 2,
                MenuServingValue = "3 per week"
            };
            return secondMenuServing;
        }

        public MenuServing ThirdMenuServing()
        {
            var thirdMenuServing = new MenuServing
            {
                MenuServingId = 3,
                MenuServingValue = "5 per week"
            };
            return thirdMenuServing;
        }

        ~FakeMenuServings()
        {
            MyMenuServings = null;
        }
    }
}
