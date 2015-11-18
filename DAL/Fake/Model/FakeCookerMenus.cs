using System.Collections.Generic;
using DAL.Fake.Model.Util;
using Model;

namespace DAL.Fake.Model
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
                ThirdFakeCookerMenus()
            };
        }

        public CookerMenu FirstFakeCookerMenus()
        {
            var firstFakeCookerMenus = new CookerMenu
            {
                MenuId = 1,
                CuisineTypeId = (int)Cuisines.Types.Italian,
                CookerId = 1,
                Photo = "@",
                Title = "",
                Description = ""
                
            };
            return firstFakeCookerMenus;
        }

        public CookerMenu SecondFakeCookerMenus()
        {
            var secondFakeCookerMenus = new CookerMenu
            {
                MenuId = 1,
                CuisineTypeId = (int)Cuisines.Types.Italian,
                CookerId = 1,
                Photo = "@",
                Title = "Hot Appetizers",
                Description = ""
            };
            return secondFakeCookerMenus;
        }

        public CookerMenu ThirdFakeCookerMenus()
        {
            var thirdFakeCookerMenus = new CookerMenu
            {
                MenuId = 3,
                CookerId = 1,
                CuisineTypeId = 4,
                Description = "Third Cooker Menu",
                Photo = "Photo Path3"
            };
            return thirdFakeCookerMenus;
        }

        ~FakeCookerMenus()
        {
            MyFakeCookerMenus = null;
        }
    }
}
