using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time
{
    public partial class frame : Form
    {
        private TimeSpan currentTime;//now
        private TimeSpan timeCounter;//time of start
        private bool isTimer = true;//timer selected
        private bool isStop = false;//stopwatch selected
        private bool isAlarm = false;//alarm selected
        private bool isPause = false;//paused
        private TimeSpan setTimer;//countdown timer
        private TimeSpan setAlarm;//alarm time
        
        private bool isStart = false;
        
        public frame()
        {
            InitializeComponent();
            setCurrentTime();
            setTimeCounter();
            resetTimer();
            resetStopWatch();
            setAlarm = currentTime;
            resetAlarm(setAlarm);
            updateClock();
        }

        private void setCurrentTime()
        {
            currentTime = new TimeSpan(DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond);
        }

        private void updateClock()
        {
            clock.Text=currentTime.ToString(@"hh\:mm\:ss");
        }

        private void closeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Program.close();
        }

        private void frame_Deactivate(object sender, EventArgs e)
        {
            hideButtons();
        }

        private void frame_Activated(object sender, EventArgs e)
        {
            showButtons();
        }

        private void hideButtons()
        {
            topPanel.Hide();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            addHourAlarm.Visible = false;
            addMinAlarm.Visible = false;
            addSecAlarm.Visible = false;
            addHourTimer.Visible = false;
            addMinTimer.Visible = false;
            addSecTimer.Visible = false;
            lessHourAlarm.Visible = false;
            lessMinAlarm.Visible = false;
            lessSecAlarm.Visible = false;
            lessHourTimer.Visible = false;
            lessMinTimer.Visible = false;
            lessSecTimer.Visible = false;

        }

        private void showButtons()
        {
            topPanel.Show();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            addHourAlarm.Visible = true;
            addMinAlarm.Visible = true;
            addSecAlarm.Visible = true;
            addHourTimer.Visible = true;
            addMinTimer.Visible = true;
            addSecTimer.Visible = true;
            lessHourAlarm.Visible = true;
            lessMinAlarm.Visible = true;
            lessSecAlarm.Visible = true;
            lessHourTimer.Visible = true;
            lessMinTimer.Visible = true;
            lessSecTimer.Visible = true;

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            if(isTimer)
            {
                resetTimer();
            }else if(isStop)
            {
                resetStopWatch();
            }
            else if(isAlarm)
            {
                resetAlarm(currentTime);
            }
            //reset timer
            beep();
            startBtn.Enabled = true;
            resetBtn.Enabled = false;
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            isStart = false;
            //pause timer
            beep();
            startBtn.Enabled = true;
            stopBtn.Enabled = false;
            resetBtn.Enabled = true;
        }

        private void setTimeCounter()
        {
            timeCounter = new TimeSpan(DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond);
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            setTimeCounter();
            if (isStop)
            {
                resetStopWatch();
            }
            else if (isTimer)
            {
                int hour = Int32.Parse(countHour.Text);
                int minute = Int32.Parse(countMin.Text);
                int second = Int32.Parse(countSec.Text);
                setTimer = new TimeSpan(0, hour, minute, second, 0);
            }
            else if (isAlarm)
            { setAlarm = getAlarm(); }
            
            isStart = true;
            beep();
            startBtn.Enabled = false;
            stopBtn.Enabled = true;
            
            //get current time
            //start timer
        }

        private void TimerTabs_Selected(object sender, TabControlEventArgs e)
        {
            //select timer, stopwatch, or alarm
            switch (e.TabPageIndex)
            {
                case 0: isTimer = true; isAlarm = false; isStop = false; break;
                case 1: isTimer = false; isAlarm = false; isStop = true; break;
                case 2: isTimer = false; isAlarm = true; isStop = false; break;
                default: isTimer = true; isAlarm = false; isStop = false; break;
            }
            //Console.WriteLine("Timer:" + isTimer + ", StopWatch:" + isStop + ", Alarm:" + isAlarm);
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            setCurrentTime();
            updateClock();
            
            //check time
            //update timer
            if (!isPause && isStart)
            {
                //Console.WriteLine("{0:t}", currentTime);
                // count down to 0
                if (isTimer)
                {
                    TimeSpan timeLeft = runTimer();
                    if (timeLeft.Hours == 0 && timeLeft.Minutes == 0 && timeLeft.Seconds == 00)
                    {
                        isStart = false;
                        alarmSound("Timer");
                    }
                }
                else if (isStop)
                {
                    runStopWatch();
                }
                if(isAlarm)
                {
                    if (setAlarm <= currentTime)//meet alarm time
                    {
                        isStart = false;
                        alarmSound("Alarm");
                    }
                }
            }
        }

        private void alarmSound(String source)
        {
            //play alarm sound
            //add alarm sound here
            //Console.WriteLine(source+" BEEEEEEP");
            const string message =" BEEEEEEEP";
            var result = MessageBox.Show(source+message, source);
        }

        private void beep()
        {
            //add sounds here
            //Console.WriteLine("Beep");
        }

        private void runStopWatch()
        {
            TimeSpan diff = (currentTime - timeCounter);
            //Console.WriteLine(diff);
            countTime.Text = String.Format("{0:00}h:{1:00}m:{2:00}s:{3:00}ms",diff.Hours,diff.Minutes,diff.Seconds, diff.Milliseconds );
        }

        private void resetStopWatch()
        {
            
            countTime.Text = "00h:00m:00s";
        }

        private TimeSpan runTimer()
        { 
           TimeSpan countdown= timeCounter+setTimer - currentTime;
            countHour.Text= String.Format("{0:00}h :", countdown.Hours);
            countMin.Text = String.Format("{0:00}m :", countdown.Minutes);
            countSec.Text = String.Format("{0:00}s", countdown.Seconds);
            //Console.WriteLine(countdown);
            return countdown;
        }

        private void resetTimer()
        {
            countHour.Text = "00";
            countMin.Text = "00";
            countSec.Text = "00";
        }
        
        private void resetAlarm(TimeSpan time)
        {
            Hour.Text =String.Format( "{0:00}",time.Hours);
            Min.Text = String.Format("{0:00}", time.Minutes);
            Sec.Text = String.Format("{0:00}", time.Seconds);
        }
        private TimeSpan getAlarm()
        {
            int hour = Int32.Parse(Hour.Text);
            int minute = Int32.Parse(Min.Text);
            int second = Int32.Parse(Sec.Text);
            return new TimeSpan(hour, minute, second);
        }

        private void addHour_Click(object sender, EventArgs e)
        {
            int hour = Int32.Parse(Hour.Text);
            hour++;
            if (hour > 24)
                hour = 1;
            Hour.Text = String.Format("{0:00}" , hour);
        }

        private void addMin_Click(object sender, EventArgs e)
        {
            int min = Int32.Parse(Min.Text);
            min++;
            if (min > 59)
                min = 0;
            Min.Text = String.Format("{0:00}", min);
            //timeCounter.Add(TimeSpan.FromMinutes(1.0));
        }

        private void addSec_Click(object sender, EventArgs e)
        {
            int sec = Int32.Parse(Sec.Text);
            sec++;
            if (sec > 59)
                sec = 0;
            Sec.Text = String.Format("{0:00}", sec);
            //timeCounter.Add(TimeSpan.FromSeconds(1.0));
        }

        private void lessHour_Click(object sender, EventArgs e)
        {
            int hour = Int32.Parse(Hour.Text);
            hour--;
            if (hour < 1)
            {
                hour = 24;
            }
                Hour.Text = String.Format("{0:00}", hour);
            //timeCounter.Add(-(TimeSpan.FromHours(1.0)));
        }

        private void lessMin_Click(object sender, EventArgs e)
        {
            int min = Int32.Parse(Min.Text);
            min--;
            if (min < 0)
            {
                min = 59;
            }
            Min.Text = String.Format("{0:00}", min);
            //timeCounter.Add(-(TimeSpan.FromMinutes(1.0)));
        }

        private void lessSec_Click(object sender, EventArgs e)
        {
            int sec = Int32.Parse(Sec.Text);
            sec--;
            if (sec < 0)
                sec = 59;
            Sec.Text = String.Format("{0:00}", sec);
            //timeCounter.Add(-(TimeSpan.FromSeconds(1.0)));
        }

        private void Hour_Click(object sender, EventArgs e)
        {
            isPause = true;
        }

        private void addHourTimer_Click(object sender, EventArgs e)
        {
            int hour = Int32.Parse(countHour.Text);
            hour++;
            if (hour > 24)
                hour = 1;
            countHour.Text = String.Format("{0:00}", hour);
        }

        private void addMinTimer_Click(object sender, EventArgs e)
        {
            int min = Int32.Parse(countMin.Text);
            min++;
            if (min > 59)
                min = 0;
            countMin.Text = String.Format("{0:00}", min);
        }

        private void addSecTimer_Click(object sender, EventArgs e)
        {
            int sec = Int32.Parse(countSec.Text);
            sec++;
            if (sec > 99)
                sec = 0;
            countSec.Text = String.Format("{0:00}", sec);
            //timeCounter.Add(TimeSpan.FromSeconds(1.0));
        }

        private void lessHourTimer_Click(object sender, EventArgs e)
        {
            int hour = Int32.Parse(countHour.Text);
            hour--;
            if (hour < 0)
            {
                hour = 99;
            }
            countHour.Text = String.Format("{0:00}", hour);
        }

        private void lessMinTimer_Click(object sender, EventArgs e)
        {
            int min = Int32.Parse(countMin.Text);
            min--;
            if (min < 0)
            {
                min = 59;
            }
            countMin.Text = String.Format("{0:00}", min);
        }

        private void lessSecTimer_Click(object sender, EventArgs e)
        {
            int sec = Int32.Parse(countSec.Text);
            sec--;
            if (sec < 0)
                sec = 59;
            countSec.Text = String.Format("{0:00}", sec);
        }
    }
}
