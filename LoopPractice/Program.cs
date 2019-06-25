using System;

namespace LoopPractice
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            ///////////////////////////////////////////
            /////// Student Averages Challenge ////////
            ///////////////////////////////////////////
            //Console.WriteLine("Please enter a score between 0 and 20. To get the total average of all scores entered, type -1.");
            //double count = 0;
            //double sumOfScores = 0;
            //double average = 0;
            //int value;
            //bool finished = false;

            //try
            //{
            //    while (!finished)
            //    {
            //        string input = Console.ReadLine();

            //        if (int.TryParse(input, out value) && value >= 0 && value <= 20)
            //        {
            //            sumOfScores += value;
            //            Console.WriteLine(sumOfScores);
            //            count++;
            //            Console.WriteLine(count);

            //        }
            //        else if (int.TryParse(input, out value) && value == -1)
            //        {

            //            average = sumOfScores / count;
            //            if (average.ToString().Equals("NaN"))
            //            {
            //                Console.WriteLine("Sorry, you must enter at least one student's score before entering -1. Please restart the app.");
            //                break;
            //            }
            //            Console.WriteLine("The average of all scores entered is: {0}", average);
            //            finished = true;

            //        }
            //        else
            //        {
            //            Console.WriteLine("Sorry, you're a total loser! Please start the app over.");
            //            finished = true;
            //        }
            //    }

            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Sorry, you must enter at least one student's score before entering -1. Please restart the app.");
            //}

            ///////////////////////////////////////////
            /////// Student Averages Challenge ////////
            /////////// Alternate Solution ////////////
            ///////////////////////////////////////////
            string input = "";
            int count = 0;
            int total = 0;
            int currentNumber = 0;

            while(input != "-1")
            {
                Console.WriteLine("Last number entered was {0}", currentNumber);
                Console.WriteLine("Please enter the next score.");
                Console.WriteLine("Current amount of entries is: {0}", count);
                Console.WriteLine("Please enter -1 once you are ready to calculate the average.");

                input = Console.ReadLine();
                if(input.Equals("-1"))
                {
                    Console.WriteLine("----------------------------------------");
                    double average = (double)total / (double)count;
                    if (average.ToString().Equals("NaN"))
                    {
                        Console.WriteLine("Sorry, you must enter at least one student's score before entering -1. Please restart the app.");
                    }
                    else
                    {
                        Console.WriteLine("The average score of your students is {0}", average);
                    }
                    
                }

                if(int.TryParse(input, out currentNumber) && currentNumber > 0 && currentNumber < 21)
                {
                    total += currentNumber;
                    //count++;
                }
                else
                {
                    if(!(input.Equals("-1")))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please enter a value between 1 and 20");
                        Console.WriteLine();
                    }
                    continue;
                }
                count++;
                //Console.WriteLine();
                //Console.WriteLine("THIS WILL ONLY PRINT WHEN A CORRECT VALUE IS ENTERED");
                //Console.WriteLine();
            }


            ///////////////////////////////
            /////// People counter ////////
            ///////////////////////////////
            //Console.WriteLine("Press ENTER to add to count. Enter any other key + ENTER to stop counting.");

            //int counter = 0;
            //bool finishedCounting = false;

            //while(!finishedCounting)
            //{
            //    string input = Console.ReadLine();
            //    if(input == "")
            //    {
            //        counter += 1;
            //        Console.WriteLine("{0} student(s) currently on the bus.", counter);

            //    } else
            //    {
            //        finishedCounting = true;
            //    }
            //}
            //Console.WriteLine("All " + counter + " students are on the bus.");

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
            // Just a test
        }
    }
}
