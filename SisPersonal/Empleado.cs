namespace SisPersonal
{
    public enum Cargos {Auxiliar,Administrativo,Ingeniero,Especialista,Investigador}
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private char estadoCivil;
        private DateTime fechaIngreso;
        private double sueldoBasico;
        private Cargos cargo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        public Cargos Cargo { get => cargo; set => cargo = value; }

        //constructor es el que inicializa los atributos de la clase
        public Empleado(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil,
        DateTime fechaIngreso, double sueldoBasico, Cargos cargo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.estadoCivil = estadoCivil;
            this.fechaIngreso = fechaIngreso;
            this.sueldoBasico = sueldoBasico;
            this.cargo = cargo;
        }

        //método para calcular la antigüedad del empleado
        public int CalcularAntiguedad()
        {
            DateTime fechaActual = DateTime.Now;
            int antiguedad = fechaActual.Year - fechaIngreso.Year;

            // Verificar si el empleado aún no ha cumplido años en el año actual
            if (fechaActual < fechaIngreso.AddYears(antiguedad))
            {
                antiguedad--;
            }

            return antiguedad;
        }

        //calcularEdad
        public int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            // Verificar si el empleado aún no ha cumplido años en el año actual
            if (fechaActual < fechaNacimiento.AddYears(edad))
            {
                edad--;
            }

            return edad;
        }

        // años que faltan para la jubilación
        public int CalcularJubilacion()
        {
            int edad = CalcularEdad();
            int Tiempojubilacion = 65 - edad;
            if (Tiempojubilacion < 0)
            {
                Tiempojubilacion = 0; // Si ya tiene más de 65 años, no faltan años para jubilarse
            }
            return Tiempojubilacion;
        }

        //método para calcular el sueldo total del empleado
        public double CalcularSalario()
        {
            double adicional = 0;

            if (CalcularAntiguedad() <= 20)
            {
                adicional = sueldoBasico * CalcularAntiguedad() * 0.01;
            }
            else
            {
                adicional = sueldoBasico * 0.25;
            }
            if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
            {
                adicional *= 1.50;
            }
            if (char.ToUpper(estadoCivil) == 'C')
            {
                adicional += 150000;
            }

            return (double)(sueldoBasico + adicional);
        }

        //Mostrar info Empleados
        public string MostrarEmpleado()
        {
            return $"Nombre: {nombre} {apellido}\n" +
                   $"Fecha de Nacimiento: {fechaNacimiento}\n" +
                   $"Estado Civil: {estadoCivil}\n" +
                   $"Fecha de Ingreso: {fechaIngreso}\n" +
                   $"Sueldo Básico: {sueldoBasico}\n" +
                   $"Cargo: {cargo}\n" +
                   $"Antigüedad: {CalcularAntiguedad()} años\n" +
                   $"Edad: {CalcularEdad()} años\n" +
                   $"Años para Jubilación: {CalcularJubilacion()} años\n" +
                   $"Sueldo Total: {CalcularSalario()}";
        }

    }
}
