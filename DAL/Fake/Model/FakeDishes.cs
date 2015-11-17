using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
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
            MyDishs = new List<Dish> {
                FirstDish(), 
                SecondDish(),
                ThirdDish()
            };
        }

        #region Cooker1 Dishes
        //Cooker 1:

        #region Italian Cuisine
        //Menu 1 Cuisine Type : Italian
        //MenuId : 1

        public Dish FirstDish()
        {
            //Section: Sandwiches
            //Name: Chicken Roma Hot Sandwich
            //Description: Chicken sauteed with roasted red peppers in our marinara sauce with provolone cheese. Served on fresh white Italian braided rolls topped with sesame seeds.
            //Price: $8
            //Serving: 1 
            //with Photo

            var firstDish = new Dish
            {
                DishId = 1,
                MenuId = 1,
                CookerId = 1,
                SectionTitle = "Sandwiches",
                Name = "Chicken Roma Hot Sandwich",
                Description = "Chicken sauteed with roasted red peppers in our marinara sauce with provolone cheese. Served on fresh white Italian braided rolls topped with sesame seeds.",
                Price = "8",
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\Test\Images\Food\Italien\greek-salad.jpg",
                ServingId = 1,
                SpecialNote = "No Special Note"
            };
            return firstDish;
        }

        public Dish SecondDish()
        {
            var secondDish = new Dish
            {
                DishId = 2,
                MenuId = 1,
                CookerId = 1,
                SectionTitle = "Sandwiches",
                Name = "Chicken Piccata",
                Description = "Chicken sauteed with mushrooms and capers in lemon-wine sauce tossed with linguini.",
                Price = "12",
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\Test\Images\Food\Italien\chicken_parmesan.jpg",
                ServingId = 3,
                SpecialNote = "No Special Note"
            };
            return secondDish;
        }

        public Dish ThirdDish()
        {
            var thirdDish = new Dish
            {
                DishId = 3,
                MenuId = 1,
                CookerId = 1,
                SectionTitle = "Pasta",
                Name = "Lasagna",
                Description = "Four layers of fresh pasta, delicious bolognese and a mix of ricotta, mozzarella and pecorino romano cheese baked to perfection and topped with our signature marinara sauce.",
                Price = "9.50",
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\Test\Images\Food\Italien\romano-s-macaroni.jpg",
                ServingId = 3,
                SpecialNote = "No Special Note"
            };
            return thirdDish;
        }
        #endregion





        #region Mexican Cuisine
        //Menu 1 Cuisine Type : Italian
        //Menu Id : 2

        public Dish FourthDish()
        {

            var firstDish = new Dish
            {
                DishId = 1,
                MenuId = 1,
                CookerId = 1,
                                     SectionTitle = "Sandwiches",
                Name = "Chicken Roma Hot Sandwich",
                Description = "Chicken sauteed with roasted red peppers in our marinara sauce with provolone cheese. Served on fresh white Italian braided rolls topped with sesame seeds.",
                Price = "8",
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\Test\Images\Food\Italien\greek-salad.jpg",
                ServingId = 1,
                SpecialNote = "No Special Note"
            };
            return firstDish;
        }

        public Dish SecondDish()
        {
            var secondDish = new Dish
            {
                DishId = 2,
                MenuId = 1,
                CookerId = 1,
                SectionTitle = "Sandwiches",
                Name = "Chicken Piccata",
                Description = "Chicken sauteed with mushrooms and capers in lemon-wine sauce tossed with linguini.",
                Price = "12",
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\Test\Images\Food\Italien\chicken_parmesan.jpg",
                ServingId = 3,
                SpecialNote = "No Special Note"
            };
            return secondDish;
        }

        public Dish ThirdDish()
        {
            var thirdDish = new Dish
            {
                DishId = 3,
                MenuId = 1,
                CookerId = 1,
                SectionTitle = "Pasta",
                Name = "Lasagna",
                Description = "Four layers of fresh pasta, delicious bolognese and a mix of ricotta, mozzarella and pecorino romano cheese baked to perfection and topped with our signature marinara sauce.",
                Price = "9.50",
                CurrencyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\Test\Images\Food\Italien\romano-s-macaroni.jpg",
                ServingId = 3,
                SpecialNote = "No Special Note"
            };
            return thirdDish;
        }
        #endregion



       #endregion 
        ~FakeDishes()
        {
            MyDishs = null;
        }
    }
}
