#load DialogViewModel.csx
#load Options.csx

var wpf = Require<Wpf>();

var viewModel = new DialogViewModel(
    new StringOption("Hello", "World"),
    new ButtonOption("Choice", "Yes", "No", "Cancel")
);
wpf.RunApplication(viewModel);
// it waits!!!
Console.WriteLine(viewModel["Hello"]);

