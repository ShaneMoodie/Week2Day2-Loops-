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
            //for (int i = 0; i <= 10; i++)
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


            //Counting up
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


            //string[] favoriteFoods = { "Steak", "Baked potato", "Lobster", "Tilapia", "Chili" };

            //foreach(string food in favoriteFoods)
            //{
            //    Console.WriteLine(food);
            //}


            //int[] luckyNumber = { 31, 25, 7, 11, 15 };
            //Array.Sort(luckyNumber);

            //foreach(int number in luckyNumber)
            //{
            //    Console.WriteLine("Your lucky number is: " + number);
            //}

            //Counting down
            //for(int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            ////While - conditional loop
            //Console.WriteLine("Do you want to play the game? (YES/NO)");
            //string playAgain = Console.ReadLine().ToLower();
            //while(playAgain == "YES".ToLower())
            //{
            //    Console.WriteLine("It's a rematch!");
            //    Console.WriteLine("Do you want to play again (YES/NO)");
            //    playAgain = Console.ReadLine();
            //}


            //Console.WriteLine("Hello PATIENT. Would you like to check into your appointment? (YES/NO)");
            //string patientAnswer = Console.ReadLine().ToUpper();
            //while(patientAnswer == "YES".ToUpper() || patientAnswer == "SURE".ToUpper())
            //{
            //    Console.WriteLine("PATIENT CHECK-IN SYSTEM");
            //    Console.WriteLine("\n" + "Please type your full name.");
            //    string userName = Console.ReadLine().ToUpper();
            //    Console.WriteLine("\n" + "Please provide your 6-digit patient ID.");
            //    int userID = int.Parse(Console.ReadLine());
            //    Console.WriteLine("\n" + "What is your appointment time?");
            //    string apptTime = Console.ReadLine();

            //    Console.WriteLine("Would you like to check in another patient?");
            //    patientAnswer = Console.ReadLine().ToUpper();
            //}


            ////dowhile - essentially upside down while loop
            //string playAgain;
            //do
            //{
            //    Console.WriteLine("Great game!");
            //    Console.WriteLine("Do you want to play again?");
            //    playAgain = Console.ReadLine();
            //}
            //while (playAgain == "YES");

            //Console.WriteLine("Thanks for playing the game!");


            //GPA Calculation
            //string userAnswer;
            //do
            //{
            //    Console.WriteLine("Would you like to add a class to your GPA calculation?");
            //    userAnswer = Console.ReadLine().ToUpper();
            //    Console.WriteLine("What class would you like to add?");
            //    string classAdd = Console.ReadLine().ToUpper();
            //    Console.WriteLine("What is your letter grade for this class?");
            //    string grade = Console.ReadLine().ToUpper();

            //    Console.WriteLine("Would you like to add another class to your GPA calculator?");
            //    userAnswer = Console.ReadLine().ToUpper();
            //}
            //while (userAnswer == "YES".ToUpper());


            ////continue - stops loop and proceeds to next iteration
            //for(int i = 0; i < 20; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);

            //}

            ////break - stops loop at predesignated point ---- USE SPARRINGLY and ONLY in loop
            //for(int i = 1; i <= 20; i++)
            //{
            //    if(i % 13 == 0)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("The loop has finished.");


            ////Nested Loop - loop within a loop
            //for (int i = 1; i <= 2; i++) //2 defines repeats
            //{
            //    for (int j = 1; j <= 4; j++) //4 defines number counted to (1-4)
            //    {
            //        Console.Write(j); //columns
            //    }
            //    Console.WriteLine(); //next row
            //}

            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
            

        }
    }
}
