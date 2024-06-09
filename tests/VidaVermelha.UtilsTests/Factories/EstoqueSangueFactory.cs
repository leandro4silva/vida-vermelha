using Bogus;
using VidaVermelha.Domain.Entity;
using VidaVermelha.UtilsTests.Base;

namespace VidaVermelha.UtilsTests.Factories;

public class EstoqueSangueFactory : LazyFakerBuilder<EstoqueSangue>
{
    public static EstoqueSangueFactory Instance { get; } = new ();

    protected override Faker<EstoqueSangue> Factory()
    {
        return new Faker<EstoqueSangue>()
            .RuleFor(e => e.TipoSanguineo, f => f.PickRandom(new[] { "A", "B", "AB", "O" }))
            .RuleFor(e => e.QuantidadeML, f => f.Random.Int(420, 500))
            .RuleFor(e => e.FatorRh, f => f.PickRandom(new[] { "positivo", "negativo" }));
    }
}
