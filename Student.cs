using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNetTraiing
{
    class Student
    {
        public string name;
        public int rollNO;
         public int Class;

        //public Student() {
        //    Console.WriteLine("This is non parameter constructor..!!");
        //}
        public Student(string studentName, int studentRollNo, int studentClass)
        {
            name = studentName;
            rollNO = studentRollNo;
            Class = studentClass;
        }
     }
    }

