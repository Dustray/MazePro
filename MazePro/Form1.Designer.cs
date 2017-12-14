namespace MazePro
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.winAndNewGame = new System.Windows.Forms.CheckBox();
            this.showLevel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sideLengthBar = new System.Windows.Forms.TrackBar();
            this.test = new System.Windows.Forms.Button();
            this.btn_test = new System.Windows.Forms.Button();
            this.btn_createMap = new System.Windows.Forms.Button();
            this.txt_str = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_lb_x = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_lb_y = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mapCreateProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.mazeBox = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sideLengthBar)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.winAndNewGame);
            this.groupBox1.Controls.Add(this.showLevel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sideLengthBar);
            this.groupBox1.Controls.Add(this.test);
            this.groupBox1.Controls.Add(this.btn_test);
            this.groupBox1.Controls.Add(this.btn_createMap);
            this.groupBox1.Location = new System.Drawing.Point(584, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(395, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "配置";
            // 
            // winAndNewGame
            // 
            this.winAndNewGame.AutoSize = true;
            this.winAndNewGame.Location = new System.Drawing.Point(5, 142);
            this.winAndNewGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.winAndNewGame.Name = "winAndNewGame";
            this.winAndNewGame.Size = new System.Drawing.Size(179, 19);
            this.winAndNewGame.TabIndex = 8;
            this.winAndNewGame.Text = "通过后立即开始新游戏";
            this.winAndNewGame.UseVisualStyleBackColor = true;
            // 
            // showLevel
            // 
            this.showLevel.AutoSize = true;
            this.showLevel.Location = new System.Drawing.Point(153, 65);
            this.showLevel.Name = "showLevel";
            this.showLevel.Size = new System.Drawing.Size(15, 15);
            this.showLevel.TabIndex = 7;
            this.showLevel.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "边长：";
            // 
            // sideLengthBar
            // 
            this.sideLengthBar.LargeChange = 4;
            this.sideLengthBar.Location = new System.Drawing.Point(5, 24);
            this.sideLengthBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sideLengthBar.Maximum = 30;
            this.sideLengthBar.Minimum = 2;
            this.sideLengthBar.Name = "sideLengthBar";
            this.sideLengthBar.Size = new System.Drawing.Size(269, 56);
            this.sideLengthBar.TabIndex = 4;
            this.sideLengthBar.TabStop = false;
            this.sideLengthBar.Value = 2;
            this.sideLengthBar.Scroll += new System.EventHandler(this.sideLengthBar_Scroll);
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(297, 98);
            this.test.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(75, 22);
            this.test.TabIndex = 4;
            this.test.Text = "test";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // btn_test
            // 
            this.btn_test.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_test.Location = new System.Drawing.Point(283, 128);
            this.btn_test.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(107, 34);
            this.btn_test.TabIndex = 1;
            this.btn_test.Text = "寻路";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // btn_createMap
            // 
            this.btn_createMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_createMap.Location = new System.Drawing.Point(283, 24);
            this.btn_createMap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_createMap.Name = "btn_createMap";
            this.btn_createMap.Size = new System.Drawing.Size(107, 34);
            this.btn_createMap.TabIndex = 0;
            this.btn_createMap.Text = "创建迷宫";
            this.btn_createMap.UseVisualStyleBackColor = true;
            this.btn_createMap.Click += new System.EventHandler(this.btn_createMap_Click);
            // 
            // txt_str
            // 
            this.txt_str.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_str.Location = new System.Drawing.Point(584, 190);
            this.txt_str.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_str.Multiline = true;
            this.txt_str.Name = "txt_str";
            this.txt_str.Size = new System.Drawing.Size(393, 348);
            this.txt_str.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.status_lb_x,
            this.toolStripStatusLabel2,
            this.status_lb_y,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.mapCreateProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(989, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(84, 21);
            this.toolStripStatusLabel1.Text = "当前坐标：";
            // 
            // status_lb_x
            // 
            this.status_lb_x.Name = "status_lb_x";
            this.status_lb_x.Size = new System.Drawing.Size(18, 21);
            this.status_lb_x.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(13, 21);
            this.toolStripStatusLabel2.Text = ":";
            // 
            // status_lb_y
            // 
            this.status_lb_y.Name = "status_lb_y";
            this.status_lb_y.Size = new System.Drawing.Size(18, 21);
            this.status_lb_y.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(29, 21);
            this.toolStripStatusLabel3.Text = "  |  ";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(84, 21);
            this.toolStripStatusLabel4.Text = "当前状态：";
            // 
            // mapCreateProgressBar
            // 
            this.mapCreateProgressBar.Name = "mapCreateProgressBar";
            this.mapCreateProgressBar.Size = new System.Drawing.Size(667, 20);
            // 
            // mazeBox
            // 
            this.mazeBox.Location = new System.Drawing.Point(16, 12);
            this.mazeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mazeBox.Name = "mazeBox";
            this.mazeBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mazeBox.Size = new System.Drawing.Size(561, 526);
            this.mazeBox.TabIndex = 4;
            this.mazeBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btn_createMap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 566);
            this.Controls.Add(this.mazeBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txt_str);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1007, 613);
            this.MinimumSize = new System.Drawing.Size(1007, 613);
            this.Name = "MainForm";
            this.Text = "迷宫";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sideLengthBar)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Button btn_createMap;
        private System.Windows.Forms.TextBox txt_str;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel status_lb_x;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel status_lb_y;
        private System.Windows.Forms.TrackBar sideLengthBar;
        private System.Windows.Forms.Label showLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox winAndNewGame;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripProgressBar mapCreateProgressBar;
        private System.Windows.Forms.GroupBox mazeBox;
    }
}

