using VidaVermelha.UtilsTests.Factories;
using DomainEntity = VidaVermelha.Domain.Entity;

namespace VidaVermelha.UnitTests.Domain.Entity.Endereco;

public class EnderecoTestFixture
{
    public DomainEntity.Endereco GetExemploEndereco()
    {
        return EnderecoFactory.Instance.Build();
    }

    public DomainEntity.Endereco GetExemploEnderecoWithDoador()
    {
        var endereco = EnderecoFactory.Instance.Build();
        var doador = DoadorFactory.Instance.Build();

        endereco.Doador = doador;
        endereco.DoadorId = doador.Id;

        return endereco;
    }
}

[CollectionDefinition(nameof(EnderecoTestFixture))]
public class EnderecoTestFixtureColletion : ICollectionFixture<EnderecoTestFixture> { }
