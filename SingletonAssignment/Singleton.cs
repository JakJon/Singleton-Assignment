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

        public string getRunningTimeInSeconds()
        {
            long timeSeconds = timer.ElapsedMilliseconds / 1000;
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
