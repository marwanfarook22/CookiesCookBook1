namespace ConsoleApp1.App
{
    public interface IRecipsIngradiant
    {
        List<Recips.Recips> ReadAllExisting(string filePath);
        void Write(string filePath, List<Recips.Recips> allRecips);
    }

}
