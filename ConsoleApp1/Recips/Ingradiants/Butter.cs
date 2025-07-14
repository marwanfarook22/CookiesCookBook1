namespace ConsoleApp1.Recips.Ingradiants
{
    public class Butter : ingradiants
    {
        public override string Name => "Butter";
        public override int Id => 3;

        public override string Instructionofpreparing() => $"Melt on low heat.{base.Instructionofpreparing()}.";

    }



}
