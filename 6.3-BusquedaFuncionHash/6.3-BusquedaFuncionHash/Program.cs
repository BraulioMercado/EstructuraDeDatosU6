using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _6._3_BusquedaFuncionHash
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncionHash op = new FuncionHash(); //llamamos a la clase
            op.Proceso(); //llamamos al metodo
            Console.ReadKey();
        }
    }
    class FuncionHash
    {
        public void Proceso()
        {
            //Creamos e insertamos datos Hashtable 
            Hashtable Hash = new Hashtable(); //usamos la funcion hashtable que ya viene en la biblioteca de collections 
            Hash.Add("A", "El señor raso padilla");
            Hash.Add("B", "Comida de los dioses"); //guardamos estos valores en la tabla

            Console.WriteLine("Cantidad de palabras en el diccionario: {0}", Hash.Count); //mostramos la cantidad de palabras
            try
            {
                Console.Write("Ingrese valor que desea saber su significado: (otaku) (tacos): "); //menu 
                string opc = Console.ReadLine();

                switch (opc)
                {
                    case "otaku":
                        Console.WriteLine("El significado de otaku es: {0}", Hash["A"]); //se llama a la clave a en hash
                        break;
                    case "tacos":
                        Console.WriteLine("El significado de tacos es: {0}", Hash["B"]); //se llama a la clave b en hash
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No existe esa palabra!"); //excepcion si mete una palabra que no es
            }
        }
    }
}
