using VidaVermelha.UtilsTests.Factories;
using DomainEntity = VidaVermelha.Domain.Entity;

namespace VidaVermelha.UnitTests.Domain.Entity.Doador;

public class DoadorTestFixture
{
    public DomainEntity.Doador GetExemploDoador()
    {
        return DoadorFactory.Instance.Build();
    }

    public DomainEntity.Doador GetExemploDoadorWithEndereco()
    {
        var doador = DoadorFactory.Instance.Build();
        var endereco = EnderecoFactory.Instance.Build();

        endereco.DoadorId = doador.Id;
        endereco.Doador = doador;
        
        doador.Endereco = endereco;

        return doador;
    }

    public DomainEntity.Doador GetExemploDoadorWithDoacao()
    {
        var doador = DoadorFactory.Instance.Build();
        var doacao = DoacaoFactory.Instance.Build();

        doacao.DoadorId = doador.Id;
        doacao.Doador = doador;

        doador.Doacoes!.Add(doacao);

        return doador;
    }

    public DomainEntity.Doador GetExemploDoadorWithEnderecoAndDoacao()
    {
        var doador = DoadorFactory.Instance.Build();
        var doacao = DoacaoFactory.Instance.Build();
        var endereco = EnderecoFactory.Instance.Build();

        endereco.DoadorId = doador.Id;
        endereco.Doador = doador;

        doador.Endereco = endereco;

        doacao.DoadorId = doador.Id;
        doacao.Doador = doador;

        doador.Doacoes!.Add(doacao);

        return doador;
    }
}

[CollectionDefinition(nameof(DoadorTestFixture))]
public class DoadorTestFixtureColletion : ICollectionFixture<DoadorTestFixture> { }