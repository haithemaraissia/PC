using System.Collections.Generic;
using DAL.Fake.Model.LookUp.Langauges;
using Model;

namespace DAL.Fake.Model.GoodData.Languages
{
    public class FakeLanguage
    {
        public List<Language> MyLanguages;

        public FakeLanguage()
        {
            InitializeLanguageList();
        }

        public void InitializeLanguageList()
        {
            MyLanguages = new List<Language> {
                FirstLanguage(), 
                SecondLanguage(),
                ThirdLanguage()
            };
        }

        public Language FirstLanguage()
        {
            var firstLanguage = new Language
            {
                LanguageId = (int)LanguageType.Values.EN,
                LanguageValue = LanguageType.Values.EN.ToString()
            };
            return firstLanguage;
        }

        public Language SecondLanguage()
        {
            var secondLanguage = new Language
            {
                LanguageId = (int)LanguageType.Values.SP,
                LanguageValue = LanguageType.Values.SP.ToString()
            };
            return secondLanguage;
        }

        public Language ThirdLanguage()
        {
            var thirdLanguage = new Language
            {
                LanguageId = (int)LanguageType.Values.FR,
                LanguageValue = LanguageType.Values.FR.ToString()
            };
            return thirdLanguage;
        }

        ~FakeLanguage()
        {
            MyLanguages = null;
        }
    }
}
