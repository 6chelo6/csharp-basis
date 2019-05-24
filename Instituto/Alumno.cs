using System;

namespace Instituto
{
    public class Alumno
    {
        public int nroExpediente;
        public int ci;
        public string nombre;
        public string apellidos;
        public int nota;
        public int edad;

        public bool EsMayor()
        {
            if(edad>=18)
                return true;
            else
                return false;
        }
    }
}