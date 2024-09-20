using System;

class Program
{
    // Clase Nodo para las listas
    public class Node
    {
        public int data;
        public Node next;
        public Node prev;  // Solo se usa en listas doblemente enlazadas

        public Node(int data)
        {
            this.data = data;
            this.next = null;
            this.prev = null;
        }
    }

    static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Menú Principal:");
            Console.WriteLine("1. Lista Enlazada");
            Console.WriteLine("2. Lista Doble Enlazada");
            Console.WriteLine("3. Lista Enlazada Circular");
            Console.WriteLine("4. Salir");
            Console.Write("\nSeleccione una opción (1-4): ");
            
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    LinkedListConceptAndExample();
                    break;
                case "2":
                    DoublyLinkedListConceptAndExample();
                    break;
                case "3":
                    CircularLinkedListConceptAndExample();
                    break;
                case "4":
                    exit = true;
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }

            if (!exit)
            {
                Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
                Console.ReadKey();
            }
        }
    }

    // Concepto y ejemplo de Lista Enlazada
    static void LinkedListConceptAndExample()
    {
        Console.Clear();
        Console.WriteLine("Lista Enlazada (Linked List):");
        Console.WriteLine("Una lista enlazada es una estructura de datos lineal compuesta por nodos, donde cada nodo contiene un valor y un puntero al siguiente nodo.");
        Console.WriteLine("Ejemplo de Lista Enlazada:");

        // Crear lista enlazada
        Node head = new Node(10);
        head.next = new Node(20);
        head.next.next = new Node(30);
        head.next.next.next = new Node(40);

        // Mostrar los elementos de la lista enlazada
        Node current = head;
        while (current != null)
        {
            Console.Write(current.data + " -> ");
            current = current.next;
        }
        Console.WriteLine("null");
    }

    // Concepto y ejemplo de Lista Doble Enlazada
    static void DoublyLinkedListConceptAndExample()
    {
        Console.Clear();
        Console.WriteLine("Lista Doble Enlazada (Doubly Linked List):");
        Console.WriteLine("Una lista doble enlazada es una lista en la que cada nodo tiene dos punteros: uno al siguiente nodo y otro al nodo anterior, permitiendo la navegación en ambas direcciones.");
        Console.WriteLine("Ejemplo de Lista Doble Enlazada:");

        // Crear lista doble enlazada
        Node head = new Node(100);
        Node second = new Node(200);
        Node third = new Node(300);
        Node fourth = new Node(400);

        // Configurar los punteros
        head.next = second;
        second.prev = head;
        second.next = third;
        third.prev = second;
        third.next = fourth;
        fourth.prev = third;

        // Mostrar los elementos de la lista doblemente enlazada
        Node current = head;
        while (current != null)
        {
            Console.Write(current.data + " <-> ");
            current = current.next;
        }
        Console.WriteLine("null");
    }

    // Concepto y ejemplo de Lista Enlazada Circular
    static void CircularLinkedListConceptAndExample()
    {
        Console.Clear();
        Console.WriteLine("Lista Enlazada Circular (Circular Linked List):");
        Console.WriteLine("Una lista enlazada circular es una lista en la que el último nodo apunta al primer nodo, formando un círculo.");
        Console.WriteLine("Ejemplo de Lista Enlazada Circular:");

        // Crear lista enlazada circular
        Node head = new Node(5);
        Node second = new Node(15);
        Node third = new Node(25);
        Node fourth = new Node(35);

        // Configurar los punteros
        head.next = second;
        second.next = third;
        third.next = fourth;
        fourth.next = head;  // Último nodo apunta al primer nodo

        // Mostrar los elementos de la lista enlazada circular
        Node current = head;
        for (int i = 0; i < 8; i++)  // Mostrar algunos elementos para evitar ciclo infinito
        {
            Console.Write(current.data + " -> ");
            current = current.next;
        }
        Console.WriteLine("(vuelve al principio)");
    }
}