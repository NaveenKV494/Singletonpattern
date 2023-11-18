using SingletonPattern;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SingletonPatternExample
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    ThreadSafeChuckyKills chucky = ThreadSafeChuckyKills.Instance;
        //    chucky.AddKill();
        //    chucky.AddKill();
        //    chucky.AddKill();
        //    chucky.AddKill();
        //    chucky.AddKill();

        //    Console.WriteLine("Total kills: " + chucky.TotalKills);

            
        //    ThreadSafeChuckyKills anotherChucky = ThreadSafeChuckyKills.Instance;
        //    anotherChucky.AddKill();

        //    Console.WriteLine("Total kills: " + chucky.TotalKills);
        //    Console.WriteLine("Total kills from another instance: " + anotherChucky.TotalKills);
        //}

            public static void Main(string[] args)
            {
                var numbers = Enumerable.Range(0, 10);

                Parallel.ForEach(numbers, i =>
                {
                    var ck = ThreadSafeChuckyKills.Instance;
                    ck.AddKill();
                });

                Console.WriteLine(ThreadSafeChuckyKills.Instance.TotalKills);
            }
    }
 }

