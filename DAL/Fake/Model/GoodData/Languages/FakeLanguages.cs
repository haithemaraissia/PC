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
                LanguageId = (int)Util.LanguageType.Values.EN,
                LanguageValue = Util.LanguageType.Values.EN.ToString()
            };
            return firstLanguage;
        }

        public global::Model.Language SecondLanguage()
        {
            var secondLanguage = new global::Model.Language
            {
                LanguageId = (int)Util.LanguageType.Values.SP,
                LanguageValue = Util.LanguageType.Values.SP.ToString()
            };
            return secondLanguage;
        }

        public global::Model.Language ThirdLanguage()
        {
            var thirdLanguage = new global::Model.Language
            {
                LanguageId = (int)Util.LanguageType.Values.FR,
                LanguageValue = Util.LanguageType.Values.FR.ToString()
            };
            return thirdLanguage;
        }

        ~FakeLanguage()
        {
            MyLanguages = null;
        }
    }
}
