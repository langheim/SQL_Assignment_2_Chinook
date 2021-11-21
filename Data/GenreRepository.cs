using SQL_Assignment_2_Chinook.Interface;
using SQL_Assignment_2_Chinook.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SQL_Assignment_2_Chinook.Data
{
    public class GenreRepository : Repository<Genre>, IGenreRepository
    {
        public GenreRepository(ChinookContext context) : base(context)
        {
        }
        public IEnumerable<Genre> GetPopularGenreByCustomer(int id)
        {
            var genreTop = ChinookContext.Genres.ToArray();
            var query = (from q in genreTop.OrderByDescending(s => s.Name).Take(3).Select(s => s.Name).Distinct()
                         from i in genreTop
                         where q == i.Name
                                      as Number
                         from Genre as g
                         join
            select i).ToList();

            //queryjoin = from employee in query
            join student in students
         //            on new { employee.FirstName, employee.LastName }
         //            equals new { student.FirstName, student.LastName }
         //            select employee.FirstName + " " + employee.LastName;


            foreach (var item in query)
            {
                Console.WriteLine(item.Name);
            }
            return genreTop.ToArray();



        }
        public ChinookContext ChinookContext
        {
            get { return Context as ChinookContext; }
        }
    }
}