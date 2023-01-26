namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var building1 = new Building("Empire State", 300, 10, "somewhere in New York");
            Console.WriteLine(building1.GetVolume());

            var building2 = new Building("Big ben", 150, 6, "somewhere in London");
            Console.WriteLine(building2.GetVolume());


        }
    }
}