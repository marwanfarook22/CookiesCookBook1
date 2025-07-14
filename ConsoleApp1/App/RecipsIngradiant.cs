

using ConsoleApp1.FileSettings;

namespace ConsoleApp1.App
{
    public class RecipsIngradiant : IRecipsIngradiant
    {
        private readonly IWriteAndReadFile _writeAndReadFile;
        private readonly IRecipsColliction _recipsColliction;

        private const string Separetor = ",";



        public RecipsIngradiant(IWriteAndReadFile writeAndReadFile, IRecipsColliction recipsColliction)
        {
            _writeAndReadFile = writeAndReadFile;
            _recipsColliction = recipsColliction;
        }
        public List<Recips.Recips> ReadAllExisting(string filePath)
        {
            List<string> readStringId = _writeAndReadFile.ReadTxt(filePath);

            var read = new List<Recips.Recips>();

            foreach (var item in readStringId)
            {
                var recips = getrecips(item);
                read.Add(recips);
            }
            return read;

        }

        private Recips.Recips getrecips(string recipsId)
        {
            var TextualId = recipsId.Split(Separetor);
            var ingradiants = new List<ingradiants>();
            foreach (var textualID in TextualId)
            {
                var IntId = int.Parse(textualID);
                var Recips = _recipsColliction.GetSameID(IntId);
                ingradiants.Add(Recips);
            }

            return new Recips.Recips(ingradiants);

        }

        public void Write(string filePath, List<Recips.Recips> allRecips)
        {
            var ingradiantsAsStrings = new List<string>();
            foreach (var item in allRecips)
            {
                var AllRecipsId = new List<int>();
                foreach (var Ids in item.Ingradiants)
                {
                    AllRecipsId.Add(Ids.Id);

                }
                ingradiantsAsStrings.Add(string.Join(Separetor, AllRecipsId));
            }
            _writeAndReadFile.WriteTxt(filePath, ingradiantsAsStrings);
        }
    }

}
