using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1_BusquedaBinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu(); //llamamos al menu
            Console.ReadKey();
        }
        static void Menu() //metodo menu
        {
            Console.Write("Ingrese 1=ejemplo1 o 2=ejemplo2: ");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Ejemplo1 op = new Ejemplo1(); //llamamos a la clase del ejmeplo1
                    op.Ingresar();
                    break;
                case 2:
                    Ejemplo2 op2 = new Ejemplo2(); //llamamos a la clase del ejmeplo2
                    op2.Ingresar();
                    break;
            }
        }
    }
    class Ejemplo1
    {
        public void Ingresar()
        {
            int[] listaprueba = { 0, 1, 2, 8, 13, 17, 19, 32, 42, };
            int item;
            Console.Write("Ingrese item a buscar: ");
            item = int.Parse(Console.ReadLine());

            Console.WriteLine(Proceso(listaprueba, item)); //se imprime el proceso
        }
        public bool Proceso(int[] listaprueba, int item) //metodo tipo bool que recibe 2 parametros
        {
            int ultimo;
            int primero = 0;
            int puntoMedio; //declaracion de variables
            ultimo = listaprueba.Length - 1; //ultimo es igual a la longitud de arreglo -1
            bool encontrado = false;

            while (primero <= ultimo) //se repite si primero es menor o igual al ultimo
            {
                puntoMedio = (primero + ultimo); //punto medio es igual al primero + ultimo
                if (listaprueba[puntoMedio] == item) //si el punto medio en la lista es igual al item
                {
                    Console.WriteLine("Valor encontrado");
                    encontrado = true;
                    break; //se detiene el while
                }
                else
                {
                    if (item < listaprueba[puntoMedio]) //else si el item es menor al punto medio
                    {
                        ultimo = puntoMedio - 1; //se elimina toda la mitad mayor
                    }
                    else
                    {
                        primero = puntoMedio + 1; //si es mayor, se elimina la parte menor
                    }
                }
            }
            return encontrado; //se regresa el bool
        }
    }
    class Ejemplo2
    {
        public void Ingresar()
        {
            int[] listaprueba = { 0, 1, 2, 8, 13, 17, 19, 32, 42, };
            int item;
            Console.Write("Ingrese item a buscar: ");
            item = int.Parse(Console.ReadLine());

            Console.WriteLine(Proceso2(listaprueba, item)); //se imprime el proceso
        }

        public bool Proceso2(int[] listaprueba, int item)
        {
            int inicio, final, medio, N; //declaramos variables
            bool encontrado = false;
            N = listaprueba.Length;

            for (inicio = 0, final = N - 1; inicio <= final;) //for normal y corriente
            {
                if (inicio == final) // si el array sólo tiene un elemento:
                {
                    if (listaprueba[inicio] == item) //es igual al valor buscado
                    {
                        Console.WriteLine("Valor encontrado");
                        encontrado = true;
                    }
                    else // si no es el valor:
                    {
                        Console.WriteLine("No encontrado");
                    }
                    break; // Salir del bucle.
                }
                medio = (inicio + final) / 2; // Divide el array en dos.
                if (listaprueba[medio] == item) // Si coincide
                {
                    Console.WriteLine("Valor encontrado");
                    encontrado = true;
                    break;
                }
                else
                {
                    if (listaprueba[medio] > item) // si es menor
                    {
                        final = medio - 1; //eliminamos
                    }
                    else // y si es mayor:
                    {
                        inicio = medio + 1; //elimonamos
                    }

                }
            }
            return encontrado;
        }
    }
}
