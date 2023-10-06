using System;
using System.Collections.Generic;
using System.Text;
using Quest01.AllPersons;
using Quest01.Employees;
using Quest01.Products;
using System.Linq;

namespace Quest01
{
    class LinqService
    {
        //feature573
        public void GetProductNamesWithPriceHigher(List<Product> productList, int searchMinPrice)
        {
            if (productList == null || productList.Count == 0)
            {
                throw new Exception("LinqService.GetProductNamesWithPriceHigher: один или несколько параметров содержат null");
            }
            var productNamesWithPriceHigher = productList.Where(x => x.Price > searchMinPrice).Select(x => x.Name).ToList();
            if (productNamesWithPriceHigher == null || productNamesWithPriceHigher.Count == 0)
            {
                throw new Exception("Товары с ценой выше указанной не найдены");
            }
            else
            {
                foreach (var name in productNamesWithPriceHigher)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
