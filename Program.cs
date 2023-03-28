
namespace GenericsDemo
{
    class Program
    {

        public static void Main()
        
        {
            Console.WriteLine("Welcome to Generic Program");
            Console.WriteLine("Please Enter the FirstValue:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Please Enter the SecondValue:");
            string str2 = Console.ReadLine();
            Console.WriteLine("Please Enter the ThirdValue:");
            string str3 = Console.ReadLine();
            string val = StringMaxUC3.MaximumVal(str1, str2, str3);
            Console.WriteLine("{0} is greater", val);
        }


}
}