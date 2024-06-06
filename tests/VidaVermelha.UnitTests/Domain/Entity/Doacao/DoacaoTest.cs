using DomainEntity = VidaVermelha.Domain.Entity;
using FluentAssertions;

namespace VidaVermelha.UnitTests.Domain.Entity.Doacao;

[Collection(nameof(DoacaoTestFixture))]
public class DoacaoTest
{
    private readonly DoacaoTestFixture _fixture;

    public DoacaoTest(DoacaoTestFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact(DisplayName = nameof(Instantiate))]
    [Trait("Domain", "Doacao - Entity")]
    public void Instantiate()
    {
        var validDoacao = _fixture.GetValidDoacao();

        var doacao = new DomainEntity.Doacao()
        {
            QuantidadeML = validDoacao.QuantidadeML,
            DataDoacao = validDoacao.DataDoacao,
        };

        doacao.Should().NotBeNull();
        doacao.Id.Should().NotBeEmpty();
        doacao.QuantidadeML.Should().Be(validDoacao.QuantidadeML);
        doacao.DataDoacao.Should().NotBeSameDateAs(default);
    }

    [Fact(DisplayName = nameof(InstantiateWithoutDataDoacao))]
    [Trait("Domain", "Doacao - Entity")]
    public void InstantiateWithoutDataDoacao()
    {
        var validDoacao = _fixture.GetValidDoacao();
        
        var datetimeBefore = DateTime.Now;
        var doacao = new DomainEntity.Doacao()
        {
            QuantidadeML = validDoacao.QuantidadeML,
        };
        var datetimeAfter = DateTime.Now.AddSeconds(1);

        doacao.Should().NotBeNull();
        doacao.Id.Should().NotBeEmpty();
        doacao.QuantidadeML.Should().Be(validDoacao.QuantidadeML);
        doacao.DataDoacao.Should().NotBeSameDateAs(default);

        (doacao.DataDoacao >= datetimeBefore).Should().BeTrue();
        (doacao.DataDoacao <= datetimeAfter).Should().BeTrue();
    }

    [Fact(DisplayName = nameof(InstantiateWithDoador))]
    [Trait("Domain", "Doacao - Entity")]
    public void InstantiateWithDoador()
    { 
        var validDoacao = _fixture.GetValidDoacaoWithDoador();

        var doacao = new DomainEntity.Doacao()
        {
            QuantidadeML = validDoacao.QuantidadeML,
            DataDoacao = validDoacao.DataDoacao,
            Doador = validDoacao.Doador,
            DoadorId = validDoacao.DoadorId
        };

        doacao.Should().NotBeNull();
        doacao.Id.Should().NotBeEmpty();
        doacao.QuantidadeML.Should().Be(validDoacao.QuantidadeML);
        doacao.DoadorId.Should().Be(validDoacao.DoadorId);
        doacao.Doador.Should().Be(validDoacao.Doador);
        doacao.DataDoacao.Should().NotBeSameDateAs(default);
    }
}
