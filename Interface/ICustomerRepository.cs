using SQL_Assignment_2_Chinook.Model;
using System.Collections.Generic;

namespace SQL_Assignment_2_Chinook.Interface
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        /// <summary>
        /// Spesific functions not based on generic IRepository
        /// </summary>
        /// <returns></returns>
        /// Get number of Customers based on Contry
        IEnumerable<Country> GetNrOfCustomersByCountry();
        /// <summary>
        /// Get customers based on LIKE search
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <returns></returns>
        IEnumerable<Customer> GetNamedCustomers(string firstname, string lastname);
    }
}
