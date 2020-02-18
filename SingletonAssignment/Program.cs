using System;
using System.Timers;
using SingletonAssignment;

namespace SingletonAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SingletonTimer timer = SingletonTimer.GetSingletonTimer();
            timer.startTimer();

            start();

            void start() {

                string time;
                string input;
               
                Console.WriteLine("\n A singleton timer has been created...");
                Console.WriteLine("\n Options: \n\n I: \t show running time in milliseconds \n S: \t show running time in seconds \n M: \t show running time in minutes \n H: \t show running time in hours \n\n");

                input = Console.ReadLine().ToUpper();
                
                switch (input)
                {
                    case "I":
                        time = timer.getRunningTime();
                        Console.WriteLine("\n\n\t RUN TIME: " + time + " Milliseconds");
                        start();
                        break;
                    case "S":
                        time = timer.getRunningTimeInSeconds();
                        Console.WriteLine("\n\n\t RUN TIME: " + time + " Seconds");
                        start();
                        break;
                    case "M":
                        time = timer.getRunningTimeInMinutes();
                        Console.WriteLine("\n\n\t RUN TIME: " + time + " Minutes");
                        start();
                        break;
                    case "H":
                        time = timer.getRunningTimeInHours();
                        Console.WriteLine("\n\n\t RUN TIME: " + time + " Hours");
                        start();
                        break;
                    default:
                        start();
                        break;
                }           
            }
        }
    }
}
