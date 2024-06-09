using DomainEntity = VidaVermelha.Domain.Entity;
using VidaVermelha.UtilsTests.Factories;

namespace VidaVermelha.UnitTests.Domain.Entity.Doacao;

public class DoacaoTestFixture
{
    public DomainEntity.Doacao GetValidDoacao()
    {
        return DoacaoFactory.Instance.Build();
    }

    public DomainEntity.Doacao GetValidDoacaoWithDoador()
    {
        var doador = DoadorFactory.Instance.Build();
        var doacao = DoacaoFactory.Instance.Build();

        doacao.Doador = doador;
        doacao.DoadorId = doador.Id;

        return doacao;
    }
}

[CollectionDefinition(nameof(DoacaoTestFixture))]
public class DoacaoTestFixtureColletion : ICollectionFixture<DoacaoTestFixture> { }
