using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangfireDemo
{
    public class HangfierExample
    {
        public void PrintMessage(string msg)
        {
            Console.WriteLine($"[Job] {DateTime.Now}: {msg}");
        }
    }
}
