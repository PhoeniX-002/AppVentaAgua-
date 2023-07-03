// Contexto que utiliza una estrategia de venta de agua
public class ProgramaVentaAgua
{
    private IVentaAgua _estrategiaVentaAgua;

    public ProgramaVentaAgua(IVentaAgua estrategiaVentaAgua)
    {
        _estrategiaVentaAgua = estrategiaVentaAgua;
    }

    public void RealizarVentaAgua(int cantidad)
    {
        _estrategiaVentaAgua.VenderAgua(cantidad);
        double costo = _estrategiaVentaAgua.CalcularCosto(cantidad);
        Console.WriteLine($"Costo total: {costo:C}");
    }
}
