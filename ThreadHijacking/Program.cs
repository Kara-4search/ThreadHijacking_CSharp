using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadHijacking
{
    class Program
    {
        static void Main(string[] args)
        {
            string createprocess_path = @"C:\Windows\System32\mspaint.exe";
            ThreadHijacking.Thread_hijacking(createprocess_path);
        }
    }
}
