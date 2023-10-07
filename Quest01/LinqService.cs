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
        //feature569
        public void GetProductListWihtCategory(List<Product> productList, Categories searchCategory)
        {
            if (productList == null || productList.Count == 0)
            {
                throw new Exception("LinqService.GetProductListWihtCategory: один или несколько параметров содержат null");
            }
            var categoryProductList = productList.Where(x => x.Category == searchCategory).ToList();
            if (categoryProductList == null || categoryProductList.Count == 0)
            {
                throw new Exception("Товары с выбранной категорией не найдены");
            }
            else
            {
                foreach (var product in categoryProductList)
                {
                    Console.WriteLine(product.Name);
                    Console.WriteLine(product.Price);
                    Console.WriteLine(product.Category);
                }
            }
        }
    }
}
