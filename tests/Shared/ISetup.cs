namespace Shared;

public interface ISetup<TService>
{
    public TService Service { get; set; }
    TService Reinitialize();
}
