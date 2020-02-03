using System;
using System.IO;

namespace MVC_Web_Sales.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message): base(message)
        {

        }
    }
}
