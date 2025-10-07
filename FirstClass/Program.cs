namespace FirstClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car("BMW");
            Console.WriteLine("Main executed");


            audi.Drive();

            Console.ReadKey();
        }
    }
}
