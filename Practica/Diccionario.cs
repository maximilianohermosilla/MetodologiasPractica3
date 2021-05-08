using System;
using System.Collections.Generic;

namespace Practica
{
	/// <summary>
	/// Description of Diccionario.
	/// </summary>
	public class Diccionario<T>: Coleccionable
	{
		private List<Comparable> datos = new List<Comparable>();
		Numero num;
		int indice=0;
		EstrategiaDiccionario comparador = new PorValor();

		public int cuantos(){
			return this.datos.Count;
		}
		
		public Comparable menor(){
			Comparable minimo = this.datos[0];
			foreach (Comparable elemento in datos){
				if (comparador.esMenor((ClaveValor)elemento, (ClaveValor)minimo)){
					minimo=elemento;
				}
			}
			return minimo;
		}
		
		public Comparable mayor(){
			Comparable maximo = this.datos[0];
			foreach (Comparable elemento in datos){
				if (comparador.esMayor((ClaveValor)elemento, (ClaveValor)maximo)){
					maximo=elemento;
				}
			}
			return maximo;
		}
		
		public void recorrer(){
			foreach (ClaveValor elemento in datos){
				Console.WriteLine(elemento);
			}
		}
		
		public bool pertenece(Comparable obj){
			return this.contiene(obj);
		}
		
		
		public bool contiene(Comparable obj){
			bool existe=false;
			foreach (Comparable elemento in datos){
				if (comparador.esIgual((ClaveValor)elemento, (ClaveValor)obj)){
					existe=true;
				}
			}
			return existe;
		}
		
		public bool contieneNumero(string num){
			int numero=int.Parse(num);
			Numero number = new Numero(numero);
			bool existe=false;
			
			foreach (ClaveValor elemento in datos){
				if(((Numero)(elemento.getClave())).sosIgual(number)){
					existe=true;
				}
			}			
			return existe;
		}

		public void agregar(Comparable valor){
			EstrategiaDiccionario comparadorAgregar = new PorClave();
			num=new Numero(indice);
			ClaveValor claveTemp = new ClaveValor(num, valor);
			foreach (Comparable elemento in datos){
				if (comparadorAgregar.esMayor((ClaveValor)elemento, (ClaveValor)claveTemp)){
					claveTemp.setClave(((ClaveValor)elemento).getClave());
				}
			}
			indice=(((Numero)((ClaveValor)claveTemp).getClave()).getValor() + 1);
			num.setValor(indice);
			agregarClaveValor(num, valor);
		}
		
		public void agregarClaveValor(Comparable clave, Object valor){
			ClaveValor temp= new ClaveValor(clave, valor);
			bool existe=false;
			if (this.cuantos() > 0){
				foreach (ClaveValor elemento in this.datos){
					if(((ClaveValor)elemento).sosIgual(temp)){
						((ClaveValor)elemento).setValor(valor);
						Console.WriteLine("La clave ya existe");
						existe=true;
					}
					else{existe=false;}
				}
			}
			if (!existe){
				Console.WriteLine("Agrego clave porque no existe");
				datos.Add(temp);
			}
		}
		
		public object valorDe(Comparable clave){
			bool existe=false;
			
			foreach (ClaveValor elemento in datos){
				if(((Numero)(elemento.getClave())).sosIgual((Numero)clave)){
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

	}	
}
