#load Options.csx
#load DialogViewModel.csx
using ScriptCs.Wpf;

var wpf = Require<Wpf>();

var viewModel = new DialogViewModel(
    new StringOption("Hello", "World"),
    new ButtonOption("Choice", "Yes", "No", "Cancel")
);
wpf.RunApplication(viewModel);
// it waits!!!
Console.WriteLine(viewModel["Hello"]);

