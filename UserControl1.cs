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

        public Image cncRunImage { get => this.pictureBox4.Image; set => this.pictureBox4.Image = value; }
        public Image cncPrepareImage { get => this.pictureBox3.Image; set => this.pictureBox3.Image = value; }
        public Image cncIdleImage { get => this.pictureBox5.Image; set => this.pictureBox5.Image = value; }
        public Image cncAlarmImage { get => this.pictureBox2.Image; set => this.pictureBox2.Image = value; }
        
        
        //建立事件和觸發函數
        public event EventHandler btnClick;
        public event PaintEventHandler paintChange;
        public event EventHandler changeLabel;
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
        protected void onChangeStatusText(EventArgs e)
        {
            if (changeLabel != null)
                changeLabel(this, e);
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
        
        private void statusStr_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("TextChange : "+e);
            onChangeStatusText(e);
        }
    }
}
