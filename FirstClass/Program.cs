namespace FirstClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car("BMW");
            Console.WriteLine("Main executed");

            Console.WriteLine("enter the model name");

            audi.Model = Console.ReadLine();

            Console.WriteLine("you entered " +  audi.Model);

            Console.ReadKey();
        }
    }
}
