namespace Time
{
    partial class frame
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
            this.stopBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnPanel = new System.Windows.Forms.TableLayoutPanel();
            this.clock = new System.Windows.Forms.Label();
            this.TimerTabs = new System.Windows.Forms.TabControl();
            this.Time = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.addHourTimer = new System.Windows.Forms.Button();
            this.lessHourTimer = new System.Windows.Forms.Button();
            this.addMinTimer = new System.Windows.Forms.Button();
            this.addSecTimer = new System.Windows.Forms.Button();
            this.lessMinTimer = new System.Windows.Forms.Button();
            this.lessSecTimer = new System.Windows.Forms.Button();
            this.countHour = new System.Windows.Forms.Label();
            this.countMin = new System.Windows.Forms.Label();
            this.countSec = new System.Windows.Forms.Label();
            this.StopWatch = new System.Windows.Forms.TabPage();
            this.countTime = new System.Windows.Forms.Label();
            this.Alarm = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addHourAlarm = new System.Windows.Forms.Button();
            this.lessHourAlarm = new System.Windows.Forms.Button();
            this.addMinAlarm = new System.Windows.Forms.Button();
            this.addSecAlarm = new System.Windows.Forms.Button();
            this.lessMinAlarm = new System.Windows.Forms.Button();
            this.lessSecAlarm = new System.Windows.Forms.Button();
            this.Hour = new System.Windows.Forms.Label();
            this.Min = new System.Windows.Forms.Label();
            this.Sec = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.counter = new System.Windows.Forms.Timer(this.components);
            this.topPanel.SuspendLayout();
            this.btnPanel.SuspendLayout();
            this.TimerTabs.SuspendLayout();
            this.Time.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.StopWatch.SuspendLayout();
            this.Alarm.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stopBtn
            // 
            this.stopBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stopBtn.Enabled = false;
            this.stopBtn.Location = new System.Drawing.Point(60, 3);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(51, 23);
            this.stopBtn.TabIndex = 2;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetBtn.Enabled = false;
            this.resetBtn.Location = new System.Drawing.Point(117, 3);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(53, 23);
            this.resetBtn.TabIndex = 1;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startBtn.Location = new System.Drawing.Point(3, 3);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(51, 23);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // topPanel
            // 
            this.topPanel.ColumnCount = 2;
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topPanel.Controls.Add(this.btnPanel, 0, 0);
            this.topPanel.Controls.Add(this.clock, 1, 0);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.RowCount = 1;
            this.topPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topPanel.Size = new System.Drawing.Size(359, 35);
            this.topPanel.TabIndex = 1;
            // 
            // btnPanel
            // 
            this.btnPanel.ColumnCount = 3;
            this.btnPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.btnPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.btnPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.btnPanel.Controls.Add(this.stopBtn, 1, 0);
            this.btnPanel.Controls.Add(this.resetBtn, 2, 0);
            this.btnPanel.Controls.Add(this.startBtn, 0, 0);
            this.btnPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPanel.Location = new System.Drawing.Point(3, 3);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.RowCount = 1;
            this.btnPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.btnPanel.Size = new System.Drawing.Size(173, 29);
            this.btnPanel.TabIndex = 4;
            // 
            // clock
            // 
            this.clock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clock.AutoSize = true;
            this.clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clock.Location = new System.Drawing.Point(229, 7);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(79, 20);
            this.clock.TabIndex = 3;
            this.clock.Text = "00:00:00";
            // 
            // TimerTabs
            // 
            this.TimerTabs.Controls.Add(this.Time);
            this.TimerTabs.Controls.Add(this.StopWatch);
            this.TimerTabs.Controls.Add(this.Alarm);
            this.TimerTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimerTabs.Location = new System.Drawing.Point(0, 35);
            this.TimerTabs.Name = "TimerTabs";
            this.TimerTabs.SelectedIndex = 0;
            this.TimerTabs.Size = new System.Drawing.Size(359, 128);
            this.TimerTabs.TabIndex = 3;
            this.TimerTabs.Selected += new System.Windows.Forms.TabControlEventHandler(this.TimerTabs_Selected);
            // 
            // Time
            // 
            this.Time.Controls.Add(this.tableLayoutPanel3);
            this.Time.Location = new System.Drawing.Point(4, 22);
            this.Time.Name = "Time";
            this.Time.Padding = new System.Windows.Forms.Padding(3);
            this.Time.Size = new System.Drawing.Size(351, 102);
            this.Time.TabIndex = 0;
            this.Time.Text = "Timer";
            this.Time.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.addHourTimer, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lessHourTimer, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.addMinTimer, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.addSecTimer, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.lessMinTimer, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.lessSecTimer, 4, 2);
            this.tableLayoutPanel3.Controls.Add(this.countHour, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.countMin, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.countSec, 4, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(345, 96);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // addHourTimer
            // 
            this.addHourTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addHourTimer.Location = new System.Drawing.Point(40, 3);
            this.addHourTimer.MaximumSize = new System.Drawing.Size(20, 20);
            this.addHourTimer.Name = "addHourTimer";
            this.addHourTimer.Size = new System.Drawing.Size(20, 20);
            this.addHourTimer.TabIndex = 0;
            this.addHourTimer.Text = "+";
            this.addHourTimer.UseVisualStyleBackColor = true;
            this.addHourTimer.Click += new System.EventHandler(this.addHourTimer_Click);
            // 
            // lessHourTimer
            // 
            this.lessHourTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lessHourTimer.Location = new System.Drawing.Point(40, 71);
            this.lessHourTimer.MaximumSize = new System.Drawing.Size(20, 20);
            this.lessHourTimer.Name = "lessHourTimer";
            this.lessHourTimer.Size = new System.Drawing.Size(20, 20);
            this.lessHourTimer.TabIndex = 1;
            this.lessHourTimer.Text = "-";
            this.lessHourTimer.UseVisualStyleBackColor = true;
            this.lessHourTimer.Click += new System.EventHandler(this.lessHourTimer_Click);
            // 
            // addMinTimer
            // 
            this.addMinTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addMinTimer.Location = new System.Drawing.Point(161, 3);
            this.addMinTimer.MaximumSize = new System.Drawing.Size(20, 20);
            this.addMinTimer.Name = "addMinTimer";
            this.addMinTimer.Size = new System.Drawing.Size(20, 20);
            this.addMinTimer.TabIndex = 2;
            this.addMinTimer.Text = "+";
            this.addMinTimer.UseVisualStyleBackColor = true;
            this.addMinTimer.Click += new System.EventHandler(this.addMinTimer_Click);
            // 
            // addSecTimer
            // 
            this.addSecTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addSecTimer.Location = new System.Drawing.Point(283, 3);
            this.addSecTimer.MaximumSize = new System.Drawing.Size(20, 20);
            this.addSecTimer.Name = "addSecTimer";
            this.addSecTimer.Size = new System.Drawing.Size(20, 20);
            this.addSecTimer.TabIndex = 3;
            this.addSecTimer.Text = "+";
            this.addSecTimer.UseVisualStyleBackColor = true;
            this.addSecTimer.Click += new System.EventHandler(this.addSecTimer_Click);
            // 
            // lessMinTimer
            // 
            this.lessMinTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lessMinTimer.Location = new System.Drawing.Point(161, 71);
            this.lessMinTimer.MaximumSize = new System.Drawing.Size(20, 20);
            this.lessMinTimer.Name = "lessMinTimer";
            this.lessMinTimer.Size = new System.Drawing.Size(20, 20);
            this.lessMinTimer.TabIndex = 4;
            this.lessMinTimer.Text = "-";
            this.lessMinTimer.UseVisualStyleBackColor = true;
            this.lessMinTimer.Click += new System.EventHandler(this.lessMinTimer_Click);
            // 
            // lessSecTimer
            // 
            this.lessSecTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lessSecTimer.Location = new System.Drawing.Point(283, 71);
            this.lessSecTimer.MaximumSize = new System.Drawing.Size(20, 20);
            this.lessSecTimer.Name = "lessSecTimer";
            this.lessSecTimer.Size = new System.Drawing.Size(20, 20);
            this.lessSecTimer.TabIndex = 5;
            this.lessSecTimer.Text = "-";
            this.lessSecTimer.UseVisualStyleBackColor = true;
            this.lessSecTimer.Click += new System.EventHandler(this.lessSecTimer_Click);
            // 
            // countHour
            // 
            this.countHour.AutoSize = true;
            this.countHour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countHour.Location = new System.Drawing.Point(3, 27);
            this.countHour.Name = "countHour";
            this.countHour.Size = new System.Drawing.Size(95, 40);
            this.countHour.TabIndex = 6;
            this.countHour.Text = "00";
            this.countHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countMin
            // 
            this.countMin.AutoSize = true;
            this.countMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countMin.Location = new System.Drawing.Point(124, 27);
            this.countMin.Name = "countMin";
            this.countMin.Size = new System.Drawing.Size(95, 40);
            this.countMin.TabIndex = 7;
            this.countMin.Text = "00";
            this.countMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countSec
            // 
            this.countSec.AutoSize = true;
            this.countSec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countSec.Location = new System.Drawing.Point(245, 27);
            this.countSec.Name = "countSec";
            this.countSec.Size = new System.Drawing.Size(97, 40);
            this.countSec.TabIndex = 8;
            this.countSec.Text = "00";
            this.countSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StopWatch
            // 
            this.StopWatch.Controls.Add(this.countTime);
            this.StopWatch.Location = new System.Drawing.Point(4, 22);
            this.StopWatch.Name = "StopWatch";
            this.StopWatch.Padding = new System.Windows.Forms.Padding(3);
            this.StopWatch.Size = new System.Drawing.Size(351, 102);
            this.StopWatch.TabIndex = 1;
            this.StopWatch.Text = "StopWatch";
            this.StopWatch.UseVisualStyleBackColor = true;
            // 
            // countTime
            // 
            this.countTime.AutoSize = true;
            this.countTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.countTime.Location = new System.Drawing.Point(3, 3);
            this.countTime.Name = "countTime";
            this.countTime.Size = new System.Drawing.Size(331, 54);
            this.countTime.TabIndex = 3;
            this.countTime.Text = "00m:00s:00ms";
            this.countTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Alarm
            // 
            this.Alarm.Controls.Add(this.tableLayoutPanel1);
            this.Alarm.Location = new System.Drawing.Point(4, 22);
            this.Alarm.Name = "Alarm";
            this.Alarm.Size = new System.Drawing.Size(351, 102);
            this.Alarm.TabIndex = 2;
            this.Alarm.Text = "Alarm";
            this.Alarm.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.addHourAlarm, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lessHourAlarm, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.addMinAlarm, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.addSecAlarm, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lessMinAlarm, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lessSecAlarm, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.Hour, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Min, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Sec, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(351, 102);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // addHourAlarm
            // 
            this.addHourAlarm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addHourAlarm.Location = new System.Drawing.Point(41, 5);
            this.addHourAlarm.MaximumSize = new System.Drawing.Size(20, 20);
            this.addHourAlarm.Name = "addHourAlarm";
            this.addHourAlarm.Size = new System.Drawing.Size(20, 20);
            this.addHourAlarm.TabIndex = 0;
            this.addHourAlarm.Text = "+";
            this.addHourAlarm.UseVisualStyleBackColor = true;
            this.addHourAlarm.Click += new System.EventHandler(this.addHour_Click);
            // 
            // lessHourAlarm
            // 
            this.lessHourAlarm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lessHourAlarm.Location = new System.Drawing.Point(41, 77);
            this.lessHourAlarm.MaximumSize = new System.Drawing.Size(20, 20);
            this.lessHourAlarm.Name = "lessHourAlarm";
            this.lessHourAlarm.Size = new System.Drawing.Size(20, 20);
            this.lessHourAlarm.TabIndex = 1;
            this.lessHourAlarm.Text = "-";
            this.lessHourAlarm.UseVisualStyleBackColor = true;
            this.lessHourAlarm.Click += new System.EventHandler(this.lessHour_Click);
            // 
            // addMinAlarm
            // 
            this.addMinAlarm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addMinAlarm.Location = new System.Drawing.Point(164, 5);
            this.addMinAlarm.MaximumSize = new System.Drawing.Size(20, 20);
            this.addMinAlarm.Name = "addMinAlarm";
            this.addMinAlarm.Size = new System.Drawing.Size(20, 20);
            this.addMinAlarm.TabIndex = 2;
            this.addMinAlarm.Text = "+";
            this.addMinAlarm.UseVisualStyleBackColor = true;
            this.addMinAlarm.Click += new System.EventHandler(this.addMin_Click);
            // 
            // addSecAlarm
            // 
            this.addSecAlarm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addSecAlarm.Location = new System.Drawing.Point(288, 5);
            this.addSecAlarm.MaximumSize = new System.Drawing.Size(20, 20);
            this.addSecAlarm.Name = "addSecAlarm";
            this.addSecAlarm.Size = new System.Drawing.Size(20, 20);
            this.addSecAlarm.TabIndex = 3;
            this.addSecAlarm.Text = "+";
            this.addSecAlarm.UseVisualStyleBackColor = true;
            this.addSecAlarm.Click += new System.EventHandler(this.addSec_Click);
            // 
            // lessMinAlarm
            // 
            this.lessMinAlarm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lessMinAlarm.Location = new System.Drawing.Point(164, 77);
            this.lessMinAlarm.MaximumSize = new System.Drawing.Size(20, 20);
            this.lessMinAlarm.Name = "lessMinAlarm";
            this.lessMinAlarm.Size = new System.Drawing.Size(20, 20);
            this.lessMinAlarm.TabIndex = 4;
            this.lessMinAlarm.Text = "-";
            this.lessMinAlarm.UseVisualStyleBackColor = true;
            this.lessMinAlarm.Click += new System.EventHandler(this.lessMin_Click);
            // 
            // lessSecAlarm
            // 
            this.lessSecAlarm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lessSecAlarm.Location = new System.Drawing.Point(288, 77);
            this.lessSecAlarm.MaximumSize = new System.Drawing.Size(20, 20);
            this.lessSecAlarm.Name = "lessSecAlarm";
            this.lessSecAlarm.Size = new System.Drawing.Size(20, 20);
            this.lessSecAlarm.TabIndex = 5;
            this.lessSecAlarm.Text = "-";
            this.lessSecAlarm.UseVisualStyleBackColor = true;
            this.lessSecAlarm.Click += new System.EventHandler(this.lessSec_Click);
            // 
            // Hour
            // 
            this.Hour.AutoSize = true;
            this.Hour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hour.Location = new System.Drawing.Point(3, 30);
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(97, 42);
            this.Hour.TabIndex = 6;
            this.Hour.Text = "00";
            this.Hour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Hour.Click += new System.EventHandler(this.Hour_Click);
            // 
            // Min
            // 
            this.Min.AutoSize = true;
            this.Min.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min.Location = new System.Drawing.Point(126, 30);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(97, 42);
            this.Min.TabIndex = 7;
            this.Min.Text = "00";
            this.Min.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sec
            // 
            this.Sec.AutoSize = true;
            this.Sec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sec.Location = new System.Drawing.Point(249, 30);
            this.Sec.Name = "Sec";
            this.Sec.Size = new System.Drawing.Size(99, 42);
            this.Sec.TabIndex = 8;
            this.Sec.Text = "00";
            this.Sec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 42);
            this.label2.TabIndex = 10;
            this.label2.Text = ":";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // counter
            // 
            this.counter.Enabled = true;
            this.counter.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(359, 163);
            this.Controls.Add(this.TimerTabs);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frame";
            this.Opacity = 0.5D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.Activated += new System.EventHandler(this.frame_Activated);
            this.Deactivate += new System.EventHandler(this.frame_Deactivate);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.btnPanel.ResumeLayout(false);
            this.TimerTabs.ResumeLayout(false);
            this.Time.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.StopWatch.ResumeLayout(false);
            this.StopWatch.PerformLayout();
            this.Alarm.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.TableLayoutPanel topPanel;
        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.TabControl TimerTabs;
        private System.Windows.Forms.TabPage Time;
        private System.Windows.Forms.TabPage StopWatch;
        private System.Windows.Forms.Label countTime;
        private System.Windows.Forms.TabPage Alarm;
        private System.Windows.Forms.Timer counter;
        private System.Windows.Forms.TableLayoutPanel btnPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button addHourAlarm;
        private System.Windows.Forms.Button lessHourAlarm;
        private System.Windows.Forms.Button addMinAlarm;
        private System.Windows.Forms.Button addSecAlarm;
        private System.Windows.Forms.Button lessMinAlarm;
        private System.Windows.Forms.Button lessSecAlarm;
        private System.Windows.Forms.Label Hour;
        private System.Windows.Forms.Label Min;
        private System.Windows.Forms.Label Sec;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button addHourTimer;
        private System.Windows.Forms.Button lessHourTimer;
        private System.Windows.Forms.Button addMinTimer;
        private System.Windows.Forms.Button addSecTimer;
        private System.Windows.Forms.Button lessMinTimer;
        private System.Windows.Forms.Button lessSecTimer;
        private System.Windows.Forms.Label countHour;
        private System.Windows.Forms.Label countMin;
        private System.Windows.Forms.Label countSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

