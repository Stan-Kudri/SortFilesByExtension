using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandler
{
    class Program
    {
        //Для данной папки, по расширению, найти все файлы этого расширения и выдать отсортированный массив по размеру файлов.

        static void Main(string[] args)
        {
            string path = @"X:\Фильмы";
            string extansion = "mkv";

            var sortBy = new FileHandler();
            var creatingData = sortBy.CreatDataSortedByFileSize(path,extansion);
            sortBy.Print(creatingData);
            
            Console.ReadLine();
        }
    }
}
