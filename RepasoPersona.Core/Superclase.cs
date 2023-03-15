using System;
namespace RepasoPersona.Core
{
    public abstract class Superclase
    {
        public double Monto { get; private set;}
        public virtual double Saldo { get; private set;}

        public void Debitar(double monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto tiene que ser mayor a cero.");

            if (monto > Saldo)
                throw new InvalidOperationException("El monto supera al Saldo.");
            Saldo -= monto;
        }
        public void Acreditar(double monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto tiene que ser mayor a cero.");
            Saldo += monto;
        }
    }
}