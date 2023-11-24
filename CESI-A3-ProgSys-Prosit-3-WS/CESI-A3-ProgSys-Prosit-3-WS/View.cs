// View.cs
public class View
{
    public string GetUserInput()
    {
        Console.WriteLine("Entrez une chaîne de caractères (1 à 8 caractères) : ");
        return Console.ReadLine();
    }

    public void DisplayResult(string result)
    {
        Console.WriteLine($"Chaîne affichée : {result}");
    }

    public void WaitForUserInput()
    {
        Console.WriteLine("Appuyez sur une touche pour quitter...");
        Console.ReadKey();
    }
}
