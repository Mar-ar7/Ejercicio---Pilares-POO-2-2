using System;

class Auto : Vehiculo
{
    public int NumeroDePuertas { get; set; }

    public Auto(string marca, string modelo, int año, double kilometraje, int numeroDePuertas)
        : base(marca, modelo, año, kilometraje)
    {
        NumeroDePuertas = numeroDePuertas;
    }

    public override void Encender()
    {
        Console.WriteLine($"El auto {Marca} {Modelo} está encendido.");
    }

    public override void Apagar()
    {
        Console.WriteLine($"El auto {Marca} {Modelo} está apagado.");
    }

    public override void Conducir(double km)
    {
        Kilometraje += km;
        Console.WriteLine($"El auto {Marca} {Modelo} ha sido conducido por {km} km. Kilometraje total: {Kilometraje} km.");
    }
}
