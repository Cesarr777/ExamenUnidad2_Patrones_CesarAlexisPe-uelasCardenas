//Nombre: Cesar Alexis Peñuelas Cardenas
//NumControl: 22210335
//Examen Unidad 2 - Patrones de Diseño - Object Pool y Singleton
using System;

namespace EquiposObjectPool
{
    public sealed class AdministradorEquipos
    {
        private static readonly Lazy<AdministradorEquipos> _instancia =
            new(() => new AdministradorEquipos());

        public static AdministradorEquipos Instancia => _instancia.Value;

        private readonly object _sync = new();
        private PoolEquipos? _pool;

        private AdministradorEquipos() { }

        public void Inicializar(int capacidad)
        {
            lock (_sync)
            {
                if (_pool != null)
                    throw new InvalidOperationException("AdministradorEquipos ya fue inicializado.");
                
                _pool = new PoolEquipos(capacidad);
            }
        }

        public PoolEquipos Pool
        {
            get
            {
                lock (_sync)
                {
                    if (_pool == null)
                        throw new InvalidOperationException("Llama a Inicializar(capacidad) antes de usar el pool.");
                    return _pool;
                }
            }
        }
    }
}
