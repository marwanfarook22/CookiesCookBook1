namespace ConsoleApp1.FileSettings
{
    public class WriteAndReadTxt : FileHandling
    {
        private readonly string Sperator = Environment.NewLine;
        protected override string FromStringToTxt(List<string> allrecips)
        {
            return string.Join(Sperator, allrecips);
        }

        protected override List<string> FromTxtToSting(string fileContent)
        {
            return fileContent.Split(Sperator).ToList();
        }
    }
}
