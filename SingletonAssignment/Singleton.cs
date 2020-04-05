using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SingletonAssignment
{
    public sealed class SingletonTimer
    {
        private static readonly SingletonTimer _instance = new SingletonTimer();
        private static Stopwatch timer = new Stopwatch();

        private SingletonTimer()
        {

        }

        public enum timeUnit {
            Millisecond = 1,
            Second = 1000,
            Minute = 60000,
            Hour = 3600000
        }

        public static SingletonTimer GetSingletonTimer()
        {
            return _instance;
        }

        public void startTimer()
        {
            timer.Start();
        }

        public string getRunningTime()
        {
            return timer.ElapsedMilliseconds.ToString();
        }

        public string getTime(timeUnit Unit)
        {
            long timeSeconds = timer.ElapsedMilliseconds / Convert.ToInt32(Unit);
            return timeSeconds.ToString();
        }

        public string getRunningTimeInMinutes()
        {
            long timeSeconds = timer.ElapsedMilliseconds / 1000;
            long timeMinutes = timeSeconds / 60;
            return timeMinutes.ToString();
        }

        public string getRunningTimeInHours()
        {
            long timeSeconds = timer.ElapsedMilliseconds / 1000;
            long timeHours = timeSeconds / 3600;
            return timeHours.ToString();
        }
    }
}
