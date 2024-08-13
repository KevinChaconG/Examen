

namespace Examen
{
    public class Asignatura : Alumno, IAsignatura
    {
        public int N1;

        public int N2;

        public int N3;
        public string NombreAsignatura { get; set; }
        public string Horario { get; set; }
        public string NombreDocente { get; set; }

        public Asignatura() { }

        public Asignatura(string nombreAlumno, string nombreAsignatura, int n1, int n2, int n3)
        {
            NombreAlumno = nombreAlumno;
            NombreAsignatura = nombreAsignatura;
            N1 = n1;
            N2 = n2;
            N3 = n3;
        }

        public double CalcularNotaFinal()
        {
            return N1 + N2 + N3;
        }

        public double CalcularNotaFinal(double n1, double n2, double n3)
        {
            return n1 + n2 + n3;
        }

        public string MensajeNotaFinal()
        {

            if (CalcularNotaFinal() < 60)
            {
                return "Reprobado";
            }
            else if (CalcularNotaFinal() <= 79)
            {
                return "Bueno";
            }
            else if (CalcularNotaFinal() <= 89)
            {
                return "Muy Bueno";
            }
            else
            {
                return "Sobresaliente";
            }

        }

        public string MensajeNotaFinal2()
        {

            if (CalcularNotaFinal() < 60)
            {
                return "Reprobado";
            }
            else if (CalcularNotaFinal() <= 79)
            {
                return "Bueno";
            }
            else if (CalcularNotaFinal() <= 89)
            {
                return "Muy Bueno";
            }
            else
            {
                return "Sobresaliente";
            }

        }

        public void Imprimir()
        {
            Console.WriteLine("--- Datos del Alumno ---");
            Console.WriteLine($"Nombre del Alumno: {NombreAlumno}");
            Console.WriteLine($"Numero de Cuenta: {NumeroCuenta}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Nombre de Asignatura: {NombreAsignatura}");
            Console.WriteLine($"Nombre de Docente: {NombreDocente}");
            Console.WriteLine($"Horario: {Horario}");
            Console.WriteLine($"Nota Final: {CalcularNotaFinal()} - {MensajeNotaFinal()}");
            Console.WriteLine($"Nota Final: {CalcularNotaFinal()} - {MensajeNotaFinal()}");
            Console.WriteLine("------------------------");
        }
    }

}
 

