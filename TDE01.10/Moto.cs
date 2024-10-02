public class Moto : Veiculo
{
    private bool TemBagageiro;
    public void DarGrau(){
        Console.WriteLine("RANDANDANDAN");
    }
    public void ExibirInformacoes(){
        Console.WriteLine($"Marca:{Marca}, Modelo:{Modelo}, Ano:{Ano} Tem Bagageiro: {TemBagageiro}");
    }
    public void setTemBagageiro(bool TemBagageiro){
        this.TemBagageiro = TemBagageiro;
    }
}