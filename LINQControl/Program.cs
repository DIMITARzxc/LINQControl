using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQControl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
        {
                        new Book() { Name = "LINQ", Year = 2019, Author = "Nedilko"},
                        new Book() { Name = "Are u here?", Year = 2015, Author = "Noone" },
                        new Book() { Name = "LINQby Metanit", Year = 2020, Author = "Metanit"},
                        new Book() { Name="Who are u?LINQ?", Year = 2017, Author = "Ivanov" },
                        new Book() { Name = "AppleLINQ", Year = 2012, Author = "Metanit" },
                        new Book() { Name = "Glory for Ukraine", Year = 2014, Author = "Baiden"},

        };
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("First Task:");
            Console.ResetColor();

            Console.WriteLine(string.Join("\n", books.OfType<Book>()
                .Where(b => b.Name.Contains("LINQ") && (DateTime.IsLeapYear(b.Year)))
                .Select(b => b.Name)));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Second task:");
            Console.ResetColor();

            string str = "Complete SQL Mastery";
            Console.WriteLine($"String: {str}");
            var counter = str.GroupBy(c => c).Count();
            Console.WriteLine($"{counter} find letters");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Third task");
            Console.ResetColor();

            int[] arr = new int[] { 21, 23, 14, 12, 32, 33 };
            Console.WriteLine("Given array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ";");

            }
            Console.WriteLine(@"
Sorted:");
            Console.WriteLine(string.Join(", ", arr
                .OrderBy(tmp => tmp / 10).ThenByDescending(tmp => tmp % 10)
                ));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Fourth task");
            Console.ResetColor();

            Console.WriteLine(string.Join("\n", books.OfType<Book>()
               .GroupBy(a => a.Author)
               .Select(value => $"{value.Key}: \t{value.Count()}")));



            Console.ReadLine();
        }
    }
}
