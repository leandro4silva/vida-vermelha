using Bogus;
using VidaVermelha.Domain.Entity;
using VidaVermelha.UtilsTests.Base;

namespace VidaVermelha.UtilsTests.Factories;

public class EnderecoFactory : LazyFakerBuilder<Endereco>
{
    public static EnderecoFactory Instance { get; } = new();

    protected override Faker<Endereco> Factory()
    {
        return new Faker<Endereco>()
        .RuleFor(e => e.Id, f => Guid.NewGuid())
        .RuleFor(e => e.Logradouro, f => f.Address.StreetAddress())
        .RuleFor(e => e.Cidade, f => f.Address.City())
        .RuleFor(e => e.Estado, f => f.Address.State())
        .RuleFor(e => e.CEP, f => f.Address.ZipCode());
    }
}
