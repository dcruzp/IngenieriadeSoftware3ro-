using System;
using System.Collections.Generic;
using System.Text;

namespace SeminarioBuenasPractica
{
    class Vicedecano:Profesor , ICargoDirectivo
    {
        public Vicedecano(int ci , string nombre , string titulo) : base(ci , nombre , titulo)
        {

        }

        public void dirigir()
        {
            Console.WriteLine($"El vicedecano {this.Nombre} esta dirigiendo ");
        }

        /// <summary>
        /// Esto es un ejemplo , no tiene que ver con lo que realmente pasa 
        /// es solo para diferenciar algunas actividades 
        /// </summary>
        public void PlanificarHorarios ()
        {
            Console.WriteLine($"EL vicedecano {this.Nombre} actualizo los horarios ");
        }

        public void Tomardesicion(string desicion)
        {
            Console.WriteLine($"El vicedecano {this.Nombre} tomo la decision: {desicion}");
        }
    }
}
