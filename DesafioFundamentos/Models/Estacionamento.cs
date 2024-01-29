namespace DesafioFundamentos.Models;

public class Estacionamento
{
    private decimal precoInicial = 0;
    private decimal precoPorHora = 0;
    private List<string> ListaDeCarros = new();

    public Estacionamento(decimal precoInicial, decimal precoPorHora){
        this.precoInicial = precoInicial;
        this.precoPorHora = precoPorHora;
    }

    public void AdicionarVeiculo(){
        Console.WriteLine("Digite a placa do veículo para estacionar: ");
        string? placaADD = Console.ReadLine();
        ListaDeCarros.Add(placaADD);
    }

    public void RemoverVeiculo(){
        Console.WriteLine("Digite a placa do veículo para remover:");
        string? placaRemover = Console.ReadLine();

        if (ListaDeCarros.Any(x => x.ToUpper() == placaRemover.ToUpper())){
            Console.WriteLine("Quantas horas o veículo permaneceu estacionado:");

            int qtHoras = int.Parse(Console.ReadLine());
            int horas = 0;
            decimal valorTotal = 0;
            valorTotal = precoInicial + (precoPorHora * qtHoras);

            ListaDeCarros.Remove(placaRemover);
            Console.WriteLine($"\nO veículo {placaRemover} foi removido e o preço total foi de: R$ {valorTotal}");
            Console.ReadKey();
        }
        else Console.WriteLine("\n Esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
    }

    public void ListarVeiculos()
    {
        if (ListaDeCarros.Any()){
            Console.WriteLine("---Veículos estacionados---");

            foreach (string veiculo in ListaDeCarros)
                Console.WriteLine($"- {veiculo}");
        }
        else Console.WriteLine("Não há veículos estacionados.");
    }
}