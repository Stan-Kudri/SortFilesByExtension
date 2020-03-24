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
        private string[] SortedNames { get; set; }

        public void Sort(string path)
        {
            List<FileMetadata> fileMetadatas = new List<FileMetadata>();

            foreach (var files in Directory.EnumerateFiles(path, "*.mkv"))
            {
                var fileInfo = new FileInfo(files);
                fileMetadatas.Add(new FileMetadata(fileInfo.Name,fileInfo.Length));
                Console.WriteLine($"{fileInfo.Name} => {fileInfo.Length}");
            }

            SortedNames = fileMetadatas.OrderBy(x => x.Length).Select(x => x.Name).ToArray();                                  
        }

        public void OutputSortedFiles()
        {
            Console.WriteLine("\nОтсортированные Элементы:");
            foreach (var files in SortedNames)
            {
                Console.WriteLine($"{files}");
            }
        }

    }
}
