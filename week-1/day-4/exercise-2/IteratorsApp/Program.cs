using System.Collections;
using System.Runtime.ExceptionServices;

namespace IteratorsApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
        
            FibonacciSequence fib = new FibonacciSequence(10);

            foreach (int number in fib)
            {
                Console.WriteLine(number);
            }
        }




        // https://www.c-sharpcorner.com/UploadFile/5ef30d/understanding-yield-return-in-C-Sharp/
        // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/yield

        public class FibonacciSequence : IEnumerable
        {
            int count;
            public FibonacciSequence(int count)
            {
                this.count = count;
            }
            public IEnumerator GetEnumerator()
            {// throw new NotImplementedException(); 


                int first = 0;
                int next = 1;


                for (int i = 0; i < count; i++)
                {
                    yield return first;
                    int temp = first;
                    first = next;
                    next = temp + b;
                }

            }

        }
    }
}
