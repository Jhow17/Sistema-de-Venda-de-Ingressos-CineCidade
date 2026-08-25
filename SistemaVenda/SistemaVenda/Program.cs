// See https://aka.ms/new-console-template for more information

using SistemaVenda;

Cliente clienteJose = new Cliente();


Console.WriteLine("Qual seu Nome: ");
clienteJose.Nome = Console.ReadLine();


Console.WriteLine("Quantos Ingressos quer comprar: ");
clienteJose.Ingressos = int.Parse(Console.ReadLine());

Console.WriteLine("Tem Cupom de Desconto (Digite o cupom ): ");
clienteJose.CDesconto = (Console.ReadLine());

Console.WriteLine("Idade: ");
clienteJose.Idade = int.Parse(Console.ReadLine());


Console.WriteLine(clienteJose.Nome.ToLower());

Console.WriteLine($"O valor Bruto vai ficar: {clienteJose.CalcularBruto()}");


Console.WriteLine($" O valor Liquido vai ficar: {clienteJose.CalcularLiquido()}");



Console.WriteLine($"Elegível para Sessão Noturna : {clienteJose.Idade >= 18}");
