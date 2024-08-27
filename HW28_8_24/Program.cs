using System;
using System.Collections.Generic;


namespace HW28_8_24
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            Customer c2 = new Customer();
            Customer c3 = new Customer();
            Customer c4 = new Customer();
            Customer c5 = new Customer();
            Customer c6 = new Customer();
            Customer c7 = new Customer();
            Customer c8 = new Customer();
            Customer c9 = new Customer();
            Customer c10 = new Customer();
            Customer c11 = new Customer();
            Customer c12 = new Customer();
            Queue<Customer> q = new Queue<Customer>();
            q.Enqueue(c1); q.Enqueue(c2); q.Enqueue(c3); q.Enqueue(c4); q.Enqueue(c5);
            CustomersCountLoad ccl = new CustomersCountLoad(q);
            Console.WriteLine(ccl.LoadIndex);
            ccl.ServiceDone();
            Console.WriteLine(ccl.LoadIndex);


            HourLoad hl = new HourLoad(q, 12);
            Console.WriteLine(hl.LoadIndex);
            hl.setHour(7);
            Console.WriteLine(hl.LoadIndex);
        }
    }
}
