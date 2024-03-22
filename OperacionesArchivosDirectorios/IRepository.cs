using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesArchivosDirectorios
{
    public interface IRepository
    {
        void CreateDirectory(string path);
        bool DirectoryExists(string path);
        void CreateFile(string path, string content);
        string ReadFile(string path);
        bool FileExists(string path);
        void DeleteFile(string path);
    }
}
