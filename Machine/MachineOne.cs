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
        Focas1.ODBST oDBST = new Focas1.ODBST();

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
            return ret;
        }
        public short disConectCNC()
        {
            short ret;
            ret = Focas1.cnc_freelibhndl(FLIBHNDL);
            return ret;
        }
        byte MachineInfo.feedRate()
        {
            throw new NotImplementedException();
        }

        string  MachineInfo.machineStatus()
        {
            short ret;
            string statusText = "";
           
            ret = Focas1.cnc_statinfo(FLIBHNDL,oDBST);
            if (ret == Focas1.EW_OK)
            {
                if (oDBST.run == 0 || oDBST.run == 1)
                {
                    statusText = "閒置中";
                }
                else if (oDBST.run == 2)
                {
                    statusText = "準備中";
                }
                else if (oDBST.run == 3)
                {
                    statusText = "運轉中";
                }
                else if (oDBST.emergency != 0 || oDBST.alarm != 0)
                {
                    statusText = "異警中";
                }
            }
            return statusText;
        }

        string MachineInfo.mode()
        {
            string modeStr = "";
            switch (oDBST.aut) 
            {
                case 1:
                    modeStr = "MEMORY";
                break;
                case 3:
                    modeStr = "EDIT";
                    break;
                case 4:
                    modeStr = "HANDLE";
                    break;
                case 5:
                    modeStr = "JOG";
                    break;
                case 6:
                    modeStr = "TEACH IN JOG";
                    break;
                case 7:
                    modeStr = "TEACH IN HANDLE";
                    break;
                case 8:
                    modeStr = "INC.FEED";
                    break;
                case 9:
                    modeStr = "REFERENCE";
                    break;
                case 10:
                    modeStr = "REMOTE";
                    break;
                case 0:
                    modeStr = "MDI";
                    break;
            }
            return modeStr;
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
