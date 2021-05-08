using System;

namespace Practica
{
	/// <summary>
	/// Description of EstrategiaDiccionario.
	/// </summary>
	public interface EstrategiaDiccionario
	{
		bool esIgual(ClaveValor clave1, ClaveValor clave2);
		bool esMenor(ClaveValor clave1, ClaveValor clave2);
		bool esMayor(ClaveValor clave1, ClaveValor clave2);
	}
	
	public class PorClave : EstrategiaDiccionario{
		public bool esIgual (ClaveValor clave1, ClaveValor clave2){
			bool igual=false;
			if (clave1.getClave()==clave2.getClave()){
				igual=true;
			}
			return igual;
		}
		
		public bool esMenor (ClaveValor clave1, ClaveValor clave2){
			bool menor=false;
			if (((Numero)(clave1.getClave())).sosMenor((Numero)clave2.getClave())){
				menor=true;
			}
			return menor;
		}
		
		public bool esMayor (ClaveValor clave1, ClaveValor clave2){
			bool mayor=false;
			if (((Numero)(clave1.getClave())).sosMayor((Numero)clave2.getClave())){
				mayor=true;
			}
			return mayor;
		}
	}
	
	public class PorValor : EstrategiaDiccionario{
		public bool esIgual (ClaveValor clave1, ClaveValor clave2){
			bool igual=false;
			if (clave1.getValor()==clave2.getValor()){
				igual=true;
			}
			return igual;
		}
		
		public bool esMenor (ClaveValor clave1, ClaveValor clave2){
			bool menor=false;
			if ((clave1.getValor()).GetHashCode() < (clave2.getValor()).GetHashCode()){
				menor=true;
			}
			return menor;
		}
		
		public bool esMayor (ClaveValor clave1, ClaveValor clave2){
			bool mayor=false;
			if ((clave1.getValor()).GetHashCode() > (clave2.getValor()).GetHashCode()){
				mayor=true;
			}
			return mayor;
		}
	}
}
