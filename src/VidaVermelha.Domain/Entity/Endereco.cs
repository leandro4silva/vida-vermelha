using VidaVermelha.Domain.SeedWork;

namespace VidaVermelha.Domain.Entity;
public class Endereco : BaseEntity
{
    public string? Logradouro { get; set; }
    public string? Cidade { get; set; }
    public string? Estado { get; set; }
    public string? CEP { get; set; }

    public Guid? DoadorId { get; set; }
    public Doador? Doador { get; set; }
}
