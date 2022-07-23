using System.Text;

namespace MorseCodeDecoderLibrary;

public class MorseDecoder
{
    private static readonly IDictionary<string, string> Alphabet = new Dictionary<string, string>() {
        { ".-", "A"}, { "-...", "B"},{ "-.-.", "C"},{ "-..", "D"},
        { ".", "E"}, { "..-.", "F"}, { "--.", "G"}, { "....", "H"},
        { "..", "I"}, { ".---", "J"}, { "-.-", "K"}, { ".-..", "L"},
        { "--", "M"}, { "-.", "N"}, { "---", "O"}, { ".--.", "P"},
        { "--.-", "Q"}, { ".-.", "R"}, { "...", "S"}, { "-", "T"},
        { "..-", "U"}, { "...-", "V"}, { ".--", "W"}, { "-..-", "X"},
        { "-.--", "Y"},{ "--..", "Z"}
    };
    
    private static readonly IDictionary<string, string> ReversedAlphabet = new Dictionary<string, string>() {
        { "A", ".-"}, { "B", "-..."},{ "C", "-.-."},{ "D", "-.."},
        { "E", "."}, { "F", "..-."}, { "G", "--."}, { "H", "...."},
        { "I", ".."}, { "J", ".---"}, { "K", "-.-"}, { "L", ".-.."},
        { "M", "--"}, { "N", "-."}, { "O", "---"}, { "P", ".--."},
        { "Q", "--.-"}, { "R", ".-."}, { "S", "..."}, { "T", "-"},
        { "U", "..-"}, { "V", "...-"}, { "W", ".--"}, { "X", "-..-"},
        { "Y", "-.--"},{ "Z", "--.."}
    };



    public static string DecodeFromMorse(string message, char separator = ' ')
    {
        var str = new StringBuilder();
        
        var msg = message.Split(separator);

        foreach (var s in msg)
            str.Append(Alphabet[s]);
        
        return str.ToString(); 
        
    }

    public static string EncodeToMorse(string message, char separator = ' ')
    {
        var msg = message.ToUpper().Split(' ');

        var str = new StringBuilder();
        
        foreach (var s in msg)
        foreach (var c in s)
            str.Append(ReversedAlphabet[c.ToString()] + separator);

        str.Remove(str.Length-1, 1); // to remove extra separator after last character
        
        return str.ToString();
    }
}