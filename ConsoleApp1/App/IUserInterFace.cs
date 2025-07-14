namespace ConsoleApp1.App
{
    public interface IUserInterFace
    {
        void CreateNewRecips();
        void Exit();
        void PrintingExistingRecips(List<Recips.Recips> allRecips);
        IEnumerable<ingradiants> ReadUserRecips();
        void ShowMessage(string message);
    }

}
