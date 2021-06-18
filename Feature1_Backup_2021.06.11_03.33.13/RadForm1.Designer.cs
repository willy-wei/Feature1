
namespace Feature1
{
    partial class RadForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.machEight = new Feature1.UserControl1();
            this.machSeven = new Feature1.UserControl1();
            this.machSix = new Feature1.UserControl1();
            this.machFive = new Feature1.UserControl1();
            this.machfour = new Feature1.UserControl1();
            this.machThree = new Feature1.UserControl1();
            this.machTwo = new Feature1.UserControl1();
            this.machOne = new Feature1.UserControl1();
            this.offlineSum = new Feature1.StatusNumber();
            this.idleSum = new Feature1.StatusNumber();
            this.alarmSum = new Feature1.StatusNumber();
            this.prepareSum = new Feature1.StatusNumber();
            this.runSum = new Feature1.StatusNumber();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.radPageViewPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.radPageViewPage1);
            this.radPageView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPageView1.Location = new System.Drawing.Point(0, 0);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.PageBackColor = System.Drawing.Color.Transparent;
            this.radPageView1.SelectedPage = this.radPageViewPage1;
            this.radPageView1.SelectionWrap = false;
            this.radPageView1.Size = new System.Drawing.Size(1912, 1048);
            this.radPageView1.TabIndex = 0;
            this.radPageView1.ThemeName = "ControlDefault";
            this.radPageView1.ViewMode = Telerik.WinControls.UI.PageViewMode.NavigationView;
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.radPageView1.GetChildAt(0))).ShowItemCloseButton = false;
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.radPageView1.GetChildAt(0))).BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.radPageView1.GetChildAt(0))).BorderInnerColor = System.Drawing.SystemColors.ControlLightLight;
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.radPageView1.GetChildAt(0))).BackColor2 = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.radPageView1.GetChildAt(0))).BackColor3 = System.Drawing.SystemColors.ControlDark;
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.radPageView1.GetChildAt(0))).BackColor4 = System.Drawing.SystemColors.ControlLightLight;
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.radPageView1.GetChildAt(0))).BorderTopColor = System.Drawing.SystemColors.ControlDark;
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.radPageView1.GetChildAt(0))).BorderBottomColor = System.Drawing.SystemColors.ControlDark;
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.radPageView1.GetChildAt(0))).FocusBorderColor = System.Drawing.Color.Gray;
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.radPageView1.GetChildAt(0))).BorderHighlightColor = System.Drawing.Color.White;
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.radPageView1.GetChildAt(0))).ForeColor = System.Drawing.Color.White;
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.radPageView1.GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // radPageViewPage1
            // 
            this.radPageViewPage1.BackColor = System.Drawing.Color.Black;
            this.radPageViewPage1.Controls.Add(this.machEight);
            this.radPageViewPage1.Controls.Add(this.machSeven);
            this.radPageViewPage1.Controls.Add(this.machSix);
            this.radPageViewPage1.Controls.Add(this.machFive);
            this.radPageViewPage1.Controls.Add(this.machfour);
            this.radPageViewPage1.Controls.Add(this.machThree);
            this.radPageViewPage1.Controls.Add(this.machTwo);
            this.radPageViewPage1.Controls.Add(this.machOne);
            this.radPageViewPage1.Controls.Add(this.offlineSum);
            this.radPageViewPage1.Controls.Add(this.idleSum);
            this.radPageViewPage1.Controls.Add(this.alarmSum);
            this.radPageViewPage1.Controls.Add(this.prepareSum);
            this.radPageViewPage1.Controls.Add(this.runSum);
            this.radPageViewPage1.ForeColor = System.Drawing.Color.White;
            this.radPageViewPage1.ItemSize = new System.Drawing.SizeF(14F, 14F);
            this.radPageViewPage1.Location = new System.Drawing.Point(41, 30);
            this.radPageViewPage1.Name = "radPageViewPage1";
            this.radPageViewPage1.Size = new System.Drawing.Size(1870, 1017);
            this.radPageViewPage1.Text = "radPageViewPage1";
            // 
            // machEight
            // 
            this.machEight.CncName = "label2";
            this.machEight.CncStrFont = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machEight.CncStrForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.machEight.CncStrStatus = "label1";
            this.machEight.Location = new System.Drawing.Point(1307, 610);
            this.machEight.Name = "machEight";
            this.machEight.Size = new System.Drawing.Size(360, 320);
            this.machEight.TabIndex = 12;
            // 
            // machSeven
            // 
            this.machSeven.CncName = "label2";
            this.machSeven.CncStrFont = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machSeven.CncStrForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.machSeven.CncStrStatus = "label1";
            this.machSeven.Location = new System.Drawing.Point(888, 610);
            this.machSeven.Name = "machSeven";
            this.machSeven.Size = new System.Drawing.Size(360, 320);
            this.machSeven.TabIndex = 11;
            // 
            // machSix
            // 
            this.machSix.CncName = "label2";
            this.machSix.CncStrFont = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machSix.CncStrForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.machSix.CncStrStatus = "label1";
            this.machSix.Location = new System.Drawing.Point(466, 610);
            this.machSix.Name = "machSix";
            this.machSix.Size = new System.Drawing.Size(360, 320);
            this.machSix.TabIndex = 10;
            // 
            // machFive
            // 
            this.machFive.CncName = "label2";
            this.machFive.CncStrFont = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machFive.CncStrForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.machFive.CncStrStatus = "label1";
            this.machFive.Location = new System.Drawing.Point(46, 610);
            this.machFive.Name = "machFive";
            this.machFive.Size = new System.Drawing.Size(360, 320);
            this.machFive.TabIndex = 9;
            // 
            // machfour
            // 
            this.machfour.CncName = "label2";
            this.machfour.CncStrFont = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machfour.CncStrForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.machfour.CncStrStatus = "label1";
            this.machfour.Location = new System.Drawing.Point(1307, 257);
            this.machfour.Name = "machfour";
            this.machfour.Size = new System.Drawing.Size(360, 320);
            this.machfour.TabIndex = 8;
            // 
            // machThree
            // 
            this.machThree.CncName = "label2";
            this.machThree.CncStrFont = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machThree.CncStrForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.machThree.CncStrStatus = "label1";
            this.machThree.Location = new System.Drawing.Point(888, 257);
            this.machThree.Name = "machThree";
            this.machThree.Size = new System.Drawing.Size(360, 320);
            this.machThree.TabIndex = 7;
            // 
            // machTwo
            // 
            this.machTwo.CncName = "label2";
            this.machTwo.CncStrFont = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machTwo.CncStrForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.machTwo.CncStrStatus = "label1";
            this.machTwo.Location = new System.Drawing.Point(466, 257);
            this.machTwo.Name = "machTwo";
            this.machTwo.Size = new System.Drawing.Size(360, 320);
            this.machTwo.TabIndex = 6;
            // 
            // machOne
            // 
            this.machOne.CncName = "label2";
            this.machOne.CncStrFont = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machOne.CncStrForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.machOne.CncStrStatus = "label1";
            this.machOne.Location = new System.Drawing.Point(46, 257);
            this.machOne.Name = "machOne";
            this.machOne.Size = new System.Drawing.Size(360, 320);
            this.machOne.TabIndex = 5;
            // 
            // offlineSum
            // 
            this.offlineSum.Location = new System.Drawing.Point(1366, 42);
            this.offlineSum.Name = "offlineSum";
            this.offlineSum.Size = new System.Drawing.Size(300, 149);
            this.offlineSum.TabIndex = 4;
            // 
            // idleSum
            // 
            this.idleSum.Location = new System.Drawing.Point(1036, 42);
            this.idleSum.Name = "idleSum";
            this.idleSum.Size = new System.Drawing.Size(300, 149);
            this.idleSum.TabIndex = 3;
            // 
            // alarmSum
            // 
            this.alarmSum.Location = new System.Drawing.Point(704, 42);
            this.alarmSum.Name = "alarmSum";
            this.alarmSum.Size = new System.Drawing.Size(300, 149);
            this.alarmSum.TabIndex = 2;
            // 
            // prepareSum
            // 
            this.prepareSum.Location = new System.Drawing.Point(374, 42);
            this.prepareSum.Name = "prepareSum";
            this.prepareSum.Size = new System.Drawing.Size(300, 149);
            this.prepareSum.TabIndex = 1;
            // 
            // runSum
            // 
            this.runSum.Location = new System.Drawing.Point(46, 42);
            this.runSum.Name = "runSum";
            this.runSum.Size = new System.Drawing.Size(300, 149);
            this.runSum.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1912, 1048);
            this.Controls.Add(this.radPageView1);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadForm1";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.RadForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.radPageViewPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;

        private System.Windows.Forms.Timer timer1;
        private StatusNumber offlineSum;
        private StatusNumber idleSum;
        private StatusNumber alarmSum;
        private StatusNumber prepareSum;
        private StatusNumber runSum;
        private UserControl1 machEight;
        private UserControl1 machSeven;
        private UserControl1 machSix;
        private UserControl1 machFive;
        private UserControl1 machfour;
        private UserControl1 machThree;
        private UserControl1 machTwo;
        private UserControl1 machOne;
    }
}