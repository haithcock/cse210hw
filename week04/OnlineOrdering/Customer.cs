public class Customer
{
    public int CustomerID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public Address Address { get; set; }

    // Constructor
    public Customer(int customerID, string name, string email, string phone, Address address)
    {
        CustomerID = customerID;
        Name = name;
        Email = email;
        Phone = phone;
        Address = address; 
    }
        public bool LivesInUnitedStates()
    {
        return Address.IsInUnitedStates();
    }
}
