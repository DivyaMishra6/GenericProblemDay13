
namespace GenericsDemo
{
    class Program
    {

        public static void Main()
        
            {
            Console.WriteLine("Welcome to Generic Program");
            Console.WriteLine("Please Enter the FirstValue:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the SecondValue:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the ThirdValue:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int val = FindMax.MaximumNum(num1, num2, num3);
            Console.WriteLine("{0} is greater", val);
        }


    }
}