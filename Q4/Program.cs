/*-------------------------------------------------------------------
Questão 4: Sistema de Resgate em Labirinto
• Contextualização: Em um jogo de exploração, o jogador precisa resgatar aliados perdidos em um labirinto. O sucesso do resgate depende da quantidade de energia, da distância até o aliado e do nível de ameaça no caminho.
• Comando: Crie um programa que receba a energia do jogador, a distância até o aliado (em metros) e o nível de ameaça (baixo, médio, alto). Crie uma função que determine se o resgate é possível com base nas seguintes condições:
• Energia maior que 50: Resgate bem-sucedido.
• Distância menor que 20 metros: +10 de energia.
• Nível de ameaça:
o Baixo: Sem penalidade.
o Médio: -10 de energia.
o Alto: -20 de energia.
• Exiba se o resgate foi bem-sucedido ou falhou.
@Lista: 04 - Funções
@Autor: Mauricio Escobar Azevedo Lima
@Data: 02/09/2024
---------------------------------------------------------------------*/

using System;
class Program {
    static void Main(string[] args) {
        int energia, distancia;
        string? ameaca;

        System.Console.WriteLine("Quando de energia voce tem?");
        System.Console.Write("Escolha: ");
        int.TryParse(Console.ReadLine(), out energia);
        Console.Clear();

        System.Console.WriteLine("Qual e a distancia de voce pro seus aliados? (em metros)");
        System.Console.Write("Escolha: ");
        int.TryParse(Console.ReadLine(), out distancia);
        Console.Clear();

        while(true){
            System.Console.WriteLine("Qual o nivel de ameaça?");
            System.Console.Write("Escolha: ");
            ameaca = Console.ReadLine().ToLower();
            if(ameaca.Equals("baixo") || ameaca.Equals("medio") || ameaca.Equals("alto")){
                break;
            }
            else{
                Console.Clear();
                System.Console.WriteLine("Escreva uma ameaça valida");
            }
        }
        Console.Clear();
        
        Seraqvai(energia, distancia, ameaca);

        Console.WriteLine("\nPressione ENTER para fechar o programa");
        Console.ReadKey();
    }
    static void Seraqvai(int energia, int distancia, string? ameaca){
        if(ameaca.Equals("medio")){
            energia -= 10;
        }
        else if(ameaca.Equals("alto")){
            energia -= 20;
        }
        if(distancia < 20){
            energia += 10;
        }
        if(energia > 50){
            System.Console.WriteLine("Resgate Bem Sucedido");
        }
        else {
            System.Console.WriteLine("Resgate falhou");
        }
    }
}