using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazePro
{
    class BlockAttribute
    {
       
        public int _X { get; set; }
        public int _Y { get; set; }
        public int blockDirect { get; set; }
        public BlockAttribute(int x, int y, int direct)
        {
            _X = x;
            _Y = y;
            blockDirect = direct;
        }
    }
}
