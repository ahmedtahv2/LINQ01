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






            foreach (var i in result)
                Console.WriteLine(i);


        }
    }
}
