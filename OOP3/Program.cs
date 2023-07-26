namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalCreditManager = new PersonalCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager residenceCreditManager = new ResidenceCreditManager();
            
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(new TradesmanCreditManager(), new List<ILoggerService> {new DatabaseLoggerService(), new SMSLoggerService() });

            List<ICreditManager> credits = new List<ICreditManager> { personalCreditManager, vehicleCreditManager };
            
            
            //applicationManager.CreditPreInformation(credits);
                    

            //5. Gün 2:17:05
        }
    }
}