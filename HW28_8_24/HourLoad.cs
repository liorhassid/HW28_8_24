
using System.Collections.Generic;

namespace HW28_8_24
{
    public class HourLoad : CustomerService
    {
        public double Hour { get; set; }

        public HourLoad(Queue<Customer> customersLine, double hour) : base(customersLine)
        {
            Hour = hour;
            if (Hour > 8 && Hour < 18)
            {
                LoadIndex = 8;
            }
            else
                LoadIndex = 2;
        }

        public void setHour(double hour)
        {
            Hour = hour;
            if (Hour > 8 && Hour < 18)
            {
                LoadIndex = 8;
            }
            else
                LoadIndex = 2;
        }
    }
}
