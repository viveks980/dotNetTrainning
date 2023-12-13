using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNetTraiing
{
    public class Program
    {
        static void Main(string[] args)
        {

            Test1 test = new Test1();

            //Test1.testMethod();

            //test.testMethod2();


            // test.testMethod3();
            //int result =test.calculateSum(2, 3);

            //Console.WriteLine(result);

           // int res = test.sumMethod(3);

           // int res1 = test.sumMethod(3,10);

           // Console.WriteLine("<===Method Overloading Example===>");

           //  Console.WriteLine("Result of first sum method : "+res);
           //  Console.WriteLine("Result of Second sum method : " + res1);

           // Console.WriteLine("<===Polymorphism (method overriding) & (Inheritense)===>");

           // Vehicle car = new Car();
           // Vehicle bike = new Bike();

            //car.Drive();
            //bike.Drive();

           // Console.WriteLine("<===Getter Setter Example===>");

           // Employee emp = new Employee();
           // emp.Name = "Abhay";
           // emp.Age = 26;

           // Console.WriteLine("Employee Name : "+emp.Name);
           // Console.WriteLine("Employee Age : "+emp.Age);

            //
            //Console.WriteLine("<===Default Parameter===>");

            //test.defaultPara("USA");
           // test.defaultPara();

            //Console.WriteLine("<===Constructor example===>");

           // Student student = new Student();
            //Student student = new Student("Amit",101,2);
           // Console.WriteLine("student Name : "+student.name + " |" +"student rollno : " + + student.rollNO + "| "+ "student Class : "  + student.Class);

          // Console.WriteLine("<<<======Error Log======>>>");
          //Test2 test2 = new Test2();
          // Console.WriteLine("Enter Name: ");
          // string input1 = Console.ReadLine();
          // Console.WriteLine("Enter Age: ");
          // string input2 = Console.ReadLine();
          // test2.MyMethod(input1, input2);
          // ////Console.ReadLine();

            Console.WriteLine("<<<======Abstraction======>>>");
            Console.WriteLine("<<<======Abstract Method======>>>");
            Apple apple = new Apple();
            apple.fruitColor();
            apple.fruitTaste();
            Console.WriteLine("<<<======By Interfaces======>>>");
            Orange orange = new Orange();
            orange.fruitColor();
            orange.fruitTaste();

             Console.WriteLine("<===Encapsulation Example===>");

             Employee emp = new Employee();
             emp.Name = "Abhay";
             emp.Age = 26;
             Console.WriteLine("Employee Name : "+emp.Name);
             Console.WriteLine("Employee Age : "+emp.Age);






            Console.ReadKey();
        }
    }
}
