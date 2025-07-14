using ConsoleApp1.Recips.Ingradiants;

namespace ConsoleApp1.Recips
{
    public class AllRecipsColliction : IRecipsColliction
    {
        public IEnumerable<ingradiants> Allingradiant { get; } = new List<ingradiants>()
    {
        new Cocoapowder(),
        new Cinnamon(),
        new Cardamom(),
        new Chochlate(),
        new Suger(),
        new Wheatflour(),
        new Butter(),
        new Cocountflour(),
    };

        public ingradiants GetSameID(int ID)
        {
            foreach (var item in Allingradiant)
            {
                if (item.Id == ID)
                {
                    return item;
                }

            }
            return null;

        }
    }



}
