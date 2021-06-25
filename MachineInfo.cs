using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feature1
{
    interface MachineInfo
    {
        string IP { get; set; }
        ushort  PORT { set; }
        string machineName { get; set; }
        int axis();
        string  machineStatus();
        byte tool();
        byte spindle();
        string mode();
        byte rapid();
        byte feedRate();
        short connectCNC();
        short disConectCNC();
        short current();

    }
}
