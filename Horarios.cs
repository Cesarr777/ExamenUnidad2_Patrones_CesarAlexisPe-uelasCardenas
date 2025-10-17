//Nombre: Cesar Alexis Peñuelas Cardenas
//NumControl: 22210335
//Examen Unidad 2 - Patrones de Diseño - Object Pool y Singleton
using System;

namespace EquiposObjectPool
{
    public enum EstadoEquipo
    {
        Disponible,
        Ocupado
    }

    public class Equipos
    {
        public int Numero { get; private set; }
        public EstadoEquipo Estado { get; private set; }
        public string ClienteActual { get; private set; }

        public Equipos(int numero)
        {
            Numero = numero;
            Estado = EstadoEquipo.Disponible;
            ClienteActual = "";
        }

        public void Ocupar(string cliente)
        {
            if (Estado == EstadoEquipo.Disponible)
            {
                Estado = EstadoEquipo.Ocupado;
                ClienteActual = cliente;
                Console.WriteLine("El equipo " + Numero + " fue ocupado por " + cliente + ".");
            }
            else
            {
                Console.WriteLine("No se puede ocupar el equipo " + Numero + " porque está ocupado.");
            }
        }

        public void Liberar()
        {
            if (Estado == EstadoEquipo.Ocupado)
            {
                Console.WriteLine("El equipo " + Numero + " fue liberado por " + ClienteActual + ".");
                Estado = EstadoEquipo.Disponible;
                ClienteActual = "";
            }
            else
            {
                Console.WriteLine("No se puede liberar el equipo " + Numero + " porque no está ocupado.");
            }
        }

        public override string ToString()
        {
            string textoCliente = ClienteActual == "" ? "" : " - Cliente: " + ClienteActual;
            return "Equipo " + " 8:00 AM " + Numero + " - Estado: " + Estado + textoCliente;
            
        }
    }
}