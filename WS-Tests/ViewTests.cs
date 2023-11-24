// ViewTests.cs
[TestClass]
public class ViewTests
{
    // Vous ne pouvez pas tester directement Console.ReadLine() et Console.WriteLine()
    // Ces méthodes peuvent être redirigées via TextReader et TextWriter, mais cela peut être compliqué.

    // Vous pouvez tester DisplayResult en redirigeant Console.WriteLine() comme suit :
    [TestMethod]
    public void DisplayResult_ValidInput_WritesToConsole()
    {
        // Arrange
        View view = new View();
        string result = "MAISON";

        // Act
        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);
            view.DisplayResult(result);
            string expected = $"Chaîne affichée : {result}{Environment.NewLine}";

            // Assert
            Assert.AreEqual(expected, sw.ToString());
        }
    }
}
