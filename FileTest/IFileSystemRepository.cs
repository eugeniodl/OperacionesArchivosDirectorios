using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTest
{
    public interface IFileSystemRepository
    {
        string[] GetDirectories();
        bool FileExists();
        string ReadFile();
        string GetFileInformation();

    }
}
