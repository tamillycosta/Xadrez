using Tabuleiro.Exception;

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

    public Peca GetPeca(Posicao pos){
        PosicaoValida(pos);
        return _pecas[pos.linha,pos.coluna];
    }

    public void AdicionarPeca(Peca peca, Posicao pos ){
         ValidarPosicao(pos);
         if(!existePeca(pos)){
            _pecas[pos.linha, pos.coluna] = peca; 
            peca.Posicao = pos;
         }else{
           throw new TabuleiroException("Posição ja Ocupada!");
         }
        
    }

    private bool PosicaoValida(Posicao pos){
       return pos.linha >= 0 && pos.linha < linhas && pos.coluna >= 0 && pos.coluna < colunas;
        
    }

    private void ValidarPosicao(Posicao pos){
        if(!PosicaoValida(pos)){
            throw new TabuleiroException("Posição invalida!");
        }
    }

    public bool existePeca(Posicao pos){
        PosicaoValida(pos);
        return _pecas[pos.linha,pos.coluna] != null;
    }

}