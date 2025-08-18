namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //string myFriendsName = "Jannik";

            //Console.WriteLine("my old friend is " + myFriendsName);

            //myFriendsName = "Frank";

            //Console.WriteLine("my new friend is " + myFriendsName);


            ////user input
            //Console.WriteLine("enter your input");
            //string userInput = Console.ReadLine();

            //Console.WriteLine("you entered " + userInput);


            Console.WriteLine("Enter num1");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;

            Console.WriteLine("The sum is " + sum);

            //Value type -> Stores actual data
            //eg -> int, string, null, struct, enum
            //Stored in stack

            //Reference Type
            //It stores the memory address

        }
    }
}
