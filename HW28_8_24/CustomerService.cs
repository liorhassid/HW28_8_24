using System.Collections.Generic;

namespace HW28_8_24
{
    public abstract class CustomerService
    {
        public Queue<Customer> CustomersLine { get; set; }
        public int LoadIndex { get; set; }

        public CustomerService(Queue<Customer> customersLine)
        {
            CustomersLine = customersLine;
        }

        public virtual void ServiceRequest(Customer customer)
        {
            CustomersLine.Enqueue(customer);
        }

        public virtual void ServiceDone()
        {
            CustomersLine.Dequeue();
        }

    }
}
