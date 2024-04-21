//HAJRAH SIDDIQUI
//NOV 18-21ST
//ASSAIGNMENT 4 PART 1
//TO PROVE MYSELF I CAN CODE

using System;

namespace TeamSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARING VARIABLES
            double num1, num2;  //Declared num1 num2 which are basically going to be our two numbers in the question
            int NumberofProblems; //This is to the number of problems the user will enter
            int minimumValue, maximumValue; //maximum and minimum value what the user inputs
            double operators, correctAnswer, userAnswer; //operators are for the operations used at random, correctAnswer will be used for the userAnswer
            const int MaximumNumberOfAttempts = 3; //this is declaring the maximum attempts
            int NumberofAttemptsLeft; //It will display on screen this variable fo how many attempts are left
            int NumberofAttemptsTaken; //It will say how many are taken
            Boolean isCorrect; //to keep the status of the answer
            Boolean nextProblem; //it is for the yes/no option


            Console.Write("Enter the minimum value you want for your question: "); //questions for the thing
            minimumValue = int.Parse(Console.ReadLine()); //question for minimum
            Console.Write("Enter the maximum value you want for your question: "); //question for maximum
            maximumValue = int.Parse(Console.ReadLine());
            Console.Write("Enter how many problems you want to do: "); //problems you want to do
            NumberofProblems = int.Parse(Console.ReadLine());

            do  //This do while is to represent how if user says yes then repeats + how many problems they inputted
            {
                //randomizing things
                Random random = new Random();  //this is helping to generate the raondom
                num1 = random.Next(minimumValue, maximumValue + 1);  //+1 because it will automatically include the max value
                num2 = random.Next(minimumValue, maximumValue + 1);  //these are for generating the randoms
                operators = random.Next(1, 5);   //1 - addition  2 - subtraction  3 - multiplication  4 - division
                NumberofAttemptsLeft = MaximumNumberOfAttempts; //This is equaling numberofattempts left to max number and then it will help display it on screen
                NumberofAttemptsTaken = 1; //When it is 1 then it will tell the answer

                if (operators == 1) //addition
                {
                    do
                    {
                        Console.WriteLine("What is " + num1 + " + " + num2); //This line of code is telling how it will combine it into a question, so for this on eit is addition so num1 + num2
                        userAnswer = double.Parse(Console.ReadLine()); //userAnswer = whatver they put in the previous line
                        correctAnswer = num1 + num2; //what the actual answer is (user can still get it right but if its wrong this is useful)
                        isCorrect = IsTheAnswerCorrect(correctAnswer, userAnswer); //my method for if the answer is correct or not
                        NumberofAttemptsLeft = askquestions(isCorrect, NumberofAttemptsLeft, NumberofAttemptsTaken, correctAnswer); //my other method for the askquestions one
                        NumberofAttemptsTaken = NumberofAttemptsTaken + 1; //This is declaring what numberofattempts taken math will be because originally we are subtracting it but now we are adding to reverse it

                    } while (isCorrect == false && NumberofAttemptsLeft > 0); //this is for the do while to help it say if isCorrect is not equal to answer
                }
                else if (operators == 2) //subtraction
                {
                    do
                    {
                        Console.WriteLine("What is " + num1 + " - " + num2);  //repeating what I basically just said from line 45-57 jus subraction operator
                        userAnswer = double.Parse(Console.ReadLine());
                        correctAnswer = num1 - num2;
                        isCorrect = IsTheAnswerCorrect(correctAnswer, userAnswer);
                        NumberofAttemptsLeft = askquestions(isCorrect, NumberofAttemptsLeft, NumberofAttemptsTaken, correctAnswer);
                        NumberofAttemptsTaken = NumberofAttemptsTaken + 1;

                    } while (isCorrect == false && NumberofAttemptsLeft > 0);
                }
                else if (operators == 3) //multiplication
                {
                    do
                    {
                        Console.WriteLine("What is " + num1 + " * " + num2);  //repeating what I basically just said from line 45-57 jus subraction operator
                        userAnswer = double.Parse(Console.ReadLine());
                        correctAnswer = num1 * num2;
                        isCorrect = IsTheAnswerCorrect(correctAnswer, userAnswer);
                        NumberofAttemptsLeft = askquestions(isCorrect, NumberofAttemptsLeft, NumberofAttemptsTaken, correctAnswer);
                        NumberofAttemptsTaken = NumberofAttemptsTaken + 1;

                    } while (isCorrect == false && NumberofAttemptsLeft > 0);
                }
                else if (operators == 4) //division
                {
                    do
                    {
                        Console.WriteLine("What is " + num1 + " / " + num2);  //repeating what I basically just said from line 45-57 jus subraction operator
                        userAnswer = double.Parse(Console.ReadLine());
                        correctAnswer = num1 / num2;
                        isCorrect = IsTheAnswerCorrect(correctAnswer, userAnswer);
                        NumberofAttemptsLeft = askquestions(isCorrect, NumberofAttemptsLeft, NumberofAttemptsTaken, correctAnswer);
                        NumberofAttemptsTaken = NumberofAttemptsTaken + 1;

                    } while (isCorrect == false && NumberofAttemptsLeft > 0);
                }
                NumberofProblems = NumberofProblems - 1;   //this is for how to make numberofproblems
                nextProblem = DoYouWantToContinue(); //this is giving the method option of yes or no to continueing

            } while (nextProblem == true && NumberofProblems > 0); //this is to repeat if person says yes


            Console.ReadKey();

        } //main

        public static Boolean IsTheAnswerCorrect(double correctAnswer, double userAnswer) //first method used, it is for the yes and no, if its yes its true,
        {                                                                                 //I used boolean because I needed to do the method like true or false
            Boolean ret; //return value to caller                                         //https://www.dotnetperls.com/bool-return#:~:text=The%20bool%20type%20is%20a,Summary.
                         //this site helped me, a boolean method is basically returning if a statement is true or false, I couldn't compare a sting with an int so that is why I decided to use this
            if (correctAnswer == userAnswer) //making an if statement for if it is equal or not
            {
                ret = true;
            }
            else
            {
                ret = false; //or else false
            }
            return ret; //returning it (return basically means to return it back to where it was

        }

        public static Boolean DoYouWantToContinue()  //second type of method used, this is for the yes or no continue thing
        {
            Boolean ret; //return value to caller

            Console.Write("Do you want to continue? Yes/No: ");
            string yes_no = Console.ReadLine();

            //if (yes_no == "Yes" || yes_no == "yes" || yes_no == "y") //I made yes have a bunch of options because who knows what the user may input
            if (yes_no.ToUpper() == "YES" || yes_no.ToUpper() == "Y") //This is much more smarter
            {
                ret = true; //our return statement blabababa same thing as line 109-117
            }
            else
            {
                ret = false;
            }
            return ret;
        }

        public static int askquestions(Boolean isCorrect, int NumberofAttemptsLeft, int NumberofAttemptsTaken, double correctAnswer) //this is the last method used and it is for the number of attempts taken, left, correct answer, and useranswer
        {
            if (isCorrect == false)   //Basically doing the math on what to do
            {
                NumberofAttemptsLeft = NumberofAttemptsLeft - 1;

                if (NumberofAttemptsLeft == 0) //if statement for if the number of attempts are done then tell answer
                {
                    Console.WriteLine("The answer is " + correctAnswer); // outputting the correct answer
                    isCorrect = true;  //User doesn't have any attempts left and givign the correct answer
                }
                else
                {
                    Console.WriteLine("Retry again, " + NumberofAttemptsLeft + " times left "); //if it doesnt reach 0 it will keep repeating
                }

            } //if statement
            else
            {
                Console.WriteLine("It is correct!, You took " + NumberofAttemptsTaken + " attempts"); //this is what it will say when it is correct
            }

            return NumberofAttemptsLeft;
        } //askquestions
    } //class program
} //namespace


