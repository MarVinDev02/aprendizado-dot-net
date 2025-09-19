namespace Modulo14;

//Linq - Consulta integrada a linguagem.
//Efetua consultas em fontes de dados diferentes, bom para fazer consultas as colections.

//Where - Aplica filtros em uma fonte de dados.
//Sintaxe de método - Métodos que aplica para filtrar consultas.
//Lembra banco de dados relacional.

public class TrabalhandoComLinq
{
    public void AulaWhere()
    {
        //    string nomeCompleto = "RAFAEL ALMEIDA";
        //    Func<char, bool> filtro = c => c == 'A';
        //    //var resultado = nomeCompleto.Where(p => p == 'A');
        //    //var resultado = nomeCompleto.Where(filtro);

        //    //Sintaxe de consulta. (Parece com SQL)
        //    var resultado = from c in nomeCompleto where c == 'A' select c; 

        //    foreach(var letra in resultado)
        //    {
        //        Console.WriteLine(letra);
        //    }
        //}

        var numeros = new int[] { 10, 6, 5, 50, 15, 2 };
        
        //busca valores que peço através da lambda. 
        var resultado = numeros.Where(p => p >= 10); // Forma mais simples.

        foreach (var numero in resultado)
            {
                Console.WriteLine(numero);
            }

    }

    //Ordena qualquer tipo de dado. Quando letra, vai pelo alfabeto, quando numero, vai pela ordem crescente.
    public void AulaOrdernacao()
    {
        var numeros = new int[] { 10, 6, 5, 50, 15, 2 };

        //var resultado = numeros.OrderBy(p => p);
        var nomes = new String[] { "Rafael", "Eduardo", "Bruno" };
        
        //Inverte a ordem da lista, a colocando decrescente.
        var resultado = nomes.OrderByDescending(p => p); 
        
        
        foreach (var numero in resultado)
        {
            Console.WriteLine(numero);
        }

    }

    public void AulaTake()
    {
        //Peço para me retornar valores de uma lista. Eu que escrevo quantos elementos quero que me retorne. 

        var numeros = new int[] { 10, 6, 5, 50, 15, 2 };
        //Utilização de take com mais funções para poder especificar mais ainda minha busca.  
        var resultado = numeros.Where(p => p > 10).Take(3).OrderBy(p => p);


        foreach (var numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }

    public void AulaCount()
    { //Conta quantos elementos o Array possui.
        var numeros = new int[] { 10, 6, 5, 50, 15, 2 };

        //Conta quantos elementos no array são maiores que 10.
        var resultado = numeros.Count(p => p > 10);

        Console.WriteLine(resultado);
    }
    
    public void AulaFirstFirstOrDefault()
    {
        var numeros = new int[] { 10, 6, 5, 50, 15, 2 };
        //Retorna o primeiro valor de uma lista.
        var resultado = numeros.First();

        //Se não tiver um item, ele retorna 0.
        // -99 é um parâmetro de retorno, caso nada seja encontrado.
        //var resultado = numeros.FirstOrDefault(p => p > 5, -99);
        //var resultado = numeros.Max();

        Console.WriteLine(resultado);
    
        
    }

}