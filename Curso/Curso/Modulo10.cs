using System.Net.Mail;

namespace Modulo10;

public class TrabalhandoComStrings
{

    public void AulaRange()
    {
        //Pega os caracteres que eu requisitar entre os colchetes.
        string nomeArquivo = "2022_12_01_backup.bak";
        string ano = nomeArquivo[..4];//os 4 primeiros caracteres.
        Console.WriteLine(ano);

        string extensao = nomeArquivo[^3..]; //útimos 3 caracteres.
        Console.WriteLine(extensao);

        string nome = nomeArquivo[11..^4];//Pega a partir do 11 e elminina os 4 últimos.
        Console.WriteLine(nome);

        string apenasNome = nomeArquivo[..^4];//Pega todos os caracteres e elimina os últimos 4. 
        Console.WriteLine(apenasNome);

    }

    public void AulaContains()
    {
        //Retorna um booleando falando se contém ou não o conjunto de caracteres em uma string.
        var nomeArquivo = "2022_02_01_backup.bak";
        Console.WriteLine("Contem nome: " + nomeArquivo.Contains("backup"));

        if (nomeArquivo.Contains("backup"))
        {
            System.Console.WriteLine("Palavra encontrada");
        }
        else
        {
            System.Console.WriteLine("Palavra não encontrada.");
        }

    }

    public void AulaTrim()
    {
        //Elimina espaços ou caracteres específicos
        var teste = "**RAFAEL ALMEIDA**";
        Console.WriteLine("TOTAL: " + teste.Trim('*'));
        Console.WriteLine("INICIO: " + teste.TrimStart('*'));
        Console.WriteLine("FINAL: " + teste.TrimEnd('*'));

    }
    public void StartsWithEnds()
    {
        //BOOLEANO Verifica se uma String inicia(Start) de um modo e termina(Ends) de outro. 
        var teste = "Curso CSharp";
        Console.WriteLine("Start With: " + teste.StartsWith("Curso"));
        Console.WriteLine("Ends With: " + teste.EndsWith("CSharpe"));

    }


    public void Repleace()
    {
        //Altera uma parte da String selecionada. 
        var teste = "Curso Csharp";
        Console.WriteLine(teste);
        Console.WriteLine(teste.Replace("Csharp", "C#")); //O primeiro especifica onde quero, o segundo vai altera-lo.

    }

    public void AulaLentgh()
    {
        var teste = Console.ReadLine();
        Console.WriteLine(teste.Length);

    }


    public void ConverterParaLetrasMinusculas()
    {
        Console.Write("Favor digitar alguma informação: ");
        var linha = Console.ReadLine();
        Console.WriteLine("Informação: " + linha.ToLower());

    }
}