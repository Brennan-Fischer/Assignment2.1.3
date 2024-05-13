using System.ComponentModel;

namespace Assignment2._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 2;
            int num2 = 3;
            decimal num3 = 4.4M;
            decimal num4 = 5.5M;
            decimal num5 = 6.6M;
            float num6 = 7.7F;
            float num7 = 8.8F;
            float num8 = 9.9F;

            Console.WriteLine(Convert.ToString(MyOperations.myAdd(num1, num2)));
            Console.WriteLine(Convert.ToString(MyOperations.myAdd(num3, num4, num5)));
            Console.WriteLine(Convert.ToString(MyOperations.myMultiply(num6, num7)));
            Console.WriteLine(Convert.ToString(MyOperations.myMultiply(num6, num7, num8)));
        }
    }
    public class MyOperations
    {
       public static int myAdd( int num1, int num2)
        {
            return num1+num2; 
        }
        public static decimal myAdd(decimal num1, decimal num2, decimal num3) 
        { 
        return num1 + num2 + num3;
        }
        public static float myMultiply(float num1, float num2, float num3)
        {
            return num1 * num2 * num3;
        }
        public static float myMultiply(float num1, float num2)
        {
            return num1 * num2;
        }
    }
}
