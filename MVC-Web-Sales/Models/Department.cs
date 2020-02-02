using System;
using System.Linq;
using System.Collections.Generic;


namespace MVC_Web_Sales.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {

        }

        public Department(string name)
        {

        }

        public Department(int id, string name)
        {
            
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial,DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }


    }
}
