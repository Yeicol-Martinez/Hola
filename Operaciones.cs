using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_2
{
        public static class Operaciones
        {
            public static T Sumar<T>(T a, T b) => (dynamic)a + b;

            public static T Restar<T>(T a, T b) => (dynamic)a - b;

            public static T Multiplicar<T>(T a, T b) => (dynamic)a * b;

            public static T Dividir<T>(T a, T b)
            {
                if (b.Equals(default(T)))
                    throw new DivideByZeroException();

                return (dynamic) a / b;
            }
        }
}
