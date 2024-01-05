
using System.Dynamic;
using System.Text.Json;

namespace VarDynamicObjectExamples
{
    public static class DynamicExamples
    {
        public static void BasicExample()
        {
            // Example 1: Using dynamic for a string
            dynamic _DynamicString = "Hello, Dynamic!";
            Console.WriteLine(_DynamicString);

            // Example 2: Using dynamic with an integer
            dynamic _DynamicNumber = 42;
            Console.WriteLine(_DynamicNumber);

            // Example 3: Concatenating dynamic variables
            dynamic result = _DynamicString + _DynamicNumber;
            Console.WriteLine(result);
        }

        public static void GetInvokeDynamicMethod()
        {
            // Example 4: Dynamic with method invocation
            dynamic result2 = InvokeDynamicMethod("Dynamic Method");
            Console.WriteLine(result2);
        }

        // Another example method
        public static dynamic InvokeDynamicMethod(string input)
        {
            // Some dynamic logic based on the input
            return "Result: " + input.ToUpper();
        }

        public static void JSONDeserialization()
        {
            // Example 5: Deserializing JSON to dynamic
            string json = "{\"Name\": \"John\", \"Age\": 30}";
            dynamic _DynamicObject = JsonSerializer.Deserialize<ExpandoObject>(json);

            Console.WriteLine($"Name: {_DynamicObject.Name}, Age: {_DynamicObject.Age}");
        }
    }
}
