namespace StringLib;

public class StringLibrary {

    public string Concat(string str1, string str2) {
        return $"{str1} {str2}"; 
    }

    public string ToUpperEveryOther(string str) {
        var toUpper = true;
        var converted = string.Empty;
        foreach(var ch in str.ToCharArray()) {
            if(!char.IsLetter(ch)) {
                converted += ch;
                continue;
            }
            if(toUpper) {
                converted += ch.ToString().ToUpper();
            } else {
                converted += ch.ToString().ToLower();
            }
            toUpper = !toUpper;
        }
            return converted;
    }
}
