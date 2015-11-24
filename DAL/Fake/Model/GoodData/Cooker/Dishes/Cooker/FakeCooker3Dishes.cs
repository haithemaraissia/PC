using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Cooker.Dishes.Cooker
{
    public class FakeCooker3Dishes
    {
        public List<Dish> MyDishs;

        public FakeCooker3Dishes()
        {
            InitializeDishList();
        }

        public void InitializeDishList()
        {
            MyDishs = new List<Dish> {

                #region DominicanDishes
                    MostPopularDish1(), 
                    MostPopularDish2(),
                    MostPopularDish3(),

                    MeatDishesDish1(),
                    MeatDishesDish2(),

                    FishandSeafoodDish1(),
                    FishandSeafoodDish2()
                #endregion

            };
        }

        #region Cooker3 Dishes

        //Cooker 3:
        //Menu Dominican
        // Most Popular
        //3 dishes
        // Meat Dishes
        //2 dishes
        //Fish and SeaFood
        //2 dishe

        #region Dominican Cuisine

        #region MostPopular Section

        public Dish MostPopularDish1()
        {
            var dish = new Dish
            {
                DishId = 27,
                MenuId = 7,
                CookerId = 3,
                SectionId = 15,
                Name = "Chicken Tikka",
                Description = "Boneless pieces of chicken marinated in aromatic spices. Served with basmati rice.",
                Price = (decimal)8.00,
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Food\Dominican\mambossancocho.jpg",
                ServingId = 5,
                SpecialNote = "No Special Note"
            };
            return dish;
        }

        public Dish MostPopularDish2()
        {
            var dish = new Dish
            {
                DishId = 28,
                MenuId = 7,
                CookerId = 3,
                SectionId = 15,
                Name = "Life's a Peach Bubble Tea without Milk",
                Description = "Peach and orange.",
                Price = (decimal)8.50,
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Food\Dominican\mofongo_keia.jpg",
                ServingId = 5,
                SpecialNote = "Put extra sauce"
            };
            return dish;
        }

        public Dish MostPopularDish3()
        {
            var dish = new Dish
            {
                DishId = 29,
                MenuId = 7,
                CookerId = 3,
                SectionId = 15,
                Name = "Combination House Special Platter (Xe Lua Khai Vi)",
                Description = "pring roll, BBQ chicken, shrimp, pork and beef served with lettuce and rice paper.",
                Price = (decimal)7.99,
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Food\Italien\romano-s-macaroni.jpg",
                ServingId = 6,
                SpecialNote = null
            };
            return dish;
        }

        #endregion

        #region Meat Dishes Section

        public Dish MeatDishesDish1()
        {
            var dish = new Dish
            {
                DishId = 30,
                MenuId = 7,
                CookerId = 3,
                SectionId = 16,
                Name = "Chicken Vindaloo",
                Description = "Marinated in cubes of chicken cooked in a light vinegar and pepper sauce, spicy Goan dish.",
                Price = (decimal)10.00,
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\Test\Images\Food\Italien\greek-salad.jpg",
                ServingId = 8,
                SpecialNote = "No Special Note"
            };
            return dish;
        }

        public Dish MeatDishesDish2()
        {
            var dish = new Dish
            {
                DishId = 31,
                MenuId = 7,
                CookerId = 3,
                SectionId = 16,
                Name = "Chicken Makhani",
                Description = "Butter. Shreds of chicken taken off the bone cooked in a rich tomato and butter sauce. Punjab.",
                Price = (decimal)8.50,
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Food\Jamaican\RibbitCafe.jpg",
                ServingId = 8,
                SpecialNote = "Only Fresh meat"
            };
            return dish;
        }

        #endregion

        #region Fish and Seafood Section

        public Dish FishandSeafoodDish1()
        {
            var dish = new Dish
            {
                DishId = 32,
                MenuId = 7,
                CookerId = 3,
                SectionId = 17,
                Name = "Saag Pea Soup",
                Description = null,
                Price = (decimal)5.99,
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Food\Japanese\Asian Fish.jpg",
                ServingId = 8,
                SpecialNote = ""
            };
            return dish;
        }

        public Dish FishandSeafoodDish2()
        {
            var dish = new Dish
            {
                DishId = 33,
                MenuId = 7,
                CookerId = 3,
                SectionId = 17,
                Name = "Bhelpuri",
                Description = null,
                Price = (decimal)5.99,
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Food\Japanese\Udon.jpg",
                ServingId = 8,
                SpecialNote = ""
            };
            return dish;
        }

        #endregion

        #endregion

        #endregion


        ~FakeCooker3Dishes()
        {
            MyDishs = null;
        }
    }
}
