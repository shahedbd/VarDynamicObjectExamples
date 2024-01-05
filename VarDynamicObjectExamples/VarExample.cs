namespace VarDynamicObjectExamples
{
    public static class VarExample
    {
        public static void BasicExample()
        {
            // Example 1: Implicitly typed variable
            var _Message = "Hello, World!"; // Compiler infers the type as string
            Console.WriteLine(_Message);

            // Example 2: var with a collection
            var _Numbers = new int[] { 1, 2, 3, 4, 5 }; // Compiler infers the type as int[]
            foreach (var number in _Numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // Example 3: var in LINQ query
            var _EvenNumbers = from num in _Numbers
                               where num % 2 == 0
                               select num; // Compiler infers the type based on the LINQ query result
            Console.WriteLine("Even numbers: " + string.Join(", ", _EvenNumbers));

            // Example 4: var with anonymous types
            var _Person = new { Name = "John", Age = 30 }; // Compiler creates an anonymous type
            Console.WriteLine($"Name: {_Person.Name}, Age: {_Person.Age}");

            // Example 5: var with method return
            var _Length = GetStringLength("Hello"); // Compiler infers the type as int
            Console.WriteLine("Length of the string: " + _Length);
        }

        // Example method
        static int GetStringLength(string input)
        {
            return input.Length;
        }
    }
}
