
namespace Conversores;

public class Conversor
{
<<<<<<< HEAD
        public void ConvertAndParse()
        {
                // int numero = int.Parse("1"); //Converteu o valor string para um inteiro
                bool verdadeiro = bool.Parse("true");
                Console.WriteLine(verdadeiro);
        }

    internal void AulaTryParse()
    {
        throw new NotImplementedException();
    }
=======
    public void ConvertAndParse()
    {
        int numero = int.Parse("1");
        Console.WriteLine(numero);



    }

    public void AulaTryParse()
    {
        var numero = "abc";
        int numeroConvertido;

        //Confere se o valor pode ser convertido para int e entrega algo. Caso não consiga converter, ele não mostra o erro, entrega uma saída programada. 

        if (int.TryParse(numero, out numeroConvertido))
        {
            Console.WriteLine("Numero foi convertido com sucesso");
        }

        Console.WriteLine(numeroConvertido);
    }
>>>>>>> refs/remotes/origin/main
}