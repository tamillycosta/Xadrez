// See https://aka.ms/new-console-template for more information


namespace Xadrez;
using System;
using Jogo;
using Tabuleiro;
using Tabuleiro.Enums;

class Xadrez{

    static void Main(string[] args){
        Tabuleiro tab = new Tabuleiro(8,8);
        tab.AdicionarPeca(new Rei(Cor.Preto, tab), new Posicao(0,0));
        tab.AdicionarPeca(new Rei(Cor.Preto, tab), new Posicao(1,2));
        tab.AdicionarPeca(new Torre(Cor.Preto, tab), new Posicao(1,0));
        
        Tela.PrintTela(tab);
    }
}


