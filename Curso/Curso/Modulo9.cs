
namespace Conversores;

public class Conversor
{
        public void ConvertAndParse()
        {
                int numero = int.Parse("1"); //Converteu o valor string para um inteiro
                bool verdadeiro = bool.Parse("true");
                Console.WriteLine(verdadeiro);
        }


    //public void ConvertAndParse()
    //{  // Parse converte uma tipo para int, desde que ele seja reconhecido como numérico. 
    //    int numero = int.Parse("1");
    //    Console.WriteLine(numero
    //}

    public void AulaTryParse()
    {
        var numero = "10";
        int numeroConvertido;

        /*
         * Confere se o valor pode ser convertido para int e entrega algo. Caso não consiga converter, ele não mostra o erro, entrega uma saída programada. 
        */
        if (int.TryParse(numero, out numeroConvertido)) //entra, sai
        {
            Console.Write("Numero foi convertido com sucesso: ");
            Console.WriteLine(numeroConvertido);
        }
        else
        {
            Console.WriteLine("Não é possível converter esse valor");
        }

           
    }
}