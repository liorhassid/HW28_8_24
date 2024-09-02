using System.Collections.Generic;

namespace HW28_8_24
{
    public abstract class CustomerService
    {
        // CR: This code is coupled to a queue, what if we would like to change to a priority queue
        // CR: Or to a different queueing system?
        // CR: This code should not be coupled to an implementation
        public Queue<Customer> CustomersLine { get; set; }

        // CR: SRP, the load index should be manged by a different class
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
