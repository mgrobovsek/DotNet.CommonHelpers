<a name='assembly'></a>
# DotNet.CommonHelpers

## Contents

- [StringExtensions](#T-Dotnet-CommonHelpers-Extensions-StringExtensions 'Dotnet.CommonHelpers.Extensions.StringExtensions')
  - [SpecialChars](#F-Dotnet-CommonHelpers-Extensions-StringExtensions-SpecialChars 'Dotnet.CommonHelpers.Extensions.StringExtensions.SpecialChars')
  - [ConvertHexToBin()](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-ConvertHexToBin-System-String- 'Dotnet.CommonHelpers.Extensions.StringExtensions.ConvertHexToBin(System.String)')
  - [EmptyIfNull(s)](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-EmptyIfNull-System-String- 'Dotnet.CommonHelpers.Extensions.StringExtensions.EmptyIfNull(System.String)')
  - [EqualsCI(a,b)](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-EqualsCI-System-String,System-String- 'Dotnet.CommonHelpers.Extensions.StringExtensions.EqualsCI(System.String,System.String)')
  - [FixSpaces(input)](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-FixSpaces-System-String- 'Dotnet.CommonHelpers.Extensions.StringExtensions.FixSpaces(System.String)')
  - [GetNumbers()](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-GetNumbers-System-String- 'Dotnet.CommonHelpers.Extensions.StringExtensions.GetNumbers(System.String)')
  - [HasQuotes()](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-HasQuotes-System-String,System-String,System-String- 'Dotnet.CommonHelpers.Extensions.StringExtensions.HasQuotes(System.String,System.String,System.String)')
  - [IsAnagram()](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-IsAnagram-System-String,System-String- 'Dotnet.CommonHelpers.Extensions.StringExtensions.IsAnagram(System.String,System.String)')
  - [Left(s,length)](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-Left-System-String,System-Int32- 'Dotnet.CommonHelpers.Extensions.StringExtensions.Left(System.String,System.Int32)')
  - [LimitDomain(input)](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-LimitDomain-System-String- 'Dotnet.CommonHelpers.Extensions.StringExtensions.LimitDomain(System.String)')
  - [MD5()](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-MD5-System-String- 'Dotnet.CommonHelpers.Extensions.StringExtensions.MD5(System.String)')
  - [RemoveDiacritics()](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-RemoveDiacritics-System-String- 'Dotnet.CommonHelpers.Extensions.StringExtensions.RemoveDiacritics(System.String)')
  - [RemoveDiacriticsAndNormalize()](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-RemoveDiacriticsAndNormalize-System-String- 'Dotnet.CommonHelpers.Extensions.StringExtensions.RemoveDiacriticsAndNormalize(System.String)')
  - [RemoveHtmlTags(text)](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-RemoveHtmlTags-System-String- 'Dotnet.CommonHelpers.Extensions.StringExtensions.RemoveHtmlTags(System.String)')
  - [RemoveStrings(text,tags)](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-RemoveStrings-System-String,System-String[]- 'Dotnet.CommonHelpers.Extensions.StringExtensions.RemoveStrings(System.String,System.String[])')
  - [Reverse()](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-Reverse-System-String- 'Dotnet.CommonHelpers.Extensions.StringExtensions.Reverse(System.String)')
  - [Right(value,length)](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-Right-System-String,System-Int32- 'Dotnet.CommonHelpers.Extensions.StringExtensions.Right(System.String,System.Int32)')
  - [SplitAtFirstSpace(text)](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-SplitAtFirstSpace-System-String- 'Dotnet.CommonHelpers.Extensions.StringExtensions.SplitAtFirstSpace(System.String)')
  - [StringToIntArray()](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-StringToIntArray-System-String,System-Char- 'Dotnet.CommonHelpers.Extensions.StringExtensions.StringToIntArray(System.String,System.Char)')
  - [ToDate()](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-ToDate-System-String- 'Dotnet.CommonHelpers.Extensions.StringExtensions.ToDate(System.String)')
  - [TrimEndSpecialChars()](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-TrimEndSpecialChars-System-String- 'Dotnet.CommonHelpers.Extensions.StringExtensions.TrimEndSpecialChars(System.String)')
  - [TrimSpecialChars()](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-TrimSpecialChars-System-String- 'Dotnet.CommonHelpers.Extensions.StringExtensions.TrimSpecialChars(System.String)')
  - [TrimStartSpecialChars()](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-TrimStartSpecialChars-System-String- 'Dotnet.CommonHelpers.Extensions.StringExtensions.TrimStartSpecialChars(System.String)')
  - [TruncateAtWord(text,length)](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-TruncateAtWord-System-String,System-Int32- 'Dotnet.CommonHelpers.Extensions.StringExtensions.TruncateAtWord(System.String,System.Int32)')
  - [TryParseInt32()](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-TryParseInt32-System-String- 'Dotnet.CommonHelpers.Extensions.StringExtensions.TryParseInt32(System.String)')

<a name='T-Dotnet-CommonHelpers-Extensions-StringExtensions'></a>
## StringExtensions `type`

##### Namespace

Dotnet.CommonHelpers.Extensions

##### Summary

Additional extension methods for strings.

<a name='F-Dotnet-CommonHelpers-Extensions-StringExtensions-SpecialChars'></a>
### SpecialChars `constants`

##### Summary

List of special character for trimming. Default values are ' ', '\t', '\r', '\n', '.', ',', '!', '?', '/', '\\'

<a name='M-Dotnet-CommonHelpers-Extensions-StringExtensions-ConvertHexToBin-System-String-'></a>
### ConvertHexToBin() `method`

##### Summary

Converst a hex representation of the string into binary one

##### Parameters

This method has no parameters.

##### Example

```csharp
var t1 = "A0".ConvertHexToBin(); // returns false        
```

<a name='M-Dotnet-CommonHelpers-Extensions-StringExtensions-EmptyIfNull-System-String-'></a>
### EmptyIfNull(s) `method`

##### Summary

Returns empty string if string is null

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Dotnet-CommonHelpers-Extensions-StringExtensions-EqualsCI-System-String,System-String-'></a>
### EqualsCI(a,b) `method`

##### Summary

Case insesitive equals operator

##### Returns

true if strings are equal (case insensitive)

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | 1st parameter |
| b | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | 2nd parameter |

##### Example

```csharp
var ret = "Test".EqualsCI("test"); // returns true;
```

<a name='M-Dotnet-CommonHelpers-Extensions-StringExtensions-FixSpaces-System-String-'></a>
### FixSpaces(input) `method`

##### Summary

Replaces multiple spaces with one

##### Returns

string with multiple spaces removed

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Example

```csharp
var ret = "to     je testno  besedilo".FixSpaces(); // returns "to je testno besedilo"
```

<a name='M-Dotnet-CommonHelpers-Extensions-StringExtensions-GetNumbers-System-String-'></a>
### GetNumbers() `method`

##### Summary

Splits the string and keeps only the numbers. Anything other than a number is treated as a separator

##### Parameters

This method has no parameters.

##### Example

```csharp
var numbers = "1,24b32test3    6".GetNumbers(); // returns {1,24,32,3,6}
```

<a name='M-Dotnet-CommonHelpers-Extensions-StringExtensions-HasQuotes-System-String,System-String,System-String-'></a>
### HasQuotes() `method`

##### Summary

Checks if a string starts with openingQuote and ends with closing quote

##### Parameters

This method has no parameters.

##### Example

```csharp
bool hasQuotes = "someString".HasQuotes(); // returns false
```

<a name='M-Dotnet-CommonHelpers-Extensions-StringExtensions-IsAnagram-System-String,System-String-'></a>
### IsAnagram() `method`

##### Summary

Returns true if the Second word is an anagram of the current string

##### Parameters

This method has no parameters.

##### Example

```csharp
var t1 = "ABC".IsAnagram("ABE"); // returns false
var t2 = "ELVIS".IsAnagram("LIVES"); // returns true
```

<a name='M-Dotnet-CommonHelpers-Extensions-StringExtensions-Left-System-String,System-Int32-'></a>
### Left(s,length) `method`

##### Summary

Returns the "lenght" leftmost characters

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-Dotnet-CommonHelpers-Extensions-StringExtensions-LimitDomain-System-String-'></a>
### LimitDomain(input) `method`

##### Summary

Truncates the url, so it contains only the domain and two first folders, if they exist
ex http://www.google.com/reader/test?234iojapjapriogjerg becomes http://www.google.com/reader

##### Returns

Truncated url

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Example

```csharp
var ret = "http://www.google.si/search/dva".LimitDomain(); // returns "http://www.google.si/search"
```

<a name='M-Dotnet-CommonHelpers-Extensions-StringExtensions-MD5-System-String-'></a>
### MD5() `method`

##### Summary

Returns a MD5 hash of the string

##### Parameters

This method has no parameters.

##### Example

```csharp
var ret = "test".MD5();  // returns "C8059E2EC7419F590E79D7F1B774BFE6"
```

<a name='M-Dotnet-CommonHelpers-Extensions-StringExtensions-RemoveDiacritics-System-String-'></a>
### RemoveDiacritics() `method`

##### Summary

Removes diacritics from a string (ščžć...)

##### Parameters

This method has no parameters.

##### Example

```csharp
var x = "ščepec".RemoveDiacritics(); // returns "scepec"
```

<a name='M-Dotnet-CommonHelpers-Extensions-StringExtensions-RemoveDiacriticsAndNormalize-System-String-'></a>
### RemoveDiacriticsAndNormalize() `method`

##### Summary

Removes diacritics (ščž..) and normalizes string https://stackoverflow.com/questions/3288114/what-does-nets-string-normalize-do
replaces spaces with hypens(-)
removes + and .

##### Parameters

This method has no parameters.

<a name='M-Dotnet-CommonHelpers-Extensions-StringExtensions-RemoveHtmlTags-System-String-'></a>
### RemoveHtmlTags(text) `method`

##### Summary

Removes HTML tags from string. (all text that is between < and >)

##### Returns

Text without html tags

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Example

```csharp
var ret = "
```

<a name='M-Dotnet-CommonHelpers-Extensions-StringExtensions-RemoveStrings-System-String,System-String[]-'></a>
### RemoveStrings(text,tags) `method`

##### Summary

Removes all strings specified in tags

##### Returns

Cleaned string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| tags | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Strings to be removed / replaced with empty. |

<a name='M-Dotnet-CommonHelpers-Extensions-StringExtensions-Reverse-System-String-'></a>
### Reverse() `method`

##### Summary

Reverses the string

##### Parameters

This method has no parameters.

##### Example

```csharp
var ret = "ABCD".Reverse(); // returns "DCBA"
```

<a name='M-Dotnet-CommonHelpers-Extensions-StringExtensions-Right-System-String,System-Int32-'></a>
### Right(value,length) `method`

##### Summary

Get substring of specified number of characters on the right.

##### Returns

right `lenght` of characters

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

##### Example

```csharp
var ret = "testno".Right(2); // returns "no"
```

<a name='M-Dotnet-CommonHelpers-Extensions-StringExtensions-SplitAtFirstSpace-System-String-'></a>
### SplitAtFirstSpace(text) `method`

##### Summary

Split string at first space into two strings.

##### Returns

Split string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String to be split |

##### Example

```csharp
var ret = "John Fitzgerald Kennedy".SplitAtFirstSpace() // returns {"John", "Fitzgerald Kennedy"}
```

<a name='M-Dotnet-CommonHelpers-Extensions-StringExtensions-StringToIntArray-System-String,System-Char-'></a>
### StringToIntArray() `method`

##### Summary

Converts a delimited string array to an array of ints. Tokens that can't be converted are left out

##### Parameters

This method has no parameters.

##### Example

```csharp
var ret = "1,3,e,c,11,abba".StringToIntArray(); // returns {1,3,11}        
```

<a name='M-Dotnet-CommonHelpers-Extensions-StringExtensions-ToDate-System-String-'></a>
### ToDate() `method`

##### Summary

Converts a string to Datetime. If no conversion is possible it returns null

##### Parameters

This method has no parameters.

##### Example

```csharp
var ret1 = "3.2.2015".ToDate();  // returns [3.02.2016 00:00:00] datetime object
var ret1 = "33.2.2015".ToDate(); // returns null
```

<a name='M-Dotnet-CommonHelpers-Extensions-StringExtensions-TrimEndSpecialChars-System-String-'></a>
### TrimEndSpecialChars() `method`

##### Summary

Trims the ending of a string if a character is any of [SpecialChars](#F-Dotnet-CommonHelpers-Extensions-StringExtensions-SpecialChars 'Dotnet.CommonHelpers.Extensions.StringExtensions.SpecialChars')

##### Parameters

This method has no parameters.

##### Example

```csharp
var ret = "! !?someString!".TrimEndSpecialChars(); // returns "! !?someString"
```

<a name='M-Dotnet-CommonHelpers-Extensions-StringExtensions-TrimSpecialChars-System-String-'></a>
### TrimSpecialChars() `method`

##### Summary

Trims a string of [SpecialChars](#F-Dotnet-CommonHelpers-Extensions-StringExtensions-SpecialChars 'Dotnet.CommonHelpers.Extensions.StringExtensions.SpecialChars')

##### Parameters

This method has no parameters.

##### Example

```csharp
var ret = "! !?someString!".TrimSpecialChars(); // returns "someString"
```

<a name='M-Dotnet-CommonHelpers-Extensions-StringExtensions-TrimStartSpecialChars-System-String-'></a>
### TrimStartSpecialChars() `method`

##### Summary

Trims the beginning of a string if a character is any of [SpecialChars](#F-Dotnet-CommonHelpers-Extensions-StringExtensions-SpecialChars 'Dotnet.CommonHelpers.Extensions.StringExtensions.SpecialChars')

##### Parameters

This method has no parameters.

##### Example

```csharp
var ret = "! !?someString!".TrimStartSpecialChars(); // returns "someString!"
```

<a name='M-Dotnet-CommonHelpers-Extensions-StringExtensions-TruncateAtWord-System-String,System-Int32-'></a>
### TruncateAtWord(text,length) `method`

##### Summary

Truncate the string before specified length, without breaking words.

##### Returns

Truncated string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String to be truncated |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Max length of the truncated string |

<a name='M-Dotnet-CommonHelpers-Extensions-StringExtensions-TryParseInt32-System-String-'></a>
### TryParseInt32() `method`

##### Summary

Parses a string to an int. If the string is not an int it returns null

##### Parameters

This method has no parameters.

##### Example

```csharp
var ret = "! !?someString!".TryParseInt32(); // returns null
var out2 = "123".TryParseInt32(); // returns 123
```
