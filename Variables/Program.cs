namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable declaracion

            int number;
            string name;

            //Variable initialization

            number = 10;
            name = "John Doe";

            //Implicity typed variable

            var isActive = true;
            var pi = 3.14;
            var city = "New York";

            Console.WriteLine($"Number: {number}, Nambe: {name}");
        }
    }
}