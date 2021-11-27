namespace MoneyManager.SaraivaDev.API.Common
{
    public static class Enums
    {
        public enum AddressType
        {
            Mailing = 1,
            Billing = 2,
            Business = 3
        }

        public enum PhoneType
        {
            Cellphone = 1,
            Homephone = 2,
            Businessphone = 3
        }

        public enum EmailType
        {
            Personal = 1,
            Business = 2
        }

        public enum AccountType
        {
            Wallet = 1,
            Bank = 2,
            StockBroker = 3,
            Savings = 4,
            CreditCard = 5,
            Other = 6
        }

        public enum EntryType
        {
            Income = 1,
            Expense = 2,
            Transfer = 3
        }

        public enum UserTypes
        {
            Admin = 1,
            User = 2
        }
    }
}
