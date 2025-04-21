======================
C# Infinite Examples
======================

// Simple Infinite Loop
while (true)
{
    Console.WriteLine("This is an infinite loop");
}

// Infinite Loop with Thread
using System.Threading;

Thread thread = new Thread(() => {
    while (true)
    {
        Console.WriteLine("Thread is running");
        Thread.Sleep(1000);
    }
});
thread.Start();

// Infinite Process with Task
using System.Threading.Tasks;

Task.Run(async () => {
    while (true)
    {
        await Task.Delay(1000);
        Console.WriteLine("Ran again after waiting");
    }
});