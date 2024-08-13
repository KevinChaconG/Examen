

namespace Examen
{
    public interface IAsignatura
    {
        public double CalcularNotaFinal()
        {
            return 0;
        }

        public double CalcularNotaFinal(double n1, double n2, double n3)
        {
            return n1 + n2 + n3;
        }

        public string MensajeNotaFinal()
        {
            Console.WriteLine();
        }

        public void Imprimir()
        {
            Console.WriteLine("---Nota Final---");
            Console.WriteLine("---Nota Final---");
        }
    }
}
