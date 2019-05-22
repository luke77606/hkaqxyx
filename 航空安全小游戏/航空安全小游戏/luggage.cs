using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 航空安全小游戏
{
    class luggage
    {
        string name;
        bool dangerous;
         public luggage(string name,bool d)
        {
            dangerous = d;
            this.name = name;
        }
    }
}
