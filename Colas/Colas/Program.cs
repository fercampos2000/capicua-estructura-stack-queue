using Colas.clases.capicua;
using Colas.clases.ColaArreglo;
using Colas.clases.Pila_Lista;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas
{
    class Program
    {

        private static bool valido (String numero)
        {
            bool sw = true;
            int i = 0;
            while (sw && (i < numero.Length))
            {
                char c;
                c = numero[i++];
                sw = (c >= '0' && c <= '9');
            }
            return sw;
        }
        static void Main(string[] args)
        {

            //ejemplo 1
            //Queue qt = new Queue();
            //qt.Enqueue("hola");
            //qt.Enqueue("esta");
            //qt.Enqueue("es");
            //qt.Enqueue("una prueba");
            //qt.Enqueue("hola");

            //Console.WriteLine($"la Cola tiene {qt.Count} elementos");

            //Console.WriteLine($"Desencolando {qt.Dequeue()}");
            //Console.WriteLine($"La cola tiene  {qt.Count} elementos");
            //Console.ReadKey();
            //Console.WriteLine($"Desencolando {qt.Dequeue()}");
            //Console.WriteLine($"ahora la cola tiene {qt.Count} elementos");
            //Console.WriteLine($"Desencolando {qt.Dequeue()}");
            //Console.ReadKey();
            //Console.WriteLine($"Desencolando {qt.Dequeue()}");
            //Console.WriteLine($"Desencolando {qt.Dequeue()}");
            //Console.WriteLine($"Desencolando {qt.Dequeue()}");
            //Console.WriteLine($"Desencolando {qt.Dequeue()}");
            //fin ejemplo 1

            //programa capicua



            //bool capicua;
            //string numero;

            //PilaLista pila = new PilaLista();
            //ColaCircular circlula_Cola = new ColaCircular();

            //try
            //{
            //    capicua = false;
            //    while (!capicua)
            //    {
            //        do
            //        {
            //            Console.WriteLine("\nTeclea un nuero: ");
            //            numero = Console.ReadLine();

            //        } while (!valido(numero));

            //        for (int i = 0; i < numero.Length; i++)
            //        {
            //            Char c;
            //            c = numero[i];
            //            circlula_Cola.insertar(c);
            //            pila.insertar(c);
            //        }
            //        //se retira de la cola y pila para comparar
            //        do
            //        {
            //            Char d;
            //            d = (Char)circlula_Cola.quitar();
            //            capicua = d.Equals(pila.quitar());//compara la igualdad
            //        } while (capicua && !circlula_Cola.colaVacia());

            //            if (capicua)
            //            {
            //                Console.WriteLine($"Numero {numero} es capicua");

            //            }
            //            else
            //            {
            //                Console.WriteLine($"Numero {numero} no es capicua");
            //                Console.WriteLine("intente otro");
            //            }

            //        //vaciar estructuras
            //        circlula_Cola.borrarCola();
            //        pila.limpiarPila();

            //    }
            //}
            //catch (Exception errores)
            //{
            //    Console.WriteLine($"error es {errores.Message}");
            //}//programa capicua

            

            
                capicua_numeros campos = new capicua_numeros();
                campos.Campos();
                Console.ReadKey();
            
        }
    }
}
