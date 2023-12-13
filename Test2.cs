using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNetTraiing
{
    public class Test2
    {
        public void MyMethod(string name, string age)
        {
            try
            {

                Console.WriteLine("Welcome " + name);
                Console.WriteLine("Your age is:" + Convert.ToInt32(age));
            }
            catch (Exception ex)
            {
                Helper.WriteLog("The error is:" + ex);
                Console.WriteLine("Error is:" +ex);
                //Helper.WriteLog("The error is:" + ex);
            }
        }
    }
}
