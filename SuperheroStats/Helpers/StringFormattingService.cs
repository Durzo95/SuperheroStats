using System.Collections;
using System.Globalization;
using System.Text.RegularExpressions;

namespace SuperheroStats.Services
{
    public class StringFormattingService : IStringFormattingService
    {

        private readonly TextInfo _ti = CultureInfo.CurrentCulture.TextInfo;

        // This is for values in the Hero API that have both lists and strings
        // For example, under Hero.Appearance there are some values that are strings and others are lists
        // This function is needed in order to handle the list values
        // This allows us to loop through the values in the razor page without writing if statements in each one to check for type
        public object DeliminateStringIfList(object value)
        {
            // If value is not the Ilist string value type then just return the string value
            if (value is not IList || !value.GetType().IsGenericType)
                return value;
            // Convert object to List<string> in order to use the string.Join method
            return value is IList<string> valueListOfStrings ? string.Join(", ", valueListOfStrings) : "-";
        }
        // Converts pascal case strings into space deliminated string
        // Used for the type names in the classes when looping
        public string ToSentenceCase(string str)
        {
            str = Regex.Replace(str, "[a-z][A-Z]", m => $"{m.Value[0]} {char.ToLower(m.Value[1])}");
            str = _ti.ToTitleCase(str);
            return str;

        }

        public string ToTitleCase(string str)
        {
            return _ti.ToTitleCase(str);
        }
    }
}
