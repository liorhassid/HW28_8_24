using System.Collections.Generic;
using System.Linq;


namespace HW28_8_24
{
    //CR: Naming could be clearer 
    public class CustomersCountLoad : CustomerService
    {
        public int CurrentWaitingCustomers { get; set; }

        public CustomersCountLoad(Queue<Customer> customersLine) : base(customersLine)
        {
            CurrentWaitingCustomers = CustomersLine.Count();
            // CR: Magic value! what will happen if the number will change to 10?
            LoadIndex = CurrentWaitingCustomers / 5;
        }

        //CR: SRP: this function does two things.
        // 1. Adds customer to queue
        // 2. Calculates load
        // We will need two change both implementations for one of these changes which breaks SRP
        public override void ServiceRequest(Customer customer)
        {
            int waitingCustomers = CurrentWaitingCustomers;
            CustomersLine.Enqueue(customer);
            CurrentWaitingCustomers++;
            // CR: The load balance is a value between 1-10...
            if (CurrentWaitingCustomers / 5 > waitingCustomers / 5)
            {
                LoadIndex++;
            }
        }

        public override void ServiceDone()
        {
            int waitingCustomers = CurrentWaitingCustomers;
            CustomersLine.Dequeue();
            CurrentWaitingCustomers--;
            if (CurrentWaitingCustomers / 5 < waitingCustomers / 5)
            {
                LoadIndex--;
            }
        }
    }
}
