using System;

namespace Ejercicio1_ContarElementos
{
    // Definición del Nodo
    public class Nodo
    {
        public int Dato;
        public Nodo Siguiente;

        public Nodo(int dato)
        {
            this.Dato = dato;
            this.Siguiente = null;
        }
    }

    public class ListaEnlazada
    {
        private Nodo cabeza;

        public ListaEnlazada()
        {
            cabeza = null;
        }

        public void Agregar(int dato)
        {
            Nodo nuevo = new Nodo(dato);
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }
        }

        // --- LÓGICA DEL EJERCICIO 1.1 ---
        public int ContarElementos()
        {
            int contador = 0;
            Nodo actual = cabeza;

            // Recorremos la lista contando cada salto
            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }
            return contador;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada lista = new ListaEnlazada();
            
            // Agregamos 3 elementos de prueba
            lista.Agregar(5);
            lista.Agregar(10);
            lista.Agregar(15);

            Console.WriteLine("--- EJERCICIO 1.1: CONTAR ---");
            Console.WriteLine("Calculando longitud de la lista...");
            
            int total = lista.ContarElementos();
            
            Console.WriteLine($"Total de elementos encontrados: {total}");
            Console.ReadKey();
        }
    }
}