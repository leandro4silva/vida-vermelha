using VidaVermelha.Domain.SeedWork;

namespace VidaVermelha.Domain.Entity;

public class EstoqueSangue : BaseEntity
{
    public string? TipoSanguineo { get; set; }
    public string? FatorRh { get; set; }
    public int QuantidadeML { get; set; }
}
