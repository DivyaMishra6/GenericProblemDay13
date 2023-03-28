
namespace GenericsDemo
{
    class Program
    {
        public static void Main()
        
        {
            int a = 10, b = 20, c = 15;
            double x = 5.5, y = 7.7, z = 10.0;
            string p = "Priya", q = "Madhu", r = "Bholi";

            FindMax<int> obj = new FindMax<int>(a, b, c);
            int MaxInt = obj.TestMaximum();
            Console.WriteLine("Maximum value in integer is: " + MaxInt);
            Console.WriteLine("****************************************");

            FindMax<double> obj1 = new FindMax<double>(x, y, z);
            double MaxDouble = obj1.TestMaximum();
            Console.WriteLine("Maximum value in double is: " + MaxDouble);
            Console.WriteLine("****************************************");

            FindMax<string> obj2 = new FindMax<string>(p, q, r);
            string MaxString = obj2.TestMaximum();
            Console.WriteLine("Maximum value in string is: " + MaxString);
            Console.WriteLine("****************************************");
        }


    }


}
