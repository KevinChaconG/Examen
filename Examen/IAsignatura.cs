

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

        void MensajeNotaFinal(double CalcularNotaFinal, double n1, double n2)
        {
            {
                if (CalcularNotaFinal < 60)
                {
                    Console.WriteLine("Reprobado");
                }
                if (CalcularNotaFinal > 79)
                {
                    Console.WriteLine("Bueno");
                }
                if (CalcularNotaFinal < 89)
                {
                    Console.WriteLine("Muy Bueno");
                }
                if (CalcularNotaFinal > 89)
                {
                    Console.WriteLine("Sobresaliente");
                }
            }

            void Imprimir()
            {
                Console.WriteLine("---Nota Final---");
                Console.WriteLine("---Nota Final---");
            }
        }
    }
}
