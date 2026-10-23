using Linq02.DataSources;
using Linq02.Models;

namespace Linq02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01 

            //1. Get top 3 most expensive products

            //var result = Source.ProductList.OrderByDescending(p => p.UnitPrice)
            //                               .Take(3);

            #endregion

            #region Question02

            //2. show page 2 of products, with page size = 5

            //var result = Source.ProductList.Skip(5).Take(5);

            #endregion

            #region Question03

            //3. Take products from the list as long as Their UnitPrice is less than $25(list is ordered by price).

            //var result = Source.ProductList.OrderBy(p => p.UnitPrice)
            //                               .TakeWhile(p => p.UnitPrice < 25);

            #endregion

            #region Question04

            //4. Check if ALL products in the "Seafood" category are in stock

            //var result = Source.ProductList.Where(p => p.Category == "Seafood")
            //                               .All(p => p.UnitsInStock > 0);

            #endregion

            #region Question05

            //5. Check if the ID list contains 9. int[] ids = { 3, 9, 13, 18 };

            //int[] ids = { 3, 9, 13, 18 };
            //var result = ids.Contains(9);
            //Console.WriteLine(result);

            #endregion



            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
