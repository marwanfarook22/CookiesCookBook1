

namespace ConsoleApp1.FileMetaData
{
    public static class FileExtinsons
    {
        public static string ExtinsonsFile(this FileFormat FileType) => FileType == FileFormat.Json ? "Json" : "Txt";


    }
}
