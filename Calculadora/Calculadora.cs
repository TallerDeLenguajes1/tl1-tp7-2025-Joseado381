namespace EspacioCalculadora
{
    public class Calculadora
    {
        public double Dato;

        public double Resultado
        {
            get { return Dato; }
        }

        public void Sumar(double termino)
        {
            Dato += termino;
        }
        public void Restar(double termino)
        {
            Dato -= termino;
        }
        public void Multiplicar(double termino)
        {
            Dato *= termino;
        }
        public void Dividir(double termino)
        {
            if (termino != 0)
            {
                Dato /= termino;
            }
            else
            {
                System.Console.WriteLine("Error: No se puede dividir entre cero");
            }
        }

    }
}