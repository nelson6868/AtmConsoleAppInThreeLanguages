using AtmConsoleAppInThreeLanguages.Enums;

namespace AtmConsoleAppInThreeLanguages.Properties
{
    internal class Transaction
    {
        private long TransactionId { get; set; }
        private long UserBankId { get; set; }
        private string Description { get; set; }
        private DateTime TransactionDate { get; set; }
        private TransactionType TransType { get; set; }
        private decimal TransactionAmount { get; set; }
    }
}
