using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SortFilesByExtension;
using SortFilesByExtension.PrintFolder;
using SortFilesByExtension.Abstraction;

namespace FileHandler
{    
    class FileHandler
    {       
        private void ThrowIfInvalidPath(string path)
        {
            if (!Directory.Exists(path))
            {
                throw new ArgumentException();
            }
        }

        private void ThrowIfNull(string[] SortedNames)
        {
            if(SortedNames==null)
            {
                throw new NotImplementedException();
            }
        }

        private string NormalizeExtension(string expansion)
        {
            if (expansion.StartsWith("."))
                return expansion;
            else
            {
                return new StringBuilder("." + expansion).ToString();                
            }
        }

        public string[] CreatDataSortedByFileSize(string path,string extansion)
        {
            
            ThrowIfInvalidPath(path);

            List<FileMetadata> fileMetadatas = new List<FileMetadata>();

            foreach (var files in Directory.EnumerateFiles(path, $"*{NormalizeExtension(extansion)}"))
            {
                var fileInfo = new FileInfo(files);
                fileMetadatas.Add(new FileMetadata(fileInfo.Name,fileInfo.Length));
                Console.Write($"{fileInfo.Name} => {fileInfo.Length}");
                Console.Write(Environment.NewLine);
                
            }

            return fileMetadatas.OrderBy(x => x.Length).Select(x => x.Name).ToArray();                                  
        }

        public void Print(string[] SortedNames,IPrint print)
        {
            ThrowIfNull(SortedNames);            
            foreach(var line in SortedNames)
                print.Print(line);
        }

    }
}
