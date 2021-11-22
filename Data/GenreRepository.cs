using Microsoft.Data.SqlClient;
using SQL_Assignment_2_Chinook.Interface;
using SQL_Assignment_2_Chinook.Model;
using System;

namespace SQL_Assignment_2_Chinook.Data
{
    public class GenreRepository : Repository<Genre>, IGenreRepository
    {
        public GenreRepository(ChinookContext context) : base(context)
        {
        }
        /// <summary>
        /// Returns the genre that corresponds to the most tracks invoiced to customer. Customer ID as param
        /// </summary>
        /// <param name="id"></param>
        public void GetPopularGenreByCustomer(int id)
        {
            try
            {
                string connectionString = "Data Source=PC10396\\PC10396;Initial Catalog=Chinook;Integrated Security=true;";
                using SqlConnection connection = new(connectionString);
                connection.Open();

                string sql = "SELECT TOP(1) WITH TIES genre.Name, " +
                             "COUNT(genre.Name) " +
                             "FROM Genre AS genre " +
                             "INNER JOIN " +
                             "(SELECT GenreId AS genre_Id " +
                             "FROM Track WHERE TrackId IN " +
                             "(SELECT TrackId " +
                             "FROM InvoiceLine " +
                             "WHERE InvoiceId IN " +
                             "(SELECT InvoiceId " +
                             "FROM Invoice " +
                             "WHERE CustomerId = @id))) " +
                             "AS gid ON genre.GenreId = gid.genre_Id " +
                             "GROUP BY genre.Name " +
                             "ORDER BY COUNT(genre.Name) DESC;";

                using SqlCommand command = new(sql, connection);
                command.Parameters.AddWithValue("@id", id);
                using SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("Genre: {0}\tInvoiced: {1}", reader.GetString(0), reader.GetInt32(1));
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();
            }
            catch (SqlException exception)
            {
                Console.WriteLine("Sql exception msg:" + exception.Message);
            }

            /// Would have used LINQ for this, but it fails at select! 
            /// Need to use more time to invetigate this. Using regular SQL Reader for this function

            ////Genres
            ////    .Join(Tracks.Where(Track => InvoiceLines
            ////    .Where(InvoiceLine => Invoices.Where(Invoice => (Invoice.CustomerId == 1))
            ////    .Select(Invoice => new { InvoiceId = Invoice.InvoiceId })
            ////    .Contains(new { InvoiceId = InvoiceLine.InvoiceId }))
            ////    .Select(InvoiceLine => new { TrackId = InvoiceLine.TrackId })
            ////    .Contains(new { TrackId = Track.TrackId }))
            ////    .Select(Track => new { GId = Track.GenreId }),
            ////    g => new { GenreId = g.GenreId },
            ////    gi => new { GenreId = (Int32)(gi.GId) },
            ////    (g, gi) => new { g = g, gi = gi })
            ////    .GroupBy(temp0 => new { Name = temp0.g.Name }, temp0 => temp0.g)
            ////    .OrderByDescending(g => g.Count(p => (p.Name != null)))
            ////    .Select(g => new { Name = g.Key.Name, Number = g.Count(p => (p.Name != null)) }).Take(1)

        }
        public ChinookContext ChinookContext
        {
            get { return Context as ChinookContext; }
        }
    }
}