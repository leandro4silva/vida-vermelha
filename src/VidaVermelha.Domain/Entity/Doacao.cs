using VidaVermelha.Domain.SeedWork;

namespace VidaVermelha.Domain.Entity;

public class Doacao : BaseEntity
{
    public int QuantidadeML { get; set; }
    public DateTime DataDoacao { get; set; } = DateTime.Now;
    public Guid DoadorId { get; set; }
    public Doador? Doador { get; set; }
}
