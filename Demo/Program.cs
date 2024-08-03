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
            //In the following things if sequence is empty exception will be thrown
            var first = ProductsList.First();
            var firstWithCondition = ProductsList.First(p => p.UnitPrice > 20);
            Console.WriteLine(first);
            Console.WriteLine(firstWithCondition);
            Console.WriteLine("<========================================>");
            first = ProductsList.FirstOrDefault();
            firstWithCondition = ProductsList.FirstOrDefault(p => p.UnitPrice > 20);
            Console.WriteLine(first?.ToString() ?? "Not found");
            Console.WriteLine(firstWithCondition?.ToString() ?? "Not found");

            //In the following things if sequence is empty exception will be thrown
            var last = ProductsList.Last();
            var lastWithCondition = ProductsList.Last(p => p.UnitPrice > 20);
            Console.WriteLine(last);
            Console.WriteLine(lastWithCondition);
            Console.WriteLine("<========================================>");
            last = ProductsList.LastOrDefault();
            lastWithCondition = ProductsList.LastOrDefault(p => p.UnitPrice > 20);
            Console.WriteLine(last?.ToString() ?? "Not found");
            Console.WriteLine(lastWithCondition?.ToString() ?? "Not found");


            //In the following things if sequence is empty exception will be thrown
            var element = ProductsList.ElementAt(2);
            Console.WriteLine(element);
            Console.WriteLine("<========================================>");
            element = ProductsList.ElementAtOrDefault(999);
            Console.WriteLine(element?.ToString() ?? "Not found");
            #endregion
        }
    }
}