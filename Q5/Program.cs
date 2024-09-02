/*-------------------------------------------------------------------
Questão 5: Escolha de Habilidade Especial
• Contextualização: No jogo, o jogador pode usar habilidades especiais durante a batalha. A escolha da habilidade depende da quantidade de mana disponível, do tipo de inimigo e da distância do alvo.
• Comando: Crie um programa que receba a quantidade de mana, o tipo de inimigo (Normal, Forte, Boss) e a distância do alvo (em metros). Crie uma função que sugira qual habilidade usar com base nos seguintes critérios:
• Mana maior que 50: Use Habilidade Poderosa.
• Inimigo Forte ou Boss: +10 mana necessária.
• Distância menor que 10 metros: Reduz a mana necessária em 5.
• Exiba a habilidade sugerida.
@Lista: 04 - Funções
@Autor: Mauricio Escobar Azevedo Lima
@Data: 02/09/2024
---------------------------------------------------------------------*/

using System;
class Program {
    static void Main(string[] args) {
        int mana, distancia;
        string? forca;

        System.Console.WriteLine("Quanto de mana voce possui?");
        System.Console.Write("Escolha: ");
        int.TryParse(Console.ReadLine(), out mana);
        Console.Clear();

        while(true){
            System.Console.WriteLine("Qual o tipo do seu inimigo?\nBoss\nForte\nNormal");
            System.Console.Write("Escolha: ");
            forca = Console.ReadLine();
            if(forca == "normal" || forca == "forte" || forca == "boss"){
                break;
            }
            else{
                Console.Clear();
                System.Console.WriteLine("Escreva um tipo valido");
            }
        }
        Console.Clear();

        System.Console.WriteLine("Qual e a sua distancia do inimigo?");
        System.Console.Write("Escolha: ");
        int.TryParse(Console.ReadLine(), out distancia);
        Console.Clear();

        Frieren(mana, forca, distancia);

        Console.WriteLine("\nPressione ENTER para fechar o programa");
        Console.ReadKey();
    }
    static void Frieren(int mana, string forca, int distancia){
        int dt = 50;
        if(forca == "boss" || forca == "forte"){
            dt += 10;
        }
        if(distancia < 10){
            dt -= 5;
        }
        if(dt < mana){
            System.Console.WriteLine("Use Habilidade Poderosa");
        }
        else if(dt > mana){
            System.Console.WriteLine("Use Habilidade Basica");
        }
    }
}