using System;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a year, to check if it is a leap year. \n Then press [Enter]");
            try{
                
                int year = int.Parse(Console.ReadLine());
                
                if(IsLeapYear(year)){
                    Console.WriteLine("yay");
                } else {
                    Console.WriteLine("nay");
                };

            } catch (ArgumentException e) {
                Console.WriteLine(e.Message);
            } catch (FormatException e) {
                Console.WriteLine(e.Message);
            }
        }

        public static bool IsLeapYear(int year){
            if(year < 1582){
                throw new ArgumentException("The year must be 1582 or above");
            }
            if(year%4 == 0){
                if(year%400 == 0){
                    return true;
                } else if(year%100 == 0){
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}
