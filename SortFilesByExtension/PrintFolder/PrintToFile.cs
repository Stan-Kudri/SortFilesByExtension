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
        public enum CreateAction
        {
            Nothing,
            DeleteExistFile,
        };
        
        public PrintToFile(string path, CreateAction createAction)
        {
            _path = path;
            if (createAction == CreateAction.DeleteExistFile)
            {
                using (File.CreateText(_path)) { }
            }            
        }

        public void Print(string line)
        {            
            File.AppendAllText(_path, line + Environment.NewLine, Encoding.Default);            
        }
    }
}
