using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YO SOY UN PROGRAMADOR Y EXPERTO EN REDES EXCELENTE Y RECONOCIDO");
            /*Introducir una cadena de caracteres e indicar si es un palindromo. una palabra palindroma es aquella que se lee igual adelante que atras. por ejemplo: ojo,rayar,rapar,solos,oso,rotomotor y sedes.*/

            string palabraUsuario, palabraInvertida = "";
            //Pedimos palabra
            Console.Write("Ingresa una palabra y veamos si es un palindromo:    ");
            palabraUsuario = Console.ReadLine();

            foreach(char letra in palabraUsuario)
            {
                palabraInvertida = letra + palabraInvertida;
            }
            if(palabraUsuario.Equals(palabraInvertida, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"\"{palabraUsuario}\" Es una palabra palindroma");
            }
            else
            {
                Console.WriteLine($"\"{palabraUsuario}\" No es una palabra palindroma");
            }






        }
    }
}
