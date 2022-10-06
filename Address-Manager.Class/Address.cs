namespace Address_Manager.Class {
    public class Address {

        public string FirstName { get; }
        public string LastName { get; }
        public string Company { get; }
        public string Street { get; }
        public string PostalCode { get; }
        public string City { get; }

        public Address(string firstName, string lastName, string company, string street, string postalCode, string city) {
            FirstName = firstName;
            LastName = lastName;
            Company = company;
            Street = street;
            PostalCode = postalCode;
            City = city;
        }
    }
}