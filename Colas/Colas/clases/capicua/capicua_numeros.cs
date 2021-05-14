using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas.clases.capicua
{
    class capicua_numeros
    {
        private static bool valido(String numero)
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

        public void Campos()
        {
            bool capicua;
            string numero;
            Queue qt = new Queue();
            Stack tq = new Stack();

            capicua = false;
            while (!capicua)
            {


                do
                {
                    Console.WriteLine("INGRESE UN NUMERO ");
                    numero = Console.ReadLine();

                } while (!valido(numero));

                for (int i = 0; i < numero.Length; i++)
                {
                    Char c;
                    c = numero[i];
                    qt.Enqueue(c);
                    tq.Push(c);

                }
                int pausa = 0;



                do
                {
                    Char d;
                    d = (char)qt.Dequeue();
                    capicua = d.Equals(tq.Peek());
                    tq.Pop();
                } while (capicua && qt.Count > 0);

                if (capicua)
                {
                    Console.WriteLine($"Numero {numero} es capicua");
                }
                else
                {
                    Console.WriteLine("el numero no es Capicua");
                }

            }
            qt.Clear();
            tq.Clear();
        }
    }
}
