using System;

namespace SingletonPattern
{
    public class ChuckyKills
    {
        private static ChuckyKills _instance = null;
        private int _killcount = 0;

        private ChuckyKills()
        {
        }

        public static ChuckyKills Instance
        {
            get
            {

                    if (_instance == null)
                    {
                        _instance = new ChuckyKills();
                    }
                    return _instance;
            }
        }

        public void AddKill()
        {
            _killcount++;
            Console.WriteLine("Total kills #" + _killcount);
        }

        public int TotalKills
        {
            get { return _killcount; }
        }
    }
}
