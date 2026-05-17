using Newtonsoft.Json;

ViewFiles();

PrintDifferentLanguages();
TemperatureConversion();
DirectoryOperations();

static void TemperatureConversion()
{
    int fahrenheit = 94;
    decimal celsius = (fahrenheit - 32m) * (5m / 9m);
    Console.WriteLine("The temperature is " + celsius + " Celsius.");
}
static IEnumerable<string> FindFiles(string folderName)
{
    List<string> salesFiles = new List<string>();

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    foreach (var file in foundFiles)
    {
        var extension = Path.GetExtension(file);
        if (extension == ".json")
        {
            salesFiles.Add(file);
        }
    }

    return salesFiles;
}

static double CalculateSalesTotal(IEnumerable<string> salesFiles)
{
    double salesTotal = 0;

    // Loop over each file path in salesFiles
    foreach (var file in salesFiles)
    {
        // Read the contents of the file
        string salesJson = File.ReadAllText(file);

        // Parse the contents as JSON
        SalesData? data = JsonConvert.DeserializeObject<SalesData?>(salesJson);

        // Add the amount found in the Total field to the salesTotal variable
        salesTotal += data?.Total ?? 0;
    }

    return salesTotal;
}

static void PrintDifferentLanguages()
{
    // Kon'nichiwa World
    Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
    Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
    Console.WriteLine("Invoice: 1021\t\tComplete!");
    Console.WriteLine("Invoice: 1022\t\tComplete!");
    Console.Write("\nOutput Directory:\t");
    Console.Write(@"c:\invoices");
    // To generate Japanese invoices:
    // Nihon no seikyū-sho o seisei suru ni wa:
    Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
    // User command to run an application
    Console.WriteLine(@"c:\invoices\app.exe -j");

    string projectName = "ACME";
    string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
    Console.WriteLine($"View English output:\n\t{englishLocation}\n");

    string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
    string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
    Console.WriteLine($"{russianMessage}:\n\t{russianLocation}\n");
}

static void DirectoryOperations()
{
    Console.WriteLine(Directory.GetCurrentDirectory());
    string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    Console.WriteLine($"stores{Path.DirectorySeparatorChar}201");
    Console.WriteLine(Path.Combine("stores", "201"));
    Console.WriteLine(Path.GetExtension("sales.json"));
    string fileName = $"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales{Path.DirectorySeparatorChar}sales.json";

    FileInfo info = new(fileName);

    Console.WriteLine($@"DocPath: {docPath}{Environment.NewLine}
    Full Name: {info.FullName}{Environment.NewLine}
    Directory: {info.Directory}{Environment.NewLine}
    Extension: {info.Extension}{Environment.NewLine}
    Create Date: {info.CreationTime}"); // And many more
}

static void ViewFiles()
{
    var currentDirectory = Directory.GetCurrentDirectory();
    var storesDirectory = Path.Combine(currentDirectory, "stores");

    var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");
    Directory.CreateDirectory(salesTotalDir);

    var salesFiles = FindFiles(storesDirectory);

    var salesTotal = CalculateSalesTotal(salesFiles);

    File.WriteAllText(Path.Combine(salesTotalDir, "totals.txt"), $"{salesTotal}{Environment.NewLine}");
}

record SalesData(double Total);