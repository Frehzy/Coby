using System.Text.RegularExpressions;

namespace FaceRecognition.Transcription;

public static class Transctiption
{
    public static string Front(string text)
    {
        if (LetterDictionary.Gost.Count <= 0)
            LetterDictionary.FillDictionary();

        string output = text;
        output = Regex.Replace(output, @"\s|\.|\(", " ");
        output = Regex.Replace(output, @"\s+", " ");
        output = Regex.Replace(output, @"[^\s\w\d-]", "");
        output = output.Trim();
        foreach (var key in LetterDictionary.Gost)
            output = output.Replace(key.Key, key.Value);

        return output;
    }

    public static string Back(string text)
    {
        if (LetterDictionary.Gost.Count <= 0)
            LetterDictionary.FillDictionary();

        string output = text;
        foreach (var key in LetterDictionary.Gost)
            output = output.Replace(key.Value, key.Key);

        return output;
    }
}