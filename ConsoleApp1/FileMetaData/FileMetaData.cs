

namespace ConsoleApp1.FileMetaData
{
    public class FileMetaData
    {
        public string Name { get; }
        public FileFormat FileType { get; }
        public FileMetaData(string name, FileFormat fileType)
        {
            Name = name;
            FileType = fileType;
        }
        public string path() => $"{Name}.{FileType.ExtinsonsFile()}";

    }
}
