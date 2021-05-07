using System;

namespace Practica
{
	/// <summary>
	/// Description of EstrategiaComparar.
	/// </summary>
	public interface EstrategiaComparar{
		bool esIgual(Alumno alumno1, Alumno alumno2);
		bool esMenor(Alumno alumno1, Alumno alumno2);
		bool esMayor(Alumno alumno1, Alumno alumno2);
	}
	
	public class PorNombre : EstrategiaComparar{
		public bool esIgual (Alumno alumno1, Alumno alumno2){
			bool igual=false;
			if (alumno1.getNombre()==alumno2.getNombre()){
				igual=true;
			}
			return igual;
		}
		
		public bool esMenor (Alumno alumno1, Alumno alumno2){
			bool menor=false;
			/*if (alumno1.getNombre()<alumno2.getNombre()){
				menor=true;
			}*/
			return menor;
		}
		
		public bool esMayor (Alumno alumno1, Alumno alumno2){
			bool mayor=false;
			/*if (alumno1.getNombre()>alumno2.getNombre()){
				mayor=true;
			}*/
			return mayor;
		}
	}
	
	public class PorDni : EstrategiaComparar{
		public bool esIgual (Alumno alumno1, Alumno alumno2){
			bool igual=false;
			if (alumno1.getDni()==alumno2.getDni()){
				igual=true;
			}
			return igual;
		}
		
		public bool esMenor (Alumno alumno1, Alumno alumno2){
			bool menor=false;
			if (alumno1.getDni()<alumno2.getDni()){
				menor=true;
			}
			return menor;
		}
		
		public bool esMayor (Alumno alumno1, Alumno alumno2){
			bool mayor=false;
			if (alumno1.getDni()>alumno2.getDni()){
				mayor=true;
			}
			return mayor;
		}
	}
	
	public class PorPromedio : EstrategiaComparar{
		public bool esIgual (Alumno alumno1, Alumno alumno2){
			bool igual=false;
			if (alumno1.getPromedio()==alumno2.getPromedio()){
				igual=true;
			}
			return igual;
		}
		
		public bool esMenor (Alumno alumno1, Alumno alumno2){
			bool menor=false;
			if (alumno1.getPromedio()<alumno2.getPromedio()){
				menor=true;
			}
			return menor;
		}
		
		public bool esMayor (Alumno alumno1, Alumno alumno2){
			bool mayor=false;
			if (alumno1.getPromedio()>alumno2.getPromedio()){
				mayor=true;
			}
			return mayor;
		}
	}
	
	public class PorLegajo : EstrategiaComparar{
		public bool esIgual (Alumno alumno1, Alumno alumno2){
			bool igual=false;
			if (alumno1.getLegajo()==alumno2.getLegajo()){
				igual=true;
			}
			return igual;
		}
		
		public bool esMenor (Alumno alumno1, Alumno alumno2){
			bool menor=false;
			if (alumno1.getLegajo()<alumno2.getLegajo()){
				menor=true;
			}
			return menor;
		}
		
		public bool esMayor (Alumno alumno1, Alumno alumno2){
			bool mayor=false;
			if (alumno1.getLegajo()>alumno2.getLegajo()){
				mayor=true;
			}
			return mayor;
		}
	}
}
