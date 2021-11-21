using SQL_Assignment_2_Chinook.Interface;
using SQL_Assignment_2_Chinook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System;

namespace SQL_Assignment_2_Chinook.Data
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ChinookContext context) : base(context)
        {
        }
        public IEnumerable<Customer> GetNrOfCustomersByCountry()
        {
            var customersByCountry = ChinookContext.Customers.ToArray().GroupBy(t => t.Country).ToList().OrderByDescending(c => c.Count());
                foreach (var nameGroup in customersByCountry)
                {
                    Console.WriteLine($"{nameGroup.Key}\t{nameGroup.Count()}");
                }
            return customersByCountry.First();
        }
        public IEnumerable<Customer> GetLimitedListOfCustomers(int offset, int limit)
        {
            var getAllCustomers = ChinookContext.Customers.ToList().Skip(offset).Take(limit);
            foreach (Customer customer in getAllCustomers)
            {
                Console.WriteLine("ID: {0}\tName: {1} {2}\tCountry: {3}\tPostalCode: {4}\tPhoneNumber: {5}\tE-Mail: {6}",
                    customer.CustomerId,
                    customer.FirstName,
                    customer.LastName,
                    customer.Country,
                    customer.PostalCode,
                    customer.Phone,
                    customer.Email);
            }
            return getAllCustomers.ToArray();
        }
        public IEnumerable<Customer> GetAllCustomers()
        {
            var getAllCustomers = ChinookContext.Customers.ToList();
                foreach (Customer customer in getAllCustomers)
                {
                    Console.WriteLine("ID: {0}\tName: {1} {2}\tCountry: {3}\tPostalCode: {4}\tPhoneNumber: {5}\tE-Mail: {6}",
                        customer.CustomerId,
                        customer.FirstName,
                        customer.LastName,
                        customer.Country,
                        customer.PostalCode,
                        customer.Phone,
                        customer.Email);
                }
            return getAllCustomers.ToArray();
        }
        public IEnumerable<Customer> GetNamedCustomers(string name)
        {
            var getNamed = ChinookContext.Customers.AsEnumerable().Where(s => s.FirstName.Contains(name) || s.LastName.Contains(name)).ToList();
            foreach (Customer customer in getNamed)
            {
                Console.WriteLine("ID: {0}\tName: {1} {2}\tCountry: {3}\tPostalCode: {4}\tPhoneNumber: {5}\tE-Mail: {6}",
                        customer.CustomerId,
                        customer.FirstName,
                        customer.LastName,
                        customer.Country,
                        customer.PostalCode,
                        customer.Phone,
                        customer.Email);
            }
            return getNamed.ToArray();
        }
        public ChinookContext ChinookContext
        {
            get { return Context as ChinookContext; }
        }
    }
}
