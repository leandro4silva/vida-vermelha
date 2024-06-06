using Bogus;
using VidaVermelha.Domain.Entity;
using VidaVermelha.UtilsTests.Base;

namespace VidaVermelha.UtilsTests.Factories;

public class DoadorFactory : LazyFakerBuilder<Doador>
{
    public static DoadorFactory Instance { get; } = new();

    protected override Faker<Doador> Factory()
    {
        return new Faker<Doador>()
        .RuleFor(d => d.Id, Guid.NewGuid())
        .RuleFor(d => d.NomeCompleto, f => f.Name.FullName())
        .RuleFor(d => d.Email, f => f.Internet.Email())
        .RuleFor(d => d.DataNascimento, f => f.Date.Past(30, DateTime.Now.AddYears(-18)))
        .RuleFor(d => d.Genero, f => f.PickRandom(new[] { "Masculino", "Feminino", "Outro" }))
        .RuleFor(d => d.Peso, f => f.Random.Decimal(50, 100))
        .RuleFor(d => d.TipoSanguineo, f => f.PickRandom(new[] { "A", "B", "AB", "O" }))
        .RuleFor(d => d.FatorRh, f => f.PickRandom(new[] { "positivo", "negativo" }));
    }
}
