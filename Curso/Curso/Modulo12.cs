namespace Modulo12;

public class TrabalhandoComExcessoes
{
    //Gerando uma excessão.

    public void AulaGerandoException()
    {

        while (true)
        {
            Console.WriteLine("Digite Uma Informação.");
            var numero = Console.ReadLine();
            var resultado = 500 / int.Parse(numero);
            Console.WriteLine("resultado = " + resultado);
        }
    }

//Tratando uma excessão
    public void AulaTratandoException()
    {

        while (true)
        {
            try
            {
                Console.WriteLine("Digite Uma Informação.");
                var numero = Console.ReadLine();
                var resultado = 500 / int.Parse(numero);
                Console.WriteLine("resultado = " + resultado);
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine("Ocorreu um erro de divisão" + exception.Message);
                Console.WriteLine("Stack: " + exception.StackTrace);
            }
            catch (Exception exception)
            {
                System.Console.WriteLine("Erro: " + exception.Message); //Entrega uma mensagem de erro.
                Console.WriteLine("Ocorreu um erro");
                Console.WriteLine("Stack: " + exception.StackTrace);//Mostra a pilha na qual o correu o erro.
                Console.WriteLine("");
            }

        }
    }
}