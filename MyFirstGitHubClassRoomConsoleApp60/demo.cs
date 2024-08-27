namespace MyFirstGitHubClassRoomConsoleApp60;

public class demo
{
    //instans
    private string _navn;
    private string _efternavn;
    
    // Prop
    public string Navn
    {
        get { return _navn; }
        set { _navn = value; }
    }

    public string Efternavn
    {
        get { return _efternavn; }
        set { _efternavn = value; }
    }
    
    //Kons
    public demo(string navn, string efternavn)
    {
        _navn = navn;
        _efternavn = efternavn;
    }
}