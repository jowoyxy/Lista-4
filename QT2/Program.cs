/*-------------------------------------------------------------------
Questão 2: Informações do Personagem
* Contextualização:Em um jogo de aventuras, o jogador ganha pontos ao completar 
missões. A pontuação é calculada com base na dificuldade da missão, na quantidade 
de inimigos derrotados e no tempo gasto para completar.
* Comando: Crie um programa que receba a dificuldade da missão (Fácil, Média, Difícil), 
o número de inimigos derrotados e o tempo gasto (em minutos). Crie uma função para 
calcular a pontuação da missão usando os seguintes critérios:
* Fácil: 5 pontos por inimigo, sem penalidade de tempo.
* Média: 10 pontos por inimigo, -2 pontos por minuto acima de 10 minutos.
* Difícil: 15 pontos por inimigo, -5 pontos por minuto acima de 15 minutos.
* Exiba a pontuação final do jogador
@Lista: 04 
@Autor: Joanna Nobre
@Data: 03/09/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a dificuldade da missão (Fácil, Média, Difícil): ");
        string dificuldade = Console.ReadLine().ToLower();

        Console.WriteLine("Digite o número de inimigos derrotados: ");
        int inimigosDerrotados = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o tempo gasto (em minutos): ");
        int tempoGasto = int.Parse(Console.ReadLine());

        int pontuacaoFinal = CalcularPontuacao(dificuldade, inimigosDerrotados, tempoGasto);

        Console.WriteLine($"Pontuação final do jogador: {pontuacaoFinal} pontos");
    }

    static int CalcularPontuacao(string dificuldade, int inimigosDerrotados, int tempoGasto)
    {
        int pontosPorInimigo = 0;
        int penalidadePorTempo = 0;
        int tempoLimite = 0;

        switch (dificuldade)
        {
            case "fácil":
            case "facil":
                pontosPorInimigo = 5;
                tempoLimite = int.MaxValue;  // Sem penalidade de tempo
                break;
            case "média":
            case "media":
                pontosPorInimigo = 10;
                penalidadePorTempo = 2;
                tempoLimite = 10;
                break;
            case "difícil":
            case "dificil":
                pontosPorInimigo = 15;
                penalidadePorTempo = 5;
                tempoLimite = 15;
                break;
            default:
                Console.WriteLine("Dificuldade inválida");
                return 0;
        }

        int pontuacaoBase = pontosPorInimigo * inimigosDerrotados;
        int penalidade = tempoGasto > tempoLimite ? (tempoGasto - tempoLimite) * penalidadePorTempo : 0;

        return pontuacaoBase - penalidade;
    }
}
