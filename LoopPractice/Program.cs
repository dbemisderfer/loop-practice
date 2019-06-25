using System;

namespace LoopPractice
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ///////////////////////////////
            /////// People counter ////////
            ///////////////////////////////
            Console.WriteLine("Press ENTER to add to count. Enter any other key + ENTER to stop counting.");

            int counter = 0;
            bool finishedCounting = false;

            while(!finishedCounting)
            {
                string input = Console.ReadLine();
                if(input == "")
                {
                    counter += 1;
                    Console.WriteLine("{0} student(s) currently on the bus.", counter);

                } else
                {
                    finishedCounting = true;
                }
            }
            Console.WriteLine("All " + counter + " students are on the bus.");

            ///////////////////////////////
            //////// Test scores //////////
            ///////////////////////////////
            //Console.Write("How many test scores are you entering? ");
            //string input = Console.ReadLine();
            //int numberOfTestScores = int.Parse(input);
            //int scoreSum = 0;
            //int counter = 1;
           
            //do
            //{
            //    Console.Write("Please enter the student score: ");
            //    string studentScore = Console.ReadLine();
            //    int scoreNum = int.Parse(studentScore);
            //    scoreSum += scoreNum;
            //    counter++;

            //} while (counter <= numberOfTestScores);
            //int testAverage = scoreSum / numberOfTestScores;
            //Console.WriteLine("The average of the test scores is: " + testAverage);

            ///////////////////////////////
            //////// Odd numbers //////////
            ///////////////////////////////
            //for(int i = 1; i <=20; i+=2)
            //{
            //    Console.WriteLine(i + " is an odd number that is less than 20.");
            //}
        }
    }
}
