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
        public void GetBookNameListByGenre(List<Book> bookList, Genre searchGenre)
        {
            if (bookList == null || bookList.Count == 0)
            {
                throw new Exception("LinqService.GetProductWithMinPrice: один или несколько параметров содержат null");
            }
            var bookNameListByGenre = bookList.Where(x => x.Genres.Contains(searchGenre)).OrderByDescending(x => x.PublicationYear).Select(x => x.Title).ToList();
            if (bookNameListByGenre == null)
            {
                throw new Exception("Студент с искомым возрастом не найден");
            }
            else
            {
                foreach (var name in bookNameListByGenre)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
