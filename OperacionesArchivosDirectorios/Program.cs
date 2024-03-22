using OperacionesArchivosDirectorios;

string directoryPath = @"C:\OpeArDire";
string filePath = @"C:\OpeArDire\archivo.txt";

IRepository repository = 
    new FileSystemRepository(filePath);

//repository.CreateDirectory();
repository.CreateFile("Este es un ejemplo de creación de archivo");

if(repository.FileExists())
{
    string content = repository.ReadFile();
    Console.WriteLine("Contenido del archivo");
    Console.WriteLine(content);
}

repository.DeleteFile();