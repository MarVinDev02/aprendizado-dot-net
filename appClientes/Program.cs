namespace appClientes;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Menu();

            Console.ReadKey();
        }
    }

    public static void Menu()
    {
        Console.Clear();

        System.Console.WriteLine("Cadastro de Clientes");
        System.Console.WriteLine("---------------------");
        System.Console.WriteLine("1- Cadastrar Cliente");
        System.Console.WriteLine("2- Exibir Cliente");
        System.Console.WriteLine("3- Editar Cliente");
        System.Console.WriteLine("4- Excluir Cliente");
        System.Console.WriteLine("5- Sair");
        System.Console.WriteLine("---------------------");


    }
}
