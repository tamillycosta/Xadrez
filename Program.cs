// See https://aka.ms/new-console-template for more information


namespace Xadrez;
using System;
using Tabuleiro;

class Xadrez{

    static void Main(string[] args){
        Tabuleiro tab = new Tabuleiro(8,8);
        
        Tela.PrintTela(tab);
    }
}


