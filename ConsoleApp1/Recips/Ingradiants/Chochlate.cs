namespace ConsoleApp1.Recips.Ingradiants
{
    public class Chochlate : ingradiants
    {
        public override string Name => "Chochlate";
        public override int Id => 4;

        public override string Instructionofpreparing() => $"Melt in a water bath.{base.Instructionofpreparing()}";

    }



}
