using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Başvuru Yönetimi
    class AppealManager
    {
        public void MakeAnAppeal(ICreditManager creditManager, List<ILoggerManager> loggerManagers)
        {
            creditManager.Calculater();
            foreach (var loggerManager in loggerManagers)
            {
                loggerManager.Logger();
            }
        }

        public void CreditCalculater(List<ICreditManager> creditManagers)
        {
            foreach (var creditManager in creditManagers)
            {
                creditManager.Calculater();
            }
        }
    }
}
