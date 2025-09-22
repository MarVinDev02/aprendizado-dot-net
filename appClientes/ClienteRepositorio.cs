using Cadastro;

namespace ClienteRepositorio;

public class ClienteRepositorio
{
    public List<Cliente> clientes = new List<Cliente>();

    public void PegarDadosCliente()
    {
        Console.Clear();

        Console.WriteLine("Id");
        var id = int.Parse(Console.ReadLine());
        Console.WriteLine(Environment.NewLine);

        Console.WriteLine("Nome");
        var nome = Console.ReadLine();
        Console.WriteLine(Environment.NewLine);


        Console.WriteLine("Nascimento");
        var dataNascimento = DateOnly.Parse(Console.ReadLine());
        Console.WriteLine(Environment.NewLine);

        Console.WriteLine("Desconto");
        var desconto = decimal.Parse(Console.ReadLine());
        Console.WriteLine(Environment.NewLine);

        Console.WriteLine("Cadastro");
        var cadastradoEm = DateTime.Parse(Console.ReadLine());
        Console.WriteLine(Environment.NewLine);

        var cliente = new Cliente();
        cliente.Id = clientes.Count + 1; //Pega a quantos clientes possui e vai adicionando mais 1.
        cliente.Nome = nome;
        cliente.DataNascimento = dataNascimento;
        cliente.Desconto = desconto;
        cliente.CadastradoEm = cadastradoEm;
        clientes.Add(cliente);

        System.Console.WriteLine("Cliente cadastrado com sucesso.");
        ImprimirCLiente(cliente);
        Console.ReadKey();

    }

    public void ImprimirCLiente(Cliente cliente)
    {
        System.Console.WriteLine("ID..........." + cliente.Id);
        System.Console.WriteLine("Nome..........." + cliente.Nome);
        System.Console.WriteLine("Data Nascimento..........." + cliente.DataNascimento);
        System.Console.WriteLine("Desconto..........." + cliente.Desconto.ToString("0.00"));
        System.Console.WriteLine("Data Cadastro..........." + cliente.CadastradoEm);
        System.Console.WriteLine("---------------------------------");
    }

    public void ExibirClientes()
    {
        Console.Clear();
        foreach (var cliente in clientes)
        {
            System.Console.WriteLine(cliente);
        }
    }

    

}