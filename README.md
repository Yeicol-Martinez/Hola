# Aplicación Matemática Genérica en C#

## Descripción general
Esta aplicación de consola en **C#** permite al usuario trabajar con una **lista genérica de números** y realizar operaciones matemáticas básicas como **suma, resta, multiplicación y división**.

El proyecto fue desarrollado como parte de la **Tarea Práctica #2** del Instituto Tecnológico de las Américas (ITLA), aplicando los conceptos de **Genéricos, Delegados y Control de Excepciones**.

---

## Objetivo del proyecto
- Aplicar **genéricos** para manejar distintos tipos de datos numéricos.
- Utilizar **delegados** para representar operaciones matemáticas.
- Implementar **control de excepciones** para manejar errores comunes.
- Diseñar una **interfaz simple en consola**.
- Mantener un código organizado y modular.

---

## 📁 Estructura del proyecto
AppMatematicaGenerica
│
├── Program.cs
├── ListaNumeros.cs
├── Operaciones.cs
└── OperacionMatematica.cs

### Descripción de los archivos

- **Program.cs**  
  Contiene el menú principal y la interacción con el usuario.

- **ListaNumeros.cs**  
  Clase genérica que administra la lista de números y ejecuta las operaciones matemáticas.

- **Operaciones.cs**  
  Clase estática que implementa las operaciones matemáticas (suma, resta, multiplicación y división).

- **OperacionMatematica.cs**  
  Contiene el delegado que representa las operaciones matemáticas.

---

## Uso de Genéricos
La clase `ListaNumeros<T>` utiliza genéricos para permitir el manejo de distintos tipos numéricos como `int`, `double` y `decimal` sin necesidad de modificar el código.

Esto hace que la aplicación sea reutilizable y flexible.

---

## Uso de Delegados
Se define el siguiente delegado:

public delegate T OperacionMatematica<T>(T a, T b);

Este delegado permite pasar las operaciones matemáticas como parámetros, facilitando la ejecución dinámica de cada operación sobre la lista de números.


## Control de Excepciones
El programa maneja las siguientes excepciones:

FormatException
Se produce cuando el usuario ingresa un valor no numérico.

InvalidOperationException
Se lanza cuando la lista contiene menos de dos números.

DivideByZeroException
Se produce cuando se intenta dividir entre cero.

Cada excepción es manejada mostrando un mensaje claro al usuario.


## Interfaz de Usuario
La aplicación presenta un menú en consola que permite al usuario:

Seleccionar el tipo de dato numérico.

Agregar números a la lista.

Elegir la operación matemática a realizar.

Salir del programa.


## Instrucciones para ejecutar el programa
Abrir el proyecto en Visual Studio

Verificar que sea un proyecto de tipo Consola

Ejecutar el programa con Ctrl + F5

Seguir las instrucciones mostradas en pantalla


## Tecnologías utilizadas
Lenguaje: C#

Plataforma: .NET

Tipo de aplicación: Consola

## Autor
Yeicol Antonio Martinez Perez
Instituto Tecnológico de las Américas (ITLA)

## Nota final
Este proyecto fue desarrollado con fines académicos y cumple con todos los requerimientos establecidos en la Tarea Práctica #2.
