using SQL_Assignment_2_Chinook.Model;

namespace SQL_Assignment_2_Chinook.Interface
{
    public interface IGenreRepository : IRepository<Genre>
    {
        void GetPopularGenreByCustomer(int id);
    }
}
