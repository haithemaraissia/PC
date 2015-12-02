using System.Collections.Generic;
using DAL.Fake.Model.Util;
using Model;

namespace DAL.Fake.Model.GoodData.Cooker
{
    public class FakeCookerMenus
    {
        public List<CookerMenu> MyFakeCookerMenus;

        public FakeCookerMenus()
        {
            InitializeFakeCookerMenusList();
        }

        public void InitializeFakeCookerMenusList()
        {
            MyFakeCookerMenus = new List<CookerMenu> {
                FirstFakeCookerMenus(), 
                SecondFakeCookerMenus(),
                ThirdFakeCookerMenus(),
                FourthFakeCookerMenus(),
                FifthFakeCookerMenus(),
                FirstFakeCookerMenus(),
                SixthFakeCookerMenus(),
                SeventhFakeCookerMenus()
            };
        }


        #region Cooker 1 has Italien and Mexican Menu

        public CookerMenu FirstFakeCookerMenus()
        {
            var firstFakeCookerMenus = new CookerMenu
            {
                MenuId = 1,
                CuisineTypeId = (int)Cuisines.Types.Italian,
                CookerId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Menu\Italien.jpg",
                Title = "Fiorella Italien Menu",
                Description = "Best Italien Cuisines"
            };
            return firstFakeCookerMenus;
        }

        public CookerMenu SecondFakeCookerMenus()
        {
            var secondFakeCookerMenus = new CookerMenu
            {
                MenuId = 2,
                CuisineTypeId = (int)Cuisines.Types.Mexican,
                CookerId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Menu\Mexican-Restaurant.jpg",
                Title = "Fiorella Mexican Menu",
                Description = "Best Mexican Food"
            };
            return secondFakeCookerMenus;
        }

        #endregion


        #region Cooker 2 has Japanese , Filipino , Jamaican , Morrocan Menu

        public CookerMenu ThirdFakeCookerMenus()
        {
            var thirdFakeCookerMenus = new CookerMenu
            {
                MenuId = 3,
                CuisineTypeId = (int)Cuisines.Types.Japanese,
                CookerId = 2,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Menu\Japanese.jpg",
                Title = "Mike Japanese Menu",
                Description = "One of the best Japanese Menu in USA"
            };
            return thirdFakeCookerMenus;
        }

        public CookerMenu FourthFakeCookerMenus()
        {
            var fourthFakeCookerMenus = new CookerMenu
            {
                MenuId = 4,
                CuisineTypeId = (int)Cuisines.Types.Filipino,
                CookerId = 2,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Menu\Filipino-Menu.jpg",
                Title = "Mike Filipino Menu",
                Description = "Best Food"
            };
            return fourthFakeCookerMenus;
        }

        public CookerMenu FifthFakeCookerMenus()
        {
            var fifthFakeCookerMenus = new CookerMenu
            {
                MenuId = 5,
                CuisineTypeId = (int)Cuisines.Types.Jamaican,
                CookerId = 2,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Menu\Jamaican.jpg",
                Title = "Mike Jamaican Menu",
                Description = "Best Food Maan"
            };
            return fifthFakeCookerMenus;
        }

        public CookerMenu SixthFakeCookerMenus()
        {
            var sixthFakeCookerMenus = new CookerMenu
            {
                MenuId = 4,
                CuisineTypeId = (int)Cuisines.Types.Moroccan,
                CookerId = 2,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Menu\Morrocan.jpg",
                Title = "Mike Morrocan Menu",
                Description = "One of the bucket List"
            };
            return sixthFakeCookerMenus;
        }
        #endregion


        #region Cooker 3 has Dominican Menu
        public CookerMenu SeventhFakeCookerMenus()
        {
            var seventhFakeCookerMenus = new CookerMenu
            {
                MenuId = 7,
                CuisineTypeId = (int)Cuisines.Types.Dominican,
                CookerId = 3,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Menu\Dominican.jpg",
                Title = "Sara Dominican Menu",
                Description = "You have to try it to believe it."
            };
            return seventhFakeCookerMenus;
        }
        #endregion

        ~FakeCookerMenus()
        {
            MyFakeCookerMenus = null;
        }
    }
}
