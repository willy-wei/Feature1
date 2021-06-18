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
            Thread t1 = new Thread(new ParameterizedThreadStart(dowork));
            t1.Start("192.6.1.6");
            Thread t2 = new Thread(new ParameterizedThreadStart(dowork1));
            t2.Start("192.6.1.7");
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000*25;



            userControl11.btnClick += ConMonitor_Click;
            //userControl11.paintChange += userControl11_Paint;

        }
        
        void ConMonitor_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show("狀態監視");
            userControl11.CncName = "OKK";
            userControl11.CncStrForeColor = Color.Green;*/
            //userControl11.CncStrStatus = "運轉中";


        }

        private void userControl11_Paint(object sender, PaintEventArgs e)
        {
            if (userControl11.CncStrStatus == "運轉中")
            {
                ControlPaint.DrawBorder(e.Graphics, this.userControl11.ClientRectangle, Color.Green, ButtonBorderStyle.Solid);
            }
            else if (userControl11.CncStrStatus == "停止中")
            {
                ControlPaint.DrawBorder(e.Graphics, this.userControl11.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
            }
            else if (userControl11.CncStrStatus == "閒置中")
            {
                ControlPaint.DrawBorder(e.Graphics, this.userControl11.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
            }
        }
        private void userControl12_Paint(object sender, PaintEventArgs e)
        {
            if (userControl12.CncStrStatus == "運轉中")
            {
                ControlPaint.DrawBorder(e.Graphics, this.userControl12.ClientRectangle, Color.Green, ButtonBorderStyle.Solid);
            }
            else if (userControl12.CncStrStatus == "準備中")
            {
                ControlPaint.DrawBorder(e.Graphics, this.userControl12.ClientRectangle, Color.Yellow, ButtonBorderStyle.Solid);
            }
            else if (userControl12.CncStrStatus == "閒置中")
            {
                ControlPaint.DrawBorder(e.Graphics, this.userControl12.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
            }
        }

        void MachNumber(object ip)
        {
            short ret = ConnectCNC((string)ip, 8193);

            if (ret == Focas1.EW_OK)
            {
                Focas1.ODBST oDBST = new Focas1.ODBST();
                short statRet;
                Console.WriteLine(PMCReadMsg());  
                statRet = MachStatus(ref oDBST);
                if (statRet == Focas1.EW_OK)
                {
                    Console.WriteLine(oDBST.run + " " + ip + " " + DateTime.Now);
                    Console.WriteLine("mstb :" + oDBST.mstb + " " + ip + " " + DateTime.Now);
                    if (oDBST.run == 3)
                    {
                        userControl11.CncStrStatus = "運轉中";
                        userControl11.paintChange += userControl11_Paint;
                        this.Refresh();//強制控制項使其工作區失效，並且立即重繪其本身和任何子控制項。
                    }
                    if (oDBST.run == 0 || oDBST.run == 1) 
                    {
                        userControl11.CncStrStatus = "閒置中";
                        userControl11.paintChange += userControl11_Paint;
                        this.Refresh();
                    }
                    if (oDBST.run == 2)
                    {
                        userControl11.CncStrStatus = "準備中";
                        userControl11.paintChange += userControl11_Paint;
                        this.Refresh();
                    }
                }
               
                //userControl11.CncName = "OKK";

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
                    if (oDBST.run == 3)
                    {
                        userControl12.CncStrStatus = "運轉中";
                        userControl12.paintChange += userControl12_Paint;
                        this.Refresh();//強制控制項使其工作區失效，並且立即重繪其本身和任何子控制項。
                    }
                    else if (oDBST.run == 0 || oDBST.run == 1)
                    {
                        userControl12.CncStrStatus = "閒置中";
                        userControl12.paintChange += userControl12_Paint;
                        this.Refresh();
                    }
                    else if (oDBST.run == 2)
                    {
                        userControl12.CncStrStatus = "準備中";
                        userControl12.paintChange += userControl12_Paint;
                        this.Refresh();
                    }
                }

                //userControl11.CncName = "OKK";

                /*short uret = uconnectCNC();
                Console.WriteLine(uret);*/
            }
        }


        private delegate void MyInvoke(string state); 
        private void dowork(object ip)
        {
            if (userControl11.InvokeRequired)
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
            if (userControl12.InvokeRequired)
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
