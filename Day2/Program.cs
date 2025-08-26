using System.Collections.Concurrent;

namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool isRain = true;

            //bool hasAmbrella = false;

            //if(isRain && hasAmbrella )
            //{
            //    Console.WriteLine("protected");
            //}

            //else
            //{
            //    Console.WriteLine("not protected");
            //}

            //int num1 = 10;
            //int num2 = 20;

            //Console.WriteLine("please enter a number");
            //if(num1 == int.Parse(Console.ReadLine()))
            //{
            //    Console.WriteLine("equal");
            //}
            //else
            //{
            //    Console.WriteLine("not");
            //}
            //Console.WriteLine("please enter your age");
            //int age = int.Parse(Console.ReadLine());

            //bool withParents;

            //if (age >= 18)
            //{
            //    Console.WriteLine("go party in the club");
            //}
            //else if(age >= 13)
            //{
            //    Console.WriteLine("are you with your parents Y or N");
            //    string parents = Console.ReadLine();

            //    if(parents == "Y")
            //    {
            //        Console.WriteLine("you can go with your parents");
            //    }
            //    else
            //    {
            //        Console.WriteLine("no party");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("go to school");
            //}


            //string question1 = "What is the capital of India";
            //String answer1 = "Delhi";

            //string question2 = "What is the addition of 4+4";
            //int answer2 = 8;

            //string question3 = "Who is our PM";
            //string answer3 = "Modi";

            //int score = 0;
            //Console.WriteLine(question1);
            //string userAnswer1 = Console.ReadLine();
            //if(userAnswer1.Trim().ToLower() == answer1.ToLower())
            //{
            //    Console.WriteLine("correct");
            //    score += 1;
            //}
            //else
            //{
            //    Console.WriteLine("opps wrong answer");
            //}
            //Console.WriteLine(question2);
            //int userAnswer2 = int.Parse( Console.ReadLine());
            //if (userAnswer2 == answer2)
            //{
            //    Console.WriteLine("correct");
            //    score += 1;
            //}
            //else
            //{
            //    Console.WriteLine("opps wrong answer");
            //}

            //Console.WriteLine(question3);
            //string userAnswer3 = Console.ReadLine();
            //if (userAnswer3.Trim().ToLower() == answer3.ToLower()+)
            //{
            //    Console.WriteLine("correct");
            //    score += 1;
            //}
            //else
            //{
            //    Console.WriteLine("opps wrong answer");
            //}

            //Console.WriteLine("your score is " + score);
            //Random ram = new Random();
            //int num = ram.Next(1,11);

            //Console.WriteLine(num);

            //Console.WriteLine("enter your number");
            //int num2 = int.Parse(Console.ReadLine());

            //if (num == num2)
            //{
            //    Console.WriteLine("you guessed it right");
            //}

            //else
            //{
            //    Console.WriteLine("You guessed it wrong");
            //
            //}

            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your choice");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtract");
            Console.WriteLine("3.Multiply");
            Console.WriteLine("4.Divide");

            int choice = int.Parse(Console.ReadLine());
            int result = 0;

            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    break;

                case 2:
                    result = num1 - num2;
                    break;

                case 3:
                    result = num1 * num2;
                    break;

                case 4:
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("wrong choice");
                    break;
            }

            Console.WriteLine(result);

        }
    }
}
