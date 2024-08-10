using System;

abstract class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Año { get; set; }
    public double Kilometraje { get; set; }

    public Vehiculo(string marca, string modelo, int año, double kilometraje)
    {
        Marca = marca;
        Modelo = modelo;
        Año = año;
        Kilometraje = kilometraje;
    }

    public abstract void Encender();
    public abstract void Apagar();
    public abstract void Conducir(double km);
}
