//Nombre: Cesar Alexis Peñuelas Cardenas
//NumControl: 22210335
//Examen Unidad 2 - Patrones de Diseño - Object Pool y Singletonusing System;
using System.Collections.Generic;

namespace EquiposObjectPool
{
    public class PoolEquipos
    {
        private List<Equipos> EquiposDisponibles;

        public PoolEquipos(int cantidad)
        {
            EquiposDisponibles = new List<Equipos>();
            for (int i = 1; i <= cantidad; i++)
            {
                EquiposDisponibles.Add(new Equipos(i));
            }
        }

        public Equipos? BuscarEquipo(int numero)
        {
            return EquiposDisponibles.Find(e => e.Numero == numero);
        }

        public void MostrarEstatus()
        {
            Console.WriteLine("\n----- ESTATUS DE EQUIPOS -----");
            foreach (var e in EquiposDisponibles)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("-----------------------------------\n");
        }
    }
}
