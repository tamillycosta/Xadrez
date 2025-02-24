namespace Jogo;
using Tabuleiro;

class PosicaoXadrez{

    public char coluna{ get; set; }
    public int linha { get; set; }


    public Posicao convertePosicao(){
        
        return new Posicao( 8 - linha, coluna + 'a');
    }

    public override string ToString()
    {
        return coluna + linha.ToString();
    }

}
