using System.Collections.Generic;

namespace FaceRecognition.Transcription;

public class LetterDictionary
{
    public static Dictionary<string, string> Gost { get; } = new();

    public static void FillDictionary()
    {
        Gost.Add("Є", "EH");
        Gost.Add("І", "I");
        Gost.Add("і", "i");
        Gost.Add("№", "#");
        Gost.Add("є", "eh");
        Gost.Add("А", "A");
        Gost.Add("Б", "B");
        Gost.Add("В", "V");
        Gost.Add("Г", "G");
        Gost.Add("Д", "D");
        Gost.Add("Е", "E");
        Gost.Add("Ё", "JO");
        Gost.Add("Ж", "ZH");
        Gost.Add("З", "Z");
        Gost.Add("И", "I");
        Gost.Add("Й", "JJ");
        Gost.Add("К", "K");
        Gost.Add("Л", "L");
        Gost.Add("М", "M");
        Gost.Add("Н", "N");
        Gost.Add("О", "O");
        Gost.Add("П", "P");
        Gost.Add("Р", "R");
        Gost.Add("С", "S");
        Gost.Add("Т", "T");
        Gost.Add("У", "U");
        Gost.Add("Ф", "F");
        Gost.Add("Х", "KH");
        Gost.Add("Ц", "C");
        Gost.Add("Ч", "CH");
        Gost.Add("Ш", "SH");
        Gost.Add("Щ", "SHH");
        Gost.Add("Ъ", "'");
        Gost.Add("Ы", "Y");
        Gost.Add("Ь", "");
        Gost.Add("Э", "EH");
        Gost.Add("Ю", "YU");
        Gost.Add("Я", "YA");
        Gost.Add("а", "a");
        Gost.Add("б", "b");
        Gost.Add("в", "v");
        Gost.Add("г", "g");
        Gost.Add("д", "d");
        Gost.Add("е", "e");
        Gost.Add("ё", "jo");
        Gost.Add("ж", "zh");
        Gost.Add("з", "z");
        Gost.Add("и", "i");
        Gost.Add("й", "jj");
        Gost.Add("к", "k");
        Gost.Add("л", "l");
        Gost.Add("м", "m");
        Gost.Add("н", "n");
        Gost.Add("о", "o");
        Gost.Add("п", "p");
        Gost.Add("р", "r");
        Gost.Add("с", "s");
        Gost.Add("т", "t");
        Gost.Add("у", "u");
        Gost.Add("ф", "f");
        Gost.Add("х", "kh");
        Gost.Add("ц", "c");
        Gost.Add("ч", "ch");
        Gost.Add("ш", "sh");
        Gost.Add("щ", "shh");
        Gost.Add("ъ", "");
        Gost.Add("ы", "y");
        Gost.Add("ь", "");
        Gost.Add("э", "eh");
        Gost.Add("ю", "yu");
        Gost.Add("я", "ya");
        Gost.Add("«", "");
        Gost.Add("»", "");
        Gost.Add("—", "-");
        Gost.Add(" ", "-");
    }
}