using SQL_Assignment_2_Chinook.Model;
using System.Collections.Generic;

namespace SQL_Assignment_2_Chinook.Interface
{
    public interface IGenreRepository : IRepository<Genre>
    {
        /// <summary>
        /// Gets the most popular genre based on the customers invoices
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IEnumerable<Genre> GetPopularGenreByCustomer(int id);
    }
}
