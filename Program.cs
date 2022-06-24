using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{

    class Program
    {
        //Addition  
        public static int Addition(int Firstno, int Secondno)
        {
            int result = Firstno + Secondno;
            return result;
        }
        //Substraction  
        public static int Subtraction(int Firstno, int Secondno)
        {
            int result = Firstno - Secondno;
            return result;
        }
        //Multiplication  
        public static int Multiplication(int Firstno, int Secondno)
        {
            int result = Firstno * Secondno;
            return result;
        }
        //Division  
        public static int Division(int Firstno, int Secondno)
        {
            int result = Firstno / Secondno;
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to 4 to perform action");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division");

            int action = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter First Number");
            int Firstno = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int Secondno = int.Parse(Console.ReadLine());

            int result = 0;
            switch (action)
            {
                case 1:
                    {
                        result = Addition(Firstno, Secondno);
                        break;
                    }
                case 2:
                    {
                        result = Subtraction(Firstno, Secondno);
                        break;
                    }
                case 3:
                    {
                        result = Multiplication(Firstno, Secondno);
                        break;
                    }
                case 4:
                    {
                        result = Division(Firstno, Secondno);
                        break;
                    }
                default:
                    Console.WriteLine("Wrong action.. try again");
                    break;
            }
            Console.WriteLine("The result is "+ result);
            Console.ReadKey();
        }        
    }
}

