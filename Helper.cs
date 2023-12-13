﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNetTraiing
{
    


   public class Helper

    {

        public static void WriteLog(string message)

        {

            

            string ErrorLogDir = "C:\\Users\\vivek\\source\\repos\\DOTNetTraiing\\error_log";

            if (!Directory.Exists(ErrorLogDir))

                Directory.CreateDirectory(ErrorLogDir);



            ErrorLogDir += "\\error1" + DateTime.Now.ToString("dd-MMM-yyyy") + ".txt";

            using (StreamWriter sr = new StreamWriter(ErrorLogDir, true))

            {

                sr.WriteLine(DateTime.Now.ToString("DD-MM-yyyy HH-mm-ss") + message);

            }



        }

    }

}
