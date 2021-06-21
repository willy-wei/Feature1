using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feature1
{
    interface MachineInfo
    {
        string IP { set;}
        ushort  PORT { set; }
        string machineName { get; set; }
        int axis();
        int machineStatus();
        byte tool();
        byte spindle();
        byte mode();
        byte rapid();
        byte feedRate();
        short connectCNC();


    }
}
