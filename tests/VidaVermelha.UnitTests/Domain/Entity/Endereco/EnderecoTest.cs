using FluentAssertions;
using DomainEntity = VidaVermelha.Domain.Entity;

namespace VidaVermelha.UnitTests.Domain.Entity.Endereco;

[Collection(nameof(EnderecoTestFixture))]
public class EnderecoTest
{
    private readonly EnderecoTestFixture _fixture;

    public EnderecoTest(EnderecoTestFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact(DisplayName = nameof(Instantiate))]
    [Trait("Domain", "Endereco - Entity")]
    public void Instantiate()
    {
        var validEndereco = _fixture.GetExemploEndereco();

        var endereco = new DomainEntity.Endereco()
        {
            Cidade = validEndereco.Cidade,
            Estado = validEndereco.Estado,
            Logradouro = validEndereco.Logradouro,
            CEP = validEndereco.CEP,
            Doador = validEndereco.Doador,
            DoadorId = validEndereco.DoadorId
        };

        endereco.Should().NotBeNull();
        endereco.Id.Should().NotBeEmpty();
        endereco.Logradouro.Should().Be(validEndereco.Logradouro);
        endereco.Cidade.Should().Be(validEndereco.Cidade);
        endereco.CEP.Should().Be(validEndereco.CEP);
        endereco.Estado.Should().Be(validEndereco.Estado); 
        endereco.DoadorId.Should().BeNull();
        endereco.Doador.Should().BeNull();
    }

    [Fact(DisplayName = nameof(InstantiateWithDoador))]
    [Trait("Domain", "Endereco - Entity")]
    public void InstantiateWithDoador()
    {
        var validEndereco = _fixture.GetExemploEnderecoWithDoador();

        var endereco = new DomainEntity.Endereco()
        {
            Cidade = validEndereco.Cidade,
            Estado = validEndereco.Estado,
            Logradouro = validEndereco.Logradouro,
            CEP = validEndereco.CEP,
            Doador = validEndereco.Doador,
            DoadorId = validEndereco.DoadorId
        };

        endereco.Should().NotBeNull();
        endereco.Id.Should().NotBeEmpty();
        endereco.Logradouro.Should().Be(validEndereco.Logradouro);
        endereco.Cidade.Should().Be(validEndereco.Cidade);
        endereco.CEP.Should().Be(validEndereco.CEP);
        endereco.Estado.Should().Be(validEndereco.Estado);
        endereco.DoadorId.Should().Be(validEndereco.DoadorId);
        endereco.Doador.Should().Be(validEndereco.Doador);
    }
}
