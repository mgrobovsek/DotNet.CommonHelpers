<a name='assembly'></a>
# DotNet.CommonHelpers

## Contents

- [AppSettingNotFoundException](#T-DotNet-CommonHelpers-Exceptions-AppSettingNotFoundException 'DotNet.CommonHelpers.Exceptions.AppSettingNotFoundException')
  - [#ctor()](#M-DotNet-CommonHelpers-Exceptions-AppSettingNotFoundException-#ctor 'DotNet.CommonHelpers.Exceptions.AppSettingNotFoundException.#ctor')
  - [#ctor(message)](#M-DotNet-CommonHelpers-Exceptions-AppSettingNotFoundException-#ctor-System-String- 'DotNet.CommonHelpers.Exceptions.AppSettingNotFoundException.#ctor(System.String)')
  - [#ctor(message,innerException)](#M-DotNet-CommonHelpers-Exceptions-AppSettingNotFoundException-#ctor-System-String,System-Exception- 'DotNet.CommonHelpers.Exceptions.AppSettingNotFoundException.#ctor(System.String,System.Exception)')
  - [#ctor(info,context)](#M-DotNet-CommonHelpers-Exceptions-AppSettingNotFoundException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext- 'DotNet.CommonHelpers.Exceptions.AppSettingNotFoundException.#ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)')
- [AppSettings](#T-DotNet-CommonHelpers-AppSettings 'DotNet.CommonHelpers.AppSettings')
  - [Get\`\`1(key)](#M-DotNet-CommonHelpers-AppSettings-Get``1-System-String- 'DotNet.CommonHelpers.AppSettings.Get``1(System.String)')
- [AsyncHelper](#T-DotNet-CommonHelpers-Extensions-AsyncHelper 'DotNet.CommonHelpers.Extensions.AsyncHelper')
  - [RunSync(func)](#M-DotNet-CommonHelpers-Extensions-AsyncHelper-RunSync-System-Func{System-Threading-Tasks-Task}- 'DotNet.CommonHelpers.Extensions.AsyncHelper.RunSync(System.Func{System.Threading.Tasks.Task})')
  - [RunSync\`\`1(func)](#M-DotNet-CommonHelpers-Extensions-AsyncHelper-RunSync``1-System-Func{System-Threading-Tasks-Task{``0}}- 'DotNet.CommonHelpers.Extensions.AsyncHelper.RunSync``1(System.Func{System.Threading.Tasks.Task{``0}})')
- [CleanerCodeExtensions](#T-DotNet-CommonHelpers-Extensions-CleanerCodeExtensions 'DotNet.CommonHelpers.Extensions.CleanerCodeExtensions')
  - [Require\`\`1(param,condition)](#M-DotNet-CommonHelpers-Extensions-CleanerCodeExtensions-Require``1-``0,System-Func{``0,System-Boolean}- 'DotNet.CommonHelpers.Extensions.CleanerCodeExtensions.Require``1(``0,System.Func{``0,System.Boolean})')
- [DBHelper](#T-DotNet-CommonHelpers-Extensions-DBHelper 'DotNet.CommonHelpers.Extensions.DBHelper')
  - [ConnectionString](#P-DotNet-CommonHelpers-Extensions-DBHelper-ConnectionString 'DotNet.CommonHelpers.Extensions.DBHelper.ConnectionString')
  - [QueryCommandTimeout](#P-DotNet-CommonHelpers-Extensions-DBHelper-QueryCommandTimeout 'DotNet.CommonHelpers.Extensions.DBHelper.QueryCommandTimeout')
  - [QueryDT(sqlQuery,connectionString,timeout)](#M-DotNet-CommonHelpers-Extensions-DBHelper-QueryDT-System-String,System-String,System-Nullable{System-Int32}- 'DotNet.CommonHelpers.Extensions.DBHelper.QueryDT(System.String,System.String,System.Nullable{System.Int32})')
- [EnumerationExtensions](#T-DotNet-CommonHelpers-Extensions-EnumerationExtensions 'DotNet.CommonHelpers.Extensions.EnumerationExtensions')
  - [GetEnumerator(range)](#M-DotNet-CommonHelpers-Extensions-EnumerationExtensions-GetEnumerator-System-Range- 'DotNet.CommonHelpers.Extensions.EnumerationExtensions.GetEnumerator(System.Range)')
- [LinqExtensions](#T-DotNet-CommonHelpers-Extensions-LinqExtensions 'DotNet.CommonHelpers.Extensions.LinqExtensions')
  - [Clone\`\`1()](#M-DotNet-CommonHelpers-Extensions-LinqExtensions-Clone``1-System-Collections-Generic-IList{``0}- 'DotNet.CommonHelpers.Extensions.LinqExtensions.Clone``1(System.Collections.Generic.IList{``0})')
  - [MaxIndex\`\`1()](#M-DotNet-CommonHelpers-Extensions-LinqExtensions-MaxIndex``1-System-Collections-Generic-IEnumerable{``0}- 'DotNet.CommonHelpers.Extensions.LinqExtensions.MaxIndex``1(System.Collections.Generic.IEnumerable{``0})')
  - [ToConsoleSameLine\`\`1()](#M-DotNet-CommonHelpers-Extensions-LinqExtensions-ToConsoleSameLine``1-System-Collections-Generic-IEnumerable{``0},System-Func{``0,System-String}- 'DotNet.CommonHelpers.Extensions.LinqExtensions.ToConsoleSameLine``1(System.Collections.Generic.IEnumerable{``0},System.Func{``0,System.String})')
- [ObjectShredder](#T-DotNet-CommonHelpers-Extensions-ObjectShredder 'DotNet.CommonHelpers.Extensions.ObjectShredder')
  - [EnumerableToDataTable\`\`1(varlist)](#M-DotNet-CommonHelpers-Extensions-ObjectShredder-EnumerableToDataTable``1-System-Collections-Generic-IEnumerable{``0}- 'DotNet.CommonHelpers.Extensions.ObjectShredder.EnumerableToDataTable``1(System.Collections.Generic.IEnumerable{``0})')
- [RawQuery](#T-DotNet-CommonHelpers-Extensions-RawQuery 'DotNet.CommonHelpers.Extensions.RawQuery')
  - [ConnectionString](#P-DotNet-CommonHelpers-Extensions-RawQuery-ConnectionString 'DotNet.CommonHelpers.Extensions.RawQuery.ConnectionString')
  - [Execute(cString,sql,param,transaction,commandTimeout,commandType)](#M-DotNet-CommonHelpers-Extensions-RawQuery-Execute-System-String,System-String,System-Object,System-Data-IDbTransaction,System-Nullable{System-Int32},System-Nullable{System-Data-CommandType}- 'DotNet.CommonHelpers.Extensions.RawQuery.Execute(System.String,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})')
  - [ExecuteAsync(cString,sql,param,transaction,commandTimeout,commandType)](#M-DotNet-CommonHelpers-Extensions-RawQuery-ExecuteAsync-System-String,System-String,System-Object,System-Data-IDbTransaction,System-Nullable{System-Int32},System-Nullable{System-Data-CommandType}- 'DotNet.CommonHelpers.Extensions.RawQuery.ExecuteAsync(System.String,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})')
  - [ExecuteScalarAsync\`\`1(cString,sql,param,transaction,commandTimeout,commandType)](#M-DotNet-CommonHelpers-Extensions-RawQuery-ExecuteScalarAsync``1-System-String,System-String,System-Object,System-Data-IDbTransaction,System-Nullable{System-Int32},System-Nullable{System-Data-CommandType}- 'DotNet.CommonHelpers.Extensions.RawQuery.ExecuteScalarAsync``1(System.String,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})')
  - [ExecuteScalar\`\`1(cString,sql,param,transaction,commandTimeout,commandType)](#M-DotNet-CommonHelpers-Extensions-RawQuery-ExecuteScalar``1-System-String,System-String,System-Object,System-Data-IDbTransaction,System-Nullable{System-Int32},System-Nullable{System-Data-CommandType}- 'DotNet.CommonHelpers.Extensions.RawQuery.ExecuteScalar``1(System.String,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})')
  - [QueryAsync\`\`1(cString,sql,param,transaction,commandTimeout,commandType)](#M-DotNet-CommonHelpers-Extensions-RawQuery-QueryAsync``1-System-String,System-String,System-Object,System-Data-IDbTransaction,System-Nullable{System-Int32},System-Nullable{System-Data-CommandType}- 'DotNet.CommonHelpers.Extensions.RawQuery.QueryAsync``1(System.String,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})')
  - [Query\`\`1(cString,sql,param,transaction,buffered,commandTimeout,commandType)](#M-DotNet-CommonHelpers-Extensions-RawQuery-Query``1-System-String,System-String,System-Object,System-Data-IDbTransaction,System-Boolean,System-Nullable{System-Int32},System-Nullable{System-Data-CommandType}- 'DotNet.CommonHelpers.Extensions.RawQuery.Query``1(System.String,System.String,System.Object,System.Data.IDbTransaction,System.Boolean,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})')
- [ReflectionCopy](#T-DotNet-CommonHelpers-Extensions-ReflectionCopy 'DotNet.CommonHelpers.Extensions.ReflectionCopy')
  - [Copy(source,destinationType)](#M-DotNet-CommonHelpers-Extensions-ReflectionCopy-Copy-System-Collections-Generic-List{System-Object},System-Type- 'DotNet.CommonHelpers.Extensions.ReflectionCopy.Copy(System.Collections.Generic.List{System.Object},System.Type)')
  - [Copy(source,destinationType)](#M-DotNet-CommonHelpers-Extensions-ReflectionCopy-Copy-System-Object,System-Type- 'DotNet.CommonHelpers.Extensions.ReflectionCopy.Copy(System.Object,System.Type)')
  - [CopyList\`\`1(source)](#M-DotNet-CommonHelpers-Extensions-ReflectionCopy-CopyList``1-System-Object- 'DotNet.CommonHelpers.Extensions.ReflectionCopy.CopyList``1(System.Object)')
  - [CopyList\`\`1(source,skipParams)](#M-DotNet-CommonHelpers-Extensions-ReflectionCopy-CopyList``1-System-Object,System-Collections-Generic-List{System-String}- 'DotNet.CommonHelpers.Extensions.ReflectionCopy.CopyList``1(System.Object,System.Collections.Generic.List{System.String})')
  - [Copy\`\`1(source,skipParams)](#M-DotNet-CommonHelpers-Extensions-ReflectionCopy-Copy``1-System-Object,System-Collections-Generic-List{System-String}- 'DotNet.CommonHelpers.Extensions.ReflectionCopy.Copy``1(System.Object,System.Collections.Generic.List{System.String})')
  - [Copy\`\`1(source)](#M-DotNet-CommonHelpers-Extensions-ReflectionCopy-Copy``1-System-Object- 'DotNet.CommonHelpers.Extensions.ReflectionCopy.Copy``1(System.Object)')
  - [Modify(source,destination)](#M-DotNet-CommonHelpers-Extensions-ReflectionCopy-Modify-System-Object,System-Object- 'DotNet.CommonHelpers.Extensions.ReflectionCopy.Modify(System.Object,System.Object)')
  - [Modify(source,destination,skipParams)](#M-DotNet-CommonHelpers-Extensions-ReflectionCopy-Modify-System-Object,System-Object,System-Collections-Generic-List{System-String}- 'DotNet.CommonHelpers.Extensions.ReflectionCopy.Modify(System.Object,System.Object,System.Collections.Generic.List{System.String})')
- [SerializationExtension](#T-DotNet-CommonHelpers-Extensions-SerializationExtension 'DotNet.CommonHelpers.Extensions.SerializationExtension')
  - [XmlDeserialize\`\`1(xml)](#M-DotNet-CommonHelpers-Extensions-SerializationExtension-XmlDeserialize``1-System-String- 'DotNet.CommonHelpers.Extensions.SerializationExtension.XmlDeserialize``1(System.String)')
  - [XmlSerialize\`\`1(obj)](#M-DotNet-CommonHelpers-Extensions-SerializationExtension-XmlSerialize``1-``0- 'DotNet.CommonHelpers.Extensions.SerializationExtension.XmlSerialize``1(``0)')
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
  - [RemoveSpacesAndNewLines(input)](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-RemoveSpacesAndNewLines-System-String- 'Dotnet.CommonHelpers.Extensions.StringExtensions.RemoveSpacesAndNewLines(System.String)')
  - [RemoveStrings(text,tags)](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-RemoveStrings-System-String,System-String[]- 'Dotnet.CommonHelpers.Extensions.StringExtensions.RemoveStrings(System.String,System.String[])')
  - [Reverse()](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-Reverse-System-String- 'Dotnet.CommonHelpers.Extensions.StringExtensions.Reverse(System.String)')
  - [Right(value,length)](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-Right-System-String,System-Int32- 'Dotnet.CommonHelpers.Extensions.StringExtensions.Right(System.String,System.Int32)')
  - [SHA1()](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-SHA1-System-String- 'Dotnet.CommonHelpers.Extensions.StringExtensions.SHA1(System.String)')
  - [SplitAtFirstSpace(text)](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-SplitAtFirstSpace-System-String- 'Dotnet.CommonHelpers.Extensions.StringExtensions.SplitAtFirstSpace(System.String)')
  - [StringToIntArray()](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-StringToIntArray-System-String,System-Char- 'Dotnet.CommonHelpers.Extensions.StringExtensions.StringToIntArray(System.String,System.Char)')
  - [StripHtml(input)](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-StripHtml-System-String- 'Dotnet.CommonHelpers.Extensions.StringExtensions.StripHtml(System.String)')
  - [ToDate()](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-ToDate-System-String- 'Dotnet.CommonHelpers.Extensions.StringExtensions.ToDate(System.String)')
  - [TrimEndSpecialChars()](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-TrimEndSpecialChars-System-String- 'Dotnet.CommonHelpers.Extensions.StringExtensions.TrimEndSpecialChars(System.String)')
  - [TrimSpecialChars()](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-TrimSpecialChars-System-String- 'Dotnet.CommonHelpers.Extensions.StringExtensions.TrimSpecialChars(System.String)')
  - [TrimStartSpecialChars()](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-TrimStartSpecialChars-System-String- 'Dotnet.CommonHelpers.Extensions.StringExtensions.TrimStartSpecialChars(System.String)')
  - [TruncateAtWord(text,length)](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-TruncateAtWord-System-String,System-Int32- 'Dotnet.CommonHelpers.Extensions.StringExtensions.TruncateAtWord(System.String,System.Int32)')
  - [TryParseInt32()](#M-Dotnet-CommonHelpers-Extensions-StringExtensions-TryParseInt32-System-String- 'Dotnet.CommonHelpers.Extensions.StringExtensions.TryParseInt32(System.String)')
- [ValueObject](#T-DotNet-CommonHelpers-Extensions-ValueObject 'DotNet.CommonHelpers.Extensions.ValueObject')

<a name='T-DotNet-CommonHelpers-Exceptions-AppSettingNotFoundException'></a>
## AppSettingNotFoundException `type`

##### Namespace

DotNet.CommonHelpers.Exceptions

##### Summary

Represents errors that occur during application execution.

<a name='M-DotNet-CommonHelpers-Exceptions-AppSettingNotFoundException-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the AppSettingNotFoundException

##### Parameters

This constructor has no parameters.

<a name='M-DotNet-CommonHelpers-Exceptions-AppSettingNotFoundException-#ctor-System-String-'></a>
### #ctor(message) `constructor`

##### Summary

Initializes a new instance of the AppSettingNotFoundException class with a specified error message

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message that describes the error. |

<a name='M-DotNet-CommonHelpers-Exceptions-AppSettingNotFoundException-#ctor-System-String,System-Exception-'></a>
### #ctor(message,innerException) `constructor`

##### Summary

Initializes a new instance of the AppSettingNotFoundException class with a specified error
message and a reference to the inner exception that is the cause of this exception.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message that describes the error. |
| innerException | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | The exception that is the cause of the current exception, or a null reference if no inner exception is specified. |

<a name='M-DotNet-CommonHelpers-Exceptions-AppSettingNotFoundException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext-'></a>
### #ctor(info,context) `constructor`

##### Summary

Initializes a new instance of the AppSettingNotFoundException class with serialized data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| info | [System.Runtime.Serialization.SerializationInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.Serialization.SerializationInfo 'System.Runtime.Serialization.SerializationInfo') | The System.Runtime.Serialization.SerializationInfo that holds the serialized object data about the exception being thrown. |
| context | [System.Runtime.Serialization.StreamingContext](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.Serialization.StreamingContext 'System.Runtime.Serialization.StreamingContext') | The System.Runtime.Serialization.StreamingContext that contains contextual information about the source or destination. |

<a name='T-DotNet-CommonHelpers-AppSettings'></a>
## AppSettings `type`

##### Namespace

DotNet.CommonHelpers

##### Summary



<a name='M-DotNet-CommonHelpers-AppSettings-Get``1-System-String-'></a>
### Get\`\`1(key) `method`

##### Summary

Easier reading of `App.config` parameters.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Appsettings key |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the parameter |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [DotNet.CommonHelpers.Exceptions.AppSettingNotFoundException](#T-DotNet-CommonHelpers-Exceptions-AppSettingNotFoundException 'DotNet.CommonHelpers.Exceptions.AppSettingNotFoundException') | Thrown when specified key is not found in the appsettings |

##### Example

```csharp
var timeret = AppSettings.Get&lt;int&gt;("Timeout");                
```

<a name='T-DotNet-CommonHelpers-Extensions-AsyncHelper'></a>
## AsyncHelper `type`

##### Namespace

DotNet.CommonHelpers.Extensions

##### Summary

Helper for running async functions synchronously

<a name='M-DotNet-CommonHelpers-Extensions-AsyncHelper-RunSync-System-Func{System-Threading-Tasks-Task}-'></a>
### RunSync(func) `method`

##### Summary

Runs an async method synchronously

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| func | [System.Func{System.Threading.Tasks.Task}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Threading.Tasks.Task}') |  |

<a name='M-DotNet-CommonHelpers-Extensions-AsyncHelper-RunSync``1-System-Func{System-Threading-Tasks-Task{``0}}-'></a>
### RunSync\`\`1(func) `method`

##### Summary

Runs an async function synchronously

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| func | [System.Func{System.Threading.Tasks.Task{\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Threading.Tasks.Task{``0}}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TResult |  |

<a name='T-DotNet-CommonHelpers-Extensions-CleanerCodeExtensions'></a>
## CleanerCodeExtensions `type`

##### Namespace

DotNet.CommonHelpers.Extensions

##### Summary

Extensions that make the code easier to read and mentain

<a name='M-DotNet-CommonHelpers-Extensions-CleanerCodeExtensions-Require``1-``0,System-Func{``0,System-Boolean}-'></a>
### Require\`\`1(param,condition) `method`

##### Summary

Checks if the parameter meets the condition. It throws an exception if it does not

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| param | [\`\`0](#T-``0 '``0') | parameter to be checked |
| condition | [System.Func{\`\`0,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Boolean}') | Condition to be met |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

##### Example

int amount = 30;
string productName = "";
amount.Require(a=>a>0);
productName.Require(p=>!string.IsNullOrWhiteSpace(p));

<a name='T-DotNet-CommonHelpers-Extensions-DBHelper'></a>
## DBHelper `type`

##### Namespace

DotNet.CommonHelpers.Extensions

##### Summary

Makes querying the database easier/more elegant

<a name='P-DotNet-CommonHelpers-Extensions-DBHelper-ConnectionString'></a>
### ConnectionString `property`

##### Summary

Global connection string. It has to be set if you wish to execute queries without specifying the connectionString

<a name='P-DotNet-CommonHelpers-Extensions-DBHelper-QueryCommandTimeout'></a>
### QueryCommandTimeout `property`

##### Summary

Global query CommandTimeout in seconds

<a name='M-DotNet-CommonHelpers-Extensions-DBHelper-QueryDT-System-String,System-String,System-Nullable{System-Int32}-'></a>
### QueryDT(sqlQuery,connectionString,timeout) `method`

##### Summary

Executes the query. If connectionString and timeout are null it takes the default settings.
If ConnectionString is null you have to set it before the 1st call with DBHelper.ConnectionString=...

##### Returns

Results of the query in a datatable

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sqlQuery | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | SQL query to be executed |
| connectionString | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | SQL Database connection string |
| timeout | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | Command timeout in seconds |

##### Example

```csharp
var data = "SELECT * FROM [dbo].[Table]".QueryDT(); // gets results of the query as a DataTable        
```

<a name='T-DotNet-CommonHelpers-Extensions-EnumerationExtensions'></a>
## EnumerationExtensions `type`

##### Namespace

DotNet.CommonHelpers.Extensions

<a name='M-DotNet-CommonHelpers-Extensions-EnumerationExtensions-GetEnumerator-System-Range-'></a>
### GetEnumerator(range) `method`

##### Summary

Syntactic suggar for better looking loops

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| range | [System.Range](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Range 'System.Range') |  |

##### Example

```csharp
foreach(var i in 1..10)
    Console.WriteLine(i);
```

<a name='T-DotNet-CommonHelpers-Extensions-LinqExtensions'></a>
## LinqExtensions `type`

##### Namespace

DotNet.CommonHelpers.Extensions

##### Summary

Linq extensions

<a name='M-DotNet-CommonHelpers-Extensions-LinqExtensions-Clone``1-System-Collections-Generic-IList{``0}-'></a>
### Clone\`\`1() `method`

##### Summary

Clones a list of clonable items

##### Parameters

This method has no parameters.

<a name='M-DotNet-CommonHelpers-Extensions-LinqExtensions-MaxIndex``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### MaxIndex\`\`1() `method`

##### Summary

Index of max value

##### Parameters

This method has no parameters.

<a name='M-DotNet-CommonHelpers-Extensions-LinqExtensions-ToConsoleSameLine``1-System-Collections-Generic-IEnumerable{``0},System-Func{``0,System-String}-'></a>
### ToConsoleSameLine\`\`1() `method`

##### Summary

Write items to console using converter function func

##### Parameters

This method has no parameters.

<a name='T-DotNet-CommonHelpers-Extensions-ObjectShredder'></a>
## ObjectShredder `type`

##### Namespace

DotNet.CommonHelpers.Extensions

##### Summary



<a name='M-DotNet-CommonHelpers-Extensions-ObjectShredder-EnumerableToDataTable``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### EnumerableToDataTable\`\`1(varlist) `method`

##### Summary

Converts an IEnumerable list to a DataTable

##### Returns

DataTable

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| varlist | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type with parameters (getters and setters) |

##### Example

```csharp
class Test { 
    public int id { get; set; } 
    public string name { get; set; } 
}
...
var input =  new[] { new Test() { id=1, name="x" } };
var ret = input.EnumerableToDataTable(); // returns a datatable
```

<a name='T-DotNet-CommonHelpers-Extensions-RawQuery'></a>
## RawQuery `type`

##### Namespace

DotNet.CommonHelpers.Extensions

##### Summary

Helpers for better looking dapper queries
ex.
var data = "SELECT ID, Name FROM dbo.MyTable".Query<dynamic>(cString);

<a name='P-DotNet-CommonHelpers-Extensions-RawQuery-ConnectionString'></a>
### ConnectionString `property`

##### Summary

Default connection string. It has to be set if you want to use Query commands without specifying the connection stirng

##### Example

```csharp
RawQuery.ConnectionString = "myconnection string...";
var data = "SELECT * FROM TestTable".Query&lt;dynamic&gt;();
```

<a name='M-DotNet-CommonHelpers-Extensions-RawQuery-Execute-System-String,System-String,System-Object,System-Data-IDbTransaction,System-Nullable{System-Int32},System-Nullable{System-Data-CommandType}-'></a>
### Execute(cString,sql,param,transaction,commandTimeout,commandType) `method`

##### Summary

Execute parameterized SQL.

##### Returns

The number of rows affected.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cString | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The connection string to query on. If cString is null you have to set it before the 1st call with RawQuery.ConnectionString |
| sql | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The SQL to execute for this query. |
| param | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The parameters to use for this query. |
| transaction | [System.Data.IDbTransaction](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Data.IDbTransaction 'System.Data.IDbTransaction') | The transaction to use for this query. |
| commandTimeout | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | Number of seconds before command execution timeout. |
| commandType | [System.Nullable{System.Data.CommandType}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Data.CommandType}') | Is it a stored proc or a batch? |

##### Example

```csharp
"EXEC dbo.DoSomething @id".Execute(param: new {id=123}); // executes stored procedure dbo.DoSomething with the parameter @id = 123
```

<a name='M-DotNet-CommonHelpers-Extensions-RawQuery-ExecuteAsync-System-String,System-String,System-Object,System-Data-IDbTransaction,System-Nullable{System-Int32},System-Nullable{System-Data-CommandType}-'></a>
### ExecuteAsync(cString,sql,param,transaction,commandTimeout,commandType) `method`

##### Summary

Execute a command asynchronously using Task.

##### Returns

The number of rows affected.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cString | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The connection string to query on. If cString is null you have to set it before the 1st call with RawQuery.ConnectionString |
| sql | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The SQL to execute for this query. |
| param | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The parameters to use for this query. |
| transaction | [System.Data.IDbTransaction](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Data.IDbTransaction 'System.Data.IDbTransaction') | The transaction to use for this query. |
| commandTimeout | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | Number of seconds before command execution timeout. |
| commandType | [System.Nullable{System.Data.CommandType}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Data.CommandType}') | Is it a stored proc or a batch? |

##### Example

```csharp
await "EXEC dbo.DoSomething @id".ExecuteAsync(param: new {id=123}); // executes stored procedure dbo.DoSomething with the parameter @id = 123
```

<a name='M-DotNet-CommonHelpers-Extensions-RawQuery-ExecuteScalarAsync``1-System-String,System-String,System-Object,System-Data-IDbTransaction,System-Nullable{System-Int32},System-Nullable{System-Data-CommandType}-'></a>
### ExecuteScalarAsync\`\`1(cString,sql,param,transaction,commandTimeout,commandType) `method`

##### Summary

Execute parameterized SQL that selects a single value asynchronously using Task.

##### Returns

The first cell returned, as `TEntity`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cString | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The connection string to query on. If cString is null you have to set it before the 1st call with RawQuery.ConnectionString |
| sql | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The SQL to execute. |
| param | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The parameters to use for this command. |
| transaction | [System.Data.IDbTransaction](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Data.IDbTransaction 'System.Data.IDbTransaction') | The transaction to use for this command. |
| commandTimeout | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | Number of seconds before command execution timeout. |
| commandType | [System.Nullable{System.Data.CommandType}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Data.CommandType}') | Is it a stored proc or a batch? |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | The type to return. |

##### Example

```csharp
var tableRowCount = await "SELECT count(1) FROM [dbo].[Table]".ExecuteScalarAsync&lt;int&gt;(); // gets number of records of dbo.Table        
```

<a name='M-DotNet-CommonHelpers-Extensions-RawQuery-ExecuteScalar``1-System-String,System-String,System-Object,System-Data-IDbTransaction,System-Nullable{System-Int32},System-Nullable{System-Data-CommandType}-'></a>
### ExecuteScalar\`\`1(cString,sql,param,transaction,commandTimeout,commandType) `method`

##### Summary

Execute parameterized SQL that selects a single value.

##### Returns

The first cell returned, as `TEntity`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cString | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The connection string to query on. If cString is null you have to set it before the 1st call with RawQuery.ConnectionString |
| sql | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The SQL to execute. |
| param | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The parameters to use for this command. |
| transaction | [System.Data.IDbTransaction](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Data.IDbTransaction 'System.Data.IDbTransaction') | The transaction to use for this command. |
| commandTimeout | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | Number of seconds before command execution timeout. |
| commandType | [System.Nullable{System.Data.CommandType}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Data.CommandType}') | Is it a stored proc or a batch? |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | The type to return. |

##### Example

```csharp
var tableRowCount = "SELECT count(1) FROM [dbo].[Table]".ExecuteScalar&lt;int&gt;(); // gets number of records of dbo.Table        
```

<a name='M-DotNet-CommonHelpers-Extensions-RawQuery-QueryAsync``1-System-String,System-String,System-Object,System-Data-IDbTransaction,System-Nullable{System-Int32},System-Nullable{System-Data-CommandType}-'></a>
### QueryAsync\`\`1(cString,sql,param,transaction,commandTimeout,commandType) `method`

##### Summary

Executes a query asynchronously using Task, returning the data typed as `TEntity`.

##### Returns

A sequence of data of the supplied type; if a basic type (int, string, etc) is queried then the data from the first column in assumed, otherwise an instance is
created per row, and a direct column-name===member-name mapping is assumed (case insensitive).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cString | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The connection string to query on. If cString is null you have to set it before the 1st call with RawQuery.ConnectionString |
| sql | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The SQL to execute for the query. |
| param | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The parameters to pass, if any. |
| transaction | [System.Data.IDbTransaction](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Data.IDbTransaction 'System.Data.IDbTransaction') | The transaction to use, if any. |
| commandTimeout | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The command timeout (in seconds). |
| commandType | [System.Nullable{System.Data.CommandType}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Data.CommandType}') | The type of command to execute. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | The type of results to return. |

##### Example

```csharp
var data = await "SELECT * FROM [dbo].[Table]".QueryAsync&lt;dynamic&gt;(); // gets results of the query as IEnumerble dynamic type
class Table{
    public int ID {get;set;}
    public string Name {get;set;}
}
var tableData = await "SELECT * FROM [dbo].[Table]".QueryAsync&lt;Table&gt;(); // gets results of the query and mapps them to IEnumerable&lt;Table&gt;
```

<a name='M-DotNet-CommonHelpers-Extensions-RawQuery-Query``1-System-String,System-String,System-Object,System-Data-IDbTransaction,System-Boolean,System-Nullable{System-Int32},System-Nullable{System-Data-CommandType}-'></a>
### Query\`\`1(cString,sql,param,transaction,buffered,commandTimeout,commandType) `method`

##### Summary

Executes a query, returning the data typed as `TEntity`.

##### Returns

A sequence of data of the supplied type; if a basic type (int, string, etc) is queried then the data from the first column in assumed, otherwise an instance is
created per row, and a direct column-name===member-name mapping is assumed (case insensitive).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cString | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The connection string to query on. If cString is null you have to set it before the 1st call with RawQuery.ConnectionString |
| sql | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The SQL to execute for the query. |
| param | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The parameters to pass, if any. |
| transaction | [System.Data.IDbTransaction](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Data.IDbTransaction 'System.Data.IDbTransaction') | The transaction to use, if any. |
| buffered | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether to buffer results in memory. |
| commandTimeout | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The command timeout (in seconds). |
| commandType | [System.Nullable{System.Data.CommandType}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Data.CommandType}') | The type of command to execute. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | The type of results to return. |

##### Example

```csharp
var data = "SELECT * FROM [dbo].[Table]".Query&lt;dynamic&gt;(); // gets results of the query as IEnumerble dynamic type
class Table{
    public int ID {get;set;}
    public string Name {get;set;}
}
var tableData = "SELECT * FROM [dbo].[Table]".Query&lt;Table&gt;(); // gets results of the query and mapps them to IEnumerable&lt;Table&gt;
```

<a name='T-DotNet-CommonHelpers-Extensions-ReflectionCopy'></a>
## ReflectionCopy `type`

##### Namespace

DotNet.CommonHelpers.Extensions

##### Summary

Deep copying of objects using reflection

<a name='M-DotNet-CommonHelpers-Extensions-ReflectionCopy-Copy-System-Collections-Generic-List{System-Object},System-Type-'></a>
### Copy(source,destinationType) `method`

##### Summary

Copies an array (source) to a destination array of type destinationType

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.List{System.Object}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Object}') |  |
| destinationType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |

<a name='M-DotNet-CommonHelpers-Extensions-ReflectionCopy-Copy-System-Object,System-Type-'></a>
### Copy(source,destinationType) `method`

##### Summary

Makes a shallow copy of a similar object (same properties!)

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| destinationType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |

<a name='M-DotNet-CommonHelpers-Extensions-ReflectionCopy-CopyList``1-System-Object-'></a>
### CopyList\`\`1(source) `method`

##### Summary

Copies an array (source) to a destination array of type T

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |

<a name='M-DotNet-CommonHelpers-Extensions-ReflectionCopy-CopyList``1-System-Object,System-Collections-Generic-List{System-String}-'></a>
### CopyList\`\`1(source,skipParams) `method`

##### Summary

Copies an array (source) to a destination array of type T that skips the parameters in skipParams list

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| skipParams | [System.Collections.Generic.List{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.String}') |  |

<a name='M-DotNet-CommonHelpers-Extensions-ReflectionCopy-Copy``1-System-Object,System-Collections-Generic-List{System-String}-'></a>
### Copy\`\`1(source,skipParams) `method`

##### Summary

Makes a shallow copy of a similar object (same properties!)

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| skipParams | [System.Collections.Generic.List{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.String}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-DotNet-CommonHelpers-Extensions-ReflectionCopy-Copy``1-System-Object-'></a>
### Copy\`\`1(source) `method`

##### Summary

Makes a shallow copy of a similar object (same properties!)

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-DotNet-CommonHelpers-Extensions-ReflectionCopy-Modify-System-Object,System-Object-'></a>
### Modify(source,destination) `method`

##### Summary



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| destination | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |

<a name='M-DotNet-CommonHelpers-Extensions-ReflectionCopy-Modify-System-Object,System-Object,System-Collections-Generic-List{System-String}-'></a>
### Modify(source,destination,skipParams) `method`

##### Summary



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| destination | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| skipParams | [System.Collections.Generic.List{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.String}') | list of parameter names to be ignored |

<a name='T-DotNet-CommonHelpers-Extensions-SerializationExtension'></a>
## SerializationExtension `type`

##### Namespace

DotNet.CommonHelpers.Extensions

##### Summary

Easier object serialization and deserialization

<a name='M-DotNet-CommonHelpers-Extensions-SerializationExtension-XmlDeserialize``1-System-String-'></a>
### XmlDeserialize\`\`1(xml) `method`

##### Summary

Deserializes an xml string in to an object of Type T

##### Returns

A new object of type T is successful, null if failed

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| xml | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Xml as string to deserialize from |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Any class type |

<a name='M-DotNet-CommonHelpers-Extensions-SerializationExtension-XmlSerialize``1-``0-'></a>
### XmlSerialize\`\`1(obj) `method`

##### Summary

Serializes an object of type T in to an xml string

##### Returns

A string that represents Xml, empty otherwise

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [\`\`0](#T-``0 '``0') | Object to serialize |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Any class type |

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

<a name='M-Dotnet-CommonHelpers-Extensions-StringExtensions-RemoveSpacesAndNewLines-System-String-'></a>
### RemoveSpacesAndNewLines(input) `method`

##### Summary

Remove spaces and newlines from string

##### Returns

Clean string, without spaces and newlines

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

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

<a name='M-Dotnet-CommonHelpers-Extensions-StringExtensions-SHA1-System-String-'></a>
### SHA1() `method`

##### Summary

Returns a SHA1 hash of the string

##### Parameters

This method has no parameters.

##### Example

```csharp
var ret = "test".SHA1();  // returns "C8059E2EC7419F590E79D7F1B774BFE6"
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

<a name='M-Dotnet-CommonHelpers-Extensions-StringExtensions-StripHtml-System-String-'></a>
### StripHtml(input) `method`

##### Summary

Strips html tags from input

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

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

<a name='T-DotNet-CommonHelpers-Extensions-ValueObject'></a>
## ValueObject `type`

##### Namespace

DotNet.CommonHelpers.Extensions

##### Summary

Learn more: https://docs.microsoft.com/en-us/dotnet/standard/microservices-architecture/microservice-ddd-cqrs-patterns/implement-value-objects
