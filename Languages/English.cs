using ATMCONSOLEAPPINTHREELANGUAGE;
using AtmConsoleAppInThreeLanguages.Implementations;

namespace AtmConsoleAppInThreeLanguages
{
    public static class English
    {
        public static void CallEnglishLanguageImplementations()
        {
            Program.Message("\nHello Awesome Person\t", "Your are welcome.\n\n");
            LoginValInEnglish loginValidation = new LoginValInEnglish();
            loginValidation.LoginVal();

        }
    }
}
