using FluentAssertions;
using DomainEntity = VidaVermelha.Domain.Entity;

namespace VidaVermelha.UnitTests.Domain.Entity.EstoqueSangue;

[Collection(nameof(EstoqueSangueFixture))]
public class EstoqueSangueTest
{
    private readonly EstoqueSangueFixture _fixture;

    public EstoqueSangueTest(EstoqueSangueFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact(DisplayName = nameof(Instantiate))]
    [Trait("Domain", "EstoqueSangue - Entity")]
    public void Instantiate()
    {
        var validEstoqueSangue = _fixture.GetExampleEstoqueSangue();

        var estoqueSangue = new DomainEntity.EstoqueSangue()
        {
            QuantidadeML = validEstoqueSangue.QuantidadeML,
            TipoSanguineo = validEstoqueSangue.TipoSanguineo,
            FatorRh = validEstoqueSangue.FatorRh
        };

        estoqueSangue.Should().NotBeNull();
        estoqueSangue.Id.Should().NotBeEmpty();
        estoqueSangue.QuantidadeML.Should().Be(validEstoqueSangue.QuantidadeML);
        estoqueSangue.TipoSanguineo.Should().Be(validEstoqueSangue.TipoSanguineo);
        estoqueSangue.FatorRh.Should().Be(validEstoqueSangue.FatorRh);
    }
}
