Carro carro = new Carro("Toyota", "Corrola", 2024);

carro.ExibirInfo(carro.Modelo, carro.Marca, carro.Ano);

Console.WriteLine("\nEscolha uma cor para seu carro:");

Console.WriteLine($"\n{Cor.Branco} - {(int)Cor.Branco}");
Console.WriteLine($"{Cor.Vermelho} - {(int)Cor.Vermelho}");
Console.WriteLine($"{Cor.Preto} - {(int)Cor.Preto}");
Console.WriteLine($"{Cor.Cinza} - {(int)Cor.Cinza}");
Console.WriteLine($"{Cor.Prata} - {(int)Cor.Prata}");
Console.WriteLine($"{Cor.Azul} - {(int)Cor.Azul}");

int valor = Convert.ToInt32(Console.ReadLine());
var CorEscolhida = (Cor)valor;

carro.Cor = CorEscolhida.ToString();

carro.ExibirCor();

Console.ReadKey();
public class Carro
{
    public string? Modelo { get; set; }
    public string? Marca { get; set; }
    public int Ano { get; set; }
    public string? Cor { get; set; }

    public Carro(string? modelo, string? marca, int ano)
    {
        Modelo = modelo;
        Marca = marca;
        Ano = ano;
    }
    public void ExibirInfo(string? modelo, string? marca, int ano)
    {
        Console.WriteLine($"Modelo : {modelo} \nMarca : {marca} \nAno : {ano}");
    }
    public void ExibirCor()
    {
        Console.WriteLine($"Parabéns!! Agora seu carro {Modelo}, da marca {Marca} e do ano de {Ano} é da cor {Cor}");
    }
}
enum Cor
{
    Branco = 1,
    Vermelho,
    Preto,
    Cinza,
    Prata,
    Azul
}