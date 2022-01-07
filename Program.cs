//-------Objetivo deste conteudo é demonstrar o----------
//-------uso de: variavel de classe-----------------------
//-------by Rodolfo C. Nascimento-------------------------
//-------email: espanharodofera@gmail.com-----------------
//-------linkedin: rodolfo-correia-do-nascimento-b96292189
using System;
using Variaveis_de_Classe.Models;

namespace Variaveis_de_Classe_Static_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            NaveEspacial nave1 = new NaveEspacial("R1", 5, "A primeira e ultima nave");
            NaveEspacial nave2 = new NaveEspacial("R2", 6, "Second Machine");
            NaveEspacial nave3 = new NaveEspacial("R3", 8, "6 machine");

            Console.WriteLine($"Nave1 name: {nave1.name}\n" + "Description: " + nave1.description);
            Console.WriteLine($"Nave2 name: {nave2.name}\n" + "Description: " + nave2.description);
            Console.WriteLine($"Nave3 name: {nave3.name}\n" + "Description: " + nave3.description);

            // change attack points
            nave1.SetAttackPoints(50);
            nave1.ShowAtkPoints();

            // usar a variavel de classe, afeta todas a variaveis dos objetos da classe NaveEspacial
            NaveEspacial.resistencia = 15;
            System.Console.WriteLine($"Atributo resistência dos objetos da classe NaveEspacial: {NaveEspacial.resistencia}");

            // uso da variavel de classe em uma condição
            NaveEspacial.resistencia = 10;

            if (NaveEspacial.resistencia == 15)
            {
                System.Console.WriteLine("Não houve modificação na variavel de classe.");
            }else
            {
                System.Console.WriteLine("A variavel de classe 'resistencia' foi modificada e todos os objetos sofrerão mudanças!");
            }

            System.Console.WriteLine($"Atributo resistência dos objetos da classe NaveEspacial apos modificar: {NaveEspacial.resistencia}");
        }
    }
}
