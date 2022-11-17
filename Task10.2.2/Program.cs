public class SomeClass : IWriter
{
    public void Write()
    {
        throw new NotImplementedException();
    }
}
public interface IWriter
{
    void Write();
}