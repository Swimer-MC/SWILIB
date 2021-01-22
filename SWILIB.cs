using System;
using System.Net;

public class SWILIB
{
    // 21 USEFUL METHODS!!! This update: 22:50 22.01.2021 (First update: 22:50 22.01.2021)
    
    // RandOMIZATION
    public static int Rand(int min, int max)
    {
        return new Random().Next(min, max);
    }
    public static int Rand(int[] ints)
    {
        return ints[Rand(0, ints.Length - 1)];
    }
    public static bool Rand()
    {
        return Rand(1, 2)==1;
    }
    public static string Rand(string[] strings)
    {
        return strings[Rand(0, strings.Length - 1)];
    }
    public static float Rand(float[] floats)
    {
        return floats[Rand(0, floats.Length - 1)];
    }
    public static double Rand(double[] doubles)
    {
        return doubles[Rand(0, doubles.Length - 1)];
    }
    public static char Rand(char[] chars)
    {
        return chars[Rand(0, chars.Length - 1)];
    }
    public static byte Rand(byte[] bytes)
    {
        return bytes[Rand(0, bytes.Length - 1)];
    }
    public static long Rand(long[] longs)
    {
        return longs[Rand(0, longs.Length - 1)];
    }
    public static short Rand(short[] shorts)
    {
        return shorts[Rand(0, shorts.Length - 1)];
    }
    // TRANSLATIONS
    public static string RusKeysToEngKeys(string stringt)
    {
        char[] rus, eng;
        rus = GetRusKeyChars(false, false);
        eng = GetEngKeyChars(false, false);
        string output = stringt;
        for (int i = 0; i < rus.Length; i++)
        {
            output = output.Replace(rus[i], eng[i]);
        }

        return output;
    }
    public static string EngKeysToRusKeys(string stringt)
    {
        char[] rus, eng;
        rus = GetRusKeyChars(false, false);
        eng = GetEngKeyChars(false, false);
        string output = stringt;
        for (int i = 0; i < eng.Length; i++)
        {
            output = output.Replace(eng[i], rus[i]);
        }

        return output;
    }
    public static char[] GetEngKeyChars(bool isOnlyChars,bool uppercase)
    {
        char[] withSymbolsWithRussian =
        {
            'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', '[', ']', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l',
            ';', '\'', 'z', 'x', 'c', 'v', 'b', 'n', 'm', ',', '.', '~'
        };
        char[] withSymbolsWithRussianUppercase =
        {
            'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', '[', ']', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L',
            ';', '\'', 'Z', 'X', 'C', 'V', 'B', 'N', 'M', ',', '.', '~'
        };
        char[] onlyChars =
        {
            'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x',
            'c', 'v', 'b', 'n', 'm'
        };
        char[] onlyCharsUppercase =
        {
            'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Z', 'X',
            'C', 'V', 'B', 'N', 'M'
        };
        if (isOnlyChars)
        {
            if (uppercase)
            {
                return onlyCharsUppercase;
            }
            return onlyChars;
        }

        if (uppercase)
        {
            return withSymbolsWithRussianUppercase;
        }

        return withSymbolsWithRussian;
    }
    public static char[] GetRusKeyChars(bool isOnlyChars,bool uppercase)
    {
        char[] withSymbolsWithRussian =
        {
            'й', 'ц', 'у', 'к', 'е', 'н', 'г', 'ш', 'щ', 'з', 'х', 'ъ', 'ф', 'ы', 'в', 'а', 'п', 'р', 'о', 'л', 'д',
            'ж', 'э', 'я', 'ч', 'с', 'м', 'и', 'т', 'ь', 'б', 'ю', 'ё'
        };
        char[] withSymbolsWithRussianUppercase =
        {
            'Й', 'Ц', 'У', 'К', 'Е', 'Н', 'Г', 'Ш', 'Щ', 'З', 'Х', 'Ъ', 'Ф', 'Ы', 'В', 'А', 'П', 'Р', 'О', 'Л', 'Д',
            'Ж', 'Э', 'Я', 'Ч', 'С', 'М', 'И', 'Т', 'Ь', 'Б', 'Ю', 'Ё'
        };
        char[] onlyChars =
        {
            'й', 'ц', 'у', 'к', 'е', 'н', 'г', 'ш', 'щ', 'з', 'ф', 'ы', 'в', 'а', 'п', 'р', 'о', 'л', 'д', 'я', 'ч', 
            'с', 'м', 'и', 'т', 'ь'
        };
        char[] onlyCharsUppercase =
        {
            'Й', 'Ц', 'У', 'К', 'Е', 'Н', 'Г', 'Ш', 'Щ', 'З', 'Ф', 'Ы', 'В', 'А', 'П', 'Р', 'О', 'Л', 'Д', 'Я', 'Ч', 
            'С', 'М', 'И', 'Т', 'Ь'
        };
        if (isOnlyChars)
        {
            if (uppercase)
            {
                return onlyCharsUppercase;
            }
            return onlyChars;
        }

        if (uppercase)
        {
            return withSymbolsWithRussianUppercase;
        }

        return withSymbolsWithRussian;
    }
    public static string ReplaceRusCharToEngVisual(string input)
    {
        string output=input;
        string[] rus, eng;
        rus = new[]
        {
            "й","ц","у","к","е","н","г","ш","щ","з","х","ъ","ф","ы","в","а","п","р","о","л","д","ж","э","я","ч","с","м"
            ,"и","т","ь","б","ю",   "Й","Ц","У","К","Е","Н","Г","Ш","Щ","З","Х","Ъ","Ф","Ы","В","А","П","Р","О","Л","Д"
            ,"Ж","Э","Я","Ч","С","М","И","Т","Ь","Б","Ю"
        };
        eng = new[]
        {
            "y", "th", "u", "k", "e", "n", "g", "sh", "sch", "z", "kh", "", "f", "y", "v", "a", "p", "o", "l", "d",
            "zh", "e", "ya", "ch", "s", "m", "i", "t", "", "b", "u",   "Н", "TH", "U", "K", "E", "N", "G", "SH", "SCH", 
            "Z", "KH", "", "F", "Y", "V", "A", "P", "O", "L", "D", "ZH", "E", "YA", "CH", "S", "M", "I", "T", "", "B", 
            "U"
        };
        for (int i = 0; i < rus.Length; i++)
        {
            output = output.Replace(rus[i], eng[i]);
        }

        return output;
    }
    // MATH
    public static int Clamp(int now, int min, int max)
    {
        if (now <= min) return min; 
        if (now >= max) return max;
        return now;
    }
    // CONDITIONS
    public static bool Contains(string text, string text1)
    {
        if (text == "" || text == null || text1 == "" || text1 == null) return false;
        int size = text.Length;
        string size1 = text;
        if (size1.Replace(text1, "").Length != size)
        {
            return true;
        }

        return false;
    }
    // STRINGS
    public static string RemoveFromString(string text, string text1)
    {
        if (text == "" || text == null || text1 == "" || text1 == null) return "";
        return text.Replace(text1, "");
    }
    // HTTP (HTTPS)
    public static string GetWebResponse(string url)
    {
        return new WebClient().DownloadString(url);
    }
    public static byte[] GetWebData(string url)
    {
        return new WebClient().DownloadData(url);
    }
    public static bool ConnectedToInternet()
    {
        if (GetWebResponse("http://www.msftncsi.com/ncsi.txt") == "Microsoft NCSI")
        {
            return true;
        }

        return false;
    }
}
