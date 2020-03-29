using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortFilesByExtension.Abstraction;

namespace SortFilesByExtension.PrintFolder
{
    class PrintToConsole:IPrint
    {        
        public void Print(string line)
        {
            Console.WriteLine(line);
        }
    }
}
