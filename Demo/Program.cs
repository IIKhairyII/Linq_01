using static Data_Source.ListGenerator;
namespace Demo
{
    internal class Program
    {
        static void printCollection<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            #region Linq Fluent and query syntax
            //List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var result = Enumerable.Where(numbers, n => n % 2 != 0);
            //printCollection(result);
            //Console.WriteLine("<========================================>");
            //result = numbers.Where(n => n % 2 != 0);
            //printCollection(result);
            //Console.WriteLine("<========================================>");
            //result = from n in numbers
            //         where n % 2 != 0
            //         select n;
            //printCollection(result);
            //Console.WriteLine("<========================================>");
            #endregion
            #region Linq Execution
            ////Deferred
            //List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var result = Enumerable.Where(numbers, n => n % 2 != 0);
            //numbers.AddRange(new List<int>() { 10, 11, 12, 13, 14 });
            //printCollection(result);
            ////Immediate
            //List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var result = Enumerable.Where(numbers, n => n % 2 != 0).ToList();
            //numbers.AddRange(new List<int>() { 10, 11, 12, 13, 14 });
            //printCollection(result);
            #endregion
            #region Filtration [Restrication] Operators
            #region Pb 1
            //var result = ProductsList.Where(p => p.UnitsInStock == 0);
            //printCollection(result);
            //Console.WriteLine("<=================================>");
            //result = from p in ProductsList
            //         where p.UnitsInStock == 0
            //         select p;
            //printCollection(result);
            //Console.WriteLine("<=================================>");
            #endregion
            #region Pb 2
            //var result = ProductsList.Where(p => p.UnitsInStock == 0 && p.Category == "Meat/Poultry");
            //printCollection(result);
            //Console.WriteLine("<=================================>");
            //result = from p in ProductsList
            //         where p.UnitsInStock == 0 && p.Category == "Meat/Poultry"
            //         select p;
            //printCollection(result);
            //Console.WriteLine("<=================================>");
            #endregion
            #region Pb 3
            //var result = ProductsList.Where((p, i) => p.UnitsInStock == 0 && i <= 10);
            //printCollection(result);
            #endregion
            #endregion
            #region Transformation [Projection] Operators
            #region Pb 1
            //var result = ProductsList.Select(p=>p.ProductName);
            //printCollection(result);
            //Console.WriteLine("<==================================>");
            //result = from p in ProductsList
            //         select p.ProductName;
            //printCollection(result);
            #endregion
            #region Pb 2
            //var result = CustomersList.Select(p => p.CustomerName);
            //printCollection(result);
            //Console.WriteLine("<==================================>");
            //result = from c in CustomersList
            //         select c.CustomerName;
            //printCollection(result);
            #endregion
            #region Pb 3
            //var result = CustomersList.SelectMany(c => c.Orders);   
            //printCollection(result);
            //Console.WriteLine("<==================================>");
            //result = from c in CustomersList
            //         from o in c.Orders
            //         select o;
            //printCollection(result);
            #endregion
            #region Pb 4
            //var result = ProductsList.Select(p => new
            //{
            //    p.ProductID,
            //    p.ProductName
            //});
            //printCollection(result);
            //Console.WriteLine("<==================================>");
            //result = from p in ProductsList
            //         select new
            //         {
            //             p.ProductID,
            //             p.ProductName
            //         };
            //printCollection(result);
            #endregion
            #region Pb 5
            //var result = ProductsList.Select(p => new
            //{
            //    p.ProductID,
            //    p.ProductName,
            //    oldPrice = p.UnitPrice,
            //    Price = p.UnitPrice * 0.9m
            //});
            //printCollection(result);
            //Console.WriteLine("<==================================>");
            //result = from p in ProductsList
            //         select new
            //         {
            //             p.ProductID,
            //             p.ProductName,
            //             oldPrice = p.UnitPrice,
            //             Price = p.UnitPrice * 0.9m
            //         };
            //printCollection(result);
            #endregion
            #endregion
            #region Ordering Operators
            #region Pb 1
            //var result = ProductsList.OrderBy(p => p.UnitPrice);
            //printCollection(result);
            //Console.WriteLine("<=========================================================>");
            //result = from p in ProductsList
            //         orderby p.UnitPrice
            //         select p;
            //printCollection(result);
            #endregion
            #region Pb 2
            //var result = ProductsList.OrderByDescending(p => p.UnitPrice);
            //printCollection(result);
            //Console.WriteLine("<=========================================================>");
            //result = from p in ProductsList
            //         orderby p.UnitPrice descending
            //         select p;
            //printCollection(result);
            #endregion
            #region Pb 3
            //var result = ProductsList.OrderBy(p => p.UnitPrice).ThenByDescending(p => p.UnitsInStock);
            //printCollection(result);
            //Console.WriteLine("<=========================================================>");
            //result = from p in ProductsList
            //         orderby p.UnitPrice, p.UnitsInStock descending
            //         select p;
            //printCollection(result);
            #endregion
            #endregion
            #region Elements Operator

            #endregion
        }
    }
}