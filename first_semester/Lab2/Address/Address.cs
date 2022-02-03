using System;
using System.Text.RegularExpressions;
using static ParserUtils.ParserUtil;

namespace Address
{
    class Address
    {
        private int _index;
        private string _country;
        private string _city;
        private string _street;
        private string _house;
        private int _apartment;


        public static readonly Regex HouseRegex = new(@"^[1-9]\d*(?:[ -]?(?:[a-zA-Z]+|[1-9]\d*))?$");

        public int Index
        {
            get => _index;
            set => _index = value;
        }

        public string Country
        {
            get => _country;
            set => _country = value;
        }

        public string City
        {
            get => _city;
            set => _city = value;
        }

        public string Street
        {
            get => _street;
            set => _street = value;
        }

        public string House
        {
            get => _house;
            set => _house = value;
        }

        public int Apartment
        {
            get => _apartment;
            set => _apartment = value;
        }


        public static void Main(string[] args)
        {
            var address = CreateAddress();
            address.PrintInfo();
        }

        public static Address CreateAddress()
        {
            Console.WriteLine("Hello, to get address you have to enter some information");
            return new Address
            {
                Index = ValidateAndParseInt("index"),
                Country = ValidateAndParseRegex(NameRegex, "country"),
                City = ValidateAndParseRegex(NameRegex, "city"),
                Street = ValidateAndParseRegex(NameRegex, "street"),
                House = ValidateAndParseRegex(HouseRegex, "house"),
                Apartment = ValidateAndParseInt("apartment")
            };
        }

        public void PrintInfo()
        {
            Console.WriteLine("Index: " + Index);
            Console.WriteLine("Country: " + Country);
            Console.WriteLine("City: " + City);
            Console.WriteLine("Street: " + Street);
            Console.WriteLine("House: " + House);
            Console.WriteLine("Apartment: " + Apartment);
        }
    }
}