using System.Collections.Generic;

public class DialogViewModel
{
    public IEnumerable<Option> Options {get; set;}
    
    public string this[string index] => Options.SingleOrDefault(n => n.Name == index)?.Value;

    public DialogViewModel(params Option[] options)
    {
        Options = options;
    }
}