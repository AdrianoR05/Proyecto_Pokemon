using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Pokemon
{
    public class Nodo
    {
        //Atributos
        public Pokemon valorPokemon;
        public Nodo siguiente;

        //Constructor
        public Nodo(Pokemon valor)
        {
            this.valorPokemon = valor;
            this.siguiente = null;
        }
        //Metodos getters y setters
        public Pokemon getValor()
        {
            return valorPokemon;
        }
        public void setValor(Pokemon valor)
        {
            this.valorPokemon = valor;
        }
        public Nodo getSiguiente()
        {
            return siguiente;
        }
        public void setSiguiente(Nodo siguiente)
        {
            this.siguiente = siguiente;
        }

    }
}
