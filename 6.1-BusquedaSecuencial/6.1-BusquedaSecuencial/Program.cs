using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1_BusquedaSecuencial
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodo1 op = new Metodo1(); //lamamos al ejemplo 1
            Metodo2 op2 = new Metodo2(); //llamamos al ejemplo1
            Console.WriteLine("Ejemplo1");
            op.Imprimir(); //imprimir arreglo 
            Console.Write("\n\nElemento a buscar: ");
            int num = int.Parse(Console.ReadLine());
            op.Proceso(num); //mandamos elemento que queremos bscar
            Console.WriteLine("\n\nEjemplo2");
            op2.Imprimir(); //imprimir arreglo 
            Console.Write("\n\nElemento a buscar: ");
            int num2 = int.Parse(Console.ReadLine());
            op2.Proceso2(num2); //mandamos elemento que queremos bscar
            Console.ReadKey();
        }
    }
    class Metodo1
    {
        int[] vector = new int[] { 5, 2, 3, 6, 77, 88, 99, 3, 5 }; //arreglo con los datos a utilizar
        public void Proceso(int num)
        {
            int i = 0, pos = 0;
            bool found = false; //condicion de si se encuentra 

            while (!(found) && i < 10) //si es diferente y es menor de 10
            {
                if (num == vector[i])
                {
                    found = true;
                    pos = i;
                }
                i = i + 1;
            }
            if (found) //if si se encuentra el valor
            {
                Console.Write("\nEl elemento {0} esta en la posicion: {1}", num, pos + 1); 

            }
        }
        public void Imprimir() //foreach para imprimir el vector
        {
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write(vector[f] + "  ");
            }
        }
    }
    class Metodo2
    {
        int[] vector = new int[] { 1, 4, 3, 6, 623, 68, 90, 7, 6 }; //arreglo con los datos
        public void Proceso2(int num2)
        {
            var item2 = vector.Where(con => con == num2); //Lambda para buscar elemento
            foreach (var item in item2) //Se despliega el elemento
            {
                Console.WriteLine("Se encontro el elemento" + item.ToString());
            }
            Console.ReadKey();
        }
        public void Imprimir()
        {
            for (int f = 0; f < vector.Length; f++) //foreach para imprimir el vector
            {
                Console.Write(vector[f] + "  ");
            }
        }
    }
}
