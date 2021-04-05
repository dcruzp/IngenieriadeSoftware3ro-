using System;
using System.Collections.Generic;
using System.Text;

namespace SeminarioBuenasPractica
{
    class Profesor:Trabajador
    {
        string titulo;

        public Profesor(int ci, string nombre, string titulo) : base(ci, nombre)
        {
            this.titulo = titulo; 
        }
        public string Titulo
        {
            get => titulo; 
        }
    }
}
