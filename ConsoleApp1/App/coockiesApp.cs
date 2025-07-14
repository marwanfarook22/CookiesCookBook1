namespace ConsoleApp1.App
{
    public class CookiesRecipsApp
    {
        private readonly IRecipsIngradiant _recipsIngradiant;
        private readonly IUserInterFace _userInterface;

        public CookiesRecipsApp(IUserInterFace userInterface, IRecipsIngradiant recipsIngradiant)
        {
            _userInterface = userInterface;
            _recipsIngradiant = recipsIngradiant;
        }

        public void Run(string FilePath)
        {
            /* Read And Printnig old recips  */
            var AllRecips = _recipsIngradiant.ReadAllExisting(FilePath);
            _userInterface.PrintingExistingRecips(AllRecips);
            /*Read And Printnig old recips*/

            /* Show As A Message For New Recips And Show All Ingradinats That Availbale   */
            _userInterface.CreateNewRecips();
            /* Show As A Message For New Recips And Show All Ingradinats That Availbale   */

            /* the User Input and some Validition For Check If The User But A correct Id In Console Or Not    */
            var RecipsPreperd = _userInterface.ReadUserRecips();
            /* the User Input and some Validition For Check If The User But A correct Id In Console Or Not    */

            if (RecipsPreperd.Count() > 0)
            {
                /* add recips we choosen To ListTo show it in End Of app */
                var recips = new Recips.Recips(RecipsPreperd);
                /* add recips we choosen To ListTo show it in End Of app */

                /* add recips we choosen To Old Recips In The File   */
                AllRecips.Add(recips);
                /* add recips we choosen  To Old Recips In The File  */

                /**/
                _recipsIngradiant.Write(FilePath, AllRecips);
                /**/


                /* Print The Recntly Add From The UserInput To The Recips List  */
                _userInterface.ShowMessage("Recipe added:");
                _userInterface.ShowMessage(recips.ToString());
                /* Print The Recntly Add From The UserInput To The Recips List  */
            }
            else
            {
                _userInterface.ShowMessage("“No ingredients have been selected. Recipe will not be saved.” is printed");

            }
            _userInterface.Exit();
        }
    }

}
