# Metodologías de Programación I

Ejercicios prácticos de la materia **Metodologías de Programación I**, desarrollados en **C# (.NET 9)**. El repositorio recorre, clase a clase, los principales **patrones de diseño GoF** (Gang of Four), aplicados sobre un mismo dominio que va creciendo a lo largo de la cursada: personas, alumnos, profesores y colecciones que los almacenan.

Cada clase es un proyecto independiente dentro de la solución y parte del código de la clase anterior, sumándole uno o dos patrones nuevos.

## 📚 Contenido por clase

| Clase | Temas / Patrones | Qué se implementa |
|:-----:|------------------|-------------------|
| **1** | Interfaces y polimorfismo | `Comparable` e `IColeccionable`, con colecciones `Pila`, `Cola` y `ColeccionMultiple` que almacenan `Numero`, `Persona` y `Alumno`. |
| **2** | **Iterator** · **Strategy** | Iteradores para cada colección y estrategias de comparación de alumnos (`PorNombre`, `PorDni`, `PorLegajo`, `PorPromedio`). Se agrega `Conjunto`. |
| **3** | **Factory Method** · **Observer** | Fábricas de comparables (`FabricaDeAlumnos`, `FabricaDeProfesores`, `FabricaDeNumeros`) y un profesor observado por sus alumnos. |
| **4** | **Adapter** · **Decorator** | `AlumnoAdapter` para integrar los alumnos con una biblioteca externa (`MDPI.cs`) y decoradores para mostrar la información del alumno (legajo, nota en letras, estado, recuadro). |
| **5** | **Proxy** · **Command** | `AlumnoProxy` que crea el alumno real solo cuando hace falta, y órdenes (`OrdenInicio`, `OrdenLlegaAlumno`, `OrdenAulaLlena`) ejecutadas sobre un `Aula`. |
| **6** | **Composite** · **Template Method** | `AlumnoCompuesto` para tratar grupos de alumnos como uno solo, y un juego de cartas (`JuegoDeGuerra`) construido sobre el esqueleto de `JuegoDeCartas`. |
| **7** | **Chain of Responsibility** · **Singleton** | Cadena de manejadores para obtener datos (aleatorios, teclado o archivo) y `LectorDeArchivos` implementado como Singleton. |

## 🗂️ Estructura del repositorio

```
Metodologias-de-Programacion-1/
├── Metodologias de Programacion.sln
├── Clase 1/
├── Clase 2/
│   ...
└── Clase 7/
    ├── Adapter/
    ├── Collections/      # Pila, Cola, Conjunto, ColeccionMultiple
    ├── Command/
    ├── Composite/
    ├── Decorator/
    ├── Factory/
    ├── Interfaces/
    ├── Iterator/
    ├── Models/           # Persona, Alumno, Profesor, Numero, Aula, lectores de datos
    ├── Proxy/
    ├── Strategy/
    ├── TemplateMethod/
    ├── MDPI.cs           # Biblioteca provista por la cátedra
    └── Program.cs
```

A partir de la clase 2, el código de cada proyecto está organizado en carpetas según el patrón que implementa, así que es fácil ubicar dónde está cada uno.

## ▶️ Cómo ejecutarlo

**Requisitos:** [.NET 9 SDK](https://dotnet.microsoft.com/download) (o Visual Studio 2022 / Rider).

Desde Visual Studio, abrí `Metodologias de Programacion.sln`, elegí la clase que quieras como proyecto de inicio y ejecutá.

Desde la terminal:

```bash
git clone https://github.com/aaronfuenzalida/Metodologias-de-Programacion-1.git
cd Metodologias-de-Programacion-1
dotnet run --project "Clase 7"
```

> ⚠️ **Nota (Clase 7):** `LectorDeArchivos` lee los datos desde un `datos.txt` con una ruta absoluta definida en `Models/LectorDeArchivos.cs`. Antes de ejecutar, cambiá esa ruta por la ubicación del archivo en tu equipo.

## 🧠 Patrones GoF cubiertos

| Creacionales | Estructurales | De comportamiento |
|--------------|---------------|-------------------|
| Factory Method | Adapter | Iterator |
| Singleton | Decorator | Strategy |
| | Proxy | Observer |
| | Composite | Command |
| | | Template Method |
| | | Chain of Responsibility |

## 👤 Autor

**Aaron Fuenzalida** — [@aaronfuenzalida](https://github.com/aaronfuenzalida)

Proyecto realizado con fines académicos.
