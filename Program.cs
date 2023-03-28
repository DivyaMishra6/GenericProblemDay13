
namespace GenericsDemo
{
    class Program
    {

        public static void Main()
        
            {
            Console.WriteLine("Welcome to Generic Program");
            Console.WriteLine("Please Enter the FirstValue:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter the SecondValue:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter the ThirdValue:");
            double num3 = Convert.ToDouble(Console.ReadLine());
            double val = FloatMax.MaximumNum(num1, num2, num3);
            Console.WriteLine("{0} is greater", val);
        }


}
}