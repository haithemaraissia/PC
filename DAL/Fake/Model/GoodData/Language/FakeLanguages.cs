using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
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
                LanguageId = 1,
                LanguageValue = "EN"
            };
            return firstLanguage;
        }

        public Language SecondLanguage()
        {
            var secondLanguage = new Language
            {
                LanguageId = 2,
                LanguageValue = "SP"
            };
            return secondLanguage;
        }

        public Language ThirdLanguage()
        {
            var thirdLanguage = new Language
            {
                LanguageId = 3,
                LanguageValue = "FR"
            };
            return thirdLanguage;
        }

        ~FakeLanguage()
        {
            MyLanguages = null;
        }
    }
}
