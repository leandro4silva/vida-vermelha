using VidaVermelha.UnitTests.Domain.Entity.Endereco;

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

    }
}
