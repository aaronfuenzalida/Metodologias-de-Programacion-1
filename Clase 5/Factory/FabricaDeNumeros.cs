
using Metodologias_de_Programacion.Clase_5_Proxy__Command.Interfaces;
using Metodologias_de_Programacion.Clase_5_Proxy__Command.Models;

namespace Metodologias_de_Programacion.Clase_5_Proxy__Command.Factory
{
public class FabricaDeNumeros : FabricaDeComparables
{
    bool aleatorio = false;
    public override Comparable crearComparable()
    {
        return new Numero(aleatorio ? new GeneradorDeDatosAleatorios().numeroAleatorio(100) : new LectorDeDatos().numeroPorTeclado());
    }

    public override void setAleatorioON()
    {
        aleatorio = true;
    }

    public override void setAleatorioOFF()
    {
        aleatorio = false;
    }
}
}
