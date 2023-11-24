
public class Model
{
    public string ConvertToUppercase(string input)
    {
        if (input.Length > 8)
        {
            return "Chaîne trop longue (8 caractères maximum).";
        }
        return input.ToUpper();
    }
}
