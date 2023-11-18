using System;

namespace SingletonPattern
{
    public class ThreadSafeChuckyKills
    {
        private static ThreadSafeChuckyKills _instance = null;
        private int _killCount = 0;
        private static readonly object _lock = new object();

        static ThreadSafeChuckyKills() 
        { 
        }

        private ThreadSafeChuckyKills() 
        { 
        }

        public static ThreadSafeChuckyKills Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new ThreadSafeChuckyKills();
                        }
                    }
                }
                return _instance;
            }
        }

        public void AddKill()
        {
            lock (_lock)
            {
                _killCount++;
                Console.WriteLine("Total kills #" + _killCount);
            }
        }

        public int TotalKills
        {
            get
            {
                lock (_lock)
                {
                    return _killCount;
                }
            }
        }
    }
}
