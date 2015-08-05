using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extensions;

namespace Csling.cs
{
     class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> cities = new[] { "Ghent", "London", "Las Vegas", "Hyderabad" };

            IEnumerable<string> query =
                cities.StringsThatStartWith("L");

            foreach (var city in query)
            {
                Console.WriteLine(city);
            }
        }
    }
}
namespace Extensions
{
    public static class FilterExtensions
    {
        public static IEnumerable<string> StringsThatStartWith
            (this IEnumerable<string> input, string start)
        {
            foreach (var s in input)
            {
                if (s.StartsWith(start))
                    {
                    yield return s;
                }
            }
        }
    }

}