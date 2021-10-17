using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Dotnet.CommonHelpers.Extensions
{
    /// <summary>
    /// Additional extension methods for strings.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Checks if a string starts with openingQuote and ends with closing quote
        /// </summary>
        /// <example>        
        /// <code lang="csharp">bool hasQuotes = "someString".HasQuotes(); // returns false</code>
        /// </example>
        public static bool HasQuotes(this string input, string openingQuote = "\"", string closingQuote = "\"")
        {
            if (input.StartsWith(openingQuote) && input.EndsWith(closingQuote))
                return true;
            return false;
        }

        /// <summary>
        /// Removes diacritics from a string (ščžć...)
        /// </summary>
        /// /// <example>        
        /// <code lang="csharp">
        /// var x = "ščepec".RemoveDiacritics(); // returns "scepec"
        /// </code>
        /// </example>        
        public static string RemoveDiacritics(this string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        /// <summary>
        /// Removes diacritics (ščž..) and normalizes string https://stackoverflow.com/questions/3288114/what-does-nets-string-normalize-do
        /// replaces spaces with hypens(-)
        /// removes + and .
        /// </summary>
        public static string RemoveDiacriticsAndNormalize(this string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            return text.RemoveDiacritics()
                .Normalize(NormalizationForm.FormC)
                .Replace(" ", "-").Replace("+", "").Replace(".", "");
        }

        /// <summary>
        /// List of special character for trimming. Default values are ' ', '\t', '\r', '\n', '.', ',', '!', '?', '/', '\\'
        /// </summary>
        public static char[] SpecialChars = new char[] { ' ', '\t', '\r', '\n', '.', ',', '!', '?', '/', '\\' };

        /// <summary>
        /// Trims the beginning of a string if a character is any of <see cref="SpecialChars"></see>
        /// </summary>
        /// <example>        
        /// <code lang="csharp">var ret = "! !?someString!".TrimStartSpecialChars(); // returns "someString!"</code>
        /// </example>
        public static string TrimStartSpecialChars(this string text)
        {
            return text.TrimStart(SpecialChars);
        }

        /// <summary>
        /// Trims the ending of a string if a character is any of <see cref="SpecialChars"></see>
        /// </summary>
        /// <example>        
        /// <code lang="csharp">var ret = "! !?someString!".TrimEndSpecialChars(); // returns "! !?someString"</code>
        /// </example>
        public static string TrimEndSpecialChars(this string text)
        {
            return text.TrimEnd(SpecialChars);
        }

        /// <summary>
        /// Trims a string of <see cref="SpecialChars"></see>
        /// </summary>
        /// <example>        
        /// <code lang="csharp">var ret = "! !?someString!".TrimSpecialChars(); // returns "someString"</code>
        /// </example>
        public static string TrimSpecialChars(this string text)
        {
            return text.Trim(SpecialChars);
        }

        /// <summary>
        /// Parses a string to an int. If the string is not an int it returns null
        /// </summary>
        /// <example>
        /// <code lang="csharp">
        /// var ret = "! !?someString!".TryParseInt32(); // returns null
        /// var out2 = "123".TryParseInt32(); // returns 123
        /// </code>
        /// </example>
        public static int? TryParseInt32(this string text) => int.TryParse(text, out int value) ? value : (int?)null;

        /// <summary>
        /// Converts a delimited string array to an array of ints. Tokens that can't be converted are left out
        /// </summary>
        /// <example>
        /// <code lang="csharp">
        /// var ret = "1,3,e,c,11,abba".StringToIntArray(); // returns {1,3,11}        
        /// </code>
        /// </example>
        public static List<int> StringToIntArray(this string text, char delimiter = ',')
        {
            return text?.Split(delimiter)
                    .Select(t => TryParseInt32(t))
                    .Where(x => x.HasValue)
                    .Select(x => x.Value)
                    .ToList();
        }

        /// <summary>
        /// Truncate the string before specified length, without breaking words.
        /// </summary>
        /// <param name="text">String to be truncated</param>
        /// /// <param name="length">Max length of the truncated string</param>
        /// <returns>Truncated string</returns>
        public static string TruncateAtWord(this string text, int length)
        {
            if (text == null || text.Length < length)
                return text;
            var cutIndex = text.LastIndexOf(" ", length, StringComparison.Ordinal);
            return string.Format("{0}...", text[..((cutIndex > 0) ? cutIndex : length)].Trim());
        }

        /// <summary>
        /// Split string at first space into two strings.
        /// </summary>
        /// <param name="text">String to be split</param>
        /// <returns>Split string</returns>
        /// <example>        
        /// <code lang="csharp">
        /// var ret = "John Fitzgerald Kennedy".SplitAtFirstSpace() // returns {"John", "Fitzgerald Kennedy"}
        /// </code>
        /// </example>
        public static string[] SplitAtFirstSpace(this string text)
        {
            return text.Split(new char[] { ' ' }, 2, StringSplitOptions.RemoveEmptyEntries);
        }

        /// <summary>
        /// Converts a string to Datetime. If no conversion is possible it returns null
        /// </summary>
        /// /// <example>
        /// <code lang="csharp">
        /// var ret1 = "3.2.2015".ToDate();  // returns [3.02.2016 00:00:00] datetime object
        /// var ret1 = "33.2.2015".ToDate(); // returns null
        /// </code>
        /// </example>
        public static DateTime? ToDate(this string date)
        {
            if (DateTime.TryParse(date, out DateTime tempDate))
            {
                return tempDate;
            }
            else
                return null;
        }

        /// <summary>
        /// Removes HTML tags from string. (all text that is between &lt; and &gt;)
        /// </summary>
        /// <param name="text"></param>
        /// <returns>Text without html tags</returns>
        /// <example>
        /// <code lang="csharp">
        /// var ret = "<div>Test</div>".RemoveHtmlTags(); // returns "Test"
        /// </code>
        /// </example>
        public static string RemoveHtmlTags(this string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                return Regex.Replace(text, "<.*?>", String.Empty).Trim();
            }
            return string.Empty;
        }

        /// <summary>
        /// Removes all strings specified in tags
        /// </summary>
        /// <param name="text"></param>
        /// <param name="tags">Strings to be removed / replaced with empty.</param>
        /// <returns>Cleaned string</returns>
        public static string RemoveStrings(this string text, string[] tags)
        {
            if (!string.IsNullOrEmpty(text))
            {
                foreach (var tag in tags)
                {
                    text = text.Replace(tag, string.Empty);
                }
                return text;
            }
            return string.Empty;
        }

        /// <summary>
        /// Replaces multiple spaces with one
        /// </summary>
        /// <param name="input"></param>
        /// <returns>string with multiple spaces removed</returns>
        /// <example>
        /// <code lang="csharp">
        /// var ret = "to     je testno  besedilo".FixSpaces(); // returns "to je testno besedilo"
        /// </code>
        /// </example>
        public static string FixSpaces(this string input)
        {
            var options = RegexOptions.None;
            var regex = new Regex(@"[ ]{2,}", options);
            return regex.Replace(input, @" ");
        }

        /// <summary>
        /// Returns empty string if string is null
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string EmptyIfNull(this string s)
        {
            if (s == null)
                return string.Empty;
            return s;
        }

        /// <summary>
        /// Returns the "lenght" leftmost characters
        /// </summary>
        /// <param name="s"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string Left(this string s, int length)
        {
            if (s.Length <= length)
                return s;
            return s[..length];
        }

        /// <summary>
        /// Get substring of specified number of characters on the right.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="length"></param>
        /// <returns>right <c>lenght</c> of characters</returns>
        /// <example>
        /// <code lang="csharp">
        /// var ret = "testno".Right(2); // returns "no"
        /// </code>
        /// </example>        
        public static string Right(this string value, int length)
        {
            return value[^length..];
        }

        /// <summary>
        /// Case insesitive equals operator
        /// </summary>
        /// <param name="a">1st parameter</param>
        /// <param name="b">2nd parameter</param>
        /// <returns>true if strings are equal (case insensitive)</returns>
        /// <example>
        /// <code lang="csharp">
        /// var ret = "Test".EqualsCI("test"); // returns true;
        /// </code>
        /// </example>
        public static bool EqualsCI(this string a, string b)
        {
            return a.Equals(b, StringComparison.CurrentCultureIgnoreCase);
        }

        /// <summary>
        /// Truncates the url, so it contains only the domain and two first folders, if they exist
        /// ex http://www.google.com/reader/test?234iojapjapriogjerg becomes http://www.google.com/reader
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Truncated url</returns>
        /// <example>
        /// <code lang="csharp">
        /// var ret = "http://www.google.si/search/dva".LimitDomain(); // returns "http://www.google.si/search"
        /// </code>
        /// </example>
        public static string LimitDomain(this string input)
        {
            char[] trim = new char[] { ' ', '\\', '/', '\r', '\n', '\t' };
            int start;
            int strlen = input.Length;
            start = input.IndexOf("://");
            start += 3;

            // remove the protocol prefix
            if (start > strlen || start <= -1 + 3)
                return input.Trim(trim); ;
            input = input[start..strlen];

            // remove parameters (?)
            int endParam = input.IndexOf('?');
            if (endParam > -1)
            {
                input = input[..endParam].Trim();
            }

            // remove parameters (#)
            endParam = input.IndexOf('#');
            if (endParam > -1)
            {
                input = input[..endParam].Trim();
            }

            string[] items = input.Split('/');
            if (items.Length >= 4)
                return items[0] + "/" + items[1] + "/" + items[2];
            else if (items.Length == 3)
                return items[0] + "/" + items[1];
            else return items[0];
        }

        //Todo unit test?
        /*
        Console.WriteLine(LimitDomain("http://www.google.si/search?q=check+if+iaccessible+is+int&ie=utf-8&oe=utf-8&aq=t&rls=org.mozilla:en-US:official&client=firefox-a#sclient=psy-ab&hl=sl&safe=off&client=firefox-a&hs=ks4&rls=org.mozilla:en-US%3Aofficial&source=hp&q=+iaccessible+int32+method+not+exists&pbx=1&oq=+iaccessible+int32+method+not+exists&aq=f&aqi=&aql=&gs_sm=e&gs_upl=10756l15619l1l15748l19l19l0l0l0l0l225l2485l2.16.1l19l0&bav=on.2,or.r_gc.r_pw.r_cp.,cf.osb&fp=12f412b5cde2dd64&biw=1280&bih=891"));
        Console.WriteLine(LimitDomain("http://www.google.si/search/dva"));
        Console.WriteLine(LimitDomain("http://www.google.si/search/dva/"));
        Console.WriteLine(LimitDomain("http://www.google.si/search/tri/dva"));
        Console.WriteLine(LimitDomain("http://www.google.si/search#tri/dva"));
        Console.WriteLine(LimitDomain("http://////"));
        Console.WriteLine(LimitDomain("http://?/##/"));
        Console.WriteLine(LimitDomain("ht/?/##/"));
        Console.WriteLine(LimitDomain("?"));
        Console.WriteLine(LimitDomain("/?"));
        Console.WriteLine(LimitDomain("//?"));
        Console.WriteLine(LimitDomain("///?"));
        Console.WriteLine(LimitDomain("//?/"));
        Console.WriteLine(LimitDomain("//?/?"));
        */

        /// <summary>
        /// Splits the string and keeps only the numbers. Anything other than a number is treated as a separator
        /// </summary>   
        /// <example>        
        /// <code lang="csharp">
        /// var numbers = "1,24b32test3    6".GetNumbers(); // returns {1,24,32,3,6}
        /// </code>
        /// </example>
        public static List<int> GetNumbers(this string input)
        {
            string[] substrings = Regex.Split(input, @"[^\d]+", RegexOptions.IgnorePatternWhitespace);
            var ret = new List<int>();
            foreach (string match in substrings.Where(s => s != string.Empty))
            {
                ret.Add(int.Parse(match));
            }
            return ret;
        }

        /// <summary>
        /// Converst a hex representation of the string into binary one
        /// </summary>        
        /// <example>
        /// <code lang="csharp">
        /// var t1 = "A0".ConvertHexToBin(); // returns false        
        /// </code>
        /// </example>
        public static string ConvertHexToBin(this string hex)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var c in hex.ToCharArray())
            {
                var intValue = int.Parse(c.ToString(), System.Globalization.NumberStyles.HexNumber);
                sb.Append(Convert.ToString(intValue, 2).PadLeft(4, '0'));
            }

            return sb.ToString();
        }

        /// <summary>
        /// Returns true if the Second word is an anagram of the current string
        /// </summary>      
        /// <example>
        /// <code lang="csharp">
        /// var t1 = "ABC".IsAnagram("ABE"); // returns false
        /// var t2 = "ELVIS".IsAnagram("LIVES"); // returns true
        /// </code>
        /// </example>
        public static bool IsAnagram(this string input, string second)
        {
            var a = new string(input.ToCharArray().OrderBy(i => i).ToArray());
            var b = new string(second.ToCharArray().OrderBy(i => i).ToArray());
            return a == b;
        }


        private static readonly MD5 _md5 = System.Security.Cryptography.MD5.Create();
        /// <summary>
        /// Returns a MD5 hash of the string
        /// </summary>    
        /// <example>
        /// <code lang="csharp">
        /// var ret = "test".MD5();  // returns "C8059E2EC7419F590E79D7F1B774BFE6"
        /// </code>
        /// </example>
        public static string MD5(this string input)
        {
            byte[] data = _md5.ComputeHash(Encoding.Unicode.GetBytes(input));
            return BitConverter.ToString(data).Replace("-", string.Empty);
        }

        private static readonly SHA1 _sha1 = System.Security.Cryptography.SHA1.Create();

        /// <summary>
        /// Returns a SHA1 hash of the string
        /// </summary>    
        /// <example>
        /// <code lang="csharp">
        /// var ret = "test".SHA1();  // returns "C8059E2EC7419F590E79D7F1B774BFE6"
        /// </code>
        /// </example>
        public static string SHA1(this string input)
        {
            byte[] data = _sha1.ComputeHash(Encoding.Unicode.GetBytes(input));
            return BitConverter.ToString(data).Replace("-", string.Empty);
        }
        /// <summary>
        /// Reverses the string       
        /// </summary>        
        /// <example>
        /// <code lang="csharp">
        /// var ret = "ABCD".Reverse(); // returns "DCBA"
        /// </code>
        /// </example>

        public static string Reverse(this string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        /// <summary>
        /// Remove spaces and newlines from string
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Clean string, without spaces and newlines</returns>
        public static string RemoveSpacesAndNewLines(this string input)
        {
            input = Regex.Replace(input, @"\s+", " ").Trim();
            input = Regex.Replace(input, @"\t|\n|\r", string.Empty);
            return input;
        }
    }
}