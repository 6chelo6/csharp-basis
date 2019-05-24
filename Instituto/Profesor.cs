using System;

namespace Instituto
{
    public class Profesor
    {
        public int ci;
        public string nombre;
        public string apellidos;
        public string direccion;
        public int telefono;
        public int anosServicio;
        public double sueldo;

        public double MostrarSueldo()
        {
            if(anosServicio >= 2 && anosServicio < 5)
                sueldo = sueldo * 1.02;
            else if(anosServicio >= 6 && anosServicio < 10)
                sueldo = sueldo * 1.035;
            else if(anosServicio > 10)
                sueldo = sueldo * 1.05;
            return sueldo;
        }
    }
}