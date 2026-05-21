using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {

        CasoList lista = new CasoList();

        Alumno alumno1 = new Alumno(1, "Nico", 8);
        Alumno alumno2 = new Alumno(3, "Pepe", 2);
        Alumno alumno3 = new Alumno(20, "Martina", 6);
        lista.AgregarAlum(alumno1);
        lista.AgregarAlum(alumno2);
        lista.AgregarAlum(alumno3);

        foreach (Alumno alumno in lista.RetornarList())
        {
            Console.WriteLine("Id: " + alumno.Id + " Nombre: " + alumno.Nombre + " Promedio: " + alumno.Promedio);
        }

        Alumno nombreBuscado = lista.BuscarAlumno("Nico");

        if (nombreBuscado != null)
        {
            Console.WriteLine("Alumno encontrado: " + nombreBuscado.Nombre);
        }

        Console.WriteLine("Buscando un nombre inexistente Francisco");

        Alumno nombreBuscado2 = lista.BuscarAlumno("Francisco");

        if (nombreBuscado2 != null)
        {
            Console.WriteLine("Alumno encontrado: " + nombreBuscado2.Nombre);
        }
        else
        {
            Console.WriteLine("No existe");
        }

        lista.EliminarAlumno(alumno2);

        foreach (Alumno alumno in lista.RetornarList())
        {
            Console.WriteLine("Id: " + alumno.Id + " Nombre: " + alumno.Nombre + " Promedio: " + alumno.Promedio);
        }

        lista.EliminacionPorPosicion(0);

        foreach (Alumno alumno in lista.RetornarList())
        {
            Console.WriteLine("Id: " + alumno.Id + " Nombre: " + alumno.Nombre + " Promedio: " + alumno.Promedio);
        }
    }


    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {

    }
}
