using System;
using System.Collections.Generic;
using System.Text;

namespace SeminarioBuenasPractica
{
    public enum tipoCargoAdministrativo
    {
        almacenero = 0, 
        energetico = 1 , 
        contador = 2,
        otro = 3
    }
    class TrabajadorAdministrativo:Trabajador
    {
        tipoCargoAdministrativo tipodecargo; 

        public TrabajadorAdministrativo (int  ci , string nombre , tipoCargoAdministrativo tipodecargo):base(ci , nombre)
        {
            this.tipodecargo = tipodecargo; 
        }

        public tipoCargoAdministrativo TipodeCargo
        {
            get => this.tipodecargo; 
        }
    }
}
