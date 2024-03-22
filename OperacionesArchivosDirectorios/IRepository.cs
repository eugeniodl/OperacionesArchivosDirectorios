using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesArchivosDirectorios
{
    public interface IRepository
    {
        void CreateDirectory();
        bool DirectoryExists();
        void CreateFile(string content);
        string ReadFile();
        bool FileExists();
        void DeleteFile();
    }
}
