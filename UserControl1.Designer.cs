
namespace Feature1
{
    partial class UserControl1
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConMonitorBtn = new System.Windows.Forms.Button();
            this.AlarmBtn = new System.Windows.Forms.Button();
            this.cncName = new System.Windows.Forms.Label();
            this.statusStr = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.ConMonitorBtn);
            this.panel1.Controls.Add(this.AlarmBtn);
            this.panel1.Controls.Add(this.cncName);
            this.panel1.Controls.Add(this.statusStr);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 320);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ConMonitorBtn
            // 
            this.ConMonitorBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ConMonitorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConMonitorBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ConMonitorBtn.Location = new System.Drawing.Point(191, 221);
            this.ConMonitorBtn.Name = "ConMonitorBtn";
            this.ConMonitorBtn.Size = new System.Drawing.Size(154, 80);
            this.ConMonitorBtn.TabIndex = 8;
            this.ConMonitorBtn.Text = "button2";
            this.ConMonitorBtn.UseVisualStyleBackColor = false;
            this.ConMonitorBtn.Click += new System.EventHandler(this.ConMonitorBtn_Click);
            // 
            // AlarmBtn
            // 
            this.AlarmBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AlarmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AlarmBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AlarmBtn.Location = new System.Drawing.Point(21, 221);
            this.AlarmBtn.Name = "AlarmBtn";
            this.AlarmBtn.Size = new System.Drawing.Size(154, 80);
            this.AlarmBtn.TabIndex = 7;
            this.AlarmBtn.Text = "button1";
            this.AlarmBtn.UseVisualStyleBackColor = false;
            // 
            // cncName
            // 
            this.cncName.AutoSize = true;
            this.cncName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cncName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cncName.Location = new System.Drawing.Point(238, 46);
            this.cncName.Name = "cncName";
            this.cncName.Size = new System.Drawing.Size(57, 21);
            this.cncName.TabIndex = 6;
            this.cncName.Text = "label2";
            // 
            // statusStr
            // 
            this.statusStr.AutoSize = true;
            this.statusStr.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statusStr.Location = new System.Drawing.Point(224, 111);
            this.statusStr.Name = "statusStr";
            this.statusStr.Size = new System.Drawing.Size(100, 42);
            this.statusStr.TabIndex = 5;
            this.statusStr.Text = "label1";
            this.statusStr.TextChanged += new System.EventHandler(this.statusStr_TextChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(311, 181);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(34, 34);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(271, 181);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(231, 181);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(191, 181);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 212);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(360, 320);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ConMonitorBtn;
        private System.Windows.Forms.Button AlarmBtn;
        private System.Windows.Forms.Label cncName;
        private System.Windows.Forms.Label statusStr;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
