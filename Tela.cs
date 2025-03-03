namespace Xadrez;
using Tabuleiro;
using Tabuleiro.Enums;
using System;
class Tela{

    public int linhas { get; set; }
    public int colunas { get; set; }


    public Tela(int linhas, int colunas)
    {
        this.linhas = linhas;
        this.colunas = colunas;
       
    }

    public static void PrintTela(Tabuleiro tab){
        int cont = 1;
        for(int i = 0; i < tab.linhas; i++){
           Console.Write(" " + cont );
            cont ++;
            for(int j = 0; j < tab.colunas; j++){
                 
                if(tab.GetPeca(i,j) == null){
                     Console.Write(  "- " );
                }else{
                   printPeca(tab.GetPeca(i,j));
                                   }
                    Console.Write(" ");
        }
        Console.WriteLine();
        }
        Console.WriteLine("  a b c d e f g h");
    }
    
    
    private static void printPeca(Peca peca)
{
    ConsoleColor aux = Console.ForegroundColor;

    if (peca.Cor == Cor.Preto)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
    }
    else
    {
        Console.ForegroundColor = aux;
    }

    Console.Write(peca);
    Console.ForegroundColor = aux;
}

       
        
    
}