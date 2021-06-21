using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feature1.Machine
{
    class Machines
    {
        static ushort FLIBHNDL;
        static string MachName;


        public static short ConnectCNC(string ip, ushort port)
        {
            short ret;
            ret = Focas1.cnc_allclibhndl3(ip, port, 10, out FLIBHNDL);
            return ret;
        }
        
        public static short DisconnectCNC() 
        {
            short ret;
            ret = Focas1.cnc_freelibhndl(FLIBHNDL);
            return ret;
        }
        public static short MachStatus(ref Focas1.ODBST oDBST) 
        {
            
            short ret;
            ret = Focas1.cnc_statinfo(FLIBHNDL, oDBST);
            return ret;
        }

        public static short PMCReadMsg() 
        {
            short pmcRet;
            ushort length = 3008;
            //Focas1.IODBPMC0 iODBPMC = new Focas1.IODBPMC0();
            byte[] bytes = new byte[length];
            pmcRet = Focas1.pmc_rdpmcrng(FLIBHNDL, (short)AdrType.R, (short)DataType.Word, 0, 1499, length, bytes);
            for (int idx = 0; idx < length; idx++)
            {
                Console.WriteLine("#{0}  0x{1:X2}", idx, bytes[8 + idx]);
            }
            return pmcRet;
        }
  
        public enum AdrType 
        { 
            G = 0,
            F = 1,
            Y = 2,
            X = 3,
            A = 4,
            R = 5,
            T = 6,
            K = 7,
            C = 8,
            D = 9,
            M = 10,
            N = 11,
            E = 12,
            Z = 13
        }

        public enum DataType
        {
            Byte = 0,
            Word = 1,
            Long = 2
        }

    }
}
