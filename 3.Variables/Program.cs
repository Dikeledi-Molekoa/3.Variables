namespace _3.Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaire variables
            string name = "John";
            int age;

            //initialization
            name = "John";
            age = 10;

            //what will be seen on the console
            Console.WriteLine("There was once a boy called " + name);
            Console.WriteLine(name + " was " + age + " years of age");
            Console.WriteLine(name + " never really liked his name.");

            //change variable values
            age= 18;
            name = "Tom";

            Console.WriteLine("At age " + age + " he changed his name to " + name);

            //to freeze the console
            Console.ReadLine();
        }
    }
}
