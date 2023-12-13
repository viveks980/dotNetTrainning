using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNetTraiing
{
    public class Test1
    {
        int a = 10;
        double b = 11.5;
        char A = 'c';
        bool c = true;
        string txt = "My name is vivek";

        public static void testMethod()
        #region Accessing element demo
        {
            Test1 t = new Test1();
            Console.WriteLine("I am Test Method()");
            Console.WriteLine("This is Integer : "+t.a);
            Console.WriteLine("This is double : " + t.b);
            Console.WriteLine("This is Character : " + t.A);
            Console.WriteLine("This is Boolean : " + t.c);
            Console.WriteLine("This is String : " + t.txt);
            Console.WriteLine("<===Example of implicit Type Casting==>");
            int IntA = 9;
            Console.WriteLine("This is int A : "+IntA);
            double DoubleA = IntA;
            Console.WriteLine("This is converted double A : " + DoubleA);
            Console.WriteLine("<===Example of Explicit Type Casting==>");
            double myDouble = 9.78;
            int myInt = (int)myDouble;
            Console.WriteLine("This is Double value : "+myDouble);
            Console.WriteLine("This is converted int value : "+myInt);

            Console.WriteLine("<===Type Conversion Using Built in methods==>");
            int myIntA = 10;
            double myDoubleA = 5.25;
            bool myBool = true;

            Console.WriteLine("Int to string Conversion "+Convert.ToString(myIntA));    
            Console.WriteLine("Int to double Conversion " + Convert.ToDouble(myIntA));    
            Console.WriteLine("double to Int Conversion " + Convert.ToInt32(myDoubleA));  
            Console.WriteLine("Boolean to string Conversion " + Convert.ToString(myBool));   



            Console.ReadKey();

        }
        #endregion

        public void testMethod2()
        {


            double num1, num2;
            string operation;

            try
            {
                Console.Write("Enter the first number: ");
                num1 = double.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Your Choice...");
                Console.WriteLine("press 1 for Sum");
                Console.WriteLine("press 2 for substraction");
                Console.WriteLine("press 3 for multipication");
                Console.WriteLine("press 4 for division");
                Console.WriteLine("Enter 5 for Your Moduler division");

                operation = Console.ReadLine();
                double result = 0.0;
                switch (operation)
                {
                    case "1":
                        result = (num1 + num2);
                        break;

                    case "2":
                        result = (num1 - num2);
                        break;

                    case "3":
                        result = (num1 * num2);
                        break;

                    case "4":
                        result = (num1 / num2);
                        break;

                    case "5":
                        result = (num1 % num2);
                        break;

                    default:
                        Console.WriteLine("Invalid operation");
                        return;
                }
                Console.WriteLine(result);
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


            //Console.WriteLine("hello anshu");
            //Console.ReadKey();
        }


        public void testMethod3()
        {
            Console.WriteLine("<===If else Example===>");
            int x = 20;
            int y = 18;
            Console.WriteLine("x : " + x);
            Console.WriteLine("y : " + y);
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }
            else
            {
                Console.WriteLine("y is greater than x");
            }

            Console.WriteLine("<===While Loop Example===>");

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("<===For Loop Example===>");

            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine(j);
            }

            Console.WriteLine("<===Array example===>");

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars[1]);
            Console.ReadKey();


        }

        public int calculateSum(int p,int q)
        {
            return p + q;
            
        }

        public int sumMethod(int x)
        {
            return x ;
        }

        public int sumMethod(int x, int y)
        {
            return x + y;
        }

        public void defaultPara(string country = "India")
        {
            Console.WriteLine(country);
        }


    }
}
