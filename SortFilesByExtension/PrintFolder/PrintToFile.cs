using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortFilesByExtension.Abstraction;
using System.IO;

namespace SortFilesByExtension.PrintFolder
{
    class PrintToFile:IPrint
    {
        private string _path { get;}

        private void ThrowIfInvalidPath(string path)
        {
            if (!Directory.Exists(path))
            {
                throw new ArgumentException();
            }
        }

        public PrintToFile(string path)
        {
            ThrowIfInvalidPath(path);
            _path = $@"{path}\SortedNames.txt";
            File.Create(_path).Close();
            Console.WriteLine($"\nПуть файла с отсортированными элементами: {_path}");
        }

        public void Print(string line)
        {            
            File.AppendAllText(_path, line + Environment.NewLine, Encoding.Default);            
        }
    }
}
