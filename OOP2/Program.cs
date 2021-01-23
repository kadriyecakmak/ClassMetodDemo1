using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            RealCustomer customer1 = new RealCustomer();
            customer1.Id = 1;
            customer1.CustomerId = "12345";
            customer1.CustomerName = "Kadriye";
            customer1.CustomerSurname = "Çakmak";
            customer1.İdentyNo = "4444444444";


            //kodlama.io

            TüzelCustomer customer2 = new TüzelCustomer();
            customer2.Id = 2;
            customer2.İdentyNo= "4555";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "123456789";

            Customer customer3 = new RealCustomer();
            Customer customer4 = new TüzelCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);





            //Gerçek Müşteri  - Tüzel Müşteri
            //SOLID
        }
    }
}
