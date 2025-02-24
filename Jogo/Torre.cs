namespace Jogo;
using Tabuleiro;
using Tabuleiro.Enums;

class Torre : Peca
{
    public Torre(Cor cor,  Tabuleiro tabuleiro) :
     base(cor,  tabuleiro)
    {
    }

    public override string ToString()
    {
        return "T";
    }

}