using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week1Challenge
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NameAndAge()
        {
            string firstName = "Eric";
            string lastName = "Bella";
            int age = 44;
            Console.WriteLine(age + 7);
            Console.WriteLine(age - 7);
            Console.WriteLine(age * 7);
            Console.WriteLine(age / 7);
            Console.WriteLine(age % 7);

        }

        [TestMethod]
        public void Array()
        {
            string[] movie = { "Back to the Future", "Ghost Busters", "Nightmare Before Christmas", "Pay it Forward" };
        }

        [TestMethod]
        public void ListOfDates()
        {
            List<DateTime> listOfDates = new List<DateTime>();
            DateTime today = DateTime.Now;
            listOfDates.Add(today);
            listOfDates.Add(new DateTime(2020, 12, 25));
            listOfDates.Add(new DateTime(2020, 9, 23));
            listOfDates.Add(new DateTime(2020, 12, 14));
        }

        [TestMethod]
        public void HowMuchSleepDidYouGet()
        {
            Console.WriteLine("How many hours of sleep did you get???");
            int hours = 4;
            if (hours >= 10)
            {
                Console.WriteLine("Wow, that's a lot of sleep");
            }
            else if (hours >= 8 && hours < 10)
            {
                Console.WriteLine("You should be well rested");
            }
            else if (hours > 4 && hours < 8)
            {
                Console.WriteLine("Bummer");
            }
            else
            {
                Console.WriteLine("Oh man get some sleep~!");
            }
        }
        [TestMethod]
        public void HowHasYourDayBeen()
        {
            string userDay = "Okay";
            switch (userDay)
            {
                case "Great":
                    Console.WriteLine("Glad you are having a great day");
                    break;
                case "Good":
                    Console.WriteLine("It is a day to be good on");
                    break;
                case "Okay":
                    Console.WriteLine("Hopefully it will get better from here");
                    break;
                case "Bad":
                    Console.WriteLine("There is always tomorrow");
                    break;
                case ":(":
                    Console.WriteLine("I guess this is us now");
                    break;
                default:
                    Console.WriteLine("Please enter something above");
                    break;
            }
        }
        [TestMethod]
        public void Supercalifragilisticexpialidocious()
        {
            string name = "Supercalifragilisticexpialidocious";
            foreach (char letter in name)
            {
                if (letter == 'i')
                {
                    Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine("not an i");
                }

            }
        }
    }
}
