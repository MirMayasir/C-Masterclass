namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRain = true;

            bool hasAmbrella = false;

            if(isRain && hasAmbrella )
            {
                Console.WriteLine("protected");
            }

            else
            {
                Console.WriteLine("not protected");
            }
        }
    }
}
