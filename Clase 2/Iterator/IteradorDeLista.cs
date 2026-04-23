namespace Clase_2___Strategy___Iterator
{
	public class IteradorDeLista : IIterador
	{
		private List<Comparable> datos;
		private int indiceActual;
		
		public IteradorDeLista(List<Comparable> elementos)
		{
			this.datos=elementos;
			this.primero();
		}
		
		public void primero(){
			this.indiceActual=0;
		}
		
		public void siguiente(){
			this.indiceActual++;
		}
		
		public bool fin(){
			return indiceActual >= this.datos.Count;
		}
		
		public Comparable actual(){
			return this.datos[this.indiceActual];
		}
	}
}