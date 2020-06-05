namespace sovos_ramonvalerio.core.Domain.Customers
{
    public class Customer
    {
        public string Name { get; private set; }

        public string Email { get; private set; }

        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(Name))
                return false;

            if (string.IsNullOrWhiteSpace(Email))
                return false;

            return true;
        }
    }
}