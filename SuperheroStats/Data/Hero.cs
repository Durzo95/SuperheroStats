namespace SuperheroStats.Data
{
    public class Hero
    {
        public int id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public Powerstats powerstats { get; set; }
        public Appearance appearance { get; set; }
        public Biography biography { get; set; }
        public Work work { get; set; }
        public Connections connections { get; set; }
        public Images images { get; set; }

    }
    public class Powerstats
    {
        public int intelligence { get; set; }
        public int strength { get; set; }
        public int speed { get; set; }
        public int durability { get; set; }
        public int power { get; set; }
        public int combat { get; set; }

    }
    public class Appearance
    {
        public string gender { get; set; }
        public string race { get; set; }
        public IList<string> height { get; set; }
        public IList<string> weight { get; set; }
        public string eyeColor { get; set; }
        public string hairColor { get; set; }

    }
    public class Biography
    {
        public string fullName { get; set; }
        public string alterEgos { get; set; }
        public IList<string> aliases { get; set; }
        public string placeOfBirth { get; set; }
        public string firstAppearance { get; set; }
        public string publisher { get; set; }
        public string alignment { get; set; }

    }
    public class Work
    {
        public string occupation { get; set; }
        public string Base { get; set; }

    }
    public class Connections
    {
        public string groupAffiliation { get; set; }
        public string relatives { get; set; }

    }
    public class Images
    {
        public string xs { get; set; }
        public string sm { get; set; }
        public string md { get; set; }
        public string lg { get; set; }

    }
    
}
