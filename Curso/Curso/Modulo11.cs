using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Modulo11;
public class TrabalhandoComDatas
{
	public void AulaDateTime()
	{
		var date1 = new DateTime(2012, 12, 02, 19, 22, 23);//DateTime normal.
		var date2 = DateTime.Parse("2022/12/22 19:25");//String Convertida em DateTime.
		var date3 = DateTime.Now;//Mostra a data atual.
		var date4 = DateTime.Today; //Apenas a data, sem horário. 

		Console.WriteLine(date1);
		Console.WriteLine(date2);
		Console.WriteLine(date3);
		Console.WriteLine(date4);

		Console.WriteLine(date3.ToString("dd/MM/yyyy HH:mm:ss"));//Edita o formato em que ir´asair a data e o horario.


		var dateOffSet1 = new DateTimeOffset(DateTime.Now, new TimeSpan(-3, 0, 0));
        Console.WriteLine(dateOffSet1.LocalDateTime);
        Console.WriteLine(dateOffSet1.UtcDateTime);

	}

	public void SubraindoDatas()
	{
		var date1 = DateTime.Now;
		var date2 = DateTime.Parse("02-01-1995");
		var diff = date1.Subtract(date2);//Faz subtração de uma data para outra.
		//var diff = date1 - date2;

        Console.WriteLine((int)diff.TotalDays);//Faz uma conta de datas.
        Console.WriteLine((int)diff.TotalHours);//Faz calculo de horas entre uma data e outra.
	}


	public void AdicionandoDiasMesAno()
	{
		var date1 = DateTime.Now;
		//Adiciona dias mês e ano dependendo do método que eu chamar. 
		Console.WriteLine(date1.AddDays(3).ToString("dd-MM-yyyy HH:mm:ss"));
		Console.WriteLine(date1.AddMonths(3).ToString("dd-MM-yyyy HH:mm:ss"));
		Console.WriteLine(date1.AddYears(3).ToString("dd-MM-yyyy HH:mm:ss"));
	}

	public void AdicionandoHoraMinutoSegundos()
	{
        var date1 = DateTime.Now;
		//Adiciona tempo
        Console.WriteLine(date1.AddHours(3).ToString("HH:mm:ss"));
        Console.WriteLine(date1.AddMinutes(3).ToString("HH:mm:ss"));
        Console.WriteLine(date1.AddSeconds(3).ToString("HH:mm:ss"));
    }

    public void AulaDiaDaSemana()
    {
        var date1 = DateTime.Now;
        //Pega qual dia da semana estou. 
        Console.WriteLine(date1.DayOfWeek);
    }

    public void AulaDateOnly()
    {
		//Trabalha apenas com datas.
        var somenteData =  DateOnly.Parse("2022-02-01");
	
        Console.WriteLine(somenteData.ToString("dd/MM/yyyy"));
        
    }

    public void AulaTimeOnly()
    {
		//Trabalha apenas com datas.
		var outraVariavel = new TimeOnly(12, 23, 50); //Outra forma de declarar.
        var somenteData = TimeOnly.Parse("23:01:23");

        Console.WriteLine(somenteData.ToString("HH:mm:ss"));

    }
}
