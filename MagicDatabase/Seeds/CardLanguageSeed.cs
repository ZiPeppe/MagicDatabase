namespace MagicDatabase.Seeds
{
    public static class CardLanguageSeed
    {
        public static List<CardLanguage> GetData()
        {
            return new List<CardLanguage>
            {
                new CardLanguage { CardLanguageId = 1, CardLanguageName = "Italian" },
                new CardLanguage { CardLanguageId = 2, CardLanguageName = "English" },
                new CardLanguage { CardLanguageId = 3, CardLanguageName = "Japanese" },
                new CardLanguage { CardLanguageId = 4, CardLanguageName = "French" },
                new CardLanguage { CardLanguageId = 5, CardLanguageName = "German" },
                new CardLanguage { CardLanguageId = 6, CardLanguageName = "Russian" },
                new CardLanguage { CardLanguageId = 7, CardLanguageName = "Spanish" },
                new CardLanguage { CardLanguageId = 8, CardLanguageName = "Portuguese" },
                new CardLanguage { CardLanguageId = 9, CardLanguageName = "Chinese" },
                new CardLanguage { CardLanguageId = 10, CardLanguageName = "Korean" },
            };
        }
    }
}
