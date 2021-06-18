using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feature1
{
    interface MachineInfo
    {
        string MachineName { get; set; }
        int MachineStatus();
    }
}
