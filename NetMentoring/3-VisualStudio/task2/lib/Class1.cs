namespace HelloLib;

public class Hello
{
    public string GetGreeting(string name)
    {
        string current_time = DateTime.Now.ToString("HH:mm:ss");
        return ($"{current_time}: Hello {name}!");
    }
}
