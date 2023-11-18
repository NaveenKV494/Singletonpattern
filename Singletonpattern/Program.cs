using SingletonPattern;
using System;

namespace SingletonPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ChuckyKills chucky = ChuckyKills.Instance;
            chucky.AddKill();
            chucky.AddKill();
            chucky.AddKill();
            chucky.AddKill();
            chucky.AddKill();

            Console.WriteLine("Total kills: " + chucky.TotalKills);

            
            ChuckyKills anotherChucky = ChuckyKills.Instance;
            anotherChucky.AddKill();

            Console.WriteLine("Total kills: " + chucky.TotalKills);
            Console.WriteLine("Total kills from another instance: " + anotherChucky.TotalKills);
        }
    }
}
