// Parallelism
using System.Diagnostics;
using System.Threading;
public class Parallelism
{
    static short[] numbers = {23, 44, 56, 2, 39, 42, 55, 21};
    public static void Main1()
    {
        // Stopwatch watch = new Stopwatch();
        // watch.Restart();
        // TestSequential();
        // Console.WriteLine("Hello");
        // TestParallel();

    }
    public static void TestSequential()
    {
        foreach(short item in numbers)
        {
            CheckIfItsPrime(item);
        }
    }
    public static void TestParallel()
    {
        // TPL (Task Parallel Library)
        Parallel.ForEach(numbers, item => {
                CheckIfItsPrime(item);
        });
    }
    // Simulation for 1 sec delay
    public static void CheckIfItsPrime(int itemNumber)
    {
        Console.WriteLine($"Processing for item {itemNumber}");
        Thread.Sleep(1000);
        Console.WriteLine($"Done with task {itemNumber}!");
    }
}


public class Asynchronous
{

    // // public static async Task<int> DownloadText()
    // public static async Task DownloadText()
    // {
    //     Console.WriteLine(" s");
    //     // var stringData = await HttpClient.GetStringAsync("https://raw.githubusercontent.com/preslavmihaylov/booknotes/master/README.md");
    //     // Console.WriteLine(stringData);
    // }
}