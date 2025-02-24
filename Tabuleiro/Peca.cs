using Tabuleiro.Enums;

namespace Tabuleiro;

class Peca{
   

    public Posicao Posicao { get; set; }
    public Cor Cor { get; set; }

    public int QuantidadeMovimentos { get; set; }

    public Tabuleiro Tabuleiro { get; set; }


    public Peca(Posicao posicao, Cor cor, int quantidadeMovimentos, Tabuleiro tabuleiro)
        {
            Posicao = posicao;
            Cor = cor;
            QuantidadeMovimentos = quantidadeMovimentos;
            Tabuleiro = tabuleiro;
        }
    
}