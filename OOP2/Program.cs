using System;
using System.Collections.Generic;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            ICreditManager transportCreditManager = new TransportCreditManager();
            ICreditManager mortgageLoanCreditManager = new MortgageLoanManager();
            ICreditManager artisanLoanCreditManager = new ArtisanLoanManager();

            AppealManager appealManager = new AppealManager();
            //appealManager.MakeAnAppeal(personalFinanceCreditManager);
            //appealManager.MakeAnAppeal(transportCreditManager);
            //appealManager.MakeAnAppeal(mortgageLoanCreditManager);

            List<ICreditManager> creditManagers = new List<ICreditManager>() { personalFinanceCreditManager, mortgageLoanCreditManager };
            //appealManager.CreditCalculater(creditManagers);

            ILoggerManager loggerManagerDatabase = new DatabaseLoggerManager();
            ILoggerManager loggerManagerFile = new FileLoggerManager();
            ILoggerManager loggerManagerSms = new SmsLoggerManager();

            List<ILoggerManager> loggerManagers = new List<ILoggerManager>() { loggerManagerDatabase, loggerManagerSms};

            appealManager.MakeAnAppeal(artisanLoanCreditManager, loggerManagers);

        }
    }
}
