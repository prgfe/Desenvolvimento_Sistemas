﻿namespace Personagem_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem tony = new Personagem();
            tony.armadura = "Bleeding Edge";

            Console.WriteLine(tony.nome);
            Console.WriteLine(tony.armadura);
            Console.WriteLine(tony.Atacar());
        }
    }
}