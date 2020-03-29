using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SortFilesByExtension.PrintFolder;

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

            Console.WriteLine("Выдача информации в консоли или сохранение в текстовом документе SortedNames.txt в папке по желанию:");

            //var print = new PrintToConsole();
            //Console.WriteLine("\nОтсортированные Элементы:");

            string pathFile = Path.Combine(@"X:\\", "SortedNames.txt");
            var print = new PrintToFile(pathFile,PrintToFile.CreateAction.DeleteExistFile);
            Console.WriteLine($"\nПуть файла с отсортированными элементами: {pathFile}");


            sortBy.Print(creatingData, print);

            Console.ReadLine();
        }
    }
}
