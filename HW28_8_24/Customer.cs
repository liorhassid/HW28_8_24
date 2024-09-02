
namespace HW28_8_24
{
    public class Customer
    {
        // CR: SRP - This class does two things, and breaks SRP
        // The Id generation should not be a part of this class
        public int Id { get; set; }
        // CR: Naming, this name is not indicative, and seems like a copy of the classes property

        public static int id = 0;

        public Customer()
        {
            id++;
            Id = id;
        }

    }
}
