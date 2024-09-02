/*-------------------------------------------------------------------
Questão 1: Sistema de Cura de Personagem
• Contextualização: Em um jogo de RPG, o jogador pode usar poções de cura para
recuperar a vida do seu personagem durante a batalha. A quantidade de vida
recuperada depende do tipo de poção, do nível do personagem e da quantidade de
poções usadas.
• Comando: Crie um programa que receba o tipo de poção (Pequena, Média, Grande), o
nível do personagem e a quantidade de poções usadas. Crie uma função que calcule a
quantidade de vida recuperada com base nos seguintes critérios:
• Poção Pequena: 10 pontos de vida por poção.
• Poção Média: 20 pontos de vida por poção.
• Poção Grande: 30 pontos de vida por poção.
• Adicione 5 pontos adicionais para cada nível do personagem acima de 5.
• Exiba o total de vida recuperada.
@Lista: 04 - Funções
@Autor: Mauricio Escobar Azevedo Lima
@Data: 02/09/2024
---------------------------------------------------------------------*/

using System;
class Program {
    static void Main(string[] args) {
        int nivel, pocoesusadas, temp = 0, total = 0;
        string?  pocao;
        while (true){
            System.Console.WriteLine("Que tipo de poção voce deseja?\nGrande\nMedio\nPequena");
            System.Console.Write("Escolha: ");
            pocao = Console.ReadLine().ToLower();
            if (pocao.Equals("grande") || pocao.Equals("medio") || pocao.Equals("pequena")) {
                Console.Clear();
                break;
            }
            else{
                Console.Clear();
                System.Console.WriteLine("Escreva um tipo valido");
            }
        }
        System.Console.WriteLine("Qual o seu nivel?");
        System.Console.Write("Escolha: ");
        int.TryParse(Console.ReadLine(), out nivel);
        Console.Clear();
        System.Console.WriteLine("Quantas dessa poção voce quer usar?");
        System.Console.Write("Escolha: ");
        int.TryParse(Console.ReadLine(), out pocoesusadas);
        Console.Clear();

        Calc(pocao,  nivel, pocoesusadas, temp, total);

        Console.WriteLine("\nPressione ENTER para fechar o programa");
        Console.ReadKey();
    }
    static void Calc(string? pocao, int nivel, int pocoesusadas, int temp, int total){
        switch (pocao) {
            case "grande":
            temp = 30;
            break;
            case "medio":
            temp = 20;
            break;
            case "pequena":
            temp = 10;
            break;
        }
        total = nivel;
        if(nivel > 5){
            nivel = (nivel - 5) * 5;
        }
        if(total > 5){
            total = nivel + (temp * pocoesusadas);
        }
        else{
            total = temp * pocoesusadas;
        }
        System.Console.WriteLine($"a vida total do seu personagem e: {total}");
    }
}