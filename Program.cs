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

            #region Question06

            ////6. Group all products by Category and print each group with its product count.

            //var result = Source.ProductList.GroupBy(p => p.Category)
            //                               .Select(g => new { Category = g.Key, Count = g.Count() });

            #endregion

            #region Question07

            //7. Group products by Category and project only product names per group

            //var result = Source.ProductList.GroupBy(p => p.Category)
            //                               .Select(g => new { Category = g.Key, Products = g.Select(p => p.ProductName) });

            //foreach (var item in result)
            //{
            //    foreach (var name in item.Products)
            //    {
            //        Console.WriteLine(name);
            //    }
            //}

            #endregion

            #region Question08

            //8. Find all categories that have MORE THAN 3 products

            //var result = Source.ProductList.GroupBy(p => p.Category)
            //                               .Where(g => g.Count() > 3)
            //                               .Select(g => g.Key);

            #endregion

            #region Question09

            //9. Using QUERY SYNTAX, group customers by Country, and for each group select { Country, Count, TotalOrderValue }.

            //var result = from c in Source.CustomerList
            //             group c by c.Country into g
            //             select new
            //             {
            //                 Country = g.Key,
            //                 Count = g.Count(),
            //                 TotalOrderValue = g.SelectMany(cust => cust.Orders).Sum(o => o.Total)
            //             };

            #endregion

            #region Question10

            //10. Calculate the total number of units in stock across all products

            //var result = Source.ProductList.Sum(p => p.UnitsInStock);
            //Console.WriteLine(result);

            #endregion

            #region Question11

            //11. Find the CHEAPEST and MOST EXPENSIVE product prices

            //var cheapestPrice = Source.ProductList.Min(p => p.UnitPrice);
            //var mostExpensivePrice = Source.ProductList.Max(p => p.UnitPrice);
            //Console.WriteLine(cheapestPrice);
            //Console.WriteLine(mostExpensivePrice);

            #endregion

            #region Question12

            //12. Get a distinct list of all product categories

            //var result = Source.ProductList.Select(p => p.Category).Distinct();

            #endregion



            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
