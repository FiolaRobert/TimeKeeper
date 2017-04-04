using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Time
{
    public partial class frame : Form
    {
        private enum Sounds {Timer, Alarm, Click};
        private TimeSpan currentTime;//now
        private TimeSpan timeCounter;//time of start
        private bool isTimer = true;//timer selected
        private bool isStop = false;//stopwatch selected
        private bool isAlarm = false;//alarm selected
        private bool isPause = false;//paused
        private TimeSpan setTimer;//countdown timer
        private TimeSpan setAlarm;//alarm time
        private SoundPlayer clickSound=new SoundPlayer();
        private SoundPlayer alarmSound = new SoundPlayer();


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

            try {
                //load audio
                clickSound.SoundLocation = "C:\\Users\\Rob\\Documents\\Documents\\Software\\Time\\Time\\click.wav";
                Console.WriteLine(clickSound.SoundLocation);
                if (clickSound.SoundLocation != null)
                    clickSound.Load();
                alarmSound.SoundLocation = "C:\\Users\\Rob\\Documents\\Documents\\Software\\Time\\Time\\alarm.wav";
                Console.WriteLine(alarmSound.SoundLocation);
                if (alarmSound.SoundLocation != null)
                    alarmSound.Load();
            }catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
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
            // this.ClientSize = new System.Drawing.Size(359, 100);
            topPanel.Hide();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            hideButtons();
        }

        private void frame_Activated(object sender, EventArgs e)
        {
            //this.ClientSize = new System.Drawing.Size(359, 163);
            topPanel.Show();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            showButtons();
        }

        private void hideButtons()
        {
            addHourTimer.Visible = false;
            addMinTimer.Visible = false;
            addSecTimer.Visible = false;
            lessHourTimer.Visible = false;
            lessMinTimer.Visible = false;
            lessSecTimer.Visible = false;

        }

        private void showButtons()
        {
            addHourTimer.Visible = true;
            addMinTimer.Visible = true;
            addSecTimer.Visible = true;
            lessHourTimer.Visible = true;
            lessMinTimer.Visible = true;
            lessSecTimer.Visible = true;

        }  
          
        private void setTimeCounter()
        {
            timeCounter = new TimeSpan(DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond);
        }

        private void TimerTabs_Selected(object sender, TabControlEventArgs e)
        {
            isStart = false;
            
            //select timer, stopwatch, or alarm
            switch (e.TabPageIndex)
            {
                case 0: isTimer = true; isAlarm = false; isStop = false; showButtons(); resetTimer(); break;
                case 1: isTimer = false; isAlarm = false; isStop = true; hideButtons(); resetStopWatch(); break;
                case 2: isTimer = false; isAlarm = true; isStop = false; showButtons(); resetAlarm(currentTime+new TimeSpan(1,0,0)); break;
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
                        playSound((int)Sounds.Alarm);
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
                        playSound((int)Sounds.Alarm);
                    }
                }
            }
        }

        private void playSound(int sound)
        {
            //play alarm sound
            //add alarm sound here
            //Console.WriteLine(source+" BEEEEEEP");
            String message = "BEEEEEEEP ";
            switch (sound)
                {
                case 0://Timer
                    if (alarmSound.IsLoadCompleted)
                        alarmSound.Play();
                    message += "Timer";
                    //Console.WriteLine("Timer"+" BEEEEEEP");
                    break;
                case 1://Alarm
                    if (alarmSound.IsLoadCompleted)
                        alarmSound.Play();
                    message += "Alarm";
                    //Console.WriteLine("Alarm"+" BEEEEEEP");
                    break;
                case 2://Click
                    if (clickSound.IsLoadCompleted)
                        clickSound.Play();
                    message += "Click";
                    //Console.WriteLine("Click");
                    break;
                default: break;
            }

            //var result = MessageBox.Show(sound+message);
        }
        

        private void runStopWatch()
        {
            TimeSpan diff = (currentTime - timeCounter);
            //Console.WriteLine(diff);
            countTime.Text = String.Format("{0:00}h:{1:00}m:{2:00}s:{3:00}",diff.Hours,diff.Minutes,diff.Seconds, diff.Milliseconds/10 );
        }

        private void resetStopWatch()
        {
            
            countTime.Text = "00h:00m:00s:00";
        }

        private TimeSpan runTimer()
        { 
           TimeSpan countdown= timeCounter+setTimer - currentTime;
            countHour.Text= String.Format("{0:00}h", countdown.Hours);
            countMin.Text = String.Format("{0:00}m", countdown.Minutes);
            countSec.Text = String.Format("{0:00}s", countdown.Seconds);
            //Console.WriteLine(countdown);
            return countdown;
        }

        private void resetTimer()
        {
            countHour.Text = "00h";
            countMin.Text = "00m";
            countSec.Text = "00s";
        }
        
        private void resetAlarm(TimeSpan time)
        {
            Hour.Text =String.Format( "{0:00}h",time.Hours);
            Min.Text = String.Format("{0:00}m", time.Minutes);
            Sec.Text = String.Format("{0:00}s", time.Seconds);
        }

        private TimeSpan getAlarm()
        {
            int hour = Int32.Parse(Hour.Text.Substring(0, 2));
            int minute = Int32.Parse(Min.Text.Substring(0, 2));
            int second = Int32.Parse(Sec.Text.Substring(0, 2));
            return new TimeSpan(DateTime.Now.Day, hour, minute, second, 0);
        }

        private void Hour_Click(object sender, EventArgs e)
        {
            //timeCounter = currentTime;//*continue from stopped time
            isPause = !isPause; }

        private void time_Click(object sender, EventArgs e)
        {            
            if (sender.Equals(addHourTimer))
            {
                if(isTimer)
                {
                    int hour = Int32.Parse(countHour.Text.Substring(0, 2));
                    hour++;
                    if (hour > 24)
                        hour = 1;
                    countHour.Text = String.Format("{0:00h}", hour);
                }
                else if(isAlarm)
                {
                    int hour = Int32.Parse(Hour.Text.Substring(0, 2));
                    hour++;
                    if (hour > 24)
                        hour = 1;
                    Hour.Text = String.Format("{0:00}h", hour);
                }
                
            }
             else   if (sender.Equals(addMinTimer))
            {
                if(isTimer)
                {
                    int min = Int32.Parse(countMin.Text.Substring(0, 2));
                    min++;
                    if (min > 59)
                        min = 0;
                    countMin.Text = String.Format("{0:00}m", min);
                }
                else if(isAlarm)
                {
                    int min = Int32.Parse(Min.Text.Substring(0, 2));
                    min++;
                    if (min > 59)
                        min = 0;
                    Min.Text = String.Format("{0:00}m", min);
                    //timeCounter.Add(TimeSpan.FromMinutes(1.0));
                }

            }
              else  if (sender.Equals(addSecTimer))
            {
                if (isTimer)
                {
                    int sec = Int32.Parse(countSec.Text.Substring(0, 2));
                    sec++;
                    if (sec > 99)
                        sec = 0;
                    countSec.Text = String.Format("{0:00}s", sec);
                    //timeCounter.Add(TimeSpan.FromSeconds(1.0));
                }
                else if (isAlarm)
                {
                    int sec = Int32.Parse(Sec.Text.Substring(0, 2));
                    sec++;
                    if (sec > 59)
                        sec = 0;
                    Sec.Text = String.Format("{0:00}s", sec);
                    //timeCounter.Add(TimeSpan.FromSeconds(1.0));
                }
            }
            else if (sender.Equals(lessSecTimer))
            {
                if(isTimer)
                {
                    int sec = Int32.Parse(countSec.Text.Substring(0, 2));
                    sec--;
                    if (sec < 0)
                        sec = 59;
                    countSec.Text = String.Format("{0:00}s", sec);
                }
                else if(isAlarm)
                {
                    int sec = Int32.Parse(Sec.Text.Substring(0, 2));
                    sec--;
                    if (sec < 0)
                        sec = 59;
                    Sec.Text = String.Format("{0:00}s", sec);
                    //timeCounter.Add(-(TimeSpan.FromSeconds(1.0)));
                }

            }
            else if (sender.Equals(lessHourTimer))
            {
                if(isTimer)
                {
                    int hour = Int32.Parse(countHour.Text.Substring(0, 2));
                    hour--;
                    if (hour < 0)
                    {
                        hour = 99;
                    }
                    countHour.Text = String.Format("{0:00}h", hour);
                }
                else if(isAlarm)
                {
                    int hour = Int32.Parse(Hour.Text.Substring(0, 2));
                    hour--;
                    if (hour < 1)
                    {
                        hour = 24;
                    }
                    Hour.Text = String.Format("{0:00}h", hour);
                    //timeCounter.Add(-(TimeSpan.FromHours(1.0)));
                }

            }
            else if (sender.Equals(lessMinTimer))
            {
                if (isTimer)
                {
                    int min = Int32.Parse(countMin.Text.Substring(0, 2));
                    min--;
                    if (min < 0)
                    {
                        min = 59;
                    }
                    countMin.Text = String.Format("{0:00}m", min);
                }
                else if (isAlarm)
                {
                    int min = Int32.Parse(Min.Text.Substring(0, 2));
                    min--;
                    if (min < 0)
                    {
                        min = 59;
                    }
                    Min.Text = String.Format("{0:00}m", min);
                    //timeCounter.Add(-(TimeSpan.FromMinutes(1.0)));
                }
            }
            playSound((int)Sounds.Click);
        }
        private void button_Click(object sender, EventArgs e)
        {
           // Console.WriteLine(sender.GetType());
           // Console.WriteLine(sender);
           // Console.WriteLine(e);
           
            if(sender.Equals(stopBtn))
            {
                showButtons();
                isStart = false;
                //pause timer
                playSound((int)Sounds.Click);
                startBtn.Enabled = true;
                stopBtn.Enabled = false;
                resetBtn.Enabled = true;
            }
            else if(sender.Equals(startBtn))
            {
                hideButtons();
                setTimeCounter();
                if (isStop)
                {
                    resetStopWatch();
                }
                else if (isTimer)
                {
                    int hour = Int32.Parse(countHour.Text.Substring(0, 2));
                    int minute = Int32.Parse(countMin.Text.Substring(0, 2));
                    int second = Int32.Parse(countSec.Text.Substring(0, 2));
                    setTimer = new TimeSpan(0, hour, minute, second, 0);
                }
                else if (isAlarm)
                { setAlarm = getAlarm(); }

                isStart = true;
                playSound((int)Sounds.Click);
                startBtn.Enabled = false;
                stopBtn.Enabled = true;
                //get current time
                //start timer
        
            }
            else if(sender.Equals(resetBtn))
            {
                if (isTimer)
                {
                    resetTimer();
                }
                else if (isStop)
                {
                    resetStopWatch();
                }
                else if (isAlarm)
                {
                    resetAlarm(setAlarm);
                }
                //reset timer
                playSound((int)Sounds.Click);
                startBtn.Enabled = true;
                resetBtn.Enabled = false;
            }

            playSound((int)Sounds.Click);
        }
    }
}
