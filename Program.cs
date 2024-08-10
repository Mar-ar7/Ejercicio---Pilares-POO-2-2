using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear instancias de cada tipo de vehículo
        Auto miAuto = new Auto("Toyota", "Corolla", 2020, 15000, 4);
        Motocicleta miMoto = new Motocicleta("Yamaha", "MT-07", 2019, 8000, "Deportiva");
        Camion miCamion = new Camion("Volvo", "FH", 2018, 120000, 20);

        // Usar los métodos y mostrar propiedades adicionales
        Console.WriteLine($"Auto: {miAuto.Marca} {miAuto.Modelo}, Año: {miAuto.Año}, Puertas: {miAuto.NumeroDePuertas}");
        miAuto.Encender();
        miAuto.Conducir(150);
        miAuto.Apagar();

        Console.WriteLine($"Motocicleta: {miMoto.Marca} {miMoto.Modelo}, Año: {miMoto.Año}, Tipo: {miMoto.TipoDeMoto}");
        miMoto.Encender();
        miMoto.Conducir(50);
        miMoto.Apagar();

        Console.WriteLine($"Camión: {miCamion.Marca} {miCamion.Modelo}, Año: {miCamion.Año}, Capacidad de Carga: {miCamion.CapacidadDeCarga} toneladas");
        miCamion.Encender();
        miCamion.Conducir(300);
        miCamion.Apagar();
    }
}

