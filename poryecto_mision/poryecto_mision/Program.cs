using System;
using System.IO;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Define la ruta y el nombre del archivo
        string path = "c://proyecto//tony//inventos.txt";

        // Contenido que deseas escribir en el archivo
        string contenido = "1.Traje Mark I.\n";
        string contenido1 = "2.Rector Arc.\n";
        string contenido2 = "3.Inteligencia Artificial ARVIS.\n";

        File.WriteAllText(path, contenido);

        File.AppendAllText(path, contenido1);
        File.AppendAllText(path, contenido2);

        Console.WriteLine("Archivo creado y contenido agregado");


        path = "c://proyecto//tony//inventos.txt";

        // Contenido que deseas agregar al archivo
        string nuevoContenido = "4.Drones de combate.\n";

        // Agregar contenido sin sobrescribir el archivo existente
        File.AppendAllText(path, nuevoContenido);

        Console.WriteLine("Nueva línea agregada al archivo");


        //leer todo el archivo  
        path = "c://proyecto//tony//inventos.txt";
        string contenidoarchivo = File.ReadAllText(path);
        Console.WriteLine(" El contenido del archivo es: ");
        Console.WriteLine(contenidoarchivo);

        //leer linea por linea
        path = "c://proyecto//tony//inventos.txt";
        string[] lineas = File.ReadAllLines(path);
        foreach (string linea in lineas)

            Console.WriteLine("linea=" + linea);



        // manejo de excepciones    
        try
        {
            File.WriteAllText(path, contenido);
        }
        catch (FileNotFoundException err)

        {
            Console.WriteLine(" El arcchivo Invento.txt no existe !Ulton debe haberlo borrado!");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);



        }


        // Definir la ruta del archivo de origen y del archivo de destino
        string rutaOrigen = "c://proyecto//tony//inventos.txt";
        string rutaDestino = "c://proyecto//tony//Backup//inventos_copia.txt";

        // Copiar el archivo de origen al archivo de destino
        File.Copy(rutaOrigen, rutaDestino, true);
        Console.WriteLine("Archivo copiado exitosamente.\n");


        // Definir la ruta del archivo de origen y del archivo de destino
        rutaOrigen = "c://proyecto//tony//inventos.txt";
        rutaDestino = "c://proyecto//tony//archivosclasificados//inventos.txt";


        // Mover el archivo de origen al archivo de destino
        File.Move(rutaOrigen, rutaDestino);
        Console.WriteLine("Archivo movido exitosamente!!.");

        




    }
}



