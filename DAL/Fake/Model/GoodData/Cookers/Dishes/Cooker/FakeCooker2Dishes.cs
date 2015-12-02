using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Cooker.Dishes.Cooker
{
    public class FakeCooker2Dishes
    {
        public List<Dish> MyDishs;

        public FakeCooker2Dishes()
        {
            InitializeDishList();
        }

        public void InitializeDishList()
        {
            MyDishs = new List<Dish> {

                #region Japanese
                    MostPopularDish1(), 
                    MostPopularDish2(),
                    MostPopularDish3(),

                    SignatureRollsDish1(),
                    SignatureRollsDish2(),

                    ClassicRollsDish1(),
                #endregion

                #region Filipino
                    FilipinoMostPopularDish1(),
                #endregion

                #region Jamaican
                    JamaicanMostPopularDish1(),
                    JamaicanMostPopularDish2(),
                    SignatureSandwichesDish1(),
                    SignatureSandwichesDish2(),
                #endregion

                #region Morrocan
                    MorrocanMostPopularDish1(), 
                    MorrocanMostPopularDish2(),
                    MorrocanMostPopularDish3(),

                    DailySpecialDish1(),
                    DailySpecialDish2(),

                    EveryDaySpecialsDish1(),
                    EveryDaySpecialsDish2()
                #endregion

            };
        }

        #region Cooker2 Dishes

        //Cooker 2:
        //Menu Japanese
        // Most Popular
        //3 dishes
        // Signature Rolls
        //2 dishes
        // Classic Rolls
        //1 dish

        //Menu Filipino
        //Most Popular
        //1 dish

        //Menu Jamaican
        //Most Popular
        //2 dishes
        //Signature Sandwiches
        //2 dishes

        //Menu Morrocan
        //Most Popular
        //3 dishes
        //Daily Special
        //2 dishes
        //Every Day Specials
        //2 dishes

        #region Japanese Cuisine

        #region MostPopular Section

        public Dish MostPopularDish1()
        {
            var dish = new Dish
            {
                DishId = 9,
                MenuId = 3,
                CookerId = 2,
                SectionId = 6,
                Name = "Wasabi Appetizer",
                Description = "Your choice of seafood with wasabi mayo, olives, scallion sealte with house sauce.",
                Price = (decimal)12.00,
                CurrencyId = 2,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Food\Japanese\Asian Fish.jpg",
                ServingId = 5,
                SpecialNote = "No Special Note"
            };
            return dish;
        }

        public Dish MostPopularDish2()
        {
            var dish = new Dish
            {
                DishId = 10,
                MenuId = 3,
                CookerId = 2,
                SectionId = 6,
                Name = "Tataki",
                Description = "Salmon or tuna with chili lime garlic sauce.",
                Price = (decimal)4.50,
                CurrencyId = 3,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Food\Japanese\Japanese-sushi.jpg",
                ServingId = 6,
                SpecialNote = "Put extra sauce"
            };
            return dish;
        }

        public Dish MostPopularDish3()
        {
            var dish = new Dish
            {
                DishId = 11,
                MenuId = 3,
                CookerId = 2,
                SectionId = 6,
                Name = "Tar Tar",
                Description = "Chopped salmon or tuna with spicy sauce.",
                Price = (decimal)7.99,
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Food\Italien\romano-s-macaroni.jpg",
                ServingId = 2,
                SpecialNote = null
            };
            return dish;
        }

        #endregion

        #region Signature Rolls Section

        public Dish SignatureRollsDish1()
        {
            var dish = new Dish
            {
                DishId = 12,
                MenuId = 3,
                CookerId = 2,
                SectionId = 7,
                Name = "Salmon Lover Sushi",
                Description = "Seven pieces of salmon sushi and spicy salmon roll with crunch. Served with miso soup or green salad.",
                Price = (decimal)19.00,
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\Test\Images\Food\Italien\greek-salad.jpg",
                ServingId = 8,
                SpecialNote = "No Special Note"
            };
            return dish;
        }

        public Dish SignatureRollsDish2()
        {
            var dish = new Dish
            {
                DishId = 13,
                MenuId = 3,
                CookerId = 2,
                SectionId = 7,
                Name = "Any 3 Rolls Lunch Special",
                Description = "Served with miso soup or green salad.",
                Price = (decimal)8.50,
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Food\Italien\romano-s-macaroni.jpg",
                ServingId = 6,
                SpecialNote = ""
            };
            return dish;
        }

        #endregion

        #region Classic Rolls Section

        public Dish ClassicRollsDish1()
        {
            var dish = new Dish
            {
                DishId = 14,
                MenuId = 3,
                CookerId = 2,
                SectionId = 8,
                Name = "Jumbo Sweet Shrimp",
                Description = null,
                Price = (decimal)5.99,
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\Test\Images\Food\Italien\greek-salad.jpg",
                ServingId = 2,
                SpecialNote = ""
            };
            return dish;
        }

        #endregion

        #endregion

        #region Filipino Cuisine

        #region MostPopular Section

        public Dish FilipinoMostPopularDish1()
        {
            var dish = new Dish
            {
                DishId = 15,
                MenuId = 4,
                CookerId = 2,
                SectionId = 9,
                Name = "Lamb Turkey Kebab Pocket Combo",
                Description = "Ground turkey and lamb, marinated and grilled. Perfectly packaged in our freshly baked pitas, original or whole wheat and filled with chopped salad and hummus. Comes with your choice of side and drink.",
                Price = (decimal)10.95,
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Food\Mexican\dscn2246.jpg",
                ServingId = 6,
                SpecialNote = "Put extra lettuce"
            };
            return dish;
        }

        #endregion

        #endregion

        #region Jamaican

        #region MostPopular Section

        public Dish JamaicanMostPopularDish1()
        {
            var dish = new Dish
            {
                DishId = 16,
                MenuId = 5,
                CookerId = 2,
                SectionId = 10,
                Name = "Buffalo Chicken Sliders",
                Description = "Two mini buns with Buffalo chicken and bleu cheese, served with seasoned curly fries.",
                Price = (decimal)11.99,
                CurrencyId = 2,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Food\Mexican\dscn2246.jpg",
                ServingId = 5,
                SpecialNote = "No Special Note"
            };
            return dish;
        }

        public Dish JamaicanMostPopularDish2()
        {
            var dish = new Dish
            {
                DishId = 17,
                MenuId = 5,
                CookerId = 2,
                SectionId = 10,
                Name = "Stuffed Pepper",
                Description = "A pepper hollowed out and then stuffed with our special blend of meat, rice, sauce and seasonings.",
                Price = (decimal)12.50,
                CurrencyId = 3,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Food\Mexican\Enchiladas.jpg",
                ServingId = 6,
                SpecialNote = "Put extra sauce"
            };
            return dish;
        }

        #endregion

        #region SignatureSandwiches

        public Dish SignatureSandwichesDish1()
        {
            var dish = new Dish
            {
                DishId = 18,
                MenuId = 5,
                CookerId = 2,
                SectionId = 11,
                Name = "Grilled Chicken Arugula Salad",
                Description = "Thin strips of grilled chicken breast served over an arugula salad with a honey balsamic dressing.",
                Price = (decimal)8.99,
                CurrencyId = 2,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Food\Mexican\mexican-food-2.jpg",
                ServingId = 5,
                SpecialNote = "No Special Note"
            };
            return dish;
        }

        public Dish SignatureSandwichesDish2()
        {
            var dish = new Dish
            {
                DishId = 19,
                MenuId = 5,
                CookerId = 2,
                SectionId = 11,
                Name = "Chef's Salad",
                Description = "Ham, turkey, cheese, lettuce, tomato, onions and pimientos.",
                Price = (decimal)7.50,
                CurrencyId = 3,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Food\Mexican\mexican-food-2.jpg",
                ServingId = 6,
                SpecialNote = "Put extra sauce"
            };
            return dish;
        }

        #endregion

        #endregion

        #region Morrocan Cuisine

        #region MostPopular Section

        public Dish MorrocanMostPopularDish1()
        {
            var dish = new Dish
            {
                DishId = 20,
                MenuId = 5,
                CookerId = 2,
                SectionId = 12,
                Name = "Falafel Bowl",
                Description = "Our chef's special recipe, with your choice of two fillings. Served with hummus.",
                Price = (decimal)12.00,
                CurrencyId = 2,
                Photo = "",
                ServingId = 5,
                SpecialNote = "No Special Note"
            };
            return dish;
        }

        public Dish MorrocanMostPopularDish2()
        {
            var dish = new Dish
            {
                DishId =21,
                MenuId = 5,
                CookerId = 2,
                SectionId = 12,
                Name = "Gyro Platter",
                Description = "Top quality beef and lamb. Made with authentic Greek spices. Served with hummus.",
                Price = (decimal)4.50,
                CurrencyId = 3,
                Photo = null,
                ServingId = 6,
                SpecialNote = "Put extra sauce"
            };
            return dish;
        }

        public Dish MorrocanMostPopularDish3()
        {
            var dish = new Dish
            {
                DishId = 22,
                MenuId = 5,
                CookerId = 2,
                SectionId = 12,
                Name = "Steak Taboon Pita",
                Description = "Succulent steak from our taboon oven. Served with hummus.",
                Price = (decimal)5.99,
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Food\Mexican\foods_tacos.jpg",
                ServingId = 5,
                SpecialNote = null
            };
            return dish;
        }

        #endregion

        #region Daily Special Section

        public Dish DailySpecialDish1()
        {
            var dish = new Dish
            {
                DishId = 23,
                MenuId = 5,
                CookerId = 2,
                SectionId = 13,
                Name = "Shawarma Laffa",
                Description = "Fire roasted marinated chicken thighs. Served with hummus.",
                Price = (decimal)12.99,
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Food\Japanese\Japanese-sushi.jpg",
                ServingId = 4,
                SpecialNote = "No Special Note"
            };
            return dish;
        }

        public Dish DailySpecialDish2()
        {
            var dish = new Dish
            {
                DishId = 24,
                MenuId = 5,
                CookerId = 2,
                SectionId = 13,
                Name = "Shawarma Bowl",
                Description = "Succulent chicken from our taboon oven. Served with hummus.",
                Price = (decimal)8.50,
                CurrencyId = 1,
                Photo = null,
                ServingId = 5,
                SpecialNote = ""
            };
            return dish;
        }

        #endregion

        #region Every Day Specials Section

        public Dish EveryDaySpecialsDish1()
        {
            var dish = new Dish
            {
                DishId = 25,
                MenuId = 5,
                CookerId = 2,
                SectionId = 14,
                Name = "Steak Taboon Bowl",
                Description = "Succulent steak from our taboon oven. Served with hummus.",
                Price = (decimal)6.99,
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Food\Filipino\Beef-Mechado.jpg",
                ServingId = 7,
                SpecialNote = ""
            };
            return dish;
        }

        public Dish EveryDaySpecialsDish2()
        {
            var dish = new Dish
            {
                DishId = 26,
                MenuId = 5,
                CookerId = 2,
                SectionId = 14,
                Name = "Corn Salad Small",
                Description = null,
                Price = (decimal)3.99,
                CurrencyId = 1,
                Photo = "",
                ServingId = 4,
                SpecialNote = ""
            };
            return dish;
        }

        #endregion

        #endregion

        #endregion

        ~FakeCooker2Dishes()
        {
            MyDishs = null;
        }
    }
}
