using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
        Thread t1;
        Thread t2;

        Boolean machOneFlag = true;
        Boolean machTwoFlag = true;
        Boolean machThreeFlag = true;
        Boolean machFourFlag = true;
        Boolean machFiveFlag = true;
        Boolean machSixFlag = true;
        Boolean machSevenFlag = true;
        Boolean machEightFlag = true;
        
        private static object machOneLocker = new Object();
        private object machTwoLocker = new Object();
        private object machThreeLocker = new Object();
        private object machFourLocker = new Object();
        private object machFiveLocker = new Object();
        private object machSixLocker = new Object();
        private object machSevenLocker = new Object();
        private object machEightLocker = new Object();

        //ManualResetEvent _pauseEvent;
        ImageList statusImageList;
        UserControl1[] machList;
        CancellationTokenSource cts;
        MachineInfo[] machineInfoList;
        int runTotal = 0,
            disConnectTotal = 0,
            prepareTotal = 0,
            idleTotal = 0,
            alarmTotal = 0;
        Task task;
        string preStatus = null;
        string preStatusTwo = null;

        private void RadForm1_Load(object sender, EventArgs e)
        {
            try
            {
                init();
                
                ImportImageList();
                ImportStatusImage();
                //Console.WriteLine("test {0}",machOneO.IP);
                
                /*machOneO.IP = "192.6.1.1";
                machOneO.PORT = 8193;
                Console.WriteLine(machOneO.connectCNC());
                Console.WriteLine(machOneO.current());*/

                //timer1.Enabled = true;
                //timer1.Start();
                //timer1.Interval = 1000;
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
            Console.WriteLine("結束連線{0}",DisconnectCNC());
            //t1 = new Thread(new ParameterizedThreadStart(dowork));
            //t1.Abort();
            //machOneFlag = false;
            Task.Delay(1000, cts.Token);
            machOne.CncStrStatus = "離線中";
            machOne.paintChange += machOne_Paint;

            machOne.cncRunImage = statusImageList.Images[0];
            machOne.cncAlarmImage = statusImageList.Images[0];
            machOne.cncIdleImage = statusImageList.Images[0];
            machOne.cncPrepareImage = statusImageList.Images[0];

            
            //this.Update();
            /*MessageBox.Show("狀態監視");
            machOne.CncName = "OKK";
            machOne.CncStrForeColor = Color.Green;*/
            //machOne.CncStrStatus = "運轉中";


        }

        private async void machOne_Paint(object sender, PaintEventArgs e)
        {
            /*之後改switch*/
            switch (machOne.CncStrStatus)
            {
                case "運轉中":
                    ControlPaint.DrawBorder(e.Graphics, this.machOne.ClientRectangle,
                        Color.Green, 3, ButtonBorderStyle.Solid,
                        Color.Green, 3, ButtonBorderStyle.Solid,
                        Color.Green, 3, ButtonBorderStyle.Solid,
                        Color.Green, 3, ButtonBorderStyle.Solid);
                    break;
                case "異警中":
                    ControlPaint.DrawBorder(e.Graphics, this.machOne.ClientRectangle,
                        Color.Red, 3, ButtonBorderStyle.Solid,
                        Color.Red, 3, ButtonBorderStyle.Solid,
                        Color.Red, 3, ButtonBorderStyle.Solid,
                        Color.Red, 3, ButtonBorderStyle.Solid);
                    break;
                case "閒置中":
                    ControlPaint.DrawBorder(e.Graphics, this.machOne.ClientRectangle,
                        Color.White, 3, ButtonBorderStyle.Solid,
                        Color.White, 3, ButtonBorderStyle.Solid,
                        Color.White, 3, ButtonBorderStyle.Solid,
                        Color.White, 3, ButtonBorderStyle.Solid);
                    break;
                case "離線中":
                    ControlPaint.DrawBorder(e.Graphics, this.machOne.ClientRectangle,
                        Color.Blue, 3, ButtonBorderStyle.Solid,
                        Color.Blue, 3, ButtonBorderStyle.Solid,
                        Color.Blue, 3, ButtonBorderStyle.Solid,
                        Color.Blue, 3, ButtonBorderStyle.Solid);
                    break;
                case "準備中":
                    ControlPaint.DrawBorder(e.Graphics, this.machOne.ClientRectangle,
                        Color.Yellow, 3, ButtonBorderStyle.Solid,
                        Color.Yellow, 3, ButtonBorderStyle.Solid,
                        Color.Yellow, 3, ButtonBorderStyle.Solid,
                        Color.Yellow, 3, ButtonBorderStyle.Solid);
                    break;

            }
        }
        private void machTwo_Paint(object sender, PaintEventArgs e)
        {
            switch (machTwo.CncStrStatus)
            {
                case "運轉中":
                    ControlPaint.DrawBorder(e.Graphics, this.machTwo.ClientRectangle, Color.Green, ButtonBorderStyle.Inset);
                    break;
                case "準備中":
                    ControlPaint.DrawBorder(e.Graphics, this.machTwo.ClientRectangle, Color.Yellow, ButtonBorderStyle.Inset);
                    break;
                case "閒置中":
                    ControlPaint.DrawBorder(e.Graphics, this.machTwo.ClientRectangle, Color.White, ButtonBorderStyle.Inset);
                    break;
                case "異警中":
                    ControlPaint.DrawBorder(e.Graphics, this.machTwo.ClientRectangle, Color.Red, ButtonBorderStyle.Inset);
                    break;
                case "離線中":
                    ControlPaint.DrawBorder(e.Graphics, this.machTwo.ClientRectangle, Color.Blue, ButtonBorderStyle.Inset);
                    break;

            }
        }

        private void changeStatusImage(int machNum,string status) 
        {
            switch (status) 
            {
                case "運轉中":
                    machList[machNum].cncRunImage = statusImageList.Images[1];
                    machList[machNum].cncAlarmImage = statusImageList.Images[0];
                    machList[machNum].cncIdleImage = statusImageList.Images[0];
                    machList[machNum].cncPrepareImage = statusImageList.Images[0];

                    machList[machNum].CncStrForeColor = Color.Green;
                    break;
                case "準備中":
                    machList[machNum].cncRunImage = statusImageList.Images[0];
                    machList[machNum].cncAlarmImage = statusImageList.Images[0];
                    machList[machNum].cncIdleImage = statusImageList.Images[0];
                    machList[machNum].cncPrepareImage = statusImageList.Images[4];

                    machList[machNum].CncStrForeColor = Color.Yellow;
                    break;
                case "閒置中":
                    machList[machNum].cncRunImage = statusImageList.Images[0];
                    machList[machNum].cncAlarmImage = statusImageList.Images[0];
                    machList[machNum].cncIdleImage = statusImageList.Images[3];
                    machList[machNum].cncPrepareImage = statusImageList.Images[0];

                    machList[machNum].CncStrForeColor = Color.White;
                    break;
                case "異警中":
                    machList[machNum].cncRunImage = statusImageList.Images[0];
                    machList[machNum].cncAlarmImage = statusImageList.Images[2];
                    machList[machNum].cncIdleImage = statusImageList.Images[0];
                    machList[machNum].cncPrepareImage = statusImageList.Images[0];

                    machList[machNum].CncStrForeColor = Color.Red;
                    break;
            }
        }
        private async void MachNumber(object ip)
        {
            
            machOneO.IP = (string)ip;
            machOneO.PORT = 8193;
            short ret = machOneO.connectCNC();
            if (ret == Focas1.EW_OK)
            {
                string status = machOneO.machineStatus();
                Console.WriteLine("{0}",preStatus);
                if (preStatus == status) 
                {
                    Console.WriteLine("一樣");
                    return;
                }
                else 
                {
                    Console.WriteLine(ip + " :" + status + " " + DateTime.Now);
                    machOne.CncStrStatus = status;
                    changeStatusImage(0, status);
                    machOne.paintChange += machOne_Paint;
                    preStatus = status;
                    this.Refresh();
                }
                

            }


        }
        void MachNumber2(object ip)
        {
            machTwoO.IP = (string)ip;
            machTwoO.PORT = 8193;
            short ret = machTwoO.connectCNC();

            if (ret == Focas1.EW_OK)
            {
                string status = machTwoO.machineStatus();
                if (preStatusTwo == status)
                {
                    Console.WriteLine("一樣2");
                    return;
                }
                else 
                {
                    Console.WriteLine(ip + " :" + status + " " + DateTime.Now);
                    machTwo.CncStrStatus = status;
                    changeStatusImage(1, status);
                    machTwo.paintChange += machTwo_Paint;
                    preStatusTwo = status;
                    this.Refresh();
                }

                
                

            }

            //machOne.CncName = "OKK";

            /*short uret = uconnectCNC();
            Console.WriteLine(uret);*/

        }


        private delegate void MyInvoke(string state);
        
        private async Task dowork(object ip)
        {
            await Task.Run(() =>
            {
                while (machOneFlag)
                {
                    try
                    {
                        if (machOne.InvokeRequired)
                        {
                            this.Invoke(new MyInvoke(this.MachNumber), new object[] { ip });

                        }
                        else
                        {
                            this.MachNumber(ip);
                        }
                        if (machOneFlag == false) break;
                        Thread.Sleep(5000);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    //SpinWait.SpinUntil(() => false, (2000));
                }
            });
            //MyInvoke mi = new MyInvoke(MachNumber);
            //this.BeginInvoke(mi, new object[] { "192.6.1.6" });
        }
        private async Task dowork1(object ip)
        {
            await Task.Run(() =>
            {
                while (machTwoFlag)
                {
                    try
                    {
                        if (machTwo.InvokeRequired)
                        {
                            this.Invoke(new MyInvoke(this.MachNumber2), new object[] { ip });
                        }
                        else
                        {
                            this.MachNumber2(ip);
                        }
                        Thread.Sleep(5 * 1000);
                        
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            });

            
        }

        protected async void CallTask() 
        {
            Task MachOneTask = dowork("192.6.1.6");
            Task MachTwoTask = dowork1("192.6.1.5");

        }
            //MyInvoke mi = new MyInvoke(MachNumber);
            //this.BeginInvoke(mi, new object[] { "192.6.1.6" })

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
             ThreadStart 指定的方法必須為無參數型態
             ParameterizedThreadStart 則可以指定方法夾帶參數，但只限制一個且型態為 object 
             */
            //Thread t1 = new Thread(new ParameterizedThreadStart(dowork));
            //Console.WriteLine(runTotal);
            //Console.WriteLine(t1.IsAlive);
            
        }
        #region 把狀態顏色的圖片變成陣列
        private void ImportImageList() 
        {
            string[] paths = { };
            paths = Directory.GetFiles("../../pictures/status");
            try
            {
                foreach (string path in paths)
                {
                    statusImageList.Images.Add(Image.FromFile(path));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion
        #region 匯入圖片至計算表格中的pictureBox中
        private void ImportStatusImage() //
        {
            runSum.statusImage = statusImageList.Images[1]; //0:black, 1:green, 2:red, 3:white, 4:yellow 
            alarmSum.statusImage = statusImageList.Images[2];
            idleSum.statusImage = statusImageList.Images[3];
            prepareSum.statusImage = statusImageList.Images[4];
            offlineSum.statusImage = statusImageList.Images[0];
        }
        #endregion
        #region 初始設定
        private async void init() //
        {
            machList = new UserControl1[] { machOne, machTwo, machThree, machFour };
            //machineInfoList = new MachineInfo[] { machOneO, machTwoO};

            //_pauseEvent = new ManualResetEvent(true);
            //t1 = new Thread(new ParameterizedThreadStart(dowork));
            //t2 = new Thread(new ParameterizedThreadStart(dowork1));
            statusImageList = new ImageList();
            statusImageList.ImageSize = new Size(255, 255);
            cts = new CancellationTokenSource();


            //dowork("192.6.1.6");
            //await dowork1("192.6.1.7");
            task = new Task(CallTask);
            task.Start();
            task.Wait();
            

            //t1.IsBackground = true;
            //t2.IsBackground = true;

            //t1.Start("192.6.1.6");
            //t2.Start("192.6.1.7");
            
        }
        #endregion
        private void judgmentStatusChange() 
        {
            Console.WriteLine(machOneO.IP);
        }
    }
}
