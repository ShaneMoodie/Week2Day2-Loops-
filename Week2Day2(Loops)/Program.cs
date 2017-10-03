using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day2_Loops_
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                // Console.WriteLine(i);
            }
            //for (int counter = 50; counter <= 100; counter++) 
            //{
            //    //Console.WriteLine(counter);
            //}
            //string greetings = "My name is Shane.";
            //string[] words = greetings.Split();

            //for (int i = 0; i < words.Length; i++) 
            //{
            //    Console.WriteLine(words[i]); 
            //}

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i); 
            //}

            //for (int counter = 50; counter <= 100; counter++)
            //{
            //    Console.WriteLine(counter);
            //}

            //string greeting = "My name is Little Bill.";
            //string[] words = greeting.Split();

            //for(int i = 0; i < words.Length; i++)
            //{
            //    Console.WriteLine(words[i]);
            //}

            //string weekDays = "Monday Tuesday Wednesday";
            //string[] daysOfWeek = weekDays.Split();

            //for (int i = 0; i < daysOfWeek.Length; i++)
            //{
            //    Console.WriteLine(daysOfWeek[i]);
            //}



            //string storyTime = ("Once upon a time");
            //string[] storyWords = storyTime.Split();
            //Array.Reverse(storyWords);

            //for (int i = 0; i < storyWords.Length; i++)
            //{
            //    Console.WriteLine(storyWords[i]);
            //}

            //string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

            //foreach(string month in months)
            //{
            //    Console.WriteLine(month);
            //}


            //string[] bands = { "Smashing Pumpkins", "Silversun Pickups", "Mazzy Star", "Slowdive", "My Bloody Valentine" };

            //foreach(string band in bands)
            //{
            //    Console.WriteLine(band);
            //}


            string[] favoriteFoods = { "Steak", "Baked potato", "Lobster", "Tilapia", "Chili" };

            foreach(string food in favoriteFoods)
            {
                Console.WriteLine(food);
            }


            int[] luckyNumber = { 3, 5, 7, 11, 15 };

            foreach(int number in luckyNumber)
            {
                Console.WriteLine("Your lucky number is: " + number);
            }

        }
    }
}
