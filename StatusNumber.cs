using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;


namespace Feature1
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class StatusNumber : UserControl
    {
        public string statusSum { get => this.StatusSumLabel.Text; set => this.StatusSumLabel.Text = value; }
        public string statusName { get => this.statusLabel.Text; set => this.statusLabel.Text = value; }
        public Image statusImage { get => this.pictureBox1.Image; set => this.pictureBox1.Image = value; }
        public StatusNumber()
        {
            InitializeComponent();
        }
    }
}
