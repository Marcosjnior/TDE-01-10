public class Carro : Veiculo{
    private int NumeroDePortas;

    public void AbrirMalas(){
        Console.WriteLine("Porta malas aberto");
    }
    public void ExibirInformacoes(){
        Console.WriteLine($"Marca:{Marca}, Modelo:{Modelo}, Ano:{Ano}, Numero de portas:{NumeroDePortas}");
    }
    public void setnumeroDePortas(int NumeroDePortas){
        this.NumeroDePortas = NumeroDePortas;
    }
}