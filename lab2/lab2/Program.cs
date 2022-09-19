using System;

namespace Address
{
    public class Address
    {

        public int Index { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string House { get; set; }

        public string Apartment { get; set; }


        public void DisplayName()
        {
            Console.WriteLine($"Index: {Index} \fCountry : {Country} \fCity : {City} \fStreet : {Street} \fHouse : {House} \fApartment : {Apartment}");
        }

        static void Main()
        {
            Address address = new Address();
            address.Index = 02000;
            address.Country = "Ukraine";
            address.City = "Kyiv";
            address.Street = "Lobachevskogo 23";
            address.House = "6";
            address.Apartment = "721";
            address.DisplayName();
        }
    }
}
