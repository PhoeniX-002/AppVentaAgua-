// Implementación de la estrategia de venta de agua en botellita
public class VentaAguaBotellita : IVentaAgua
{
    private const double PrecioUnidad = 4.00;
    public void VenderAgua(int cantidad)
    {
        Console.WriteLine($"Vendiendo {cantidad} paquete(s) agua de botellitas pequeñas de $ 4.00 cada paquete.");
    }
    public double CalcularCosto(int cantidad)
    {
        return PrecioUnidad * cantidad;
    }
}
