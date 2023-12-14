public class Produtos{
    public double valor;

    public void MostrarValor (double valor){
        this.valor = this.valor + valor;
    } 

    public void ComparProdutos (double valor){

        Console.WriteLine("voce comprou este produto" + this.valor + "R$");


    }

    public Produtos(){
        this.valor = 50;
    }

}