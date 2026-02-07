using System;
using System.Collections.Generic;
using System.Text;


namespace Practica_2
{
        /// <summary>
        /// Clase genérica que maneja una lista de números
        /// </summary>
        /// <typeparam name="T">Tipo numérico</typeparam>
        public class ListaNumeros<T>
        {
            private List<T> numeros = new List<T>();

            public void AgregarNumero(T numero)
            {
                numeros.Add(numero);
            }

            public T EjecutarOperacion(OperacionMatematica<T> operacion)
            {
                if (numeros.Count < 2)
                    throw new InvalidOperationException(
                        "La lista debe contener al menos dos números.");

                T resultado = numeros[0];

                for (int i = 1; i < numeros.Count; i++)
                {
                    resultado = operacion(resultado, numeros[i]);
                }

                return resultado;
            }
        }
}
