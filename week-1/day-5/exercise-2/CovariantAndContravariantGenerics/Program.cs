namespace CovariantAndContravariantGenerics
{
    interface IProcessor<in TInput, out TResult>
    {
        TResult Process(TInput input);
    }

    class StringToIntProcessor : IProcessor<string, int>
    {
        // Implement Process method
        public int Process(string input)
        {
            int legth = input.Length;
            return legth;
        }
    }

    class DoubleToStringProcessor : IProcessor<double, string>
    {
        // Implement Process method
        public string Process(double input)
        {
           string str = input.ToString();
            return str;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Demonstrate covariance and contravariance with IProcessor interface
            IProcessor<string,int> processor = new StringToIntProcessor();
            string str = "This is Covariance";
            object obj = processor.Process(str);
            Console.WriteLine("Covariance");
            Console.WriteLine($"Length of input string is {obj}");

            IProcessor<double,string> processor1 = new DoubleToStringProcessor();
            double inputDouble = 3.14;
            Console.WriteLine("Cotravarient");
            string sresult=processor1.Process(inputDouble);
            Console.WriteLine($"The string representation is{sresult}");



        }
       
    }
}