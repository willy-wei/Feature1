using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feature1
{

    public partial class UserControl1 : UserControl
    {

        //機台名稱
        public string CncName { get => this.cncName.Text; set => this.cncName.Text = value; }
        //機台狀態(文字)
        public string CncStrStatus{get =>this.statusStr.Text; set => this.statusStr.Text = value;}
        //文字字體設定
        public Font CncStrFont { get => this.statusStr.Font; set => this.statusStr.Font = value; }
        public Color CncStrForeColor { get => this.statusStr.ForeColor; set => this.statusStr.ForeColor = value; }


        
        //建立事件和觸發函數
        public event EventHandler btnClick;
        public event PaintEventHandler paintChange;
        protected void OnbtnClick(EventArgs e)
        {
            if (btnClick != null) 
            {
                btnClick(this, e);
            }
        }
        protected void onPanelChange(PaintEventArgs e)
        {
            if (paintChange != null)
                paintChange(this, e);
        }
        
        public UserControl1()
        {
            InitializeComponent();
        }

        private void ConMonitorBtn_Click(object sender, EventArgs e)
        {
            OnbtnClick(e);
            Console.WriteLine("EventArgs2: " + e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            onPanelChange(e);
        }
    }
}
