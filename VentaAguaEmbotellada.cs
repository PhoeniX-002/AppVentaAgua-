// Implementación de la estrategia de venta de agua embotellada
public class VentaAguaEmbotellada : IVentaAgua
{
    private const double PrecioPaquete = 1.25;

    public void VenderAgua(int cantidad)
    {
        Console.WriteLine($"Vendiendo {cantidad} botella(s) de agua embotellada en Bidon a $ 1.25 cada una.");
    }
    public double CalcularCosto(int cantidad)
    {
        return PrecioPaquete * cantidad;
    }
}
