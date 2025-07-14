namespace ConsoleApp1.Recips
{
    public interface IRecipsColliction
    {
        IEnumerable<ingradiants> Allingradiant { get; }

        ingradiants GetSameID(int ID);
    }



}
