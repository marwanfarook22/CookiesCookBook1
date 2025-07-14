namespace ConsoleApp1.App
{
    public class UserInterFace : IUserInterFace
    {
        private IRecipsColliction _allingradiantcolliction { get; }

        public UserInterFace(IRecipsColliction allingradiantcolliction)
        {
            _allingradiantcolliction = allingradiantcolliction;

        }
        public void CreateNewRecips()
        {
            Console.WriteLine(@"Create a new cookie recipe! 
Available ingredients are:");

            foreach (var item in _allingradiantcolliction.Allingradiant)
            {
                Console.WriteLine(item);

            }

        }

        public void Exit()
        {
            Console.WriteLine("Press Any Key To Esc");
            Console.ReadKey();
        }

        public void PrintingExistingRecips(List<Recips.Recips> allRecips)
        {
            Console.WriteLine("Existing recipes are:" + Environment.NewLine);
            int Counter = 1;
            foreach (var item in allRecips)
            {
                Console.WriteLine($"*****{Counter}****");
                Console.WriteLine(item);
                Console.WriteLine();
                Counter++;
            }
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        public IEnumerable<ingradiants> ReadUserRecips()
        {
            bool ShallStop = false;
            var Ingradinats = new List<ingradiants>();
            while (!ShallStop)
            {
                Console.WriteLine("Add an ingredient by its ID or type anything else if finished");
                var userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int ID))
                {
                    var IngradiantResult = _allingradiantcolliction.GetSameID(ID);
                    if (IngradiantResult is not null)
                    {
                        Ingradinats.Add(IngradiantResult);
                    }

                }
                else
                {
                    ShallStop = true;
                }

            }
            return Ingradinats;
        }
    }

}
