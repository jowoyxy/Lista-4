/*-------------------------------------------------------------------
Questão 2: Informações do Personagem
* Contextualização:Em combates, o jogador pode realizar ataques críticos que causam
danos adicionais. O dano causado depende do ataque base, do multiplicador crítico e
da arma utilizada.
• Comando: Crie um programa que receba o valor do ataque base, o multiplicador crítico
(1.5x, 2x, 3x) e o tipo de arma (Espada, Arco, Cajado). Crie uma função que calcule o
dano crítico da seguinte forma:
• Espada: +10 pontos ao dano total.
• Arco: +5 pontos ao dano total.
• Cajado: +15 pontos ao dano total.
• Exiba o dano total causado pelo ataque crítico.
@Lista: 04 
@Autor: Joanna Nobre
@Data: 03/09/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor do ataque base: ");
        int ataqueBase = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o multiplicador crítico (1.5x, 2x, 3x): ");
        double multiplicadorCritico = double.Parse(Console.ReadLine().TrimEnd('x'));

        Console.WriteLine("Digite o tipo de arma (Espada, Arco, Cajado): ");
        string tipoDeArma = Console.ReadLine().ToLower();

        int danoCritico = CalcularDanoCritico(ataqueBase, multiplicadorCritico, tipoDeArma);

        Console.WriteLine($"Dano total causado pelo ataque crítico: {danoCritico} pontos");
    }

    static int CalcularDanoCritico(int ataqueBase, double multiplicadorCritico, string tipoDeArma)
    {
        int bonusArma = 0;

        switch (tipoDeArma)
        {
            case "espada":
                bonusArma = 10;
                break;
            case "arco":
                bonusArma = 5;
                break;
            case "cajado":
                bonusArma = 15;
                break;
            default:
                Console.WriteLine("Tipo de arma inválido");
                return 0;
        }

        int danoTotal = (int)(ataqueBase * multiplicadorCritico) + bonusArma;
        return danoTotal;
    }
}
