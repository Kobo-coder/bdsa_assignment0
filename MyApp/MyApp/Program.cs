using System;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a year, to check if it is a leap year. \n Then press [Enter]");
            int year = int.Parse(Console.ReadLine());
            IsLeapYear(year);
            //Console.WriteLine("Hello World!");
        }
        public static bool IsLeapYear(int year){
            if(year%4 == 0){
                if(year%400 == 0){
                    Console.WriteLine("yay");
                    return true;
                } else if(year%100 == 0){
                    Console.WriteLine("nay");
                    return false;
                }
                Console.WriteLine("yay");
                return true;
            }
            Console.WriteLine("nay");
            return false;
        }
    }
}
