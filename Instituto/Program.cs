using System;

namespace Instituto
{
    class Program
    {
        static void Main(string[] args)
        {
            // LLenar datos profesor 1
            Profesor profesorMatematicas = new Profesor();
            profesorMatematicas.ci = 123456;
            profesorMatematicas.nombre = "Pepe";
            profesorMatematicas.apellidos = "Lepuf";
            profesorMatematicas.direccion = "Calle falsa Nro.123";
            profesorMatematicas.telefono = 70700001;
            profesorMatematicas.anosServicio = 7;
            profesorMatematicas.sueldo = 1000;

            Console.WriteLine(profesorMatematicas.MostrarSueldo());

            
            // LLenar datos estudiante 1
            Alumno jherico = new Alumno();
            jherico.nroExpediente = 1;
            jherico.ci = 555555;
            jherico.nombre = "Jherico";
            jherico.apellidos = "Prueba";
            jherico.nota = 75;
            jherico.edad = 18;
            if(jherico.EsMayor())
                Console.WriteLine(jherico.nombre + " es mayor de edad.");
            else
                Console.WriteLine(jherico.nombre + " NO es mayor de edad.");
        }
    }
}
