using System;
using System.Collections.Generic;

namespace Practica
{
	/// <summary>
	/// Description of Pila.
	/// </summary>
	public class Pila<T> : Coleccionable
	{
		private List<Comparable> datos = new List<Comparable>();
	
		public void push(Comparable elem) {
			this.datos.Add(elem);
		}
	
		public Comparable pop() {
			Comparable temp = this.datos[(this.datos.Count-1)];
			this.datos.RemoveAt(this.datos.Count-1);
			return temp;
		}
		
		public Comparable top() {
			return this.datos[(this.datos.Count-1)]; 
		}
		
		public bool isEmpty() {
				return this.datos.Count == 0;
		}
		
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
			this.datos.Add(obj);
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
	}
}