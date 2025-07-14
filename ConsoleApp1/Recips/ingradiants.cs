namespace ConsoleApp1.Recips
{
    public abstract class ingradiants
    {
        public abstract string Name { get; }
        public abstract int Id { get; }

        public virtual string Instructionofpreparing() => "Add to other ingredients.";

        public override string ToString() => $"{Id}.{Name}";
    }



}
