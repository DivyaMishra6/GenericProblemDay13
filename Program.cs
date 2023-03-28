
namespace GenericsDemo
{
    class Program
    {
        public static void Main()
        
        {
            Console.WriteLine("Please Enter the FirstValue:");
            var val1 = Console.ReadLine();
            Console.WriteLine("Please Enter the SecondValue:");
            var val2 = Console.ReadLine();
            Console.WriteLine("Please Enter the ThirdValue:");
            var val3 = Console.ReadLine();

            var Value = Refactor1.MaximumNum(val1, val2, val3);
            Console.WriteLine("{0} is greater", Value);
            Console.WriteLine("**************************************");

        }


    }
}