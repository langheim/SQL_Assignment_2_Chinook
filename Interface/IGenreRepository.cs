using SQL_Assignment_2_Chinook.Model;
using System.Collections.Generic;

namespace SQL_Assignment_2_Chinook.Interface
{
    public interface IGenreRepository : IRepository<Genre>
    {
        IEnumerable<Genre> GetPopularGenreByCustomer(int id);
    }
}
