using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Pokemon
{
    public class ListaPokemon
    {
        private Nodo cabeza;
        private int cantidad;

        //Constructor
        public ListaPokemon()
        {
            this.cabeza = null;
            this.cantidad = 0;
        }

        public void AgregarPokemon(Pokemon valor)
        {
            Nodo nuevo = new Nodo(valor);
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                Nodo aux = cabeza;
                while (aux.getSiguiente() != null)
                {
                    aux = aux.getSiguiente();
                }
                aux.setSiguiente(nuevo);
            }
            cantidad++;
        }

        public void EliminarPokemon(int id)
        {
            if (cabeza != null)
            {
                if (cabeza.getValor().getID() == id)
                {
                    cabeza = cabeza.getSiguiente();
                    cantidad--;
                }
                else
                {
                    Nodo aux = cabeza;
                    while (aux.getSiguiente() != null)
                    {
                        if (aux.getSiguiente().getValor().getID() == id)
                        {
                            aux.setSiguiente(aux.getSiguiente().getSiguiente());
                            cantidad--;
                            break;
                        }
                        aux = aux.getSiguiente();
                    }
                }
            }
        }

        //Metodo para buscar la posicion de un pokemon en la lista
        public Pokemon BuscarPokemon(int id)
        {
            Nodo aux = cabeza;
            while (aux != null)
            {
                if (aux.getValor().getID() == id)
                {
                    return aux.getValor();
                }
                aux = aux.getSiguiente();
            }
            return null;
        }
        public Boolean ExistePokemon(int id)
        {
            Nodo aux = cabeza;
            while (aux != null)
            {
                if (aux.getValor().getID() == id)
                {
                    return true;
                }
                aux = aux.getSiguiente();
            }
            return false;
        }

        public string MostrarPokemon()
        {
            string lista = "";
            Nodo aux = cabeza;
            while (aux != null)
            {
                lista += aux.getValor().MostrarPokemon() + "\n";
                aux = aux.getSiguiente();
            }
            return lista;
        }

        public int CantidadPokemon()
        {
            return cantidad;
        }

        public string LeerArchivo()
        {
            string ruta = @"LISTAPOKEMONES.txt";
            string texto = "";
            if (System.IO.File.Exists(ruta))
            {
                System.IO.StreamReader archivo = new System.IO.StreamReader(ruta);
                texto = archivo.ReadToEnd();
                archivo.Close();
            }
            return texto;
        }
    }
}
