using System;
using Xunit;
using SQL_Assignment_2_Chinook;

namespace SQLAssignment_2_ChinookTests
{
    public class UnitTest1
    {
        [Fact]
        public void Read_All_Customer_In_Database_Return_List_Of_Customers()
        {
            //Arrange
            using (var UnitOfWork = new UnitOfWork(new Data.ChinookContext()))
            {
                UnitOfWork.Customer.GetAllCustomers();
                //Act

                //Assert
            }
        }
    }
}
