public class Entry
{
    DateTime currentTime = DateTime.Now;
    Prompt _promptObj = new Prompt();
    public string _date;
    public string _prompt;
    public string _response; 
    

    public Entry ()
    {
    }

    public void Write ()
    {
        _date = currentTime.ToShortDateString();

        _prompt = _promptObj.getPrompt();
        Console.WriteLine(_prompt);
        Console.Write("> ");
        
        _response = Console.ReadLine();
    }
}    