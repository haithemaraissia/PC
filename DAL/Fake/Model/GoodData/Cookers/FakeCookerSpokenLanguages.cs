using System.Collections.Generic;
using DAL.Fake.Model.LookUp.Langauges;
using Model;

namespace DAL.Fake.Model.GoodData.Cookers
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
                LanguageValue = LanguageType.Values.EN.ToString(),
                CookerId = 1
            };
            return firstCookerSpokenLanguage;
        }

        public CookerSpokenLanguage SecondCookerSpokenLanguage()
        {
            var secondCookerSpokenLanguage = new CookerSpokenLanguage
            {
                LanguageId = 2,
                LanguageValue = LanguageType.Values.SP.ToString(),
                CookerId = 1
            };
            return secondCookerSpokenLanguage;
        }

        public CookerSpokenLanguage ThirdCookerSpokenLanguage()
        {
            var thirdCookerSpokenLanguage = new CookerSpokenLanguage
            {
                LanguageId = 3,
                LanguageValue = LanguageType.Values.EN.ToString(),
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
