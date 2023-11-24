[TestClass]
public class ModelTests
{
    [TestMethod]
    public void ConvertToUppercase_onlylowercase()
    {
        // Arrange
        Model model = new Model();
        string input = "maison";

        // Act
        string result = model.ConvertToUppercase(input);

        // Assert
        Assert.AreEqual("MAISON", result);
    }

    [TestMethod]
    public void ConvertToUppercase_lowercaseandNumbers()
    {
        // Arrange
        Model model = new Model();
        string input = "Corse123";

        // Act
        string result = model.ConvertToUppercase(input);

        // Assert
        Assert.AreEqual("CORSE123", result);
    }

    [TestMethod]
    public void ConvertToUppercase_ValidInput_ReturnsUppercaseString_exadecimal()
    {
        // Arrange
        Model model = new Model();
        string input = "%&ciel";

        // Act
        string result = model.ConvertToUppercase(input);

        // Assert
        Assert.AreEqual("%&CIEL", result);
    }

    [TestMethod]
    public void ConvertToUppercase_ValidInput_ReturnsUppercaseString_all()
    {
        // Arrange
        Model model = new Model();
        string input = "!*port";

        // Act
        string result = model.ConvertToUppercase(input);

        // Assert
        Assert.AreEqual("!*PORT", result);
    }

    [TestMethod]
    public void ConvertToUppercase_TooLongInput_ReturnsErrorMessage()
    {
        // Arrange
        Model model = new Model();
        string input = "maisonnette";

        // Act
        string result = model.ConvertToUppercase(input);

        // Assert
        Assert.AreEqual("Chaîne trop longue (8 caractères maximum).", result);
    }
}
