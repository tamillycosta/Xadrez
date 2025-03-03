using Tabuleiro.Enums;

namespace Tabuleiro;

class Peca{
   

    public Posicao Posicao { get; set; }
    public Cor Cor { get; set; }

    public int QuantidadeMovimentos { get; set; }

    public Tabuleiro Tabuleiro { get; set; }


    public Peca(Cor cor, Tabuleiro tabuleiro)
        {
            Posicao = new Posicao();
            Cor = cor;
            QuantidadeMovimentos = 0;
            Tabuleiro = tabuleiro;
        }
    
}