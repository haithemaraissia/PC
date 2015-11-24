using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Cooker
{
    public class FakeCookerSpokenLanguage
    {
        public List<CookerSpokenLanguage> MyCookerSpokenLanguages;

        public FakeCookerSpokenLanguage()
        {
            InitializeCookerSpokenLanguageList();
        }

        public void InitializeCookerSpokenLanguageList()
        {
            MyCookerSpokenLanguages = new List<CookerSpokenLanguage> {
                FirstCookerSpokenLanguage(), 
                SecondCookerSpokenLanguage(),
                ThirdCookerSpokenLanguage()
            };
        }

        public CookerSpokenLanguage FirstCookerSpokenLanguage()
        {
            var firstCookerSpokenLanguage = new CookerSpokenLanguage
            {
                LanguageId = 1,
                LanguageValue = "EN",
                CookerId = 1
            };
            return firstCookerSpokenLanguage;
        }

        public CookerSpokenLanguage SecondCookerSpokenLanguage()
        {
            var secondCookerSpokenLanguage = new CookerSpokenLanguage
            {
                LanguageId = 2,
                LanguageValue = "SP",
                CookerId = 1
            };
            return secondCookerSpokenLanguage;
        }

        public CookerSpokenLanguage ThirdCookerSpokenLanguage()
        {
            var thirdCookerSpokenLanguage = new CookerSpokenLanguage
            {
                LanguageId = 3,
                LanguageValue = "EN",
                CookerId = 2
            };
            return thirdCookerSpokenLanguage;
        }

        ~FakeCookerSpokenLanguage()
        {
            MyCookerSpokenLanguages = null;
        }
    }
}
