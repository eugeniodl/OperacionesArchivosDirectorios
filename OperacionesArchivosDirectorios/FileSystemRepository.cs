using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesArchivosDirectorios
{
    public class FileSystemRepository : IRepository
    {
        public void CreateDirectory(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                Console.WriteLine("Directorio creado correctamente.");
            }
            else
            {
                Console.WriteLine("El directorio ya existe.");
            }
        }

        public void CreateFile(string path, string content)
        {
            try
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.Write(content);
                }
                Console.WriteLine("Archivo creado y contenido escrito " +
                    "correctamente");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public void DeleteFile(string path)
        {
            if(File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("Archivo eliminado correctamente.");
            }
            else

            {
                Console.WriteLine( "El archivo no existe");
            }
        }

        public bool DirectoryExists(string path)
        {
            return Directory.Exists(path);
        }

        public bool FileExists(string path)
        {
            return File.Exists(path);
        }

        public string ReadFile(string path)
        {
            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }
                
            else
            {
                return null;
            }
                
        }
    }
}
