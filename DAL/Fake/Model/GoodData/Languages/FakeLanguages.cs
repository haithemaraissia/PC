using System.Collections.Generic;
using DAL.Fake.Model.LookUp.Langauges;

namespace DAL.Fake.Model.GoodData.Languages
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
                LanguageId = (int)LanguageType.Values.EN,
                LanguageValue = LanguageType.Values.EN.ToString()
            };
            return firstLanguage;
        }

        public global::Model.Language SecondLanguage()
        {
            var secondLanguage = new global::Model.Language
            {
                LanguageId = (int)LanguageType.Values.SP,
                LanguageValue = LanguageType.Values.SP.ToString()
            };
            return secondLanguage;
        }

        public global::Model.Language ThirdLanguage()
        {
            var thirdLanguage = new global::Model.Language
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
