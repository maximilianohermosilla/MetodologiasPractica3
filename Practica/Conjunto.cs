using System;
using System.Collections.Generic;

namespace Practica
{
	/// <summary>
	/// Description of Conjunto.
	/// </summary>
	public class Conjunto<T>: Coleccionable
	{
		private List<Comparable> datos = new List<Comparable>();
		
		
		public int cuantos(){
			return datos.Count;
		}
		
		public Comparable menor(){
			Comparable minimo = datos[0];
			foreach (Comparable elemento in datos){
				if (((Comparable)elemento).sosMenor(minimo)){
					minimo=elemento;
				}
			}
			return minimo;
		}
		
		public Comparable mayor(){
			Comparable maximo = datos[0];
			foreach (Comparable elemento in datos){
				if (((Comparable)elemento).sosMayor(maximo)){
					maximo=elemento;
				}
			}
			return maximo;
		}
		
		public void agregar(Comparable obj){
			if (!this.pertenece(obj)){
				this.datos.Add(obj);
			}
			else if (this.pertenece(obj)){
				Console.WriteLine("El objeto ya existe");
			}
			
		}
		
		public bool contiene(Comparable obj){
			bool existe=false;
			foreach (Comparable elemento in datos){
				if (elemento.sosIgual(obj)){
					existe=true;
				}
			}
			return existe;
		}
		
		public bool contieneNumero(string num){
			bool existe=false;
			foreach (Comparable elemento in datos){
				if (elemento.informar() == num.ToString()){
					existe=true;
				}
			}
			return existe;
		}
		
		public bool pertenece(Comparable obj){
			return this.contiene(obj);
		}
	}
}