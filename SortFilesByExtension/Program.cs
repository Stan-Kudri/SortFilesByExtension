using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SortFilesByExtension
{
    class Program
    {
        //Для данной папки, по расширению, найти все файлы этого расширения и выдать отсортированный массив по размеру файлов.

        static void Main(string[] args)
        {
            string path = @"X:\Фильмы";
            string expansion = "mkv";

            var sortBy = new SortByExtension();
            var creatingData = sortBy.CreatingDataSortedByFileSize(path,expansion);
            sortBy.OutputSortedFiles(creatingData);
            
            Console.ReadLine();
        }
    }
}
