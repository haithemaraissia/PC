using System.Collections.Generic;

namespace DAL.Fake.Model.GoodData.MostPopularDish
{
    public class FakeMostPopularDishes
    {
        public List<global::Model.MostPopularDish> MyMostPopularDishes;

        public FakeMostPopularDishes()
        {
            InitializeMostPopularDishesList();
        }

        public void InitializeMostPopularDishesList()
        {
            MyMostPopularDishes = new List<global::Model.MostPopularDish> {
                FirstDish(), 
                SecondDish(),
                ThirdDish()
            };
        }

        public global::Model.MostPopularDish FirstDish()
        {
            var firstDish = new global::Model.MostPopularDish
            {
                DishId = 3,
                OrderDishCount = 5
            };
            return firstDish;
        }

        public global::Model.MostPopularDish SecondDish()
        {
            var secondDish = new global::Model.MostPopularDish
            {
                DishId = 1,
                OrderDishCount = 3
            };
            return secondDish;
        }

        public global::Model.MostPopularDish ThirdDish()
        {
            var thirdDish = new global::Model.MostPopularDish
            {
                DishId = 4,
                OrderDishCount = 4
            };
            return thirdDish;
        }
        ~FakeMostPopularDishes()
        {
            MyMostPopularDishes = null;
        }
    }
}
