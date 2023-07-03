// Interfaz para definir la estrategia de venta de agua
public interface IVentaAgua
{
    void VenderAgua(int cantidad);
    double CalcularCosto(int cantidad);
}
