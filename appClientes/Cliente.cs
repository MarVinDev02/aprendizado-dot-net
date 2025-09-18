namespace Cadastro;

public class Cliente
{
    public int Id { get; set; }
    public String? Nome { get; set; }
    public DateOnly DataNascimento { get; set; }
    public DateTime CadastradoEm { get; set; }
    public Decimal Desconto { get; set; }

}