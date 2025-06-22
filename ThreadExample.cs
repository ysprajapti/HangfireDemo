using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangfireDemo
{
    class ThreadExample
    {   
        public void PrintMessage(string msg)
        {
            Console.WriteLine($"[Thread] {DateTime.Now}: {msg}");
        }
    }
}
