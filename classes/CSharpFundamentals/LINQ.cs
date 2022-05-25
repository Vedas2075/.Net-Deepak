// // Language Integrated Query (LINQ)
// using System.Linq;
// using System.Collections.Generic;

// public class Query
// {
//     byte[] numbers = { 23, 45, 67, 12, 20, 21, 43, 54, 76, 90 };
//     List<Person> people = new()
//     {
//         new Person { Name = "Ram", Address = "Ktm", Gen = 'm'},
//         new Person { Name = "Ram1", Address = "Ktm", Gen = 'm'},
//         new Person { Name = "Ram2", Address = "Ktm", Gen = 'm'},
//         new Person { Name = "Hari", Address = "Ctwn", Gen = 'm'},
//         new Person { Name = "Harilaxmi", Address = "Ctwn", Gen = 'f'},
//         new Person { Name = "Hari2", Address = "Ctwn", Gen = 'm'}
//     };

//     public void Test()
//     {
//         // List all odd numbers
//         var oddNumbers = numbers.Where(number => number % 2 != 0);

//         // List all even numbers greater than 50
//         var numbersGreaterThan50 = numbers.Where(x => x > 50 && x % 2 == 0);
//         numbersGreaterThan50 = from num in numbers
//                                where num > 50 && num % 2 == 0
//                                select num;

//         // Get squares of all elements
//         var squares = numbers.Select(y => y * y);

//         // Check if collection has number greater than 100
//         var x = numbers.Any(x => x > 100);
//         var y = numbers.All(x => x > 100);

//         // Skip and take
//         var z = numbers.Skip(5).Take(4);

//         // ordering
//         var orderedNumbers = numbers.OrderBy(x => x).Select(x => x);

//         // Expression Syntax
//         var orderedNumbers1 = from number in numbers
//                               orderby x
//                               select x;

//         // List all persons who lives in kathmandu
//         // var ktmNiwasi = people.Where(x => x.Address == "ktm");

//         // List all males whose name starts with letter 'h/H'
        
//     }
// }