using System;

namespace Herança.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(2001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(512, "Araguaína", 0.0, 500.0);


            //Trabalhando com UPcasting
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(513, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(552, "Ana", 0.0, 0.02);

            
        }
    }
}
