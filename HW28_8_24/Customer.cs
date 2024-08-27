
namespace HW28_8_24
{
    public class Customer
    {
        public int Id { get; set; }
        public static int id = 0;

        public Customer()
        {
            id++;
            Id = id;
        }

    }
}
