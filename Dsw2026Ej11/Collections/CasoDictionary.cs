using Dsw2026Ej11.Domain;
using System.Reflection.Metadata.Ecma335;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private Dictionary<int, Alumno> alumnos; //No se si las listas, Diccionarios, etc, deben ser privados siempre o se puede dar que sea Public

    public CasoDictionary()
    {
        alumnos = new Dictionary<int, Alumno>();
    }

    public void AgregarAlumno(int legajo, Alumno alumno)
    {
        alumnos.Add(legajo, alumno);
    }

    public Alumno BuscarAlumno(int legajo)
    {
        if (alumnos.ContainsKey(legajo))
        {
            return alumnos[legajo];
        }
        return null;
    }

    public Dictionary<int, Alumno> RetornarDictionary()
    {
        return alumnos;
    }

    public void EliminarAlumno(int legajo)
    {
        alumnos.Remove(legajo);
    }
}
