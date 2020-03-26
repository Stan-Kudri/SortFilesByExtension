using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
