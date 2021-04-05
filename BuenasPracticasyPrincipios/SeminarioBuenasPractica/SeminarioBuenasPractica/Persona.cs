using System;
using System.Collections.Generic;
using System.Text;

namespace SeminarioBuenasPractica
{
    abstract class Persona
    {
        int ci;
        string nombre;
        string direcion;

        public Persona(int ci , string nombre )  
        {
            this.ci = ci;
            this.nombre = nombre; 
        }
        public int CI
        {
            get => this.ci; 
        }

        public string Nombre
        {
            get => this.nombre; 
        }

        public string Direcion
        {
            get => this.direcion; 
        }
    }
}
