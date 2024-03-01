namespace MindworkingTest.Repository.Repositories;

public abstract class RepositoryBase<TContext>
{
    public virtual TContext Context { get; }
    public RepositoryBase(TContext context)
    {
        Context = context;
    }
}