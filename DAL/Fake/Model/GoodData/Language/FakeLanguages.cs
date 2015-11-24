using System.Collections.Generic;

namespace DAL.Fake.Model.GoodData.Language
{
    public class FakeLanguage
    {
        public List<global::Model.Language> MyLanguages;

        public FakeLanguage()
        {
            InitializeLanguageList();
        }

        public void InitializeLanguageList()
        {
            MyLanguages = new List<global::Model.Language> {
                FirstLanguage(), 
                SecondLanguage(),
                ThirdLanguage()
            };
        }

        public global::Model.Language FirstLanguage()
        {
            var firstLanguage = new global::Model.Language
            {
                LanguageId = 1,
                LanguageValue = "EN"
            };
            return firstLanguage;
        }

        public global::Model.Language SecondLanguage()
        {
            var secondLanguage = new global::Model.Language
            {
                LanguageId = 2,
                LanguageValue = "SP"
            };
            return secondLanguage;
        }

        public global::Model.Language ThirdLanguage()
        {
            var thirdLanguage = new global::Model.Language
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
