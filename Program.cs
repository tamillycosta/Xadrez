// See https://aka.ms/new-console-template for more information


namespace Xadrez;
using System;
using Jogo;
using Tabuleiro;
using Tabuleiro.Enums;
using Tabuleiro.Exception;

class Xadrez{

    static void Main(string[] args){
        Tabuleiro tab = new Tabuleiro(8,8);
        try{
            tab.AdicionarPeca(new Rei(Cor.Preto, tab), new Posicao(0,0));
            tab.AdicionarPeca(new Rei(Cor.Preto, tab), new Posicao(0,0));
            tab.AdicionarPeca(new Torre(Cor.Preto, tab), new Posicao(1,0));

             Tela.PrintTela(tab);
        }catch(TabuleiroException e){
            System.Console.WriteLine(e.Message);
        }
       
    }
}


