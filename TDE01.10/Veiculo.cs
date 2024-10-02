public class Veiculo{
    protected string Marca;
    protected string Modelo;
    protected int  Ano;


public void Ligar(){
    Console.WriteLine("Ligando");
}
public void Desligar(){
    Console.WriteLine("Desligando");
}


    public void setMarca(string Marca){
        this.Marca = Marca;
    }
    public void setModelo(string Modelo){
        this.Modelo = Modelo;
    }
    public void setAno(int Ano){
        this.Ano = Ano;
    }

}