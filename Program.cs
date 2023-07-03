// Ejemplo
public class Program
{
    public static void Main(string[] args)
    {
        // Crear las estrategias de venta de agua
        var ventaAguaEmbotellada = new VentaAguaEmbotellada();
        var ventaAguaBotellita = new VentaAguaBotellita();

        Console.Write("Ingrese la cantidad de agua en bidon: ");
        int cantidadEmbotellada = int.Parse(Console.ReadLine());

        Console.Write("Ingrese la cantidad de agua en paquetes de botellita: ");
        int cantidadBotellita = int.Parse(Console.ReadLine());

        // Crear el programa de venta de agua con la estrategia de venta de agua embotellada en Bidon.
        var programaVentaAgua = new ProgramaVentaAgua(ventaAguaEmbotellada);
        programaVentaAgua.RealizarVentaAgua(cantidadEmbotellada);  // Vendiendo 10 botellas de agua embotellada en Bidon.

        // Cambiar la estrategia del programa de venta de agua a la estrategia de venta de agua en botellita pequeñas
        programaVentaAgua = new ProgramaVentaAgua(ventaAguaBotellita);
        programaVentaAgua.RealizarVentaAgua(cantidadBotellita);  // Vendiendo paquetes de agua en botellitas pequeñas.
    }
}
