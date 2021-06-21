using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feature1.Machine
{
    class MachineOne : MachineInfo
    {
        private string IP;
        private ushort PORT;
        private int timeout = 10;
        private ushort FLIBHNDL;
        private string machineName;


        string MachineInfo.machineName { get => machineName; set => machineName = value; }
        string MachineInfo.IP { set => this.IP = value; }
        ushort MachineInfo.PORT { set => this.PORT = value; }

        int MachineInfo.axis()
        {
            
            throw new NotImplementedException();
        }

        short MachineInfo.connectCNC()
        {
            short ret;
            //Console.WriteLine(IP);
            ret = Focas1.cnc_allclibhndl3(IP, PORT, 10, out FLIBHNDL);
            return ret=1;
        }

        byte MachineInfo.feedRate()
        {
            throw new NotImplementedException();
        }

        int MachineInfo.machineStatus()
        {
            throw new NotImplementedException();
        }

        byte MachineInfo.mode()
        {
            throw new NotImplementedException();
        }

        byte MachineInfo.rapid()
        {
            throw new NotImplementedException();
        }

        byte MachineInfo.spindle()
        {
            throw new NotImplementedException();
        }

        byte MachineInfo.tool()
        {
            throw new NotImplementedException();
        }
    }
}
