namespace StackApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stack<int> intStack = new Stack<int>();
            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);
            Console.WriteLine(intStack.Pop()); // Output: 3
            Console.WriteLine(intStack.Pop()); // Output: 2
            Console.WriteLine(intStack.IsEmpty()); // Output: False
            
           Stack<float> floatStack = new Stack<float>();
            floatStack.Push(8.8f);
            floatStack.Push(2.3f);
            Console.WriteLine(floatStack.Pop());
            Console.WriteLine(floatStack.Pop());
            Console.WriteLine(floatStack.IsEmpty());

            Stack<string> stringStack = new Stack<string>();
            stringStack.Push("Hello");
            stringStack.Push("26 ");
            Console.WriteLine(stringStack.Pop());
            Console.WriteLine(stringStack.Pop());
            Console.WriteLine(stringStack.IsEmpty());


        }
    }
}