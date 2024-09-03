/*-------------------------------------------------------------------
Questão 1: Informações do Personagem
* Contextualização: Em um jogo de aventuras, o jogador ganha pontos ao completar 
missões. A pontuação é calculada com base na dificuldade da missão, na quantidade 
de inimigos derrotados e no tempo gasto para completar.
* Comando: Crie um programa que receba a dificuldade da missão (Fácil, Média, Difícil), 
o número de inimigos derrotados e o tempo gasto (em minutos). Crie uma função para 
calcular a pontuação da missão usando os seguintes critérios:
* Fácil: 5 pontos por inimigo, sem penalidade de tempo.
* Média: 10 pontos por inimigo, -2 pontos por minuto acima de 10 minutos.
* Difícil: 15 pontos por inimigo, -5 pontos por minuto acima de 15 minutos.
* Exiba a pontuação final do jogador
4@Lista: 02 
@Autor: Joanna Nobre
@Data: 03/09/2024
---------------------------------------------------------------------*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o tipo de poção, sendo pequena, média, grande: ");
        string tipodePocao = Console.ReadLine();

        Console.WriteLine("Digite o nivel do personagem: ");
        int nivelpersona = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de poções usadas: ");
        int quantidadepocus = int.Parse(Console.ReadLine());

        int vidarec = calcularVidaRec(tipodePocao, nivelpersona, quantidadepocus);

        Console.WriteLine($"Total de vida recuperada {vidarec}");
    }
    static int calcularVidaRec(string tipodePocao, int nivelpersona, int quantidadepocus)
    {
        int pontosporPocao = 0;

        switch (tipodePocao)
        {
            case "pequena":
                pontosporPocao = 10;
                break;
            case "média":
                pontosporPocao = 20;
                break;
            case "Grande":
                pontosporPocao = 30;
                break;
            default:
                Console.WriteLine("tipo de poção invalido");
                return 0;
        }
        int vidabaserec = pontosporPocao * quantidadepocus;

        int bonusdenivel = 0;
        if (nivelpersona > 5)
        {
            bonusdenivel = (nivelpersona - 5) * 5;
        }
        return vidabaserec + bonusdenivel;
    }
}
