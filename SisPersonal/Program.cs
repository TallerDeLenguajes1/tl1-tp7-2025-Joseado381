
using SisPersonal;

Empleado Jose = new Empleado
("Jose","Alonzo",new DateTime(2003,04,24),'c',new DateTime(2010,03,20),650000,Cargos.Especialista);

System.Console.WriteLine("Datos del Empleado:");
System.Console.WriteLine(Jose.MostrarEmpleado());

Empleado[] empleados = new Empleado[3];

empleados[0] = new Empleado("Ana", "García", new DateTime(1990, 5, 12), 's', new DateTime(2015, 6, 1), 500000, Cargos.Administrativo);
empleados[1] = new Empleado("Luis", "Pérez", new DateTime(1985, 8, 23), 'c', new DateTime(2010, 3, 20), 700000, Cargos.Especialista);
empleados[2] = new Empleado("María", "López", new DateTime(1995, 2, 17), 's', new DateTime(2020, 1, 10), 450000, Cargos.Auxiliar);

foreach (var empleado in empleados)
{
    System.Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    System.Console.WriteLine($"Empleado: {empleado.Apellido} {empleado.Nombre}");
    System.Console.WriteLine($"Antiguedad: {empleado.CalcularAntiguedad()} años");
    System.Console.WriteLine($"Salario Total: {empleado.CalcularSalario()}");
}
System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

// Monto total de los salarios
double SalarioTotal = 0;
foreach (var empleado in empleados)
{
    SalarioTotal += empleado.CalcularSalario();
}
System.Console.WriteLine($"El salario gastado en empleados es de ${SalarioTotal}");

int jubilarse = 65, i = 0;
foreach (var empleado in empleados)
{
    if (empleado.CalcularJubilacion() < jubilarse)
    {
        jubilarse = empleado.CalcularJubilacion();
        i++;
    }
}

System.Console.WriteLine($"\nEl empleado mas proximo a jubilarse es:\n{empleados[i-1].MostrarEmpleado()}");
