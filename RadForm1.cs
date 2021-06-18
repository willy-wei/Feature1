using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using static Feature1.Machine.Machines;

namespace Feature1
{
    
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        
        public RadForm1()
        {
            InitializeComponent();
            
            
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            try
            {

                Thread t1 = new Thread(new ParameterizedThreadStart(dowork));
                t1.IsBackground = true;
                t1.Start("192.168.1.1");
                Thread t2 = new Thread(new ParameterizedThreadStart(dowork1));
                t2.Start("192.168.1.2");

               

                timer1.Enabled = true;
                timer1.Start();
                timer1.Interval = 1000 * 25;
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1);
            }




            machOne.btnClick += ConMonitor_Click;
            //machOne.paintChange += machOne_Paint;

        }
        
        void ConMonitor_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show("狀態監視");
            machOne.CncName = "OKK";
            machOne.CncStrForeColor = Color.Green;*/
            //machOne.CncStrStatus = "運轉中";


        }

        private void machOne_Paint(object sender, PaintEventArgs e)
        {
            if (machOne.CncStrStatus == "運轉中")
            {
                ControlPaint.DrawBorder(e.Graphics, this.machOne.ClientRectangle, Color.Green, ButtonBorderStyle.Inset);
            }
            else if (machOne.CncStrStatus == "停止中")
            {
                ControlPaint.DrawBorder(e.Graphics, this.machOne.ClientRectangle, Color.Black, ButtonBorderStyle.Inset);
            }
            else if (machOne.CncStrStatus == "閒置中")
            {
                ControlPaint.DrawBorder(e.Graphics, this.machOne.ClientRectangle, Color.White, ButtonBorderStyle.Inset);
            }
        }
        private void machTwo_Paint(object sender, PaintEventArgs e)
        {
            if (machTwo.CncStrStatus == "運轉中")
            {
                ControlPaint.DrawBorder(e.Graphics, this.machTwo.ClientRectangle, Color.Green, ButtonBorderStyle.Inset);
            }
            else if (machTwo.CncStrStatus == "準備中")
            {
                ControlPaint.DrawBorder(e.Graphics, this.machTwo.ClientRectangle, Color.Yellow, ButtonBorderStyle.Inset);
            }
            else if (machTwo.CncStrStatus == "閒置中")
            {
                ControlPaint.DrawBorder(e.Graphics, this.machTwo.ClientRectangle, Color.White, ButtonBorderStyle.Inset);
            }
        }

        void MachNumber(object ip)
        {
            short ret = ConnectCNC((string)ip, 8193);

            if (ret == Focas1.EW_OK)
            {
                Focas1.ODBST oDBST = new Focas1.ODBST();
                short statRet;
                //Console.WriteLine(PMCReadMsg());  
                statRet = MachStatus(ref oDBST);
                if (statRet == Focas1.EW_OK)
                {
                    Console.WriteLine(oDBST.run + " " + ip + " " + DateTime.Now);
                    Console.WriteLine("mstb :" + oDBST.mstb + " " + ip + " " + DateTime.Now);
                    if (oDBST.run == 3)
                    {
                        machOne.CncStrStatus = "運轉中";
                        machOne.paintChange += machOne_Paint;
                        this.Refresh();//強制控制項使其工作區失效，並且立即重繪其本身和任何子控制項。
                    }
                    if (oDBST.run == 0 || oDBST.run == 1) 
                    {
                        machOne.CncStrStatus = "閒置中";
                        machOne.paintChange += machOne_Paint;
                        this.Refresh();
                    }
                    if (oDBST.run == 2)
                    {
                        machOne.CncStrStatus = "準備中";
                        machOne.paintChange += machOne_Paint;
                        this.Refresh();
                    }
                }
               
                //machOne.CncName = "OKK";

                /*short uret = uconnectCNC();
                Console.WriteLine(uret);*/
            }
        }
        void MachNumber2(object ip)
        {
            short ret = ConnectCNC((string)ip, 8193);

            if (ret == Focas1.EW_OK)
            {
                Focas1.ODBST oDBST = new Focas1.ODBST();
                short statRet;

                statRet = MachStatus(ref oDBST);
                if (statRet == Focas1.EW_OK)
                {
                    Console.WriteLine(oDBST.run+" "+ip + " " + DateTime.Now);
                    Console.WriteLine("mstb :"+oDBST.mstb + " " + ip+" "+DateTime.Now);
                    //short rret = PMCReadMsg();
                    //Console.WriteLine(rret);
                    if (oDBST.run == 3)
                    {
                        machTwo.CncStrStatus = "運轉中";
                        machTwo.paintChange += machTwo_Paint;
                        this.Refresh();//強制控制項使其工作區失效，並且立即重繪其本身和任何子控制項。
                    }
                    else if (oDBST.run == 0 || oDBST.run == 1)
                    {
                        machTwo.CncStrStatus = "閒置中";
                        machTwo.paintChange += machTwo_Paint;
                        this.Refresh();
                    }
                    else if (oDBST.run == 2)
                    {
                        machTwo.CncStrStatus = "準備中";
                        machTwo.paintChange += machTwo_Paint;
                        this.Refresh();
                    }
                }

                //machOne.CncName = "OKK";

                /*short uret = uconnectCNC();
                Console.WriteLine(uret);*/
            }
        }


        private delegate void MyInvoke(string state); 
        private void dowork(object ip)
        {
            if (machOne.InvokeRequired)
            {
                this.Invoke(new MyInvoke(this.MachNumber), new object[] { ip });
            }
            else 
            {
                this.MachNumber(ip);
            }
            //MyInvoke mi = new MyInvoke(MachNumber);
            //this.BeginInvoke(mi, new object[] { "192.6.1.6" });
        }
        private void dowork1(object ip)
        {
            if (machTwo.InvokeRequired)
            {
                this.Invoke(new MyInvoke(this.MachNumber2), new object[] { ip });
            }
            else
            {
                this.MachNumber2(ip);
            }
            //MyInvoke mi = new MyInvoke(MachNumber);
            //this.BeginInvoke(mi, new object[] { "192.6.1.6" });
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
             ThreadStart 指定的方法必須為無參數型態
             ParameterizedThreadStart 則可以指定方法夾帶參數，但只限制一個且型態為 object 
             */
            Thread t1 = new Thread(new ParameterizedThreadStart(dowork)); 
            t1.Start("192.6.1.6");
            Thread t2 = new Thread(new ParameterizedThreadStart(dowork1));
            t2.Start("192.6.1.7");
        }

    }
}
