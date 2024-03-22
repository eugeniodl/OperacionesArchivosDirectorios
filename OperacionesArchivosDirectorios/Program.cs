﻿
using OperacionesArchivosDirectorios;

IRepository repository = new FileSystemRepository();

string directoryPath = @"C:\directorio";
repository.CreateDirectory(directoryPath);

string filePath = @"C:\directorio\archivo.txt";
repository.CreateFile(filePath, "Este es un ejemplo.");

if(repository.FileExists(filePath))
{
    string content = repository.ReadFile(filePath);
    Console.WriteLine( "Contenido del archivo:");
    Console.WriteLine(content);
}

//repository.DeleteFile(filePath);