using static Data_Lists.ListGenerator;
namespace Linq_01
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
            #region Restriction Operators
            #region Problem 1
            var result = ProductsList.Where(p => p.UnitsInStock == 0);
            printCollection(result);
            #endregion
            Console.WriteLine();
            Console.WriteLine("<====================================================================================================================>");
            Console.WriteLine();
            #region Problem 2
            var result01 = ProductsList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);
            printCollection(result01);
            #endregion
            Console.WriteLine();
            Console.WriteLine("<====================================================================================================================>");
            Console.WriteLine();
            #region Problem 3
            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var result03 = Arr.Where((n, i) => n.Length < i);
            printCollection(result03);
            #endregion
            #endregion
            Console.WriteLine();
            Console.WriteLine("<================================================Element Operators====================================================================>");
            Console.WriteLine();
            #region Element Operators
            #region Problem 1
            var result04 = ProductsList.First(p => p.UnitsInStock == 0);
            Console.WriteLine(result04);
            #endregion
            Console.WriteLine();
            Console.WriteLine("<====================================================================================================================>");
            Console.WriteLine();
            #region Problem 2
            var result05 = ProductsList.FirstOrDefault(p => p.UnitPrice > 100);
            Console.WriteLine(result05);
            #endregion
            Console.WriteLine();
            Console.WriteLine("<====================================================================================================================>");
            Console.WriteLine();
            #region Problem 3
            int[] Arr01 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var result06 = Arr01.Where(n => n > 5).Skip(1).FirstOrDefault();
            Console.WriteLine(result06);
            #endregion
            #endregion
            Console.WriteLine();
            Console.WriteLine("<=============================================================Aggregate Operators=======================================================>");
            Console.WriteLine();
            #region Aggregate Operators
            #region Problem 1
            int[] arrAgg1 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int oddCountAgg1 = arrAgg1.Where(n => n % 2 != 0).Count();
            Console.WriteLine(oddCountAgg1);
            #endregion
            Console.WriteLine();
            Console.WriteLine("<====================================================================================================================>");
            Console.WriteLine();
            #region Problem 2
            var resultAgg2 = CustomersList.Select(c=> new
            {
                customer = c.CustomerID,
                customerName = c.CustomerName,
                ordersCount = c.Orders.Count()
            });
            printCollection(resultAgg2);
            #endregion
            Console.WriteLine();
            Console.WriteLine("<====================================================================================================================>");
            Console.WriteLine();
            #region Problem 3
            var resultAgg3 = ProductsList.GroupBy(p => p.Category).Select(c=> new
            {
                Category = c.Key,
                ProductCount = c.Count()
            });
            printCollection(resultAgg3);
            #endregion
            Console.WriteLine();
            Console.WriteLine("<====================================================================================================================>");
            Console.WriteLine();
            #region Problem 4

            #endregion
            Console.WriteLine();
            Console.WriteLine("<====================================================================================================================>");
            Console.WriteLine();
            #region Problem 5

            #endregion
            Console.WriteLine();
            Console.WriteLine("<====================================================================================================================>");
            Console.WriteLine();
            #region Problem 6

            #endregion
            Console.WriteLine();
            Console.WriteLine("<====================================================================================================================>");
            Console.WriteLine();
            #region Problem 7

            #endregion
            Console.WriteLine();
            Console.WriteLine("<====================================================================================================================>");
            Console.WriteLine();
            #region Problem 8

            #endregion
            #endregion
            Console.WriteLine();
            Console.WriteLine("<=================================================================Ordering Operators===================================================>");
            Console.WriteLine();
            #region Ordering Operators
            #region Problem 1
            var resultO1 = ProductsList.OrderBy(p => p.ProductName);
            printCollection(resultO1);
            #endregion
            Console.WriteLine();
            Console.WriteLine("<====================================================================================================================>");
            Console.WriteLine();
            #region Problem 2
            string[] ArrO2 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var resultO2 = ArrO2.OrderBy(w => w, StringComparer.OrdinalIgnoreCase);
            printCollection(resultO2);
            #endregion
            Console.WriteLine();
            Console.WriteLine("<====================================================================================================================>");
            Console.WriteLine();
            #region Problem 3
            var resultO3 = ProductsList.OrderByDescending(p => p.UnitsInStock);
            printCollection(resultO3);
            #endregion
            Console.WriteLine();
            Console.WriteLine("<====================================================================================================================>");
            Console.WriteLine();
            #region Problem 4
            string[] ArrO4 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var resultO4 = ArrO4.OrderBy(e => e.Length).ThenBy(e => e);
            printCollection(resultO4);
            #endregion
            Console.WriteLine();
            Console.WriteLine("<====================================================================================================================>");
            Console.WriteLine();
            #region Problem 5
            string[] ArrO5 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var resultO5 = ArrO5.OrderBy(w => w.Length).ThenBy(w => w, StringComparer.OrdinalIgnoreCase);
            printCollection(resultO5);
            #endregion
            Console.WriteLine();
            Console.WriteLine("<====================================================================================================================>");
            Console.WriteLine();
            #region Problem 6
            var resultO6 = ProductsList.OrderByDescending(p => p.Category).ThenByDescending(p => p.UnitPrice);
            printCollection(resultO6);
            #endregion
            Console.WriteLine();
            Console.WriteLine("<====================================================================================================================>");
            Console.WriteLine();
            #region Problem 7
            string[] ArrO7 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var resultO7 = ArrO7.OrderBy(w => w.Length).ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase);
            printCollection(resultO7);
            #endregion
            Console.WriteLine();
            Console.WriteLine("<====================================================================================================================>");
            Console.WriteLine();
            #region Problem 8
            string[] ArrO8 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var resultO8 = ArrO8.Where(word => word.Length > 1 && word[1] == 'i').Reverse();
            printCollection(resultO8);
            #endregion
            #endregion
            Console.WriteLine();
            Console.WriteLine("<=================================================================Transformation Operators===================================================>");
            Console.WriteLine();
            #region Transformation Operators
            #region Problem 1
            var resultT1 = ProductsList.Select(p => p.ProductName);
            printCollection(resultT1);
            #endregion
            Console.WriteLine();
            Console.WriteLine("<====================================================================================================================>");
            Console.WriteLine();
            #region Problem 2
            string[] wordsT2 = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            var resultT2 = wordsT2.Select(w => new
            {
                Upper = w.ToUpper(),
                Lower = w.ToLower(),
            });
            printCollection(resultT2);
            #endregion
            Console.WriteLine();
            Console.WriteLine("<====================================================================================================================>");
            Console.WriteLine();
            #region Problem 3
            var resultT3 = ProductsList.Select(p => new
            {
                p.ProductName,
                Price = p.UnitPrice,
                p.Category
            });
            printCollection(resultT3);
            #endregion
            Console.WriteLine();
            Console.WriteLine("<====================================================================================================================>");
            Console.WriteLine();
            #region Problem 4
            int[] ArrT4 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var resultT4 = ArrT4.Select((n, i) =>
            {
                return $"{n}: {n == i}";
            });
            Console.WriteLine("Numbers in place");
            printCollection(resultT4);
            #endregion
            Console.WriteLine();
            Console.WriteLine("<====================================================================================================================>");
            Console.WriteLine();
            #region Problem 5
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var resultT5 = numbersA.SelectMany(na => numbersB.Where(nb => nb > na).Select(nb =>
            {
                return $"{na} is less than {nb}";
            }));
            printCollection(resultT5);
            #endregion
            Console.WriteLine();
            Console.WriteLine("<====================================================================================================================>");
            Console.WriteLine();
            #region Problem 6
            var resultT6 = CustomersList.SelectMany(c => c.Orders.Where(o => o.Total < 500));
            printCollection(resultT6);  
            #endregion
            Console.WriteLine();
            Console.WriteLine("<====================================================================================================================>");
            Console.WriteLine();
            #region Problem 7
            var resultT7 = CustomersList.SelectMany(c => c.Orders.Where(o => o.OrderDate.Year >= 1998));
            printCollection(resultT7);
            #endregion
            #endregion
        }
    }
}