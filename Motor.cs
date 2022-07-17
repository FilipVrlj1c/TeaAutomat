using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace RacunalniSustaviProjekt
{
    class Motor
    {
        [DllImport("stp.dll")]
        public static extern int InitStp();
        [DllImport("stp.dll")]
        public static extern bool RunMotor1(int steps, int interval, int direction, int outputs);
        [DllImport("stp.dll")]
        public static extern bool StopMotor1(int outputs);
    }
}
