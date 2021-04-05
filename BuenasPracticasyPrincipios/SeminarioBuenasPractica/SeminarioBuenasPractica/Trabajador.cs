using System;
using System.Collections.Generic;
using System.Text;

namespace SeminarioBuenasPractica
{
    public enum SectorInstitucional
    {
        educacion = 0, 
        salud = 1 , 
        obrera = 2, 
        campesina =3 ,
        otra =4 
    }
    abstract class Trabajador:Persona 
    {
        SectorInstitucional sectorinstitucional;
        int salario;

        private int salariominimo = 2400; 
        public Trabajador(int ci , string nombre ):base(ci , nombre)
        {
            this.salario = salariominimo; 
        }

        public Trabajador(int ci, string nombre , int salario) : base(ci, nombre)
        {
            if (salario < salariominimo) throw new Exception($"el salario no puede ser menor que  {this.salariominimo}"); 
            this.salario = salario;
        }

        public SectorInstitucional Sector
        {
            get => this.sectorinstitucional; 
        }

        public int Salario
        {
            get => this.salario;
        }
    }
}
