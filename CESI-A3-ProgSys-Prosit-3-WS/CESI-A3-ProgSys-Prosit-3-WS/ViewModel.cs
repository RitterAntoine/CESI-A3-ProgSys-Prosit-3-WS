// ViewModel.cs
public class ViewModel
{
    private readonly Model _model;
    private readonly View _view;

    public ViewModel(Model model, View view)
    {
        _model = model;
        _view = view;
    }

    public void Run()
    {
        string userInput = _view.GetUserInput();
        string result = _model.ConvertToUppercase(userInput);
        _view.DisplayResult(result);
        _view.WaitForUserInput();
    }
}
