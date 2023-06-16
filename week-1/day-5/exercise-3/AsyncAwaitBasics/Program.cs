using System.Diagnostics;

namespace AsyncAwaitBasics
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Call PerformCalculations and measure time taken using Stopwatch
            int totalTasks = 5;
            Stopwatch sw = Stopwatch.StartNew();
            await PerformCalculations(totalTasks);
            sw.Stop();
            Console.WriteLine($"Total time taken :{sw.ElapsedMilliseconds} milliseconds");

        }

        static async Task SimulateLongRunningTask(int delayInSeconds)
        {
            // Implement long-running task simulation
            Console.WriteLine($"LongProcess Started with {delayInSeconds} ms delay");

            await Task.Delay(delayInSeconds*5000);

            Console.WriteLine($"LongProcess Completed in {delayInSeconds} ms delay");
        }

        static async Task PerformCalculations(int numberOfTasks)
        {
            // Start long-running tasks concurrently and wait for them to complete
            Console.WriteLine($"Starting : {numberOfTasks} Tasks");
            Task[] tasks = new Task[numberOfTasks];
            for (int i = 0; i < numberOfTasks; i++)
            {
                tasks[i]=SimulateLongRunningTask(i+1);
            }
            await Task.WhenAll(tasks);
            Console.WriteLine("ALL TASKS FINISHED");
        }

    }
}