namespace Modulo13;

public class TrabalhandoComArquivos
{
    public void AulaCriandoArquivo()
    {
        var escrever = new StreamWriter("Cadastro.txt", true); //Cria um arquivos e usa o append (apenas escreve o que se pede dentro do arquivo, caso ele já exista.)

        Console.WriteLine("Informe um nome");
        var nome = Console.ReadLine();
        escrever.WriteLine("ID..." + Random.Shared.Next(1, 100));
        escrever.WriteLine("Nome: " + nome);
        escrever.WriteLine("--------------------");
        escrever.Close();
    }

    public void AulaLendoArquivo()
    {
        // var conteudo = File.ReadAllText("Cadastro.txt");
        // System.Console.WriteLine(conteudo);

        //Lê linha por linha, sem forçar a memória de uma vez. 
        var ler = new StreamReader("Cadastro.txt");
        while (!ler.EndOfStream)
        {
            var linha = ler.ReadLine();
            System.Console.WriteLine(linha);
        }

        ler.Close();

    }

    public void AulaExcluindoArquivo()
    {
        if (File.Exists("Cadastro.txt"))
        {
            File.Delete("Cadastro.txt");
        }
    }
}