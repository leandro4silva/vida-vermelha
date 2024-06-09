using VidaVermelha.UtilsTests.Factories;
using DomainEntity = VidaVermelha.Domain.Entity;

namespace VidaVermelha.UnitTests.Domain.Entity.EstoqueSangue;

public class EstoqueSangueFixture
{
    public DomainEntity.EstoqueSangue GetExampleEstoqueSangue()
    {
        return EstoqueSangueFactory.Instance.Build();
    }
}

[CollectionDefinition(nameof(EstoqueSangueFixture))]
public class EstoqueSangueFixtureColletion : ICollectionFixture<EstoqueSangueFixture> { }