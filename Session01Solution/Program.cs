using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Intrinsics.X86;

namespace Session01Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implicitly Typed Local Variable [var Vs dynamic]
            // when we use the var keyword compilar will automatically detect the data type of the variable based on it's initial value
            //var name = "Ahmed Magdy";

            // we can't just declare a variable with the var keyword without being initialized 
            // var MyName; => invalid

            // we can't also decalare a variable with the var keyword and assign null value to it.
            // var MyName = null; => invalid

            #endregion
            #region Dynamic keyword
            // when we use the CLR keyword compiar will detect the data type of the variable based on the last assigned datatype
            dynamic name = "Ahmed";
            name = 24;
            name = true;

            dynamic flag = null; // we can use null the dynamic

            #endregion
            #region Extension Methods
            int number = 12345;
            Console.WriteLine(intExtension.Reverse(number));
            Console.WriteLine(number.Reverse()); // Extension Method Must be In static And NonGeneric Class
            #endregion
            #region Anonymus Type
            var employee = new { Id = 10, Name = "Ahmed Magdy", Salary = 15000 };
            Console.WriteLine(employee.Id);

            //employee.Id = 50; // this is invalid because the values in any anonyms type is immutable

            employee = employee with { Id = 50, };
            #endregion
            #region What is LINQ
            // stands for Language-Integrated Query
            /*
             * LINQ provides over 40 extension methods.
             * Extension methods are for the built-in interface IEnumerable.
             * These methods are found in the Enumerable class.
             *  LINQ operators can be used against data stored in sequences.
             *  You can use LINQ operators regardless of the data source, such as SQL, Oracle, or MySQL.
             */

            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var oddNumber = numbers.Where(N => N % 2 == 1);
            //foreach(var i  in oddNumber)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region LINQ SYNTAX
            /*List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // 1- Fluent Syntax
            // 1.1 using linq as a static methods
            var oddNumbers = Enumerable.Where(numbers, N => N % 2 == 1).ToList();
            Console.WriteLine(oddNumbers.GetType());

            // 1.2 usin linq operators as an extenstion method
            oddNumbers = numbers.Where(N => N % 2 == 1).ToList();

            // 2Query syntax
            var oddNum = from N in numbers
                         where N % 2 == 1
                         select N;*/
            #endregion
            #region LINQ Excution way
            // Deferred Execution
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var oddNumbers = numbers.Where(number => number % 2 == 1); // without usin toList();

            numbers.AddRange(new int[] {11, 12, 13, 14, 15});
            foreach (var n in oddNumbers)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("*********************************");
            // Imdediate Execution
            List<int> numbers2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var oddNumbers2 = numbers2.Where(number => number % 2 == 1).ToList(); // without usin toList();

            numbers2.AddRange(new int[] { 11, 12, 13, 14, 15 });
            foreach (var n in oddNumbers2)
            {
                Console.WriteLine(n);
            }
            #endregion
        }
    }
}
