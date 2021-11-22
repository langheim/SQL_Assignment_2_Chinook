using SQL_Assignment_2_Chinook.Interface;
using SQL_Assignment_2_Chinook.Model;
using System.Collections.Generic;
using System.Linq;

namespace SQL_Assignment_2_Chinook.Data
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ChinookContext context) : base(context)
        {
        }
        /// <summary>
        /// Get the total number of Customers by coutry.
        /// Creating a list then using Dbcontext to create the returned list
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Country> GetNrOfCustomersByCountry()
        {
            List<Country> listReturn = new();

            var customersByCountry = ChinookContext.Customers.ToArray().GroupBy(t => t.Country).ToList().OrderByDescending(c => c.Count());
            foreach (var nameGroup in customersByCountry)
            {
                Country country = new()
                {
                    Name = nameGroup.Key,
                    NumberOfCustomers = nameGroup.Count()
                };
                listReturn.Add(country);
            }
            return listReturn;
        }
        /// <summary>
        /// Create a list for the return then get customer by partial firstname, lastname via DbContext 
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <returns></returns>
        public IEnumerable<Customer> GetNamedCustomers(string firstname, string lastname)
        {
            List<Customer> listReturn = new();
            var getNamed = ChinookContext.Customers.AsEnumerable().Where(s => s.FirstName.Contains(firstname) || s.LastName.Contains(lastname)).ToList();
            foreach (Customer customer in getNamed)
            {
                Customer customer1 = new()
                {
                    CustomerId = customer.CustomerId,
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    Country = customer.Country,
                    PostalCode = customer.PostalCode,
                    Phone = customer.Phone,
                    Email = customer.Email

                };
                listReturn.Add(customer1);
            }
            return listReturn;
        }
        public ChinookContext ChinookContext
        {
            get { return Context as ChinookContext; }
        }
    }
}
