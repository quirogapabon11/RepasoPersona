namespace RepasoPersona.Core
{
    public class Cuenta : Superclase
    {
        public int Cbu { get; private set;}

        public Cuenta(double saldo, double monto, int cbu)
        {
            Cbu = cbu;
        }
    }
}