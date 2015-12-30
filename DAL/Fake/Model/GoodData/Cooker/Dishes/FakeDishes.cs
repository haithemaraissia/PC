using System.Collections.Generic;
using DAL.Fake.Model.GoodData.Cooker.Dishes.Cooker;
using Model;

namespace DAL.Fake.Model.GoodData.Cooker.Dishes
{
    public class FakeDishes
    {
        public List<Dish> MyDishs;

        public FakeDishes()
        {
            InitializeDishList();
        }

        public void InitializeDishList()
        {
            MyDishs = new List<Dish>();
            var cooker1Dishes = new FakeCooker1Dishes().MyDishs;
            foreach (var dish in cooker1Dishes)
            {
                MyDishs.Add(dish);
            }
            var cooker2Dishes = new FakeCooker2Dishes().MyDishs;
            foreach (var dish in cooker2Dishes)
            {
                MyDishs.Add(dish);
            }
            var cooker3Dishes = new FakeCooker3Dishes().MyDishs;
            foreach (var dish in cooker3Dishes)
            {
                MyDishs.Add(dish);
            }
        }

        #region All
        //Cooker 1:

        //Menu Italien
        // Most Popular
        // Starters
        // Entrees

        //Menu Mexican
        //Burgers and Chicken
        //Soup and Salad


        //Cooker 2:
        //Menu Japanese
        //Most Popular
        //Signature Rolls
        //Classic Rolls

        //Menu Filipino
        //Most Popular

        //Menu Jamaican
        //Most Popular
        //Signature Sandwiches

        //Menu Morrocan
        //Most Popular
        //Daily Special
        //Every Day Specials


        //Cooker3:
        //Menu Dominican
        //Most Popular
        //Meat Dishes
        //Fish and SeaFood
        #endregion

        ~FakeDishes()
        {
            MyDishs = null;
        }
    }
}
