public class SomeClass : IWorker
{
    void IWorker.Build()
    {
        throw new NotImplementedException();
    }
}
public interface IWorker
{
    public void Build();
}