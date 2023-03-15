using System;

namespace RepasoPersona.Core
{
    public class Persona : Superclase
    {
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public double Saldo { get; private set; }
        public Persona() => Saldo = 0;
        public Persona(string nombre, string apellido, double saldo)

        {
            Nombre = nombre;
            Apellido = apellido;
            Saldo = saldo;
        }
    }
}
