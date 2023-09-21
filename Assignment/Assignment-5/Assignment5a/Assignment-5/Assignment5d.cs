using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Assignment5d
    {
        public static void Main()
        {
            Console.Write("Enter Customer ID: ");
            string customerId = Console.ReadLine();

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter Phone: ");
            long phone = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter City: ");
            string city = Console.ReadLine();

            //customer object using the parameterized constructor
            Customer customer1 = new Customer(customerId, name, age, phone, city);

            //printing customer info using static method
            Customer.DisplayCustomer(customer1);

            Customer customer2 = new Customer();
            Customer.DisplayCustomer(customer2);
            Console.Read();
        }
    }
    class Customer
    {
        string Customerid;
        string Name;
        int Age;
        long Phone;
        string City;
        public Customer()
        {
        }
        public Customer(string cutomerId, string name, int age, long phone, string city)
        {
            Customerid = cutomerId;
            Name = name;
            Age = age;
            Phone = phone;
            City = city;
        }
        public static void DisplayCustomer(Customer customer)
        {
            Console.WriteLine("Customer ID: " + customer.Customerid);
            Console.WriteLine("Name: " + customer.Name);
            Console.WriteLine("Age: " + customer.Age);
            Console.WriteLine("Phone: " + customer.Phone);
            Console.WriteLine("City: " + customer.City);
        }
        ~Customer()
        {

        }
    }

}
persistence using stream reader and writer



