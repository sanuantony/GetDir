using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppsMode
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Directory.GetFiles(@"C:\Users\santony\Desktop\All Dlls");

            File.WriteAllLines(@"C:\Users\santony\Desktop\All.txt", list);
        }
    }
}
