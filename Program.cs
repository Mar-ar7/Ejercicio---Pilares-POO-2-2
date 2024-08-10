using System;

class Program
{
    static void Main(string[] args)
    {
        //Marcas 
        Auto miAuto = new Auto("Ford", "Mustang", 2023, 15000, 4);
        Motocicleta miMoto = new Motocicleta("Yamaha", "YZF-R1", 2023, 6000, "Deportiva");
        Camion miCamion = new Camion("Volvo", "FH", 2022, 120000, 20);

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

