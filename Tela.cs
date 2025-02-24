namespace Xadrez;
using Tabuleiro;
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
        for(int i = 0; i < tab.linhas; i++){
            for(int j = 0; j < tab.colunas; j++){
                if(tab.GetPeca(i,j) == null){
                     System.Console.Write(  "- " );
                }else{
                    System.Console.Write( tab.GetPeca(i,j) + "  ");
                }
                
        }
         System.Console.WriteLine();
        }
    }
    
}