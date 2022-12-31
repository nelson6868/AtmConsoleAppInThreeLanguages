using ATMCONSOLEAPPINTHREELANGUAGE;
using AtmConsoleAppInThreeLanguages.Implementations;

namespace AtmConsoleAppInThreeLanguages.Transactions
{
    internal static class ChooseTransactionTypeIgbo
    {
        public static void ChooseTransactionType(string usersAccountName)
        {

            Program.Message($"Welcome {usersAccountName}\n\t", "Tinwe number mbu, abou ma obu ito (1-3) \n");
            Program.Message("\t\t1.\t", "Tinwe ego na account gi\n");
            Program.Message("\t\t2.\t", "Ichoro iwoputa ego gi\n");
            Program.Message("\t\t3.\t", "Ka obu izipu ego ki choro\n");
            Program.Message("\t\t4.\t", "Ka ichoro ima ego ka di na account gi.");

        }

        public static void CheckBalance(decimal accountBalance, string userfullName)
        {
            try
            {
                Console.WriteLine($"{userfullName} balance gi bu {accountBalance}");


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }

        public static void Deposit(int AccountNumber, decimal AccountBalance, string AccountFullName)
        {

            try
            {

                Console.WriteLine("Tinwe amount ichoro itinwe na account gi");
                int AmountToDeposit = Convert.ToInt32(Console.ReadLine());
                    decimal newBalance = AccountBalance + AmountToDeposit;
                Program.Message($"\n{AccountFullName}\t", $"Itinwego {AmountToDeposit} na account gi. Balance gi kita bu\t : {newBalance}");
            }
            catch (Exception errorException)
            {

                Program.Message("\nError:\t", $"{errorException.Message}");
                return;
            }
        }
        public static void Withdrawal(decimal AccountBalance, string AccountFullName)
        {

            try
            {

                Console.WriteLine("Tinwe Amount ichoro iwepu na account gi");
                int amountToWidthraw = Convert.ToInt32(Console.ReadLine());
                    decimal newBalance = AccountBalance -= amountToWidthraw;
                Program.Message($"\n{AccountFullName}\t", $"Iwepu go {amountToWidthraw} na account gi, Ife di na account gi kita bu:\t {newBalance} ");
            }
            catch (Exception errorException)
            {

                Program.Message("\nError:\t", $"\n: Biko tinwe ife ziri ezi {errorException.Message}");
                return;
            }
        }

        public static void Transfer(string SenderFullName, decimal SenderAccountBalance, int SenderAccountNumber)
        {
            try
            {
                LoginValInEnglish loginValidation = new LoginValInEnglish();
                var account = loginValidation._userAccountList;
                foreach (var user in account)
                {


                    Console.WriteLine("Tinwe Amount ichoro izipu");
                    decimal AmountToTransfer = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Tinwe Account Number gi");

                    int ReceiverAccountNumberInput = Convert.ToInt32(Console.ReadLine());
                    var currentUser = account.FirstOrDefault(specificUser => specificUser.AccountNumber == ReceiverAccountNumberInput);
                    if (SenderAccountNumber == currentUser.AccountNumber)
                    {
                        Console.WriteLine("Biko ikwe si gi izipuru onwe gi ego");
                    }
                    else if (SenderAccountBalance < AmountToTransfer)
                    {
                        Console.WriteLine("Ego i nwere erughi ego ichoro izipu");
                    }
                    else
                    {
                        currentUser.AccountBalance += AmountToTransfer;
                        SenderAccountBalance -= AmountToTransfer;
                        Console.WriteLine($"{SenderFullName} Izi puru {AmountToTransfer} zigara {currentUser.FullName}. {AmountToTransfer} a pu go  na account gi");
                        Program.Message($"\n{SenderFullName} Ego foro na account gi bu", $"{SenderAccountBalance}");
                    }
                    LoginValidationInPidgin.getUser(user, user.AccountNumber);
                }
            }
            catch (Exception exception)
            {
                Program.Message("\n Nzogbu di:", $"{exception.Message}");

            }
        }
    }
}
