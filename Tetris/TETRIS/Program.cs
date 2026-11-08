using System.Timers;



for (int i = 0; i < 20; i++)
{
    Console.SetCursorPosition(0,i);
    Console.WriteLine("XXXXX");
    Thread.Sleep(100);
    Console.Clear();
}