using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Cooker
{
    public class FakeMenuSection
    {
        public List<MenuSection> MyMenuSections;

        public FakeMenuSection()
        {
            InitializeMenuSectionList();
        }

        public void InitializeMenuSectionList()
        {
            MyMenuSections = new List<MenuSection> {
                FirstMenuSection(), 
                SecondMenuSection(),
                ThirdMenuSection(),
                FourthMenuSection(),
                FifthMenuSection(),
                MenuSection6(),
                MenuSection7(),
                MenuSection8(),
                MenuSection9(),
                MenuSection10(),
                MenuSection11(),
                MenuSection12(),
                MenuSection13(),
                MenuSection14(),
                MenuSection15(),
                MenuSection16(),
                MenuSection17()
            };
        }


        #region Cooker 1 

        #region Italien

        public MenuSection FirstMenuSection()
        {
            var firstMenuSection = new MenuSection
            {
                SectionId = 1,
                SectionTitle = "Most Popular",
                MenuId = 1
            };
            return firstMenuSection;
        }

        public MenuSection SecondMenuSection()
        {
            var secondMenuSection = new MenuSection
            {
                SectionId = 2,
                SectionTitle = "Starters",
                MenuId = 1
            };
            return secondMenuSection;
        }

        public MenuSection ThirdMenuSection()
        {
            var thirdMenuSection = new MenuSection
            {
                SectionId = 3,
                SectionTitle = "Entrees",
                MenuId = 1
            };
            return thirdMenuSection;
        }
        #endregion

        #region Mexican

        public MenuSection FourthMenuSection()
        {
            var fourthMenuSection = new MenuSection
            {
                SectionId = 4,
                SectionTitle = "Burgers and Chicken",
                MenuId = 2
            };
            return fourthMenuSection;
        }

        public MenuSection FifthMenuSection()
        {
            var fifthMenuSection = new MenuSection
            {
                SectionId = 5,
                SectionTitle = "Soup and Salad",
                MenuId = 2
            };
            return fifthMenuSection;
        }
        #endregion

        #endregion

        #region Cooker 2

        #region Japanese

        public MenuSection MenuSection6()
        {
            var menuSection6 = new MenuSection
            {
                SectionId = 6,
                SectionTitle = "Most Popular",
                MenuId = 3
            };
            return menuSection6;
        }

        public MenuSection MenuSection7()
        {
            var menuSection7 = new MenuSection
            {
                SectionId = 7,
                SectionTitle = "Signature Rolls",
                MenuId = 3
            };
            return menuSection7;
        }

        public MenuSection MenuSection8()
        {
            var menuSection8 = new MenuSection
            {
                SectionId = 8,
                SectionTitle = "Classic Rolls",
                MenuId = 3
            };
            return menuSection8;
        }

        #endregion

        #region Filipino

        public MenuSection MenuSection9()
        {
            var menuSection9 = new MenuSection
            {
                SectionId = 9,
                SectionTitle = "Most Popular",
                MenuId = 4
            };
            return menuSection9;
        }

        #endregion

        #region  Jamaican

        public MenuSection MenuSection10()
        {
            var menuSection10 = new MenuSection
            {
                SectionId = 10,
                SectionTitle = "Most Popular",
                MenuId = 5
            };
            return menuSection10;
        }

        public MenuSection MenuSection11()
        {
            var menuSection11 = new MenuSection
            {
                SectionId = 11,
                SectionTitle = "Signature Sandwiches",
                MenuId = 5
            };
            return menuSection11;
        }

        #endregion

        #region Morrocan

        public MenuSection MenuSection12()
        {
            var menuSection9 = new MenuSection
            {
                SectionId = 12,
                SectionTitle = "Most Popular",
                MenuId = 6
            };
            return menuSection9;
        }

        public MenuSection MenuSection13()
        {
            var menuSection10 = new MenuSection
            {
                SectionId = 13,
                SectionTitle = "Daily Special",
                MenuId = 6
            };
            return menuSection10;
        }

        public MenuSection MenuSection14()
        {
            var menuSection10 = new MenuSection
            {
                SectionId = 14,
                SectionTitle = "Every Day Specials",
                MenuId = 6
            };
            return menuSection10;
        }
        #endregion

        #endregion

        #region Cooker 3

        #region Dominican
        public MenuSection MenuSection15()
        {
            var menuSection15 = new MenuSection
            {
                SectionId = 15,
                SectionTitle = "Most Popular",
                MenuId = 7
            };
            return menuSection15;
        }

        public MenuSection MenuSection16()
        {
            var menuSection16 = new MenuSection
            {
                SectionId = 16,
                SectionTitle = "Meat Dishes",
                MenuId = 7
            };
            return menuSection16;
        }

        public MenuSection MenuSection17()
        {
            var menuSection17 = new MenuSection
            {
                SectionId = 17,
                SectionTitle = "Fish and Seafood",
                MenuId = 7
            };
            return menuSection17;
        }
        #endregion

        #endregion

        ~FakeMenuSection()
        {
            MyMenuSections = null;
        }
    }
}
