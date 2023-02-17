using System;

namespace Desafio01Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************DESAFIO 01 - BALTA.IO**************");
            Console.WriteLine("");
            Console.WriteLine("Digite um texto:");
            var texto = Console.ReadLine();
            var caracteres = ContarCaracteresTexto(texto);
            var palavras = ContarPalavrasTexto(texto);
            Console.WriteLine(String.Format("{0} caracteres, {1} palavras", caracteres, palavras));
            Console.ReadKey();
        }

        private static int ContarPalavrasTexto(string texto)
        {
            var textoSeparado = texto.Split(' ');
            return textoSeparado.Length;
        }

        private static int ContarCaracteresTexto(string texto)
        {
            int soma = 0;
            var textoSeparado = texto.Split(' ');
            foreach (var item in textoSeparado)
            {
                soma += item.Length;
            }
            return soma;
        }
    }
}