
using Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Interfaces;
using Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Models;

namespace Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Factory
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
