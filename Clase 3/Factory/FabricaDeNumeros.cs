
using Metodologias_de_Programacion.Clase_3_Factory__Observer.Interfaces;
using Metodologias_de_Programacion.Clase_3_Factory__Observer.Models;

namespace Metodologias_de_Programacion.Clase_3_Factory__Observer.Factory
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
