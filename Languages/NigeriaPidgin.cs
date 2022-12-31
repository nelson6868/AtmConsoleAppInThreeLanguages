using ATMCONSOLEAPPINTHREELANGUAGE;
using AtmConsoleAppInThreeLanguages.Implementations;

namespace AtmConsoleAppInThreeLanguages.Languages
{
    internal static class NigeriaPidgin
    {
        public static void CallNigeriaPidginLanguageImplementations()
        {
            Program.Message("\nWelcome Onye Ego", "Whatsup You!\n\n");
            LoginValidationInPidgin Pidgin = new LoginValidationInPidgin();
            Pidgin.LoginVal();
        }
    }
}
