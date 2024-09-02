
using System.Collections.Generic;

namespace HW28_8_24
{
    public class HourLoad : CustomerService
    {
        // CR: Naming: What does hour mean? This name could relate to anything

        public double Hour { get; set; }

        public HourLoad(Queue<Customer> customersLine, double hour) : base(customersLine)
        {
            Hour = hour;
            if (Hour > 8 && Hour < 18)
            {
                LoadIndex = 8;
            } // CR: Add brackets be consistent with formatting
            else
                LoadIndex = 2;
        }

        // CR: Convention: SetHour
        // CR: this function should be private, why do you need an input of time?
        // CR: use c# DateTime for this
        // CR: Naming: this function, d
        public void setHour(double hour)
        {
            Hour = hour;
            // CR: Magic values in code. Move to constant.
            if (Hour > 8 && Hour < 18)
            {
                LoadIndex = 8;
            } // CR: Add brackets be consistent with formatting
            else
                LoadIndex = 2;
        }
    }
}
