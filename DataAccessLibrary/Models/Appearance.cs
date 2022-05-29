namespace SuperheroStats.Data;

public class Appearance
{
    public string gender { get; set; }
    public string race { get; set; }
    public IList<string> height { get; set; }
    public IList<string> weight { get; set; }
    public string eyeColor { get; set; }
    public string hairColor { get; set; }

}