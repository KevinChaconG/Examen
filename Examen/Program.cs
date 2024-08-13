
using Examen;

Asignatura asignatura = new Asignatura();
Console.WriteLine("");
Console.WriteLine("Ingrese el nombre del estudiante");
asignatura.NombreAlumno = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("Ingrese el numero de cuenta");
asignatura.NumeroCuenta = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("Ingrese el correo electronico");
asignatura.Email = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("Ingrese el nombre de la asignatura");
asignatura.NombreAsignatura = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("Ingrese el nombre del Docente");
asignatura.NombreDocente = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("Ingrese el horario de la asignatura");
asignatura.Horario = Console.ReadLine();
Console.WriteLine("");
try
{
    Console.WriteLine("Ingrese el valor de la primera nota (Valores permitidos 0 - 30)");
    asignatura.N1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");
    Console.WriteLine("Ingrese el valor de la segunda nota (Valores permitidos 0 - 30)");
    asignatura.N2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");
    Console.WriteLine("Ingrese el valor de la tercera nota (Valores permitidos 0 - 40)");
    asignatura.N3 = Convert.ToInt32(Console.ReadLine());

    if(asignatura.N1 > 30 ||asignatura.N2 >30 || asignatura.N3 >40 )
    {
        Console.WriteLine();
        Console.WriteLine("Se excedió el valor permitido para las notas");
    }

    else
    {
        Console.WriteLine("");
        asignatura.Imprimir();
    }       
}
catch (Exception ex)
{
    Console.WriteLine();
    Console.WriteLine("Uno de los valores de nota ingresados no es correcto");
}
Console.ReadLine();
