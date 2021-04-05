using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq; 

namespace SeminarioBuenasPractica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Algunos datos de ejemplo 

            Decano decano = new Decano(1234567890, "Pedro Cruz", "Lic. Ciencias de la computacion ", "Matematica");
            Vicedecano vicedecanaAlicia = new Vicedecano(0987654321, "Alicia Perez ", "Lic. Matematica");
            TrabajadorAdministrativo trabajadorAdministrativoPepe = new TrabajadorAdministrativo(345436324, "Pepe", tipoCargoAdministrativo.almacenero);
            TrabajadorAdministrativo trabajadorAdministrativoAlfonso = new TrabajadorAdministrativo(345129324, "Alfonso", tipoCargoAdministrativo.contador);
            Vicedecano vicedecanaIndira = new Vicedecano(0987654321, "Indira Sanchez ", "Lic. Contabilidad");



            List<Persona> personas = new List<Persona>(){ decano, vicedecanaAlicia , trabajadorAdministrativoPepe , trabajadorAdministrativoAlfonso , vicedecanaIndira};
            foreach (var item in personas)
            {
                Console.WriteLine($"CI : {item.CI}      Nombre : {item.Nombre}");
            }

            Console.WriteLine("\n");
            List<ICargoDirectivo> cargoDirectivos = new List<ICargoDirectivo>();
            foreach (var item in personas.Where(x => x is ICargoDirectivo))
            {
                Console.WriteLine($"CI : {item.CI}      Nombre : {item.Nombre}");

                /// Esto de error 
                //ICargoDirectivo cargo = item;  


                ICargoDirectivo cargoDirectivo = item as ICargoDirectivo;
                cargoDirectivos.Add(cargoDirectivo); 
            }

            Console.WriteLine("\n");
            ICargoDirectivo cargoDirectivo1 = cargoDirectivos.FirstOrDefault();
            cargoDirectivo1.dirigir(); 
        }
    }
}
