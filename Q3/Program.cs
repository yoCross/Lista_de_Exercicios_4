/*-------------------------------------------------------------------
Questão 3: Cálculo de Dano Crítico
• Contextualização: Em combates, o jogador pode realizar ataques críticos que causam danos adicionais. O dano causado depende do ataque base, do multiplicador crítico e da arma utilizada.
• Comando: Crie um programa que receba o valor do ataque base, o multiplicador crítico (1.5x, 2x, 3x) e o tipo de arma (Espada, Arco, Cajado). Crie uma função que calcule o dano crítico da seguinte forma:
• Espada: +10 pontos ao dano total.
• Arco: +5 pontos ao dano total.
• Cajado: +15 pontos ao dano total.
• Exiba o dano total causado pelo ataque crítico.
@Lista: 04 - Funções
@Autor: Mauricio Escobar Azevedo Lima
@Data: 02/09/2024
---------------------------------------------------------------------*/

using System;
class Program {
    static void Main(string[] args) {
        int atkbase;
        double danocrit, total = 0;
        string? arma;
        while(true){
            System.Console.WriteLine("Qual e a sua arma?\nEspada\nArco\nCajado");
            System.Console.Write("Escolha: ");
            arma = Console.ReadLine().ToLower();
            if(arma == "arco" || arma == "cajado" || arma == "espada"){
                Console.Clear();
                break;
            }
            else{
                Console.Clear();
                System.Console.WriteLine("Escreva uma arma valida");
            }
        }
        System.Console.WriteLine("Qual o dano base da sua arma?");
        System.Console.Write("Escolha: ");
        int.TryParse(System.Console.ReadLine(), out atkbase);
        Console.Clear();

        System.Console.WriteLine("Qual e o seu multiplicador de dano critico?\n1.5\n2\n3");
        System.Console.Write("Escolha: ");
        double.TryParse(System.Console.ReadLine(), out danocrit);
        Console.Clear();

        Crit(arma, atkbase, danocrit, total);


        Console.WriteLine("\nPressione ENTER para fechar o programa");
        Console.ReadKey();
    }
    static void Crit(string? arma, int atkbase, double danocrit, double total){
        total = atkbase * danocrit;
        switch(arma){
            case "espada":
            total = atkbase * danocrit + 10;
            break;
            case "cajado":
            total = atkbase * danocrit + 15;
            break;
            case "arco":
            total = atkbase * danocrit + 5;
            break;
        }
        System.Console.WriteLine($"O dano total de sua arma foi: {total}");
    }
}