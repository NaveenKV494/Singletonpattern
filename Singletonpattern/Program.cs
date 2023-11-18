using SingletonPattern;
using System;

namespace SingletonPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadSafeChuckyKills chucky = ThreadSafeChuckyKills.Instance;
            chucky.AddKill();
            chucky.AddKill();
            chucky.AddKill();
            chucky.AddKill();
            chucky.AddKill();

            Console.WriteLine("Total kills: " + chucky.TotalKills);

            
            ThreadSafeChuckyKills anotherChucky = ThreadSafeChuckyKills.Instance;
            anotherChucky.AddKill();

            Console.WriteLine("Total kills: " + chucky.TotalKills);
            Console.WriteLine("Total kills from another instance: " + anotherChucky.TotalKills);
        }
    }
}
