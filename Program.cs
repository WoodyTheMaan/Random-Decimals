namespace Random_Decimals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double theRandomNumber;
            int minimumNumber, maximumNumber;
            var random = new Random();
            Console.WriteLine("Please tell me the minimum number you want me to generate");
            minimumNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Great!");
            Console.WriteLine("Now please tell me the minimum number you want me to generate");
            maximumNumber = Convert.ToInt32(Console.ReadLine());
            var rDouble = random.NextDouble() * maximumNumber + minimumNumber;
            theRandomNumber = random.NextDouble();
            Console.WriteLine(theRandomNumber);


        }
    }
}