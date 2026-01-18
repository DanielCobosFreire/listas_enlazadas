using System;

namespace Ejercicio2_InvertirLista
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

        public void Imprimir()
        {
            Nodo actual = cabeza;
            while (actual != null)
            {
                Console.Write(actual.Dato + " -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine("null");
        }

        // --- LÓGICA DEL EJERCICIO 2.2 ---
        public void InvertirLista()
        {
            Nodo anterior = null;
            Nodo actual = cabeza;
            Nodo siguiente = null;

            while (actual != null)
            {
                siguiente = actual.Siguiente; // Guardar referencia al resto de la lista
                actual.Siguiente = anterior;  // Invertir el puntero actual hacia atrás
                
                // Avanzar un paso
                anterior = actual;
                actual = siguiente;
            }
            // Actualizar la cabeza para que apunte al nuevo primer elemento
            cabeza = anterior;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada lista = new ListaEnlazada();
            
            // Llenamos la lista: 1 -> 2 -> 3 -> 4
            lista.Agregar(1);
            lista.Agregar(2);
            lista.Agregar(3);
            lista.Agregar(4);

            Console.WriteLine("--- EJERCICIO 2.2: INVERTIR ---");
            Console.WriteLine("Original:");
            lista.Imprimir();

            lista.InvertirLista();

            Console.WriteLine("Invertida:");
            lista.Imprimir();
            
            Console.ReadKey();
        }
    }
}