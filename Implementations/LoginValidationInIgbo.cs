using ATMCONSOLEAPPINTHREELANGUAGE;
using AtmConsoleAppInThreeLanguages.Enums;
using AtmConsoleAppInThreeLanguages.Properties;
using AtmConsoleAppInThreeLanguages.Transactions;

namespace AtmConsoleAppInThreeLanguages.Implementations
{
    internal class LoginValidationInIgbo
    {
        public List<UserAccount> _userAccountList;
        private int _userAccountNumberInput;
        private int _userCardPin;
        private static string Options { get; set; }
        private static int userInput { get; set; }

        public LoginValidationInIgbo()
        {
            _userAccountList = new List<UserAccount>()
            {
                new UserAccount()
                {
                    UserId = 1,
                    CardPin = 423234,
                    CardNumber = 123456789,
                    AccountNumber = 0669976019,
                    AccountBalance = 500000000,
                    AccountName = "Ekwom Nelson ",
                    FullName = "Ekwom Nelson Nnacheta",
                    Bank = "Access Bank",
                    Location = "New Heaven Junction,Enugu State"
                },
                new UserAccount()
                {
                    UserId = 2,
                    CardPin = 123231,
                    CardNumber = 987654321,
                    AccountNumber = 423710377,
                    AccountBalance = 600000000,
                    AccountName = "Alex",
                    FullName = "Nelson Alex",
                    Bank = "Access Bank",
                    Location = "San Francisco, America"
                },new UserAccount()
                {
                    UserId = 3,
                    CardPin = 565656,
                    CardNumber = 656565,
                    AccountNumber = 123456789,
                    AccountBalance = 600000000,
                    AccountName = "Chidubem",
                    FullName = "Onah Chidubem",
                    Bank = "Daimond Bank",
                    Location = "Imo"
                }
            };
        }

        public void LoginVal()
        {

            try
            {
                Program.Message("\nBiko:\t", "Tinwe ngiri mara gi maka mgbochi accounti gi.\n");
                Program.Message("\nBiko:\t", "Tinwe account number gi\n");
                _userAccountNumberInput = int.Parse(Console.ReadLine());
                Program.Message("\nBiko:\t", "Tinew CardPin gi.\n");
                _userCardPin = int.Parse(Console.ReadLine());

                foreach (var account in _userAccountList)
                {
                    var userAccountNumber = account.AccountNumber;
                    var userCardPin = account.CardPin;
                    if (userAccountNumber == _userAccountNumberInput && _userCardPin == userCardPin)
                    {
                        while (true)
                        {
                            getUser(account, userAccountNumber);
                            break;
                        }
                    }
                    /* else
                         {
                             Console.Clear();
                             Welcome.Message("\nError:\t", "User does'nt Exist");
                             LoginVal();
                         }*/
                }
            }
            catch (Exception exception)
            {
                Console.Clear();
                Program.Message("\nBiko:\t", "Tiye number mara mma\n");
                Console.WriteLine(exception.Message);
                LoginVal();
            }
        }


        public static void getUser(UserAccount? account, int userAccountNumber)
        {
            ChooseTransactionTypeIgbo.ChooseTransactionType(account.AccountName);

            try
            {
                Options = Console.ReadLine();

                userInput = Convert.ToInt32(Options);
                switch (userInput)
                {

                    case (int)TransactionType.Deposit:
                        ChooseTransactionTypeIgbo.Deposit(userAccountNumber, account.AccountBalance, account.FullName);
                        break;
                    case (int)TransactionType.Withdrawal:
                        ChooseTransactionTypeIgbo.Withdrawal(account.AccountBalance, account.FullName);
                        break;
                    case (int)TransactionType.Transfer:
                        ChooseTransactionTypeIgbo.Transfer(account.FullName, account.AccountBalance, account.AccountNumber);
                        break;
                    case (int)TransactionType.CheckBalance:
                        ChooseTransactionTypeIgbo.CheckBalance(account.AccountBalance, account.FullName);
                        break;
                    default:
                        Console.WriteLine("Ife i tinwere adiro nah list");
                        break;
                }

            }
            catch (Exception exception)
            {
                Program.Message("\nNjehie:\t", exception.Message);
            }
        }



    }
}
