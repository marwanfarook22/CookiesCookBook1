namespace ConsoleApp1.FileSettings
{
    public interface IWriteAndReadFile
    {
        void WriteTxt(string FilePath, List<string> allrecips);
        List<string> ReadTxt(string filePath);
    }
}
