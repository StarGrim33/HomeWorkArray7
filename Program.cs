namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "There is something about us i want to say";

            string[] array = text.Split();

            foreach(string split in array)
            {
                Console.WriteLine(split);
            }

        }
    }
}
