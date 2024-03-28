using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Pokemon
{
    public class Pokemon
    {
        public int id;
        public string Nombre;
        public string Tipo1;
        public string Tipo2;
        public int Vida;
        public int Ataque;
        public int AtaqueEspecial;
        public int Defensa;
        public int DefensaEspecial;
        public int Velocidad;

        public Pokemon(int id, string Nombre, string Tipo1, string Tipo2, int Vida, int Ataque, int AtaqueEspecial, int Defensa, int DefensaEspecial, int Velocidad)
        {
            this.id = id;
            this.Nombre = Nombre;
            this.Tipo1 = Tipo1;
            this.Tipo2 = Tipo2;
            this.Vida = Vida;
            this.Ataque = Ataque;
            this.AtaqueEspecial = AtaqueEspecial;
            this.Defensa = Defensa;
            this.DefensaEspecial = DefensaEspecial;
            this.Velocidad = Velocidad;
        }
        
        public string MostrarPokemon()
        {
            return "ID: " + id + " Nombre: " + Nombre + " Tipo1: " + Tipo1 + " Tipo2: " + Tipo2 + " Vida: " + Vida + " Ataque: " + Ataque + " Ataque Especial: " + AtaqueEspecial + " Defensa: " + Defensa + " Defensa Especial: " + DefensaEspecial + " Velocidad: " + Velocidad;
        }
        public int getID()
        {
            return id;
        }
        public string getNombre()
        {
            return Nombre;
        }
        public string getTipo1()
        {
            return Tipo1;
        }
        public string getTipo2()
        {
            return Tipo2;
        }
        public int getVida()
        {
            return Vida;
        }
        public int getAtaque()
        {
            return Ataque;
        }
        public int getAtaqueEspecial()
        {
            return AtaqueEspecial;
        }
        public int getDefensa()
        {
            return Defensa;
        }
        public int getDefensaEspecial()
        {
            return DefensaEspecial;
        }
        public int getVelocidad()
        {
            return Velocidad;
        }

    }
}
