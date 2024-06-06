using Bogus;
using FluentAssertions;
using VidaVermelha.Domain.Validation;

namespace VidaVermelha.UnitTests.Domain.Validation;

public class DomainValidationTests
{
    private Faker Faker {  get; set; } = new Faker();

    [Fact(DisplayName = nameof(NotNullOk))]
    [Trait("Domain", "DomainValidation - Validation")]
    public void NotNullOk()
    {
        var value = Faker.Person.FullName;
        Action action = () => DomainValidation.NotNull(value, "Value");

        action.Should().NotThrow();
    }
}
