using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazePro
{
    class OneStepAttribute
    {
        public int path_x { get; set; }
        public int path_y { get; set; }
        public int direct { get; set; }
        public OneStepAttribute(int x,int y,int d)
        {
            path_x = x;
            path_y = y;
            direct = d;
        }
    }
}
