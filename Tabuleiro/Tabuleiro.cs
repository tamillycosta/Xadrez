namespace Tabuleiro;

class Tabuleiro{


    public int linhas { get; set; }
    public int colunas { get; set; }

    private Peca[,] _pecas;

    public Tabuleiro(int linhas, int colunas)
    {
        this.linhas = linhas;
        this.colunas = colunas;
        _pecas = new Peca[linhas,colunas];
    }

    public Peca GetPeca(int linha, int coluna){
        return _pecas[linha,coluna];
    }

    public void AdicionarPeca(Peca peca, Posicao pos ){
        _pecas[pos.linha, pos.coluna] = peca; 
         peca.Posicao = pos;
    }
}