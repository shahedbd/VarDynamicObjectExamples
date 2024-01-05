

namespace VarDynamicObjectExamples
{
    public static class ObjectExamples
    {
        public static void BasicExamples()
        {
            // Example 1: Using object to hold different types
            object _object1 = 42;        // An integer
            object _object2 = "Hello";   // A string
            object _object3 = DateTime.Now; // A DateTime object

            // Displaying the values
            Console.WriteLine(_object1);
            Console.WriteLine(_object2);
            Console.WriteLine(_object3);
        }
        public static void ObjectInCollections()
        {
            // Example 2: Using object in a list
            List<object> listOject = new List<object>();
            listOject.Add(505);
            listOject.Add("Hello");
            listOject.Add(DateTime.Now);

            // Iterating through the list
            foreach (object item in listOject)
            {
                Console.WriteLine(item);
            }
        }
        public static void CastingObjectExample()
        {
            // Example 3: Casting object to specific types
            object _object = "123"; // A string

            // Explicit casting to int
            int intValue = Convert.ToInt32(_object);
            Console.WriteLine("Int value: " + intValue);

            // Explicit casting to string
            string _StringValue = (string)_object;
            Console.WriteLine("String value: " + _StringValue);
        }
    }
}
