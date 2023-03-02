using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace laboratorio1MelvinPerez.Entidades
{
    public class Persona
    {
        public string nombre ;
        public int edad ;
        public char sexo ;
        public double peso ;
        public double altura;

        public Persona(string nombre, int edad, char sexo, double peso, double altura) {
        this.nombre = nombre;
        this.edad = edad;
        this.sexo = sexo;
        this.peso = peso;
        this.altura = altura;
        }
        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad {
            get { return edad; }
            set { edad = value; }
        }

        public char Sexo {
            get { return sexo; }
            set { sexo = value; }
        }

        public double Peso {
            get { return peso; }
            set { peso = value; }
        }

        public double Altura {
            get { return altura; }
            set { altura = value; }
        }
    }
}
    
