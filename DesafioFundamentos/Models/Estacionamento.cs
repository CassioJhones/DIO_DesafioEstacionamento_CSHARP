namespace DesafioFundamentos.Models;

public class Estacionamento
{
    private decimal precoInicial = 0;
    private decimal precoPorHora = 0;
    private List<string> veiculos = new List<string>();

    public Estacionamento(decimal precoInicial, decimal precoPorHora){
        this.precoInicial = precoInicial;
        this.precoPorHora = precoPorHora;
    }

    public void AdicionarVeiculo(){
        Console.WriteLine("Digite a placa do veículo para estacionar: ");
        string? placaADD = Console.ReadLine();
        veiculos.Add(placaADD);
    }

    public void RemoverVeiculo(){
        Console.WriteLine("Digite a placa do veículo para remover:");
        string? placaRemover = Console.ReadLine();

        if (veiculos.Any(x => x.ToUpper() == placaRemover.ToUpper())){
            Console.WriteLine("Quantas horas o veículo permaneceu estacionado:");

            int qtHoras = int.Parse(Console.ReadLine());
            int horas = 0;
            decimal valorTotal = 0;
            valorTotal = precoInicial + (precoPorHora * qtHoras);

            // TODO: Remover a placa digitada da lista de veículos

            veiculos.Remove(placaRemover);
            Console.WriteLine($"\nO veículo {placaRemover} foi removido e o preço total foi de: R$ {valorTotal}");
            Console.ReadKey();
        }
        else Console.WriteLine("\nDesculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
    }

    public void ListarVeiculos()
    {
        if (veiculos.Any()){
            Console.WriteLine("---Veículos estacionados---");

            foreach (string veiculo in veiculos)
                Console.WriteLine($"- {veiculo}");
        }
        else Console.WriteLine("Não há veículos estacionados.");
    }
}