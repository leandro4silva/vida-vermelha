using VidaVermelha.Domain.SeedWork;

namespace VidaVermelha.Domain.Entity;

public class Doador : BaseEntity
{
    public string? NomeCompleto { get; set; }
    public string? Email { get; set; }
    public DateTime DataNascimento { get; set; }
    public string? Genero { get; set; }
    public decimal Peso { get; set; }
    public string? TipoSanguineo { get; set; }
    public string? FatorRh { get; set; }
    public Endereco? Endereco { get; set; }
    public List<Doacao>? Doacoes { get; set; } = new List<Doacao>();
}
