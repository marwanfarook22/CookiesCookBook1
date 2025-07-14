

using System.Text.Json;

namespace ConsoleApp1.FileSettings
{
    public class WriteAndReadJson : FileHandling
    {
        protected override string FromStringToTxt(List<string> allrecips)
        {
            return JsonSerializer.Serialize(allrecips);
        }

        protected override List<string> FromTxtToSting(string fileContent)
        {
            return JsonSerializer.Deserialize<List<string>>(fileContent);
        }
    }
}
