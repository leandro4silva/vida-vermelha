using Bogus;
using VidaVermelha.Domain.Entity;
using VidaVermelha.UtilsTests.Base;

namespace VidaVermelha.UtilsTests.Factories;

public class DoacaoFactory : LazyFakerBuilder<Doacao>
{
    public static DoacaoFactory Instance { get; } = new();

    protected override Faker<Doacao> Factory()
    {
        return new Faker<Doacao>()
        .RuleFor(d => d.DataDoacao, f => f.Date.Past(1))
        .RuleFor(d => d.QuantidadeML, f => f.Random.Int(420, 500));
    }
}
