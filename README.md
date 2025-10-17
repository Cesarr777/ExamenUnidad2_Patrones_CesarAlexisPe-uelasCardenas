# ExamenUnidad2_Patrones_CesarAlexisPeñuelasCardenas

**Examen de Unidad 2 - Patrones de Diseño**  
Autor: **Cesar Alexis Peñuelas Cardenas**  
Número de Control: **22210335**  
Proyecto: **Reserva y Gestión de Equipos de Laboratorio**

---

## 🧠 Resumen
Este proyecto aplica los patrones de diseño **Object Pool** y **Singleton** en un entorno de laboratorio donde se administran equipos de cómputo.  
El objetivo es demostrar el uso eficiente de recursos y el control centralizado de las instancias dentro de una aplicación.


## COMO EJECUTARLO
- ABRA UNA TERMINAL
- VAYA A LA CARPETA DONDE GUARDO EL PROGRAMA
- CORRA EL COMANDO DOTNET RUN
- LA TERMINAL LE INDICARA LAS INSTRUCCIONES 
---

## ⚙️ Descripción del funcionamiento
El sistema permite **reservar y liberar equipos de laboratorio** de manera ordenada.  
- El **patrón Singleton** se utiliza en la clase `AdministradorEquipos`, asegurando que solo exista una instancia que controle todo el sistema.  
- El **patrón Object Pool** se implementa en `PoolEquipos`, que gestiona un conjunto de objetos `Equipos` reutilizables sin necesidad de crearlos y destruirlos constantemente.  
- Desde la consola, el usuario puede:
  1. Ver el estado actual de los equipos.  
  2. Ocupar un equipo indicando el nombre del usuario.  
  3. Liberar un equipo cuando ya no esté en uso.  

Este enfoque mejora la **eficiencia**, **organización** y **control** dentro de un entorno de simulación de laboratorio, mostrando la utilidad real de los patrones de diseño en el desarrollo de software.

---
