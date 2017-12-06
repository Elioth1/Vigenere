using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cifrado_de_Vigenere
{
    class Program
    {

        static string Alfa = ("abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZÁÉÍÓÚáéíóúäëïöüÄËÏÖÜ1234567890");

        static void Main(string[] args)
        {
            
            char opcion;
            Console.Write("***Elija numéricamente xD***\n\n ");
            Console.Write("Opcion 1\n");
            Console.WriteLine("¡Encripar y lo que dejó de tarea!\n");
            Console.Write("Oooooooh! puede elegir...");
            Console.Write("La Opcion 2\n");
            Console.WriteLine(" Algo más chido 7u7\n");
            opcion = Console.ReadKey().KeyChar;
            
            switch (opcion)
            {
                case '1':
                    {
                        Console.Clear();
                        cifrar();

                        break;
                    }

                case '2':
                    {
                        Console.Clear();

                        Console.SetCursorPosition(20, 11);
                        Console.Write("Que trull");
                        Console.SetCursorPosition(20, 12);
                        Console.Write("aquí no hay nada profe xdxdxd");
                        break;
                    }
               /* case '3':
                    {
                        Console.Clear();
                        descifrar();
                        break;
                    }*/


            }
            /* static string cifrar(string Texto, int desplazamiento)
             {
                 string cifrado = "";

                 int posTexto, posClave;

                 if(tex)

                 return cifrado;
             }          */
            Console.ReadKey();

        }



        public static void cifrar()
        {
            string encriptar = "";
            Console.Write("Que aburrido 7n7\n");
                        
            Console.SetCursorPosition(5,5);
            Console.Write("abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZÁÉÍÓÚáéíóúäëïöüÄËÏÖÜ1234567890\n\n\n\n\n");
            Console.WriteLine("Ingrése una palabra: ");
            string texto = Console.ReadLine();

            Console.WriteLine("Ingrése una clave: ");
            string clave = Console.ReadLine();

            

            int Tamales = texto.Length;
            int Atole = clave.Length;

            int posTexto, posClave;

            if (Tamales > Atole)
            {
                for (int i = 0; i < texto.Length; i++)
                {
                    clave += clave[i];
                    Console.Write("");
                }

                for (int i = 0; i < texto.Length; i++)
                {
                    posTexto = getPosABC(texto[i]);
                    posClave = getPosABC(clave[i]);
                    encriptar += Alfa[(posTexto + posClave) % 84 + 1];
                }
            }
            else
            {
                for (int i = 0; i < texto.Length; i++)
                {
                    posTexto = getPosABC(texto[i]);
                    posClave = getPosABC(clave[i]);
                    encriptar += Alfa[(posTexto + posClave) % 84 + 1];
                }
            }

            Console.Write("Texto encripado: ");
            for (int i = 0; i < texto.Length; i++)
            {
                Console.Write($"{encriptar[i]}");
            }

        }


       /* public static void descifrar()
        {
            string desencriptar = "";
            Console.Write("Que aburrido 7n7\n");
            Console.WriteLine("Ingrése una palabra: ");
            string texto = Console.ReadLine();

            Console.WriteLine("Ingrése una clave: ");
            string clave = Console.ReadLine();

            int Tamales = texto.Length;
            int Atole = clave.Length;
            int Todo = Tamales - Atole;
            int posTexto, posClave;
            
            if (Tamales > Atole)
            {
                for (int i = 0; i < texto.Length; i++)
                {
                    clave += clave[i];
                    Console.Write("");
                }

                for (int i = 0; i < texto.Length; i++)
                {
                    posTexto = getPosABC(texto[i]);
                    posClave = getPosABC(clave[i]);
                    
                    desencriptar += Alfa[(posTexto + posClave) % 84 - Todo];
                }
            }
            else
            {
                for (int i = 0; i < texto.Length; i++)
                {
                    posTexto = getPosABC(texto[i]);
                    posClave = getPosABC(clave[i]);
                    
                    desencriptar += Alfa[(posTexto - posClave) % 84 - Todo];
                }
            }
            
            Console.Write("Texto encripado: ");
            for (int i = 0; i < texto.Length; i++)
            {
                Console.Write($"{desencriptar[i]}");
            }

        }*/


        static int getPosABC(Char caracter)
        {
            for (int i = 0; i < Alfa.Length; i++)
            {
                if (caracter == Alfa[i])
                {
                    return i;
                }
            }
            return -1;
        }             
        
    }
}
