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

        Console.WriteLine("\n Eliminando Alumno 2");

        lista.EliminarAlumno(alumno2);

        foreach (Alumno alumno in lista.RetornarList())
        {
            Console.WriteLine("Id: " + alumno.Id + " Nombre: " + alumno.Nombre + " Promedio: " + alumno.Promedio);
        }

        Console.WriteLine("Eliminando el alumno de la poscion 0");

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
        CasoDictionary diccionario = new CasoDictionary();
        Alumno alumno1 = new Alumno(45, "Nico", 8);
        Alumno alumno2 = new Alumno(66, "Juan", 5);
        Alumno alumno3 = new Alumno(18, "Lucas", 9);

        diccionario.AgregarAlumno(60680, alumno1);
        diccionario.AgregarAlumno(1111, alumno2);
        diccionario.AgregarAlumno(22222, alumno3);


        foreach (var alumno in diccionario.RetornarDictionary())
        {
            Console.WriteLine("Legajo: " + alumno.Key + " Id: " + alumno.Value.Id + " Nombre: " + alumno.Value.Nombre + " Promedio: " + alumno.Value.Promedio);
        }

        Alumno buscado = diccionario.BuscarAlumno(60680);

        Console.WriteLine("\n Busco el alumno con Id: " + buscado.Id);

        if (buscado != null)
        {
            Console.WriteLine("Alumno encontrado: " + buscado.Nombre);
        }

        Console.WriteLine("\n Buscando legajo inexistente");

        Alumno buscado2 = diccionario.BuscarAlumno(9999);

        if (buscado2 != null)
        {
            Console.WriteLine("Alumno encontrado: " + buscado2.Nombre);
        }
        else
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine("\n Elimino al alumno de legajo 1111");

        diccionario.EliminarAlumno(1111);

        foreach (var alumno in diccionario.RetornarDictionary())
        {
            Console.WriteLine("Legajo: " + alumno.Key + " Id: " + alumno.Value.Id + " Nombre: " + alumno.Value.Nombre + " Promedio: " + alumno.Value.Promedio);
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq caso = new CasoLinq();

        // 1
        Console.WriteLine("Primer libro:");
        Console.WriteLine(caso.GetPrimero(null).Titulo);

        // 2
        Console.WriteLine("\nÚltimo libro:");
        Console.WriteLine(caso.GetUltimo().Titulo);

        // 3
        Console.WriteLine("\nSuma total de precios:");
        Console.WriteLine(caso.GetTotalPrecios());

        // 4
        Console.WriteLine("\nPromedio de precios:");
        Console.WriteLine(caso.GetPromedioPrecios());

        // 5
        Console.WriteLine("\nLibros con ID mayor a 15:");

        foreach (var libro in caso.ListPorId())
        {
            Console.WriteLine(libro.Titulo);
        }

        // 7
        Console.WriteLine("\nLibro con mayor precio:");
        Console.WriteLine(caso.GetMayorPrecio().Titulo);

        // 8
        Console.WriteLine("\nLibro con menor precio:");
        Console.WriteLine(caso.GetMenorPrecio().Titulo);

        // 9
        Console.WriteLine("\nLibros con precio mayor al promedio:");

        foreach (var libro in caso.GetMayorPromedio())
        {
            Console.WriteLine(libro.Titulo + " - " + libro.Precio);
        }

        // 10
        Console.WriteLine("\nLibros ordenados descendentemente:");

        foreach (var libro in caso.OrdenarDesc())
        {
            Console.WriteLine(libro.Titulo);
        }

    }
}

