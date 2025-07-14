namespace ConsoleApp1.FileSettings
{
    public abstract class FileHandling : IWriteAndReadFile
    {
        public void WriteTxt(string FilePath, List<string> allrecips)
        {
            File.WriteAllText(FilePath, FromStringToTxt(allrecips));
        }

        protected abstract string FromStringToTxt(List<string> allrecips);

        public List<string> ReadTxt(string filePath)
        {
            if (File.Exists(filePath))
            {
                var FileContent = File.ReadAllText(filePath);
                return FromTxtToSting(FileContent);
            }
            return new List<string>();

        }

        protected abstract List<string> FromTxtToSting(string fileContent);
    }
}
