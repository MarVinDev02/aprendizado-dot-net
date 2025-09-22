using System.Text;

namespace Cadastro;

public class Cliente
{
    private int dataNascimento;
    private DateOnly dataCadastro;

    public int Id { get; set; }
    public string? Nome { get; set; }
    public DateOnly DataNascimento { get; set; }
    public Decimal Desconto { get; set; }
    public DateTime CadastradoEm { get; set; }

}