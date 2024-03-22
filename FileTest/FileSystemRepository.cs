using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTest
{
    public class FileSystemRepository : IFileSystemRepository
    {
        private string _path;

        public FileSystemRepository(string path)
        {
            _path = path;
        }
        public bool FileExists()
        {
            return File.Exists(_path);
        }

        public string[] GetDirectories()
        {
            return Directory.GetDirectories(_path);
        }

        public string GetFileInformation()
        {
            if (File.Exists(_path) || Directory.Exists(_path))
            {
                string info = $"{_path} existe\n" + 
                    Environment.NewLine;
                info += $"Creación: {File.GetCreationTime(_path)}" + 
                    Environment.NewLine;
                info += $"Última modificación: {File.GetLastWriteTime(_path)}" 
                    + Environment.NewLine;
                info += $"Último acceso: {File.GetLastAccessTime(_path)}" + 
                    Environment.NewLine;
                return info;
            }
            else
            {
                return null;
            }
        }

        public string ReadFile()
        {
            try
            {
                return File.ReadAllText(_path);
            }
            catch (IOException)
            {
                return null;
            }
            
        }
    }
}
