using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_day3
{
    class Program
    {
        static void Main(string[] args)
        {
            ////when writing a method it has to be outside of static void main because it is a method
            //int answer = Add(5,);
            //Console.WriteLine(answer);
            FavFood("for", "chicken");

        }
        public static int Add(int firstNumber , int secondNumber)

        {
            int sum = firstNumber + secondNumber;
            return sum; // this is the keyword to using every method
        }
        public static void FavFood(string name, string food)
        {
            string conCad = name + " " + food;
            Console.WriteLine(conCad);
            
            return   ;
        }
    }
}
