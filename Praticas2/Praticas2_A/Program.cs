﻿using System;
using Praticas2_A.Entities;
namespace Praticas2_A
{
    class Program
    {
        static void Main(string[] args)
        {
            // HERANÇA / UPCASTING / DOWNCASTING / IS / AS
            //BussinesAccount account = new BussinesAccount(8000, "Raphael", 3500.00, 10000.00);
            //Console.WriteLine(account.Balance);


            Account acc = new Account(8000, "Raphael", 0.0); // NORMAL
            BussinesAccount bacc = new BussinesAccount(7000, "Flávia", 0.0, 4500.00); // UPCASTING

            Account acc1 = bacc; // UPCASTING
            Account acc2 = new BussinesAccount(6000, "Júlia", 0.0, 3000.00); // UPCASTING
            Account acc3 = new SavingAccount(500, "Kelly", 0.0, 0.01); // UPCASTING

            
            BussinesAccount acc4 = (BussinesAccount)acc2; //DOWNCASTING
            acc4.Loan(100.00);


            
            if(acc3 is BussinesAccount)
            {
                //BussinesAccount acc5 = (BussinesAccount)acc3; // DOWNCASTING
                BussinesAccount acc5 = acc3 as BussinesAccount; // AS
                acc5.Loan(200.00);
                Console.WriteLine("Loan!!");
            }
            if(acc3 is SavingAccount)
            {
                //SavingAccount acc5 = (SavingAccount)acc3; // DOWNCASTING
                SavingAccount acc5 = acc3 as SavingAccount; // AS
                acc5.UpdateBalance();
                Console.WriteLine("Update!!");
            }




            Console.ReadLine();
        }
    }
}
