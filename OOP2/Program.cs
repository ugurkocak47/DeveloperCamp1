namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.Name = "Engin";
            customer1.Surname = "Demiroğ";
            customer1.IdNumber = "12345678910";

            LegalCustomer customer2 = new LegalCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "1234567890";

            Customer customer3 = new IndividualCustomer() { Id = 3 };
            Customer customer4 = new LegalCustomer() {  Id = 4 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            
            //SOLID
        
        }
    }
}