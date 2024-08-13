

namespace Examen
{
    public class Asignatura : Alumno, IAsignatura
    {
        public int N1;

        public int N2;

        public int N3;
        public string NombreAsignatura {  get; set; }
        public string Horario { get; set; }
        public string NombreDocente { get; set; }


    }
}
