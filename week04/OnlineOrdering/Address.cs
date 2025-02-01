public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }

    // Constructor
    public Address(string street, string city, string state, string postalCode, string country)
    {
        Street = street;
        City = city;
        State = state;
        PostalCode = postalCode;
        Country = country;
    }
        public bool IsInUnitedStates()
    {
        return Country.Equals("United States", StringComparison.OrdinalIgnoreCase);
    }
        public override string ToString()
    {
        return $"{Street}\n{City}\n{State}\n{PostalCode}\n{Country}";
    }
}
