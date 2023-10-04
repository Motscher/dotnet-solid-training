using System.Collections.Generic;

namespace DevBasics.CarManagement
{
    public static class LanguageCodesProvider
    {
        public static IDictionary<string, string> GetLanguageCodes()
        {
            var languageCodes = new Dictionary<string, string>
            {
                { "Dutch", "nl" },
                { "English", "en" },
                { "French", "fr" },
                { "German", "de" },
                { "Spanish", "es" },
                { "Italian", "it" },
                { "Japanese", "jp" },
                { "Traditional Chinese", "zf" },
                { "Simple Chinese", "zh" },
                { "Swedish", "sv" },
                { "Finnish", "fi" },
                { "Danish", "dk" },
                { "Norwegian", "no" },
                { "Thailand", "th" },
                { "Brazilian Portugese", "br" },
                { "Czech", "cs" },
                { "Hungarian", "hu" },
                { "Polish", "pl" },
                { "Portuguese", "pt" },
                { "Korean", "ko" },
                { "Malay", "my" },
                { "Romanian", "ro" },
                { "Slovak", "sk" },
                { "Ukrainian", "uk" },
                { "Hindi", "hi" },
            };
            return languageCodes;
        }
    }
}