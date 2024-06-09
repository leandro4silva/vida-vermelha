using FluentAssertions;
using DomainEntity = VidaVermelha.Domain.Entity;

namespace VidaVermelha.UnitTests.Domain.Entity.Doador;

[Collection(nameof(DoadorTestFixture))]
public class DoadorTest
{
    private readonly DoadorTestFixture _fixture;

    public DoadorTest(DoadorTestFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact(DisplayName = nameof(Instantiate))]
    [Trait("Domain", "Doador - Entity")]
    public void Instantiate()
    {
        var validDoador = _fixture.GetExemploDoador();

        var doador = new DomainEntity.Doador()
        {
            NomeCompleto = validDoador.NomeCompleto,
            Email = validDoador.Email,
            DataNascimento = validDoador.DataNascimento,
            FatorRh = validDoador.FatorRh,
            Genero = validDoador.Genero,
            Peso = validDoador.Peso,
            TipoSanguineo = validDoador.TipoSanguineo,
            Doacoes = validDoador.Doacoes,
            Endereco = validDoador.Endereco
        };

        doador.Should().NotBeNull();
        doador.Id.Should().NotBeEmpty();
        doador.NomeCompleto.Should().Be(validDoador.NomeCompleto);
        doador.Email.Should().Be(validDoador.Email);
        doador.DataNascimento.Should().Be(validDoador.DataNascimento);
        doador.FatorRh.Should().Be(validDoador.FatorRh);
        doador.Genero.Should().Be(validDoador.Genero);
        doador.Peso.Should().Be(validDoador.Peso);
        doador.TipoSanguineo.Should().Be(validDoador.TipoSanguineo);
        doador.Doacoes.Should().BeEmpty();
        doador.Endereco.Should().BeNull();
    }

    [Fact(DisplayName = nameof(InstantiateWithDoacoes))]
    [Trait("Domain", "Doador - Entity")]
    public void InstantiateWithDoacoes()    
    {
        var validDoador = _fixture.GetExemploDoadorWithDoacao();

        var doador = new DomainEntity.Doador()
        {
            NomeCompleto = validDoador.NomeCompleto,
            Email = validDoador.Email,
            DataNascimento = validDoador.DataNascimento,
            FatorRh = validDoador.FatorRh,
            Genero = validDoador.Genero,
            Peso = validDoador.Peso,
            TipoSanguineo = validDoador.TipoSanguineo,
            Doacoes = validDoador.Doacoes,
            Endereco = validDoador.Endereco
        };

        doador.Should().NotBeNull();
        doador.Id.Should().NotBeEmpty();
        doador.NomeCompleto.Should().Be(validDoador.NomeCompleto);
        doador.Email.Should().Be(validDoador.Email);
        doador.DataNascimento.Should().Be(validDoador.DataNascimento);
        doador.FatorRh.Should().Be(validDoador.FatorRh);
        doador.Genero.Should().Be(validDoador.Genero);
        doador.Peso.Should().Be(validDoador.Peso);
        doador.TipoSanguineo.Should().Be(validDoador.TipoSanguineo);
        doador.Doacoes.Should().NotBeEmpty();
        doador.Endereco.Should().BeNull();

        foreach (var doacao in validDoador.Doacoes!)
        {
            var exampleDocao = validDoador.Doacoes.Find(
                x => x.Id == doacao.Id
            );

            doacao.QuantidadeML.Should().Be(exampleDocao!.QuantidadeML);
            doacao.DataDoacao.Should().Be(exampleDocao.DataDoacao);
            doacao.Doador.Should().Be(exampleDocao.Doador);
            doacao.DoadorId.Should().Be(exampleDocao.DoadorId);
        }
    }

    [Fact(DisplayName = nameof(InstantiateWithDoacoesAndEndereco))]
    [Trait("Domain", "Doador - Entity")]
    public void InstantiateWithDoacoesAndEndereco()
    {
        var validDoador = _fixture.GetExemploDoadorWithEnderecoAndDoacao();

        var doador = new DomainEntity.Doador()
        {
            NomeCompleto = validDoador.NomeCompleto,
            Email = validDoador.Email,
            DataNascimento = validDoador.DataNascimento,
            FatorRh = validDoador.FatorRh,
            Genero = validDoador.Genero,
            Peso = validDoador.Peso,
            TipoSanguineo = validDoador.TipoSanguineo,
            Doacoes = validDoador.Doacoes,
            Endereco = validDoador.Endereco
        };

        doador.Should().NotBeNull();
        doador.Id.Should().NotBeEmpty();
        doador.NomeCompleto.Should().Be(validDoador.NomeCompleto);
        doador.Email.Should().Be(validDoador.Email);
        doador.DataNascimento.Should().Be(validDoador.DataNascimento);
        doador.FatorRh.Should().Be(validDoador.FatorRh);
        doador.Genero.Should().Be(validDoador.Genero);
        doador.Peso.Should().Be(validDoador.Peso);
        doador.TipoSanguineo.Should().Be(validDoador.TipoSanguineo);
        doador.Doacoes.Should().NotBeEmpty();

        foreach (var doacao in validDoador.Doacoes!)
        {
            var exampleDocao = validDoador.Doacoes.Find(
                x => x.Id == doacao.Id
            );

            doacao.Id.Should().Be(exampleDocao!.Id); 
            doacao.QuantidadeML.Should().Be(exampleDocao.QuantidadeML);
            doacao.DataDoacao.Should().Be(exampleDocao.DataDoacao);
            doacao.Doador.Should().Be(exampleDocao.Doador);
            doacao.DoadorId.Should().Be(exampleDocao.DoadorId);
        }

        doador.Endereco.Should().NotBeNull();
        doador.Endereco!.Id.Should().Be(validDoador.Endereco!.Id);
        doador.Endereco!.Cidade.Should().Be(validDoador.Endereco.Cidade);
        doador.Endereco!.CEP.Should().Be(validDoador.Endereco.CEP);
        doador.Endereco!.Estado.Should().Be(validDoador.Endereco.Estado);
        doador.Endereco!.Logradouro.Should().Be(validDoador.Endereco.Logradouro);
        doador.Endereco!.DoadorId.Should().Be(validDoador.Endereco.DoadorId);
        doador.Endereco!.Doador.Should().Be(validDoador.Endereco.Doador);
    }
}
