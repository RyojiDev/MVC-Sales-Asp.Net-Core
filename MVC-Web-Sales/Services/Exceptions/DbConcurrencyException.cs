using System;
using System.IO;


namespace MVC_Web_Sales.Services.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string message) :base (message)
        {

        }
    }
}
