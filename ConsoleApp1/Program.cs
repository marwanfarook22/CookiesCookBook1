




using ConsoleApp1.App;
using ConsoleApp1.FileMetaData;
using ConsoleApp1.FileSettings;

try
{
    var AllRecips = new AllRecipsColliction();
    FileFormat filePath = FileFormat.Json;
    const string fileName = "Recips";

    var FileControls = new FileMetaData(fileName, filePath);

    IWriteAndReadFile ControleFile = filePath == FileFormat.Json ?
        new WriteAndReadJson()
        : new WriteAndReadTxt();
    var CookiesRecips = new CookiesRecipsApp(
        new UserInterFace(
            AllRecips
            ),
        new RecipsIngradiant(
           ControleFile
            , AllRecips
            )
        );
    CookiesRecips.Run(FileControls.path());
}
catch (Exception ex)
{
    Console.WriteLine("Sorry! " +
        "We Will Fixed It Soon");
    Console.WriteLine();
    Console.WriteLine("The Erooor Message IS " + ex.Message);
    Console.WriteLine();

    Console.WriteLine("Press Any Key To Esc");
    Console.ReadKey();
}



