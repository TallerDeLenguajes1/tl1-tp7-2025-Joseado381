// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;

Claculadora miCalculadora = new Claculadora();
miCalculadora.Sumar(23);
miCalculadora.Sumar(10);
miCalculadora.Sumar(50);
miCalculadora.dividir(0);
miCalculadora.dividir(2);

Console.WriteLine($"El resultado es: {miCalculadora.ObtenerResultado()}");