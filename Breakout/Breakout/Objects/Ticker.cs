using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breakout.Objects
{
    class Ticker : Timer
    {
        public Ticker()
        {
            this.Interval = 1;
            this.Enabled = true;
        }
    }
}
