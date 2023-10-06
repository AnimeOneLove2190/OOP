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
        public void GetProductNameList(List<Product> productList, Categories searcCategory)
        {
            if (productList == null || productList.Count == 0)
            {
                throw new Exception("LinqService.GetProductNameList: один или несколько параметров содержат null");
            }
            var poroductNamesList = productList.Where(x => x.Category == searcCategory).Select(x => x.Name).ToList();
            if (poroductNamesList == null || productList.Count == 0)
            {
                throw new Exception("Студенты с искомым возрастом не найдены");
            }
            else
            {
                foreach (var name in poroductNamesList)
                {
                    Console.WriteLine(name);
                }
            }

        }
    }
}
