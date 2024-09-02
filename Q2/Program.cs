/*-------------------------------------------------------------------
Questão 2: Sistema de Pontuação de Missões
• Contextualização: Em um jogo de aventuras, o jogador ganha pontos ao completar missões. A pontuação é calculada com base na dificuldade da missão, na quantidade de inimigos derrotados e no tempo gasto para completar.
• Comando: Crie um programa que receba a dificuldade da missão (Fácil, Média, Difícil), o número de inimigos derrotados e o tempo gasto (em minutos). Crie uma função para calcular a pontuação da missão usando os seguintes critérios:
• Fácil: 5 pontos por inimigo, sem penalidade de tempo.
• Média: 10 pontos por inimigo, -2 pontos por minuto acima de 10 minutos.
• Difícil: 15 pontos por inimigo, -5 pontos por minuto acima de 15 minutos.
• Exiba a pontuação final do jogador.
@Lista: 04 - Funções
@Autor: Mauricio Escobar Azevedo Lima
@Data: 02/09/2024
---------------------------------------------------------------------*/

using System;
class Program {
    static void Main(string[] args) {
        int tempo, inimigos, temp = 0, total = 0;
        string?  dificuldade;
        while (true){
            System.Console.WriteLine("Qual foi a dificuldade da missão?\nDificil\nMedio\nFacil");
            System.Console.Write("Escolha: ");
            dificuldade = Console.ReadLine().ToLower();
            if (dificuldade.Equals("dificil") || dificuldade.Equals("medio") || dificuldade.Equals("facil")) {
                Console.Clear();
                break;
            }
            else{
                Console.Clear();
                System.Console.WriteLine("Escreva um tipo valido");
            }
        }
        System.Console.WriteLine("Qual o seu tempo?");
        System.Console.Write("Escolha: ");
        int.TryParse(Console.ReadLine(), out tempo);
        Console.Clear();
        System.Console.WriteLine("Quanto tempo demoraste pra terminar o nivel??");
        System.Console.Write("Escolha: ");
        int.TryParse(Console.ReadLine(), out inimigos);
        Console.Clear();

        Calc(dificuldade,  tempo, inimigos, temp, total);

        Console.WriteLine("\nPressione ENTER para fechar o programa");
        Console.ReadKey();
    }
    static void Calc(string? dificuldade, int tempo, int inimigos, int temp, int total){
        switch (dificuldade) {
            case "dificil":
            temp = 15;
            break;
            case "medio":
            temp = 10;
            break;
            case "facil":
            temp = 5;
            break;
        }
        total = inimigos * temp;
        if(dificuldade == "medio" && tempo > 10){
            total -= (tempo - 10) * 2;
        }
        else if(dificuldade == "dificil" && tempo > 15){
            total -= (tempo - 15) * 5;
        }
        System.Console.WriteLine($"sua pontuação total foi de {total}");
    }
}