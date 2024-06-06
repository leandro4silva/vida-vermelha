using Bogus;

namespace VidaVermelha.UtilsTests.Base;

public abstract class LazyFakerBuilder<TEntity>
 where TEntity : class
{
    private readonly Lazy<Faker<TEntity>> lazyFaker;
    private Faker faker { get; set; }

    public virtual TEntity Build() =>
    Faker.Generate();

    protected Faker<TEntity> Faker =>
    lazyFaker.Value;

    protected LazyFakerBuilder()
    {
        lazyFaker = new Lazy<Faker<TEntity>>(
        Factory, isThreadSafe: true);
        faker = new Faker("pt_BR");
    }

    protected abstract Faker<TEntity> Factory();
}
