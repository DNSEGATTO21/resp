// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string aulaIntro = "Introdução às Coleções";
        string aulaModelando = "Modelando a Classe Aula";
        string aulaSets = "Trabalhando com Conjuntos";

        //Primeira forma de declarar um array     
        //      string[] aulas = new string[]{
        //        aulaIntro,
        //        aulaModelando,
        //        aulaSets
        //      };

        // Segunda forma de declarar um array

        string[] aulas = new string[3];
        aulas[0] = aulaIntro;
        aulas[1] = aulaModelando;
        aulas[2] = aulaSets;

        Console.WriteLine(aulas);

        Console.WriteLine("A aula modelando está no índice" + Array.IndexOf(aulas, aulaModelando));
        Console.WriteLine(Array.LastIndexOf(aulas, aulaModelando));

        Array.Reverse(aulas);
        Imprimir(aulas);

        

    }

    private static void Imprimir(string[] aulas)
    {
        for (int i = 0; i < aulas.Length; i++)
        {
            Console.WriteLine(aulas[i]);
        }
    }

    
}

