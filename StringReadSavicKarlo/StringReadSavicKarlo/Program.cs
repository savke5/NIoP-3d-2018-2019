﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StringReadSavicKarlo
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Učenik\source\repos\StringReadSavicKarlo\sir");
          

            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }
            

            sr.Close();
            Console.ReadKey();
        }
    }
}
