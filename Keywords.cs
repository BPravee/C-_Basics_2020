using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyWords
{
    public delegate void TestDelegate();
    class Program
    {
        static void Main_old(string[] args)
        {
            int data = 10;
            Echo(ref data);
            Console.WriteLine(data);

            int targetValue;
            bool isValidConvertion=ConvertToInteger("23", out targetValue);
            Console.WriteLine(targetValue);

            int[] numbers = { 1, 2, 3 };
            Add( out targetValue, numbers);
            //ReInitialize Array
            numbers = new int[] { 23, 4, 5, 6, 6, 7, 7 };
            Add( out targetValue, numbers);

            Add(out targetValue, 2, 3);
            Add(out targetValue,3, 5, 6, 6, 7, 7, 8);
            Add(out targetValue,2, 3, 3, 4, 5, 5, 6, 6,7, 7, 9);

        }
        static void Echo(ref int x)
        {
            x = 100;

        }
        static bool ConvertToInteger(string data,out int convertedValue)
        {
            convertedValue = Int32.Parse(data);
            return true;
        }
        public static void Add(out int sum, params int[] numbers)
        {
            sum = default(int);
            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
        }
        public static void Main()
        {
            TestDelegate obj = () => {
                Console.WriteLine("Hello");
            };
            /*
             * void  <Main_b__4_0(){Console.WriteLine("Hello") ; }
             * TestDelegate obj=new TestDelegate(Program.<Main_b__4_0>);
             * 
             * 
             */
            obj.Invoke();
        }
    }
}
