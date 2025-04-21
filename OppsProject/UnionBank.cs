using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsProject
{
    //Multiple inheritance possible through two interfaces
    class UnionBank:IDebitCard, ICreditCard
    {
        public void debitTrans()
        {
            Console.WriteLine("Debit card transaction successfully completed!!!");
        }

        public void creditTrans()
        {
            Console.WriteLine("Credit Card Transaction Sucessfully COmpleted..!");
        }

        //Method Overloading
        public void transactionFrom(int AccountNo1)
        {
            Console.WriteLine($"Trassaction completed from: {AccountNo1}");
        }

        public void transactionFrom(int AccountNo1, int AccountNo2)
        {
            Console.WriteLine($"Transaction completed from: {AccountNo1}");
            Console.WriteLine($"Transaction completed from: {AccountNo2}");
        }
    }
}
