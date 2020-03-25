using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SortFilesByExtension
{
    class FileMetadata
    {
        public string Name { get; }
        public long Length { get; }

        public FileMetadata(string name, long length)
        {
            Name = name;
            Length = length;
        }
    }

    class SortByExtension
    {       
        private void ThrowIfInvalidPath(string path)
        {
            if (!Directory.Exists(path))
            {
                throw new NotImplementedException();
            }
        }

        private void ThrowIfNoData(string[] SortedNames)
        {
            if(SortedNames==null)
            {
                throw new NotImplementedException();
            }
        }

        private string NormalizationExtensions(string expansion)
        {
            if (expansion.StartsWith("."))
                return expansion;
            else
            {
                return new StringBuilder("." + expansion).ToString();                
            }
        }

        public string[] CreatingDataSortedByFileSize(string path,string expansion)
        {
            ThrowIfInvalidPath(path);
            expansion = NormalizationExtensions(expansion);

            List<FileMetadata> fileMetadatas = new List<FileMetadata>();

            foreach (var files in Directory.EnumerateFiles(path, $"*{expansion}"))
            {
                var fileInfo = new FileInfo(files);
                fileMetadatas.Add(new FileMetadata(fileInfo.Name,fileInfo.Length));
                Console.WriteLine($"{fileInfo.Name} => {fileInfo.Length}");
            }

            return fileMetadatas.OrderBy(x => x.Length).Select(x => x.Name).ToArray();                                  
        }

        public void OutputSortedFiles(string[] SortedNames)
        {
            ThrowIfNoData(SortedNames);
            Console.WriteLine("\nОтсортированные Элементы:");
            foreach (var files in SortedNames)
            {
                Console.WriteLine($"{files}");
            }
        }

    }
}
