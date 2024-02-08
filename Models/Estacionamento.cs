namespace DesafioFundamentos.Models
{
  public class Estacionamento
  {
    private List<string> vehicles = new();
    private decimal price = 0;
    private decimal priceByHour = 0;

    public Estacionamento(decimal price, decimal priceByHour)
    {
      this.price = price;
      this.priceByHour = priceByHour;
    }

    public void Register()
    {
      // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
      Console.WriteLine("Digite a placa do veículo para estacionar:");
      string? license = Console.ReadLine();

      if (license != null) vehicles.Add(license.ToUpper());
    }

    public void Remove()
    {
      // Pedir para o usuário digitar a placa e armazenar na variável placa
      Console.WriteLine("Digite a placa do veículo para remover:");
      string? license = Console.ReadLine();

      if (license != null && vehicles.Any(x => x.ToUpper() == license.ToUpper()))
      {
        // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
        Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
        int time = 0;
        time = Convert.ToInt32(Console.ReadLine());

        // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal   
        decimal total = 0;
        total = Convert.ToDecimal(price + (priceByHour * time));

        // TODO: Remover a placa digitada da lista de veículos
        vehicles.Remove(license.ToUpper());

        Console.WriteLine($"O veículo {license} foi removido e o preço total foi de: R$ {total}");
      }
      else
      {
        Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
      }
    }

    public void ListAll()
    {
      if (vehicles.Any())
      {
        Console.WriteLine("Os veículos estacionados são:");

        // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
        foreach (var vehicle in vehicles)
        {
          Console.WriteLine(vehicle);
        }
      }
      else
      {
        Console.WriteLine("Não há veículos estacionados.");
      }
    }
  }
}