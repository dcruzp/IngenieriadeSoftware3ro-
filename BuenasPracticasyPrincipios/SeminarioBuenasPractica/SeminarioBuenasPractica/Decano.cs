using System;
using System.Collections.Generic;
using System.Text;

namespace SeminarioBuenasPractica
{
    class Decano:Profesor , ICargoDirectivo
    {
        string facultadasignada; 
        public Decano(int ci , string nombre , string titulo , string facultadaltanto) : base(ci , nombre ,titulo)
        {
            this.facultadasignada = facultadaltanto;
        }

        public void dirigir()
        {
            Console.WriteLine($"El decano {this.Nombre} esta dirigiendo ");
        }

        public void Reunirse()
        {
            Console.WriteLine($"El decano {this.Nombre} se reunió con el claustro");
        }

        public void Tomardesicion(string desicion)
        {
            Console.WriteLine($"El decano {this.Nombre} tomo la decision: {desicion}");
        }
                
    }
}
