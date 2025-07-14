global using ConsoleApp1.Recips;
namespace ConsoleApp1.Recips
{
    public class Recips
    {
        public IEnumerable<ingradiants> Ingradiants { get; }
        public Recips(IEnumerable<ingradiants> ingradiants)
        {
            Ingradiants = ingradiants;

        }
        public override string ToString()
        {
            var StringListConvert = new List<string>();
            foreach (var item in Ingradiants)
            {
                StringListConvert.Add(item.Name + "." + item.Instructionofpreparing());

            }
            return string.Join(Environment.NewLine, StringListConvert);
        }

    }
}
