using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplicationManager
    {
        public void Apply(ICreditManager creditManager,List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
            //
            
            creditManager.Calculate();
            foreach(ILoggerService loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void CreditPreInformation(List<ICreditManager> credits)
        {
            foreach (ICreditManager credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
