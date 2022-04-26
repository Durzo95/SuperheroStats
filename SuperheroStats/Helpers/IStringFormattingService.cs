namespace SuperheroStats.Services;

public interface IStringFormattingService
{
    object DeliminateStringIfList(object value);
    string ToSentenceCase(string str);
    public string ToTitleCase(string str);
}