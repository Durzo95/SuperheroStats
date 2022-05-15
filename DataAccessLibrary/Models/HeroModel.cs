namespace SuperheroStats.Data
{
    public class HeroModel
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
}
