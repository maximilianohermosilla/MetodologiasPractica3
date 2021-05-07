using System;
using System.Collections.Generic;

namespace Practica
{
	/// <summary>
	/// Description of Diccionario.
	/// </summary>
	public class Diccionario<T>: Conjunto<T>
	{
		private List<Comparable> datos = new List<Comparable>();		
		

		public new int cuantos(){
			return datos.Count;
		}
		
		public new Comparable menor(){
			Comparable minimo = datos[0];
			foreach (Comparable elemento in datos){
				if (((Comparable)elemento).sosMenor(minimo)){
					minimo=elemento;
				}
			}
			return minimo;
		}
		
		public new Comparable mayor(){
			Comparable maximo = datos[0];
			foreach (Comparable elemento in datos){
				if (((Comparable)elemento).sosMayor(maximo)){
					maximo=elemento;
				}
			}
			return maximo;
		}

		public new void agregar(Comparable cV){
			this.datos.Add(cV);			
		}
		
		public void agregarClaveValor(Comparable clave, Object valor){
			ClaveValor temp= new ClaveValor(clave, valor);
			bool existe=false;
			if (this.cuantos() > 0){
			foreach (Comparable elemento in datos){
				if(((ClaveValor)elemento).sosIgual(temp)){
					((ClaveValor)elemento).setValor(valor);
					Console.WriteLine("La clave ya existe");
					existe=true;
				}
			}
			}
			else{
			if (!existe){
				Console.WriteLine("Agrego clave porque no existe");
				this.agregar(temp);	
			}
			}
		}
		
		public object valorDe(Comparable clave){
			bool existe=false;
			foreach (ClaveValor elemento in datos){
				//if ((((ClaveValor)elemento).getClave()).Equals(clave)){
				if(((Numero)elemento.getClave()).sosIgual(clave)){
					existe=true;
					return elemento.getValor();
				}
			}
			if (!existe){
				Console.WriteLine("La clave no existe");
				return null;
			}
			return null;
			
		}
		
		public new bool pertenece(Comparable obj){
			return this.contiene(obj);
		}

	}
}
