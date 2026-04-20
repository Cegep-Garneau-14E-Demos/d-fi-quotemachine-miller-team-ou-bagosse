using QuoteMachine_ExerciceGit;

Console.WriteLine("Bienvenue dans QuoteMachine!");
Console.WriteLine("Ce projet est collaboratif et utilise le GitHub Flow.");
Console.WriteLine("Développez une application console pour gérer et afficher des citations inspirantes.\n");
Console.WriteLine("Prochaines étapes : implémentez les fonctionnalités dans des branches distinctes.\n");
Console.WriteLine("\n=== Menu Principal ===");
Console.WriteLine("Ajouter une nouvelle quote (A)   Quote random (R)   sauvegarder les quotes (S)   Charger citations (C)");


Console.ReadKey(true);
var manager = new QuoteManager();
string path = "citations.csv";
string choix = Console.ReadLine().ToUpper();
if (choix.Length > 1)
    Console.WriteLine("vous devez avoir un seul charactère");
switch (choix)
{
    case "A":
        AddNewQuote(manager);
        break;
    case "R":
        ShowRandomQuote(manager);
        break;
    case "S":
        SaveQuotesToFile(manager);
        break;
    case "C":
        LoadQuotesFromFile(manager);
        break;
}



static void ShowRandomQuote(QuoteManager manager)
{
    Console.WriteLine("[Simulation] Une citation aléatoire s’afficherait ici.");
    // Exemple futur : Console.WriteLine(manager.GetRandomQuote());
}

static void AddNewQuote(QuoteManager manager)
{
    Console.WriteLine("[Simulation] On ajouterait une nouvelle citation ici.");
    // Exemple futur :
    // Console.Write("Texte : ");
    // var texte = Console.ReadLine();
    // Console.Write("Auteur : ");
    // var auteur = Console.ReadLine();
    // manager.AddQuote(texte, auteur);
    // Console.WriteLine("Citation ajoutée !");
}

static void SaveQuotesToFile(QuoteManager manager)
{
    try
    {
        Console.WriteLine("[Simulation] On sauvegarderait les citations ici.");
        // Exemple futur :
        // manager.SaveToFile("citations.txt");
        //Console.WriteLine("Citations sauvegardées !");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erreur : {ex.Message}");
    }
}

static void LoadQuotesFromFile(QuoteManager manager)
{
    try
    {
        Console.WriteLine("[Simulation] On chargerait les citations ici.");
        // Exemple futur :
        // manager.LoadFromFile("citations.txt");
        //Console.WriteLine("Citations chargées !");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erreur : {ex.Message}");
    }
}

