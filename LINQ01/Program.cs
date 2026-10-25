using static LINQ01.Source;
namespace LINQ01

{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1
            //var result = ProductList.Where(p => p.Category == "Seafood")
            //                        .Select(p => new { p.ProductName, p.UnitPrice }); 
            #endregion

            #region Q2
            //var result = ProductList.Select(p => p.ProductName); 
            #endregion

            #region Q3
            //var result = ProductList.OrderBy(p => p.UnitPrice)
            //                        .Select(p => $"Name:{p.ProductName} - Price:{p.UnitPrice}"); 
            #endregion

            #region Q4

            //var result = ProductList.Where(p => p.UnitPrice>=10 && p.UnitPrice<=30)
            //                        .Select(p => p); 
            #endregion

            #region Q5
            //var result = ProductList.Where(p => p.UnitsInStock>0 && p.Category == "Condiments")
            //                        .Select(p =>p); 
            #endregion

            #region Q6
            //var result = ProductList.Select(p => new {
            //    Name=p.ProductName,
            //    Price=p.UnitPrice,
            //    StockStatus=p.UnitsInStock>0?"Available" :"Out of stock"
            //}); 
            #endregion

            #region Q7
            //var result = ProductList.Select((p , i) =>  $"{i+1}. {p.ProductName}");
            #endregion

            #region Q8
            //var result = ProductList.OrderBy(p => p.Category)
            //                        .ThenByDescending(p => p.UnitPrice)
            //                        .Select(p => p); 
            #endregion

            #region Q9
            //var result = ProductList.Where(p => p.Category == "Beverages")
            //                        .OrderByDescending(p => p.UnitsInStock)
            //                        .Select(p => $"Name:{p.ProductName} - Stock:{p.UnitsInStock}"); 
            #endregion

            #region Q10
            //var result = from c in CustomerList
            //             from o in c.Orders
            //             where o.OrderDate.Year >= 1997
            //             select new
            //             {
            //                 c.CustomerID,
            //                 o.OrderID
            //             }; 
            #endregion

            #region Q11
            //var result = ProductList.Select((p, i) => $"{i + 1}-{p.ProductName}");

            #endregion

            #region Q12
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(p => p.Length)
            //                .ThenBy(p => p , StringComparer.OrdinalIgnoreCase ); 
            #endregion








            foreach (var i in result)
                Console.WriteLine(i);


        }
    }
}
