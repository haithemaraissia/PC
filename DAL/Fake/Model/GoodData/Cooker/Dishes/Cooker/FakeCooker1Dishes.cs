using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Cooker.Dishes.Cooker
{
    public class FakeCooker1Dishes
    {
        public List<Dish> MyDishs;

        public FakeCooker1Dishes()
        {
            InitializeDishList();
        }

        public void InitializeDishList()
        {
            MyDishs = new List<Dish> {

                #region MexicanDishes
                    MostPopularDish1(), 
                    MostPopularDish2(),
                    MostPopularDish3(),

                    StartersDish1(),
                    StartersDish2(),

                    EntreesDish1(),
                #endregion

                #region MexicanDishes
                    BurgersAndChickenDish1(),
                    SoupAndSaladDish1(),
                    SoupAndSaladDish2(),
                    SoupAndSaladDish3(),
                    SoupAndSaladDish4()
                #endregion

            };
        }

        #region Cooker1 Dishes

        //Cooker 1:

        //Menu Italien
        // Most Popular
        //3 dishes
        // Starters
        //2 dishes
        // Entrees
        //1 dishe

        //Menu Mexican
        //Burgers and Chicken
        //Soup and Salad

        #region Italian Cuisine

        #region MostPopular Section

        public Dish MostPopularDish1()
        {
            var dish = new Dish
            {
                DishId = 1,
                MenuId = 1,
                CookerId = 1,
                SectionId = 1,
                Name = "Chicken Roma Hot Sandwich",
                Description = "Chicken sauteed with roasted red peppers in our marinara sauce with provolone cheese. Served on fresh white Italian braided rolls topped with sesame seeds.",
                Price = (decimal)8.00,
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\Test\Images\Food\Italien\greek-salad.jpg",
                ServingId = 8,
                SpecialNote = "No Special Note"
            };
            return dish;
        }

        public Dish MostPopularDish2()
        {
            var dish = new Dish
            {
                DishId = 2,
                MenuId = 1,
                CookerId = 1,
                SectionId = 1,
                Name = "Pizza al Salame",
                Description = "Tomato sauce, mozzarella, salami sausage, mixed green and black olives and basil",
                Price = (decimal)8.50,
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Food\Italien\romano-s-macaroni.jpg",
                ServingId = 8,
                SpecialNote = "Put extra sauce"
            };
            return dish;
        }

        public Dish MostPopularDish3()
        {
            var dish = new Dish
            {
                DishId = 3,
                MenuId = 1,
                CookerId = 1,
                SectionId = 1,
                Name = "Traditional Lasagna",
                Description = "Home made pasta, ground beef, tomato sauce, bechamel sauce and parmesan.",
                Price = (decimal)7.99,
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Food\Italien\romano-s-macaroni.jpg",
                ServingId = 8,
                SpecialNote = null
            };
            return dish;
        }

        #endregion

        #region Starters Section

        public Dish StartersDish1()
        {
            var dish = new Dish
            {
                DishId = 4,
                MenuId = 1,
                CookerId = 1,
                SectionId = 2,
                Name = "Shrimp Shumai",
                Description = "Includes six pieces.",
                Price = (decimal)10.00,
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\Test\Images\Food\Italien\greek-salad.jpg",
                ServingId = 8,
                SpecialNote = "No Special Note"
            };
            return dish;
        }

        public Dish StartersDish2()
        {
            var dish = new Dish
            {
                DishId = 5,
                MenuId = 1,
                CookerId = 1,
                SectionId = 1,
                Name = "Spiced Filet Mignon Mini Burgers",
                Description = "Includes two mini burgers. Mildly spicy.",
                Price = (decimal)8.50,
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Food\Italien\romano-s-macaroni.jpg",
                ServingId = 8,
                SpecialNote = "Only Fresh meat"
            };
            return dish;
        }

        #endregion

        #region Entrees Section

        public Dish EntreesDish1()
        {
            var dish = new Dish
            {
                DishId = 6,
                MenuId = 1,
                CookerId = 1,
                SectionId = 3,
                Name = "Jumbo Sweet Shrimp",
                Description = null,
                Price = (decimal)5.99,
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\Test\Images\Food\Italien\greek-salad.jpg",
                ServingId = 8,
                SpecialNote = ""
            };
            return dish;
        }

        #endregion

        #endregion

        #region Mexican Cuisine

        #region BurgersAndChicken Section

        public Dish BurgersAndChickenDish1()
        {
            var dish = new Dish
            {
                DishId = 7,
                MenuId = 1,
                CookerId = 1,
                SectionId = 4,
                Name = "Lamb Turkey Kebab Pocket Combo",
                Description = "Ground turkey and lamb, marinated and grilled. Perfectly packaged in our freshly baked pitas, original or whole wheat and filled with chopped salad and hummus. Comes with your choice of side and drink.",
                Price = (decimal)10.95,
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Food\Mexican\dscn2246.jpg",
                ServingId = 8,
                SpecialNote = "Put extra lettuce"
            };
            return dish;
        }

        #endregion

        #region SoupAndSalad Section

        public Dish SoupAndSaladDish1()
        {
            var dish = new Dish
            {
                DishId = 8,
                MenuId = 1,
                CookerId = 1,
                SectionId = 5,
                Name = "Green Papaya Salad",
                Description = "Mildly spicy.",
                Price = (decimal)12.00,
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Food\Mexican\Enchiladas.jpg",
                ServingId = 8,
                SpecialNote = ""
            };
            return dish;
        }

        public Dish SoupAndSaladDish2()
        {
            var dish = new Dish
            {
                DishId = 9,
                MenuId = 1,
                CookerId = 1,
                SectionId = 5,
                Name = "Mango Vermicelli Salad",
                Description = "Includes two mini burgers. Mildly spicy.",
                Price = (decimal)8.50,
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Food\Mexican\foods_tacos.jpg",
                ServingId = 7,
                SpecialNote = "Nothing"
            };
            return dish;
        }

        public Dish SoupAndSaladDish3()
        {
            var dish = new Dish
            {
                DishId = 10,
                MenuId = 1,
                CookerId = 1,
                SectionId = 5,
                Name = "Onion Soup",
                Description = "",
                Price = (decimal)10.00,
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Food\Mexican\mexican-food-2.jpg",
                ServingId = 4,
                SpecialNote = "In a clean bowl"
            };
            return dish;
        }

        public Dish SoupAndSaladDish4()
        {
            var dish = new Dish
            {
                DishId = 11,
                MenuId = 1,
                CookerId = 1,
                SectionId = 5,
                Name = "Premium Soup Medium",
                Description = "Onion, garlic, cucumber, celery, cilantro, mixed peppers, tomato puree, tomato juice, tobasco sauce and lime juice.",
                Price = (decimal)4.50,
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Food\Mexican\mexican-food.jpg",
                ServingId = 5,
                SpecialNote = "I love your soup"
            };
            return dish;
        }

        #endregion

        #endregion

        #endregion


        ~FakeCooker1Dishes()
        {
            MyDishs = null;
        }
    }
}
