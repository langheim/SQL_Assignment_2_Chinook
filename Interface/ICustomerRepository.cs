using SQL_Assignment_2_Chinook.Model;
using System.Collections.Generic;

namespace SQL_Assignment_2_Chinook.Interface
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        IEnumerable<Customer> GetNrOfCustomersByCountry();
        IEnumerable<Customer> GetLimitedListOfCustomers(int offset, int limit);
        IEnumerable<Customer> GetAllCustomers();
        IEnumerable<Customer> GetNamedCustomers(string name);
    }
}
