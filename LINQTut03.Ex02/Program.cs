using LINQTut03.Shared;

namespace LINQTut03.Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var evenNumbers = numbers.Where(x => x % 2 == 0); // construction (lazy loading)

            // Extension Where
            var evenNumbersUsingExtensionWhere =
                numbers.Where(x => x % 2 == 0);

            // Enumerable Where Method
            var evenNumbersUsingEnumerableWhereMethod =
                Enumerable.Where(numbers, x => x % 2 == 0);

            // Query Syntax
            // Select n fROM numbers where n % 2 = 0;
            var evenNumbersUsingQuerySyntax =
                 from n in numbers
                 where n % 2 == 0
                 select n;


            numbers.Add(10);
            numbers.Add(12);
            numbers.Remove(4);

            // [1]  ===>   2, 4, 6, 8
            // [2]  ===>   2, 6, 8, 10, 12
            //foreach (var number in evenNumbersUsingQuerySyntax) // enumeration (immediate execution)
            //{
            //    Console.WriteLine(number);
            //}

            evenNumbersUsingExtensionWhere.Print("evenNumbersUsingExtensionWhere");
            evenNumbersUsingEnumerableWhereMethod.Print("evenNumbersUsingEnumerableWhereMethod");
            evenNumbersUsingQuerySyntax.Print("evenNumbersUsingQuerySyntax");


        }
    }
}
