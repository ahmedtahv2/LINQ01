using static LINQ01.Source;
namespace LINQ01

{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Q1
            //var result = ProductList.Where(p => p.Category == "Seafood")
            //                        .Select(p => new { p.ProductName, p.UnitPrice });






            foreach(var i in result)
                Console.WriteLine(i);


        }
    }
}
