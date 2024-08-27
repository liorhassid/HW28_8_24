using System.Collections.Generic;
using System.Linq;


namespace HW28_8_24
{
    public class CustomersCountLoad : CustomerService
    {
        public int CurrentWaitingCustomers { get; set; }

        public CustomersCountLoad(Queue<Customer> customersLine) : base(customersLine)
        {
            CurrentWaitingCustomers = CustomersLine.Count();
            LoadIndex = CurrentWaitingCustomers / 5;
        }

        public override void ServiceRequest(Customer customer)
        {
            int waitingCustomers = CurrentWaitingCustomers;
            CustomersLine.Enqueue(customer);
            CurrentWaitingCustomers++;
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
