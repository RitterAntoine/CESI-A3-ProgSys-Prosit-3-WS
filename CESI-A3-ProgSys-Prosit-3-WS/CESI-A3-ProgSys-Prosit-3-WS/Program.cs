// Program.cs
using System.Reflection;
namespace CESI_A3_ProgSys_Prosit_3_WS;

class Program
{
    static void Main(string[] args)
    {
        Model model = new Model();
        View view = new View();
        ViewModel viewModel = new ViewModel(model, view);

        viewModel.Run();
    }
}
