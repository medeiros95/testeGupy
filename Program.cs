﻿using System;

namespace testeGupy2 {
    internal class Program {
        static void Main(string[] args) {

            //questao 2

            int x = 0, y = 1, fibonacci, j;

            Console.WriteLine("Digite um numero de 0 a 99");
            j = int.Parse(Console.ReadLine());


            for (int i = 0; i < 30; i++) {

                fibonacci = x + y;

                x = y;
                y = fibonacci;
                
                if (j == fibonacci) {
                    Console.WriteLine("O numero digitado está na sequencia");
                }
            }

            // questão 3
            a) 9
            b) 128
            c) 49
            d) 136
            e) 13
            f) 200


            // questão 4

            "Os dois estarão na mesma distancia, pois quando se cruzam eles se encontram no mesmo ponto da rodovia."


            //resposta 5

            Console.WriteLine("digite um texto:");
            string original = Console.ReadLine();
            string reversed = Reverse(original);
            Console.WriteLine(reversed);
        }

        static string Reverse(string text) {
            char[] charArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = charArray.Length - 1; i >= 0; i--) {
                reverse += charArray[i];
            }
            return reverse;
        }
    }
}
