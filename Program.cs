using DesafioFundamentos.Models;

Console.Clear();
Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");

Console.WriteLine("Digite o preço inicial:");
decimal price = 0;
price = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
decimal priceByHour = 0;
priceByHour = Convert.ToDecimal(Console.ReadLine());

bool menu = true;
int option = 0;

Estacionamento estacionamento = new(price, priceByHour);

while (menu)
{
  Console.Clear();
  Console.WriteLine("Digite a sua opção:");
  Console.WriteLine("1 - Cadastrar Veículo");
  Console.WriteLine("2 - Remover veículo");
  Console.WriteLine("3 - Listar veículos");
  Console.WriteLine("4 - Encerrar");

  option = Convert.ToInt32(Console.ReadLine());

  switch (option)
  {
    case 1: estacionamento.Register(); break;
    case 2: estacionamento.Remove(); break;
    case 3: estacionamento.ListAll(); break;
    case 4: menu = false; break;
    default: Console.WriteLine("Opção inválida!"); break;
  }

  Console.WriteLine("Pressione uma tecla para continuar...");
  Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");