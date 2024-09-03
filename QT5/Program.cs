/*-------------------------------------------------------------------
Questão 5: Informações do Personagem
* Contextualização: No jogo, o jogador pode usar habilidades especiais durante a
batalha. A escolha da habilidade depende da quantidade de mana disponível, do tipo de
inimigo e da distância do alvo.
• Comando: Crie um programa que receba a quantidade de mana, o tipo de inimigo
(Normal, Forte, Boss) e a distância do alvo (em metros). Crie uma função que sugira
qual habilidade usar com base nos seguintes critérios:
• Mana maior que 50: Use Habilidade Poderosa.
• Inimigo Forte ou Boss: +10 mana necessária.
• Distância menor que 10 metros: Reduz a mana necessária em 5.
• Exiba a habilidade sugerida.
@Lista: 04 
@Autor: Joanna Nobre
@Data: 03/09/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a quantidade de mana disponível: ");
        int mana = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o tipo de inimigo (Normal, Forte, Boss): ");
        string tipoInimigo = Console.ReadLine().ToLower();

        Console.WriteLine("Digite a distância até o alvo (em metros): ");
        int distancia = int.Parse(Console.ReadLine());

        string habilidadeSugerida = SugerirHabilidade(mana, tipoInimigo, distancia);

        Console.WriteLine($"Habilidade sugerida: {habilidadeSugerida}");
    }

    static string SugerirHabilidade(int mana, string tipoInimigo, int distancia)
    {
        if (mana > 50)
        {
            return "Use Habilidade Suprema";
        }

        if (tipoInimigo == "forte" || tipoInimigo == "boss")
        {
            mana += 10;
        }

        if (distancia < 10)
        {
            mana -= 5;
        }

        if (mana >= 50)
        {
            return "Use Habilidade Poderosa";
        }
        else
        {
            return "Use Habilidade Básica";
        }
    }
}

