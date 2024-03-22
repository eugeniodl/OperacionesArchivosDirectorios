using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesArchivosDirectorios
{
    public class FileSystemRepository : IRepository
    {
        private string _path;

        public FileSystemRepository(string path)
        {
            _path = path;
        }

        public void CreateDirectory()
        {
            if(!Directory.Exists(_path))
            {
                Directory.CreateDirectory(_path);
                Console.WriteLine("Directorio creado correctamente");
            }
            else
            {
                Console.WriteLine("El directorio ya existe");
            }
        }

        public void CreateFile(string content)
        {
            using(StreamWriter writer = File.CreateText(_path)) 
            {
                writer.Write(content);
            }
            Console.WriteLine( "Archivo y contenido creado correctamente");
        }

        public void DeleteFile()
        {
            if(File.Exists(_path))
            {
                File.Delete(_path);
                Console.WriteLine("Archivo eliminado correctamente");
            }
        }

        public bool DirectoryExists()
        {
            return Directory.Exists(_path);
        }

        public bool FileExists()
        {
           return File.Exists(_path);
        }

        public string ReadFile()
        {
            if(File.Exists(_path))
            {
                return File.ReadAllText(_path);
            }
            else
            {
                return null;
            }
        }
    }
}
