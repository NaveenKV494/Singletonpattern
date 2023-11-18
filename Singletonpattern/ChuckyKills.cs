using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletonpattern
{
    public class ChuckyKills
    {
        private ChuckyKills _instance = null;
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
            }
            return _instance;
        }
    }

    public void KillsCount()
    {
        _killcount += 1;
        Console.WriteLine("Total kills #" + _killcount);

    }

    public int TotalKills
    {
        get
        {
            return _killcount;
        }
    }
}
